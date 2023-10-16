using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    //Клас студента
    internal class Student
    {
        //поле рівень школи
        private SchoolE school;
        //поле список книжок
        private string[] books;
        //поле сбірник книжок
        BooksShaper boocksShaper = new BooksShaper();

        //Конструктор
        public Student(SchoolE school)
        {
            this.school = school;
            this.books = boocksShaper.ShapBook(school);
        }

        //Властивість доступу до поля класу 
        public string[] Books
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

    }
}
