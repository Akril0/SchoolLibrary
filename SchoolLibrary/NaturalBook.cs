using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class NaturalBook : Book
    {
        public NaturalBook(string title)
            : base(title) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("Книга з природничих наук:");
            base.DisplayInfo();
        }
    }
}
