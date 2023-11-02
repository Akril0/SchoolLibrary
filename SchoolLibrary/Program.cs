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
            Book book = new Book("Укр Мова", BookType.Language);
            book.DisplayInfo();
            book.DisplayId();
            MathBook mathBook = new MathBook("Матемактика", "Автор");
            mathBook.DisplayInfo();
            mathBook.DisplayAuthor();
            mathBook.DisplayId();

        } 
    }
}
