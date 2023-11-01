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

        // Конструктор класу
        public Book(string title)
        {
            this.title = title;
        }

        // Властивості для доступу до полів
        public string Title
        {
            get => title;
            set => title = value;
        }


        // Метод для виведення інформації про книгу
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Назва: {title}");
            Console.WriteLine("=======================================================");
        }
    }
 
}
