using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class MathBook : Book
    {
        private string author;
        protected new BookType type = BookType.Language;
        public MathBook(string title, string author)
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
            Console.WriteLine("Математична книга:");
            base.DisplayInfo();
            Console.WriteLine($"Автор: {author}");
        }

        public void DisplayAuthor()
        {
            Console.WriteLine($"Книга з математики за:{author}");
        }
        public virtual void DisplayId()
        {
            Console.WriteLine($"Id: {Id}");
        }

    }
}
