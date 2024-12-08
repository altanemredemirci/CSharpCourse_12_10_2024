using System.Collections;

namespace _17_SortedList_QueueList_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList: Key:Value mantığı ile değer tutar. Sözlük mantığı ile çalışır. Key üzerinden value değerine erişilir ve aynı sözlük gibi A->Z ye sıralıdır.
            // SortedList<Key,Value>


            //SortedList sozluk = new SortedList()
            //{
            //    {"Bugün","Today"},
            //    {"Yarin","Tommorrow"},
            //    {"Hava","Wheather" },
            //    {"Gokyuzu","Sky" },
            //    {"Karli","Snowy" },
            //    {"Gunesli","Sunny" },
            //    {"Bulutlu","Cloudy" },
            //    {"Acik","Clear" },
            //    {"Kapali","Cloudy" },
            //    {"Yaş", 35 }
            //    //{ 35,"Yaş" }
            //};

            // Key üzerinden arama veya değer getirme yapılır.
            //Console.WriteLine(sozluk["Bugün"]);


            // SortedList yazdırma
            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}


            //// SortedList Key yazdırma
            //foreach (string item in sozluk.Keys)
            //{
            //    Console.WriteLine(item);
            //}


            //// SortedList Values yazdırma
            //foreach (string item in sozluk.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList Eleman Ekleme
            sozluk.Add("Yağmur", "Rain");

            //sozluk["Siyah"] = "Black";

            //sozluk["Bugün"] = "Yes Or right";

            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}

            /*
          sözlük uygulaması istenmektedir.Tr - Eng
       sözlük = { "siyah":"black",,,,}
          kullanıcı 4 girene kadar sorulur.
           1 - Arama
           2 - Çıkarma
           3 - Listeleme
           4 - Çıkış

      Kullanıcı 1'e basarsa ->
          - Aranacak olan kelimeyi giriniz:
          -Bu kelime dizide varsa eng karşılığı yazılır.
          -Yoksa uygulamanın gelişmesine yardımcı olmak ister msiniz(E-H):
              -E ise bu kelimenin karşılığı istenir ve sözlüğe eklenir
              -H ise bişey yapılmaz
      Kullanıcı 2'ye basarsa ->
          - Çıkarılmak istenen kelime :
          -Kelime sözlükte varsa çıkartılır
          - Yoksa uyarı verilir.
      Kullanıcı 3'e basarsa ->
          - Tum key value lar listelenir
          -KEY->VALUE
      Kullanıcı 4'e basarsa ->
          - Döngü sonlanır.
           */

            SortedList sozluk = new SortedList()
            {
                {"Sarı","Yellow"},
                {"Lacivert","DarkBlue"}
            };

            while (true)
            {
                Console.WriteLine("1-Arama\n2-Çıkarma\n3-Listeleme\n4-Çıkış");
                string secim = Console.ReadLine();

                if(secim == "1") 
                {
                    Console.WriteLine("Aranacak Kelime:");
                    string kelime = Console.ReadLine();

                    if(sozluk.ContainsKey(kelime))
                    {
                        Console.WriteLine(sozluk[kelime]);
                    }
                    else
                    {
                        Console.WriteLine("Kelime bulunamadı.Uygulamayı geliştirmek ister misiniz?");
                        string cevap = Console.ReadLine();

                        if(cevap != "E") { Console.WriteLine("Peki!!"); continue; }

                        Console.WriteLine($"{kelime} kelimesinin ingilizce karşılığını giriniz:");
                        sozluk[kelime] = Console.ReadLine();

                    }
                }
                else if(secim == "2") 
                {
                    Console.WriteLine("Silinecek kelime:");
                    string kelime = Console.ReadLine();

                    if (sozluk.ContainsKey(kelime))
                    {
                        sozluk.Remove(kelime);
                        Console.WriteLine("Silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Zaten ekli değildir.");
                    }
                }
                else if(secim == "3") 
                {
                    foreach (DictionaryEntry item in sozluk)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if(secim == "4") 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim!!");
                }
            }

        }
    }
}
