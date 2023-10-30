using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolLibrary.BooksShaper;

namespace SchoolLibrary
{
    internal class Teacher: Student
    {
        private BookType subject;
        private Dictionary<SchoolE, string[]> books;
        public BookType Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }
        public Teacher() 
        {
        }
        public Teacher(BookType subject)
        {
            this.subject = subject;
            this.books = BooksShaper.ShapBook(this.subject);
        }
        //Десткутор
        ~Teacher()
        {
            Console.WriteLine("OBJ is deleted");
        }

        //Властивість доступу до поля класу 
        public new Dictionary<SchoolE, string[]> Books
        {
            get
            {
                return books;
            }
        }
        //Повертаємо список книжок
        public new List<string> GetBooksList()
        {
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

        //Забороняємо використовувати метод базового класу
        public new List<string> GetBooksList(BookType bookType)
        {
            throw new InvalidOperationException("Этот метод доступен только через объект базового класса.");
        }


        //Метод, який повертає список книжок учня конкретного типу
        public List<string> GetBooksList(SchoolE SchoolE)
        {
            List<string> list = new List<string>();

            foreach (string book in books[SchoolE])
            {
                list.Add(book);
            }

            return list;
        }

    }
}
