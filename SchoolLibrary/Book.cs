using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Book
    {
        private int id;
        protected BookType type;
        // Приватні поля класу
        protected string title;

        // Конструктор класу
        public Book(string title, BookType type)
        {
            this.title = title;
            this.type = type;
            Random rnd = new Random();
            id = rnd.Next();
        }
        protected Book(string title)
        {
            this.title = title;
        }

        public int Id
        {
            get => id;
        }

        public BookType BookType 
        {
            get 
            { 
                return type; 
            } 
        }

        // Властивості для доступу до полів
        public string Title
        {
            get => title;
            set => title = value;
        }


        // Метод для виведення інформації про книгу
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва: {title}");
            Console.WriteLine("=======================================================");
        }

        public void DisplayId()
        {
            Console.WriteLine($"Id: {id}");
        }
    }
 
}
