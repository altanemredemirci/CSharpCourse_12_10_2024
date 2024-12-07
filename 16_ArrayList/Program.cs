
using System.Collections;

namespace _16_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ARRAYLIST

            //Array:VeriTipi ve uzunluk(elemansayısı) zorunludur.
            //int[] sayilar = new int[10];


            //ArrayList kullanmak için "using System.Collections;" adresi import edilmelidir.
            //ArrayList de Veritipi ve uzunluk zorunluluğu yoktur.
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(11);
            //arrayList.Add(12);
            //arrayList.Add("Altan Emre");
            //arrayList.Add(150.45);
            //arrayList.Add(true);
            //arrayList.Add(100.5f);
            //arrayList.Add(100.4m);
            //arrayList.Add('?');


            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            // ** Capacity and Count **
            //ArrayList list = new ArrayList() { 11, 12, 13,14,15,16,17,18,19 };

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);


            #region METHODS

            //ArrayList list = new ArrayList();

            //list.Add(11); //eleman ekleme
            //list.Add(12);
            //list.Add("Altan");
            //list.Add(13);


            //list.Insert(2, "Emre"); //istenilen index değerine eleman ekleme

            ////list.Clear(); //bütün elemanları siler
            ////Console.WriteLine(list.Capacity); //elemanlar silinse bile capacity sabit kalır.

            //list.AddRange(new ArrayList() { 14, 15, 16 }); //çoklu elemanlar ekleme 

            //ArrayList sayilar = new ArrayList() { 99, 88, 77 };

            //list.AddRange(sayilar);

            //list.AddRange(new int[5] { 1, 2, 3, 4, 5 });

            //list.InsertRange(1, new ArrayList() { 44, 55, 66 });//istenilen index e çoklu elemanlar ekleme 


            //list.Remove("Emre");//silinecek değer girilir.
            //list.RemoveAt(4);//silinecek index girilir.




            #endregion

            #region Clone
            //ArrayList arrayList1 = new ArrayList(){ 1,2,3 };

            ////ArrayList arrayList2 = arrayList1;

            //ArrayList arrayList2 = (ArrayList)arrayList1.Clone(); //Boxing (ArrayList)

            //foreach (var item in arrayList1)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("*****************");

            //arrayList1.Add(4);

            //foreach (var item in arrayList1)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #endregion


            // Kullanıcıdan sayı isteyelim Sayı verdiği sürece toplama yapalım sayı yerine "çık" yazarsa toplama işlemi bitsin sonuc yazdırılsın.

            ArrayList sayilar = new ArrayList();
            int toplam =0;

            while (true)
            {
                Console.WriteLine("Sayı Gir:");
                string sayi = Console.ReadLine();

                if (sayi == "cik")
                {
                    Console.WriteLine("Toplam:"+toplam);
                    break;
                }

                int s = Convert.ToInt32(sayi);

                sayilar.Add(s);
                toplam += s;
            }
    


           

        }
    }
}
