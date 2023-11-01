using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class LanguageBook : Book
    {
        public LanguageBook(string title)
            : base(title) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("Мовна книга:");
            base.DisplayInfo();
        }
    }
}
