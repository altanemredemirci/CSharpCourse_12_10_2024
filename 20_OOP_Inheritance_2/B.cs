using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Inheritance_2
{
    internal class B:A
    {
        public int b { get; set; }

        public B(string kangrubu):base(kangrubu)
        {
            Console.WriteLine("Ben B Sınıfıyım.");
        }
    }
}
