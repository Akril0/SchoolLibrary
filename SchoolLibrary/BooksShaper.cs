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

        private static Dictionary<BookType, string[]> setOfHighBoocks = new Dictionary<BookType, string[]>()
        {
            { BookType.Natural, new string[] { "Фiзика", "Хiмiя" } },
            { BookType.Language, new string[] { "Українська мова", "Украинська Лiтература" } },
            { BookType.Math, new string[] { "Тригонометрiя", "Стереометрiя" } }
        };
        private static Dictionary<BookType, string[]> setOfPrimaryBoocks = new Dictionary<BookType, string[]>()
        {
            { BookType.Natural, new string[] { "Природознавство" } },
            { BookType.Language, new string[] { "Українська мова та література" } },
            { BookType.Math, new string[] { "Математика" } }
        };
        private static Dictionary<BookType, string[]> setOfSecondaryBoocks = new Dictionary<BookType, string[]>()
        {
            { BookType.Natural, new string[] { "Географія" } },
            { BookType.Language, new string[] { "Українська мова", "Украинська Література" } },
            { BookType.Math, new string[] { "Алгебра", "Геометрія" } }
        };

        //Метод сбору книжок
        public static Dictionary<BookType, string[]> ShapBook(SchoolE school)
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


        public static Dictionary<SchoolE, string[]> ShapBook(BookType bookType)
        {

            switch (bookType)
            {
                case BookType.Language:
                    Dictionary<SchoolE, string[]> setOfLanguageBoocks = new Dictionary<SchoolE, string[]>();
                    setOfLanguageBoocks[SchoolE.PrimarySchool] = setOfPrimaryBoocks[BookType.Language];
                    setOfLanguageBoocks[SchoolE.SecondarySchool] = setOfSecondaryBoocks[BookType.Language];
                    setOfLanguageBoocks[SchoolE.HighSchool] = setOfHighBoocks[BookType.Language];
                    return setOfLanguageBoocks;

                case BookType.Math:
                    Dictionary<SchoolE, string[]> setOfMathBoocks = new Dictionary<SchoolE, string[]>();
                    setOfMathBoocks[SchoolE.PrimarySchool] = setOfPrimaryBoocks[BookType.Math];
                    setOfMathBoocks[SchoolE.SecondarySchool] = setOfSecondaryBoocks[BookType.Math];
                    setOfMathBoocks[SchoolE.HighSchool] = setOfHighBoocks[BookType.Math];
                    return setOfMathBoocks;

                case BookType.Natural:
                    Dictionary<SchoolE, string[]> setOfNaturalBoocks = new Dictionary<SchoolE, string[]>();
                    setOfNaturalBoocks[SchoolE.PrimarySchool] = setOfPrimaryBoocks[BookType.Natural];
                    setOfNaturalBoocks[SchoolE.SecondarySchool] = setOfSecondaryBoocks[BookType.Natural];
                    setOfNaturalBoocks[SchoolE.HighSchool] = setOfHighBoocks[BookType.Natural];
                    return setOfNaturalBoocks;

                default:
                    //Повертаємо null якщо не віповідає іншим умовам
                    return null;
            }
        }

    }
}
