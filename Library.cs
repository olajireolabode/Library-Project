using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ProApp
{
    public abstract class Library
    {
        private static Hashtable books = new Hashtable();
        private static Hashtable supplierBooks = new Hashtable();

        private static Stack<User> tentativeMembers = new Stack<User>();
        public static Stack<User> TentativeMembers { get { return tentativeMembers; } set { tentativeMembers = value; }  }

        private static List<User> MemberList = new List<User>();
        public static Hashtable Books { get { return books; } }
        public static Hashtable SpBooks { get { return supplierBooks; } }

        public static void RequestMember(User request) { 
            tentativeMembers.Push(request);
        }
        public static void AddBook(Book book)
        {
            books.Add(book.Title, book);
        }

        public static Book GetBook(string bookId)
        {
            if (books.ContainsKey(bookId))
            {
                return (Book)books[bookId];
            }
            else
            {
                return null;
            }
        }

        public static void RemoveBook(string bookId)
        {
            books.Remove(bookId);
        }

        public static List<Book> SearchBook(string bookTitle, bool sp)
        {
            Hashtable target;
            if (!sp)
            {
                target = Library.books;
            }
            else {
                target = Library.supplierBooks;
            }
            Regex alike = new Regex($"{bookTitle.ToLower()}");
            List<Book> selectedBooks = new List<Book>();

            var selects =
                from book in target.Keys.Cast<string>().ToList()
                where alike.IsMatch(book.ToLower())
                select book;

            foreach (var select in selects)
            {
                selectedBooks.Add(books[select] as Book);
            }

            if (selectedBooks.Count == 0)
            {
                return null;
            }
            else {
                return selectedBooks;
            }
        }

        public static void AddMember(User user)
        {
            MemberList.Add(user);
        }

        public static void SpAddBook(Book book) {
            supplierBooks.Add(book.Title, book);
        }

        public static void SpRemoveBook(string bookTitle)
        {
            supplierBooks.Remove(bookTitle);
        }

        public static void Initialize() {
            SpAddBook(new Book("Harry Potter", "123", "Action", "J.K. Rowling", "Universal"));
            SpAddBook(new Book("John Doe 4", "34", "Mystery", "John Flurkel", "Columbia"));
            SpAddBook(new Book("John Doe 3", "35", "Mystery", "John Flurkel", "Columbia"));
            SpAddBook(new Book("How to program in C#", "12", "Education", "Phillip Bornknel", "Ibf"));
            SpAddBook(new Book("Recreational Ibuprofen and Its Dangers", "43", "Education", "Eric Wang", "Sweewp"));
        }


    }

}