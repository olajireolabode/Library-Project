using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProApp
{
    internal abstract class SaveXml
    {
        static BinaryFormatter sr = new BinaryFormatter();
        static int libraryCount = 0;
        static int spCount = 0;
        static DirectoryInfo target = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\save");
        static DirectoryInfo spTarget = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\spsave");
        static FileStream requests = new FileStream(Directory.GetCurrentDirectory() + "\\requests.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        public static void SaveData(object obj, string fileName)
        {
            FileStream overwrite = new FileStream(fileName, FileMode.Create);
            sr.Serialize(overwrite, obj);
            overwrite.Close();
        }

        public static void SaveAll() {
            foreach (Book book in Library.Books.Values) {
                libraryCount++;
                SaveData(book, $"{target.FullName}\\book{libraryCount}");
            }
            foreach (FileInfo file in spTarget.GetFiles()) {
                File.Delete(file.ToString());
            }
            foreach (Book book in Library.SpBooks.Values)
            {
                spCount++;
                SaveData(book, $"{spTarget.FullName}\\book{spCount}");
            }
            SavePendingMembers();

        }

        public static void LoadAll() {
            foreach (var file in target.GetFiles()) {
                FileStream load = new FileStream(file.FullName, FileMode.Open);
                Book newBook = sr.Deserialize(load) as Book;
                //MessageBox.Show(newBook.ToString());
                Library.AddBook(newBook);
                load.Close();
            }
            foreach (var file in spTarget.GetFiles())
            {
                FileStream load = new FileStream(file.FullName, FileMode.Open);
                Book newBook = sr.Deserialize(load) as Book;
                //MessageBox.Show(newBook.ToString());
                Library.SpAddBook(newBook);
                load.Close();
            }
            LoadPendingMembers();

        }

        public static void SavePendingMembers() {

            StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\requests.txt");
            foreach (User user in Library.TentativeMembers) {
                writer.Write($"{user.Username},{user.Password},{user.Membership}\n");
            }
            writer.Close();
        }

        public static void LoadPendingMembers() {
            StreamReader reader = new StreamReader(requests);
            while (!reader.EndOfStream) {
                var member = reader.ReadLine().Split(",", 3);
                Library.TentativeMembers.Push(new User(member[0], member[1], int.Parse(member[2])));
            }
            reader.Close();
        }

        public static void AddMember(User user) {
            StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\members.txt");
            writer.Write($"[{user.Username}]\n");
            writer.Close();
        }

        public static bool IsMember(User user) {
            StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\members.txt");
            string record = reader.ReadToEnd();
            reader.Close();
            return record.Contains($"[{user.Username}]");

        }

        public static void Reserve(Book book, User user) {
            string data = $"[{book.Title},{user.Username}]";

            if (!IsReserved(book)) {
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\reservations.txt")) {
                    writer.Write(data + "\n");
                    writer.Close();
                }
            }


        }

        public static bool IsReserved(Book book) {
            string data = $"[{book.Title},";
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\reservations.txt"))
            {
                return reader.ReadToEnd().Contains(data);

            }
        }

        public static bool IsReservedBy(Book book, User user) {
            string data = $"[{book.Title},{user.Username}]";
            using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\reservations.txt"))
            {
                return reader.ReadToEnd().Contains(data);
            }
        }

        public static void Unreserve(Book book, User user) {
            var path = Directory.GetCurrentDirectory() + "\\reservations.txt";
            string data = $"[{book.Title},{user.Username}]";
            string output = "";
            using (StreamReader reader = new StreamReader(path)) {
                output = reader.ReadToEnd();
                reader.Close();
            }
                

            File.Delete(path);
            output = output.Replace(data, "");
            File.Create(path).Close();

            using (StreamWriter writer = new(path)) {
                writer.Write(output);
                writer.Close();
            }

                
           
        }
    }
}
