using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Object_1
{
    internal class Camasir_Makinesi
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string Kapasite;
        internal int Fiyat;

        internal static Camasir_Makinesi Ekle()
        {
            Camasir_Makinesi c = new Camasir_Makinesi();

            Console.WriteLine("Id:");
            c.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marka:");
            c.Marka = Console.ReadLine();

            Console.WriteLine("Model:");
            c.Model = Console.ReadLine();

            Console.WriteLine("Kapasite:");
            c.Kapasite = Console.ReadLine();

            Console.WriteLine("Fiyat:");
            c.Fiyat = Convert.ToInt32(Console.ReadLine());

            return c;
        }

        internal static void List(List<Camasir_Makinesi> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine($"{item.Id} - {item.Marka} {item.Model}, Enerji: {item.Kapasite}, Fiyat: {item.Fiyat}");
            }
        }
    }
}
