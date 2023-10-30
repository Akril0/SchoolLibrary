using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SchoolLibrary.BooksShaper;

namespace SchoolLibrary
{
    //Клас студента
    internal class Student
    {
        //поле рівень школи
        private SchoolE school;
        //поле список книжок
        private Dictionary<BookType, string[]> books;
        
            

        //Конструктор
        public Student()
        {
        }

        //Конструктор з параметрами
        public Student(SchoolE school)
        {
            this.school = school;
            this.books = BooksShaper.ShapBook(school);
        }
        //Конструктор копіюючий інший об'єкт
        public Student(Student student)
        {
            this.school = student.School;
            this.books = student.Books;
        }
        //Десткутор
        ~Student()
        {
            Console.WriteLine("OBJ is deleted");
        }

        //Властивість доступу до поля класу 
        public Dictionary<BookType, string[]> Books
        {
            get 
            {
                return books;
            }
        }

        //Властивість доступу до поля класу
        public SchoolE School 
        { 
            get 
            { 
                return school; 
            } 
            set 
            { 
                school = value; 
            } 
        }

        //Метод, який повертає список всіх книжок учня
        public List<string> GetBooksList(){
            List<string> list = new List<string>();

            foreach (string[] books in books.Values)
            {
                foreach (string book in books)
                {
                    list.Add(book);
                }
            }
            return list;
        }

        //Метод, який повертає список книжок учня конкретного типу

        public List<string> GetBooksList(BookType bookType)
        {
            List<string> list = new List<string>();

            foreach (string book in books[bookType])
            {
                list.Add(book);
            }
            
            return list;
        }


    }
}
