using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Створюємо студента
            Student student = new Student(SchoolE.PrimarySchool);
            //Виводимо список його книжок
            foreach (string book in student.Books)
            {
                Console.WriteLine(book);
            }
        }

        
    }
}
