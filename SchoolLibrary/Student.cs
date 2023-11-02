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
        private Dictionary<BookType, Book[]> books;

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
        public Dictionary<BookType, Book[]> Books
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
        public List<Book> GetBooksList(){
            List<Book> list = new List<Book>();

            foreach (Book[] books in books.Values)
            {
                foreach (Book book in books)
                {
                    list.Add(book);
                }
            }
            return list;
        }

        //Метод, який повертає список книжок учня конкретного типу

        public List<Book> GetBooksList(BookType bookType)
        {
            List<Book> list = new List<Book>();

            foreach (Book book in books[bookType])
            {
                list.Add(book);
            }
            
            return list;
        }


    }
}
