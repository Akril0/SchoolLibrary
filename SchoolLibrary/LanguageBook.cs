using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolLibrary.BooksShaper;

namespace SchoolLibrary
{

    public class LanguageBook : Book
    {
        protected new BookType type = BookType.Language;
        private string author;
        public LanguageBook(string title, string author)
            : base(title)
        {
            this.author = author;
        }

        public BookType Type
        {
            get => type;
        }
        public string Author
        {
            get => author;
            set => author = value;
        }
        public new void DisplayInfo()
        {
            Console.WriteLine("Мовна книга:");
            base.DisplayInfo();
            Console.WriteLine($"Автор: {author}");
        }

        public void DisplayAuthor()
        {
            Console.WriteLine($"Мовна книга за: {author}");
        }
        public virtual void DisplayId()
        {
            Console.WriteLine($"Id: {Id}");
        }
    }
}
