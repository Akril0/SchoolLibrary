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
            foreach (string book in student1.GetBooksList())
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\nСписок природ. книжок: ");

            //Виводимо список його природничих книжок
            foreach (string book in student1.GetBooksList(BookType.Natural))
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\n=========================================================\n");

            //Створюємо студента
            Student student2 = new Student(student1);
            //Виводимо список його книжок
            Console.WriteLine("Студен номер 2");
            Console.WriteLine("Список всiх книжок: ");
            //Виводимо список всіх його книжок
            foreach (string book in student2.GetBooksList())
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\nСписок мат. книжок: ");
            //Виводимо список його математичних книжок
            foreach (string book in student2.GetBooksList(BookType.Math))
            {
                Console.WriteLine(book);
            }

            

        }

        
    }
}
