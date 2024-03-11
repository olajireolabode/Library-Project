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

namespace ProApp
{
    public partial class BookEdit : Form
    {
        Book selected;
        MainStaff previous;
        public BookEdit(Book selected, MainStaff previous)
        {
            InitializeComponent();
            this.selected = selected;
            this.previous = previous;
            titleTextBox.Text = selected.Title;
            authorTextBox.Text = selected.Author;
            bookIdTextBox.Text = selected.BookId;
            publisherTextBox.Text = selected.Publisher;
            genreTextBox.Text = selected.Genre;
            reservedCheckBox.Checked = selected.Reserved;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            foreach (Control a in Controls)
            {
                if (a is TextBox)
                {
                    if (a.Text.IsNullOrEmpty())
                    {
                        MessageBox.Show("Please enter values in every field.");
                        return;
                    }
                }
            }
            selected.Title = titleTextBox.Text;
            selected.Publisher = publisherTextBox.Text;
            selected.Author = authorTextBox.Text;
            selected.BookId = bookIdTextBox.Text;
            selected.Genre = genreTextBox.Text;
            this.Close();
            previous.LoadBooks();
            previous.Show();

        }

        private void reservedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            selected.Reserved = reservedCheckBox.Checked;
        }
    }
}
