using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolLibrary.BooksShaper;

namespace SchoolLibrary
{
    //Класс для сбору книжок
    internal class BooksShaper
    {
        public enum BookType
        {
            Math,
            Natural,
            Language
        }

        private static Dictionary<BookType, Book[]> setOfHighBoocks = new Dictionary<BookType, Book[]>()
        {
            { BookType.Natural, new Book[] { new NaturalBook("Фізика"), new NaturalBook("Хімія") } },
            { BookType.Language, new Book[] { new LanguageBook( "Українська мова"),new LanguageBook( "Украинська Лiтература") } },
            { BookType.Math, new Book[] { new MathBook("Тригонометрiя"), new MathBook("Стереометрiя") } }
        };
        private static Dictionary<BookType, Book[]> setOfPrimaryBoocks = new Dictionary<BookType, Book[]>()
        {
            { BookType.Natural, new Book[] { new NaturalBook("Природознавство") } },
            { BookType.Language, new Book[] { new LanguageBook("Українська мова та література") } },
            { BookType.Math, new Book[] {   new MathBook("Математика") } }
        };
        private static Dictionary<BookType, Book[]> setOfSecondaryBoocks = new Dictionary<BookType, Book[]>()
        {
            { BookType.Natural, new Book[] { new NaturalBook("Географія") } },
            { BookType.Language, new Book[] { new LanguageBook("Українська мова"),  new LanguageBook("Украинська Література") } },
            { BookType.Math, new Book[] { new MathBook("Алгебра"), new MathBook("Геометрія") } }
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
