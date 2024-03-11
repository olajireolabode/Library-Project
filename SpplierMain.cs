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
    public partial class SpplierMain : Form
    {
        private User currentUser;
        public SpplierMain(User currentUser)
        {
            //Library.Initialize();
            InitializeComponent();
            this.currentUser = currentUser;
            LoadBooks();
        }

        private void LoadBooks()
        {
            spBooksListBox.Items.Clear();
            foreach (Book book in Library.SpBooks.Values)
            {
                spBooksListBox.Items.Add($"{book.Title} - {book.Author}");
            }
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void spBooksListBox_MouseClick(object sender, MouseEventArgs e)
        {
            Book selectedBook = Library.SpBooks[spBooksListBox.SelectedItem.ToString().Split(" - ", 2)[0]] as Book;
            if (selectedBook != null)
            {
                DialogResult sell = MessageBox.Show($"Do you want to sell {selectedBook.Title}?", "Sell", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sell == DialogResult.Yes)
                {
                    Library.AddBook(selectedBook);
                    Library.SpRemoveBook(selectedBook.Title);
                }
            }
            LoadBooks();

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            spBooksListBox.SelectedItems.Clear();
            var selected = Library.SearchBook(searchTextBox.Text, true);
            if (selected != null)
            {
                foreach (Book book in selected)
                {
                    spBooksListBox.SelectedItems.Add($"{book.Title} - {book.Author}");
                }
            }
        }
    }
}
