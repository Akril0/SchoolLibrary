using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolLibrary.BooksShaper;

namespace SchoolLibrary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Створюємо студента
            Student student1 = new Student(SchoolE.PrimarySchool);
            //Виводимо список його книжок
            Console.WriteLine("Студен номер 1");
            Console.WriteLine("Список всiх книжок: ");

            //Виводимо список всіх його книжок
            foreach (Book book in student1.GetBooksList())
            {
                book.DisplayInfo();
            }
            Console.WriteLine("\nСписок природ. книжок: ");

            //Виводимо список його природничих книжок
            foreach (Book book in student1.GetBooksList(BookType.Natural))
            {
                book.DisplayInfo();
            }
            Console.WriteLine("\n=========================================================\n");
        } 
    }
}
