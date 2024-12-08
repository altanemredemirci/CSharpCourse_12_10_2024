namespace _18_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ARRAY Veri tipi ve Uzunluk belirtilmelidir. 
                 * Veritipi belirtilmesi AVANTAJ
                 * Eleman sayı sabit olması DEZAVANTAJ

             *ARRAYLIST Veri tipi ve Uzunluk belirtmez.
                 * Veritipi belirsizliği DEZAVANTAJ
                 * Eleman sayı belirtilmemesi AVANTAJ

             *LIST Veritipi belirtilir ama uzunluk(eleman sayısı) belirtilmez.



             */
            //Boş List Tanımı
            List<string> list = new List<string>();

            list.Add("Nil");
            list.Add("Safiye");
            list.Add("Sude");
            list.Add("Rümeysa");
            list.Add("Elif");

            //Dolu List Tanımı
            List<string> isimler = new List<string> {"Selin","Gizem","Enes" };

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            list.AddRange(isimler);

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            isimler.ForEach(item => Console.WriteLine(item));

            
        }
    }
}
