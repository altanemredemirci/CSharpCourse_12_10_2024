using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Restaurant_Otomasyonu
{
    internal class Menu
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Yemek> Yemekler { get; set; }

    }
}
