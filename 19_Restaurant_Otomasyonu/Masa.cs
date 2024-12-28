using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Restaurant_Otomasyonu
{
    internal class Masa
    {
        public int Id { get; set; }
        public int Kapasite { get; set; } 
        public bool BosMu { get; set; } = true;
        public double Hesap { get; set; } = 0;

        public List<Yemek> Siparis { get; set; } // Error: return null

        public Masa()
        {
            Siparis = new List<Yemek>();
        }
    }
}
