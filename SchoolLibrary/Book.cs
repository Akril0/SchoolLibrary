using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Book
    {
        // Приватні поля класу
        protected string title;
        protected string author;
        protected int pages;

        // Конструктор класу
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        // Властивості для доступу до полів
        public string Title 
        { 
            get => title; 
            set => title = value; 
        }
        public string Author { get => author; set => author = value; }
        public int Pages
        {
            get => pages;
            set
            {
                if (value > 0)
                    pages = value;
                else
                    Console.WriteLine("Кількість сторінок не може бути менше або рівне 0");
            }
        }

        // Метод для виведення інформації про книгу
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Назва: {title}");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Кількість сторінок: {pages}");
        }
    }
 
}
