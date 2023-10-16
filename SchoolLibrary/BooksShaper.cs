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
        //Поле книжки для  молодшої школи
        private string[] primaryBoock ={ "Математика", "Природознавство", "Українська мова та література" };
        //Поле книжки для середньої школи
        private string[] secondaryBoock = { "Алгебра","Геометрія" , "Географія", "Українська мова", "Украинська Література" };
        //поле книжки для старшої школи 
        private string[] highBoock = { "Тригонометрія", "Стереометрія", "Фізика", "Хімія" ,"Українська мова", "Украинська Література" };

        //Метод сбору книжок
        public string[] ShapBook(SchoolE school)
        {
            switch(school)
            {
                case SchoolE.HighSchool:
                    //Повертаємо список книжок для старшої школи
                    return highBoock;
                case SchoolE.PrimarySchool:
                    //Повертаємо список книжок для молодшої школи
                    return primaryBoock;
                case SchoolE.SecondarySchool:
                    //Повертаємо список книжок для середньої школи
                    return secondaryBoock;
                default:
                    //Повертаємо null якщо не віповідає іншим умовам
                    return null;
            }
        }
        
    }
}
