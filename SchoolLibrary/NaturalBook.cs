using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class NaturalBook : Book
    {
        private string author;
        protected new BookType type = BookType.Natural;
        public NaturalBook(string title, string author)
            : base(title)
        {
            this.author = author;
        }

        public BookType BookType
        {
            get
            {
                return type;
            }
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public new void DisplayInfo()
        {
            Console.WriteLine("Книга з природничих наук:");
            base.DisplayInfo();
            Console.WriteLine($"Автор: {author}");
        }

        public void DisplayAuthor()
        {
            Console.WriteLine($"Книга з природничих наук за:{author}");
        }

        public virtual void DisplayId()
        {
            Console.WriteLine($"Id: {Id}");
        }
    }
}
