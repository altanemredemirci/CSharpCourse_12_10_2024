using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Inheritance_4
{
    internal class IK:Personel
    {
        public int PersonelSayisi { get; set; }


        public static void Ekleme1(List<IK> liste)
        {
            IK ik = new IK();
            ik.TC = "11111111";
            ik.Ad = "Altan Emre";
            ik.Soyad = "Demirci";
            ik.SGKTarihi = "20-12-2024";
            ik.PersonelSayisi = 5;

            liste.Add(ik);
        }

        public static IK Ekleme2()
        {
            IK ik = new IK();
            ik.TC = "11111111";
            ik.Ad = "Altan Emre";
            ik.Soyad = "Demirci";
            ik.SGKTarihi = "20-12-2024";
            ik.PersonelSayisi = 5;

            return ik;
        }

        public void Ekleme3()
        {
            TC = "11111111";
            Ad = "Altan Emre";
            Soyad = "Demirci";
            SGKTarihi = "20-12-2024";
            PersonelSayisi = 5;
        }
    }
}
