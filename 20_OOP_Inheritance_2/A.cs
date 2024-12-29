using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Inheritance_2
{
    internal class A
    {
        public string kanGrubu { get; set; }

        public A(string _kanGrubu)
        {
            kanGrubu = _kanGrubu;
            Console.WriteLine("Ben A Sınıfıyım.");
        }
    }
}
