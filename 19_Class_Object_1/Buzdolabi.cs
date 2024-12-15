using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Object_1
{
    internal class Buzdolabi
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string Enerji;
        internal int Fiyat;

        internal static Buzdolabi Ekle()
        {
            Buzdolabi b = new Buzdolabi();

            Console.WriteLine("Id:");
            b.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marka:");
            b.Marka = Console.ReadLine();

            Console.WriteLine("Model:");
            b.Model = Console.ReadLine();

            Console.WriteLine("Enerji:");
            b.Enerji = Console.ReadLine();

            Console.WriteLine("Fiyat:");
            b.Fiyat = Convert.ToInt32(Console.ReadLine());

            return b;
        }

        internal static void List(List<Buzdolabi> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine($"{item.Id} - {item.Marka} {item.Model}, Enerji: {item.Enerji}, Fiyat: {item.Fiyat}");
            }
        }
    }
}
