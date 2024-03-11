using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProApp
{
    [Serializable]
    public class Book
    {
        public string Title { get; set; }
        public string BookId { get; set; }
        public string Genre { get; set;  }
        public string Author { get; set;  }
        public string Publisher { get; set;  }
        public bool Reserved { get; set; }

        public Book(string title, string bookId, string genre, string author, string publisher)
        {
            this.Title = title;
            this.BookId = bookId;
            this.Genre = genre;
            this.Author = author;
            this.Publisher = publisher;
            this.Reserved = false;
        }

        public Book() { }

        public override string ToString()
        {
            return $"Title: {Title}\nBookId: {BookId}\nAuthor: {Author}\nGenre: {Genre}, Publisher: {Publisher}";
        }
    }

}
