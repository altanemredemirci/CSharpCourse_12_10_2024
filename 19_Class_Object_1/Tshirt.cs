using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Object_1
{
    internal class Tshirt
    {
        internal int Barkod;
        internal string Beden;
        internal string Renk;
        internal double Fiyat;

        #region 1.yöntem
        //internal static void Create(List<Tshirt> liste)
        //{
        //    Tshirt t = new Tshirt();
        //    Console.WriteLine("Barkod:");
        //    t.Barkod = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Beden:");
        //    t.Beden = Console.ReadLine();
        //    Console.WriteLine("Renk:");
        //    t.Renk = Console.ReadLine();
        //    Console.WriteLine("Fiyat:");
        //    t.Fiyat = Convert.ToDouble(Console.ReadLine());

        //    liste.Add(t);

        //}
        #endregion

        #region 2.yöntem
        internal static Tshirt Create()
        {
            Tshirt t = new Tshirt();
            Console.WriteLine("Barkod:");
            t.Barkod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Beden:");
            t.Beden = Console.ReadLine();
            Console.WriteLine("Renk:");
            t.Renk = Console.ReadLine();
            Console.WriteLine("Fiyat:");
            t.Fiyat = Convert.ToDouble(Console.ReadLine());
            
            return t;
        }
        #endregion

        internal static void List(List<Tshirt> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine($"{item.Barkod}-{item.Beden}-{item.Renk}:{item.Fiyat}");
            }
        }

        internal static void List(List<Tshirt> liste,Func<Tshirt,bool> where)
        {
            //Expression: i=> i.Renk==renk
            
            foreach (var item in liste.Where(where).ToList())
            {
                Console.WriteLine($"{item.Barkod}-{item.Beden}-{item.Renk}:{item.Fiyat}");
            }
        }

        internal static string Delete(List<Tshirt> liste)
        {
            List(liste);
            Console.WriteLine("Silinecek Ürün Barkod Numarası:");
            int barkod = Convert.ToInt32(Console.ReadLine());

            //Where: koşul belirtme komutudur.
            Tshirt urun = liste.Where(t => t.Barkod == barkod).FirstOrDefault();
            //Tshirt urun = liste.FirstOrDefault(t => t.Barkod == Id);

            if (urun == null)
            {
                return "Ürün Bulunamadı!";
            }

            liste.Remove(urun);
            return "Ürün Silindi";
        }

        internal static string Update(List<Tshirt> liste)
        {
            List(liste);

            Console.WriteLine("Güncellenecek Ürün Barkod Numarası:");
            int barkod = Convert.ToInt32(Console.ReadLine());

            var urun = liste.Where(i => i.Barkod == barkod).FirstOrDefault();

            if (urun == null)
                return "Ürün Bulunamadı";

            Console.WriteLine("Barkod:");
            urun.Barkod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Beden:");
            urun.Beden = Console.ReadLine();
            Console.WriteLine("Renk:");
            urun.Renk = Console.ReadLine();
            Console.WriteLine("Fiyat:");
            urun.Fiyat = Convert.ToDouble(Console.ReadLine());

            return "Ürün Güncellendi";
        }

        internal static Tshirt Find(List<Tshirt> liste)
        {
            Console.WriteLine("Ürün Barkod:");
            int barkod = Convert.ToInt32(Console.ReadLine());
            var urun = liste.FirstOrDefault(i=> i.Barkod==barkod);
            return urun;
        }

    }
}
