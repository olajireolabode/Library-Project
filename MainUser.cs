using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProApp
{
    public partial class MainUser : Form
    {
        private User currentUser;
        public MainUser(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            //this.TestCase();
            if (SaveXml.IsMember(currentUser))
            {
                label5.Text = "Greetings, Member!";
                label5.Enabled = false;
            }
            StartListBox();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (!SaveXml.IsMember(currentUser) && Library.TentativeMembers.Where(user => user.Username == currentUser.Username).IsNullOrEmpty())
            {
                Library.RequestMember(currentUser);
                MessageBox.Show("You have now applied for registration! We will let you know if you are accepted.", "Applied for membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You have already applied. Be patient.");
            }

        }


        public void TestCase()
        {
            Library.AddBook(new Book("Harry Potter", "12", "Fantasy", "John", "Publisher"));
            Library.AddBook(new Book("John Smith", "54", "Action", "Jimmy", "Publisher"));
            Library.AddBook(new Book("Harry Potter 2", "22", "Fantasy", "John", "Publisher"));
        }



        private void searchButton_Click(object sender, EventArgs e)
        {

            if (bookNameTextBox.Text.Length != 0)
            {
                var results = Library.SearchBook(bookNameTextBox.Text, false);
                LoadListBox(results);
            }
        }

        private void LoadListBox(List<Book> values)
        {
            resultsListBox.Items.Clear();
            if (!values.IsNullOrEmpty())
            {
                foreach (Book book in values)
                {
                    resultsListBox.Items.Add($"{book.Title} - {book.Author} : {book.Genre}. Publisher : {book.Publisher}");
                }
            }

        }

        private void StartListBox()
        {
            foreach (Book book in Library.Books.Values)
            {
                resultsListBox.Items.Add($"{book.Title} - {book.Author} : {book.Genre}. Publisher : {book.Publisher}");
            }
        }

        private void resultsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            Book selectedBook = Library.GetBook(resultsListBox.SelectedItem.ToString().Split(" - ", 2)[0]);
            if (!selectedBook.Reserved)
            {
                DialogResult toRent = MessageBox.Show($"Do you want to rent {selectedBook.Title}?", "Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(toRent == DialogResult.Yes) { 
                    selectedBook.Reserved = true;
                    SaveXml.Reserve(selectedBook, currentUser);
                }
            }
            else {
                if (SaveXml.IsReservedBy(selectedBook, currentUser))
                {
                    DialogResult toReturn = MessageBox.Show($"You have this book! Would you like to return {selectedBook.Title}?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (toReturn == DialogResult.Yes)
                    {
                        selectedBook.Reserved = false;
                        SaveXml.Unreserve(selectedBook, currentUser);
                    }
                }
                else {
                    MessageBox.Show($"{selectedBook.Title} has already been reserved.");
                }
                
            }
        }
    }
}
