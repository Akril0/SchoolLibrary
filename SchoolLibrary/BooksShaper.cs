using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolLibrary.BooksShaper;

namespace SchoolLibrary
{
    //Класс для сбору книжок
    class BooksShaper
    {
     

        private static Dictionary<BookType, Book[]> setOfHighBoocks = new Dictionary<BookType, Book[]>()
        {
            { BookType.Natural, new Book[] { new NaturalBook("Фізика", "Автор"), new NaturalBook("Хімія", "Автор") } },
            { BookType.Language, new Book[] { new LanguageBook("Українська мова", "Автор"), new LanguageBook( "Украинська Лiтература", "Автор") } },
            { BookType.Math, new Book[] {new MathBook("Тригонометрiя", "Автор"), new MathBook("Стереометрiя", "Автор") } }
        };
        private static Dictionary<BookType, Book[]> setOfPrimaryBoocks = new Dictionary<BookType, Book[]>()
        {
            { BookType.Natural, new Book[] { new NaturalBook("Природознавство", "Автор") } },
            { BookType.Language, new Book[] { new LanguageBook("Українська мова та література", "Автор") } },
            { BookType.Math, new Book[] {   new MathBook("Математика", "Автор") } }
        };
        private static Dictionary<BookType, Book[]> setOfSecondaryBoocks = new Dictionary<BookType, Book[]>()
        {
            { BookType.Natural, new Book[] { new NaturalBook("Географія", "Автор") } },
            { BookType.Language, new Book[] {new LanguageBook("Українська мова", "Автор"), new LanguageBook("Украинська Література", "Автор") } },
            { BookType.Math, new Book[] {new MathBook("Алгебра", "Автор"), new MathBook("Геометрія", "Автор") } }
        };

        //Метод сбору книжок
        public static Dictionary<BookType, Book[]> ShapBook(SchoolE school)
        {
           
            switch (school)
            {
                case SchoolE.HighSchool:
                    //Повертаємо список книжок для старшої школи'
                    return setOfHighBoocks;
           
                case SchoolE.PrimarySchool:
                    //Повертаємо список книжок для молодшої школи
                    return setOfPrimaryBoocks;

                case SchoolE.SecondarySchool:
                    //Повертаємо список книжок для середньої школи
                    return setOfSecondaryBoocks;

                default:
                    //Повертаємо null якщо не віповідає іншим умовам
                    return null;
            }
        }
    }
}
