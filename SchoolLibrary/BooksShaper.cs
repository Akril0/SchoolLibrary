using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //Метод сбору книжок
        public static Dictionary<BookType, string[]> ShapBook(SchoolE school)
        {
            Dictionary<BookType, string[]> setOfBoocks = new Dictionary<BookType, string[]>();
            switch (school)
            {
                case SchoolE.HighSchool:
                    //Повертаємо список книжок для старшої школи'
                   
                    setOfBoocks[BookType.Natural] = new string[] { "Фiзика", "Хiмiя" };
                    setOfBoocks[BookType.Language] = new string[] { "Українська мова", "Украинська Лiтература" };
                    setOfBoocks[BookType.Math] = new string[] { "Тригонометрiя", "Стереометрiя" };
                    return setOfBoocks;
           
                case SchoolE.PrimarySchool:
                    //Повертаємо список книжок для молодшої школи
                    setOfBoocks[BookType.Natural] = new string[] { "Природознавство" };
                    setOfBoocks[BookType.Language] = new string[] { "Українська мова та література" };
                    setOfBoocks[BookType.Math] = new string[] { "Математика" };
                    return setOfBoocks;

                case SchoolE.SecondarySchool:
                    //Повертаємо список книжок для середньої школи
                    setOfBoocks[BookType.Natural] = new string[] { "Географія" };
                    setOfBoocks[BookType.Language] = new string[] { "Українська мова", "Украинська Література" };
                    setOfBoocks[BookType.Math] = new string[] { "Алгебра", "Геометрія" };
                    return setOfBoocks;

                default:
                    //Повертаємо null якщо не віповідає іншим умовам
                    return null;
            }
        }
        
    }
}
