namespace _15_Methods_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen değerler arasında rastgele sayı üreten  ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
            //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,
            //en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
            //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
            //kullanıcının bütün hataları kontrol altına alınmalı


            SayiUret();
             


        }

        static void SayiUret()
        {
            Console.WriteLine("Başlangıç değeri:");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş değeri:");
            int bitis = Convert.ToInt32(Console.ReadLine());

            if (basla > bitis)
            {
                int temp = basla;
                basla = bitis;
                bitis = temp;
            }

            Random r = new Random();

            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = r.Next(basla, bitis);
            }

            DiziYazdir(sayilar);

            Console.WriteLine("En Büyük:"+EnBuyukDeger(sayilar));
            Console.WriteLine("En Küçük:"+EnKucukDeger(sayilar));

        }

        static void DiziYazdir(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int EnBuyukDeger(int[] array)
        {
            int sayi = array[0];
            foreach (var item in array)
            {
                if (item > sayi)
                {
                    sayi = item;
                }
            }

            return sayi;
        }

        static int EnKucukDeger(int[] array)
        {
            int sayi = array[0];
            foreach (var item in array)
            {
                if (item < sayi)
                {
                    sayi = item;
                }
            }

            return sayi;
        }
    }
}
