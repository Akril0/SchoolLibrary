using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class MathBook : Book
    {
        public MathBook(string title, string author, int pages)
            : base(title, author, pages) { }

        public override void DisplayInfo()
        {
            Console.WriteLine("Математична книга:");
            base.DisplayInfo();
        }
    }
}
