using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Automation;

namespace ProApp
{

    public partial class MainStaff : Form
    {

        User currentUser;
        public MainStaff(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadBooks();
            AcceptMembers();
        }

        public void LoadBooks()
        {
            booksListBox.Items.Clear();
            foreach (Book book in Library.Books.Values)
            {
                booksListBox.Items.Add($"{book.Title} - {book.Author}");
            }
        }

        private void AcceptMembers()
        {
            while (!Library.TentativeMembers.IsNullOrEmpty())
            {
                var tentativeMember = Library.TentativeMembers.Pop();
                DialogResult decision = MessageBox.Show($"{tentativeMember.Username} has applied to be a member. Do you accept?", "New Member", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (decision == DialogResult.Yes)
                {
                    //Library.AddMember(tentativeMember);
                    SaveXml.AddMember(tentativeMember);
                    MessageBox.Show("Member added!");
                }
                else
                {
                    MessageBox.Show("Member declined....");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            booksListBox.SelectedItems.Clear();
            var selected = Library.SearchBook(searchTextBox.Text, false);
            if (selected != null)
            {
                foreach (Book book in selected)
                {
                    booksListBox.SelectedItems.Add($"{book.Title} - {book.Author}");
                }
            }
        }

        private void booksListBox_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult edit = MessageBox.Show("Do you want to edit " + booksListBox.SelectedItem, "Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (edit == DialogResult.Yes)
            {
                var bookTitle = (booksListBox.SelectedItem as string).Split(" - ", 2)[0];
                BookEdit newForm = new BookEdit(Library.Books[bookTitle] as Book, this);
                this.Hide();
                newForm.Show();
                this.LoadBooks();
            }
            else
            {

            }
            booksListBox.SelectedItems.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }



        private void addBookButton_Click(object sender, EventArgs e)
        {


            if (!titleTextBox.Text.IsNullOrEmpty() && !bookIdTextBox.Text.IsNullOrEmpty() && !genreTextBox.Text.IsNullOrEmpty() && !authorTextBox.Text.IsNullOrEmpty() && !publisherTextBox.Text.IsNullOrEmpty())
            {
                Library.Books.Add(titleTextBox.Text, new Book(titleTextBox.Text, bookIdTextBox.Text, genreTextBox.Text, authorTextBox.Text, publisherTextBox.Text));
                MessageBox.Show($"{titleTextBox.Text} successfully added!");
                LoadBooks();


            }
            else
            {
                MessageBox.Show("Please fill in all the values.");
            }


        }

    }
}

