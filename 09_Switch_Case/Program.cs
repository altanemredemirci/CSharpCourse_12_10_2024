namespace _09_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nt sayi = 6;

            //if (sayi == 1)
            //{
            // Console.WriteLine("Sayi 1");
            //}
            //else if (sayi == 2) { }
            //else if (sayi == 3) { }
            //else if (sayi == 4) { }
            //else if (sayi == 5) { }
            //else{ }

            //switch (sayi)
            //{
            //    case 1: //sayi==1
            //        Console.WriteLine("Sayı 1");
            //        break; // kırmak - kontrol durumunu devam ettirmiyor. Switch case yapısından çıkar.

            //    case 2:
            //        Console.WriteLine("Sayı 2");
            //        break;

            //    case 3:
            //        Console.WriteLine("Sayı 3");
            //        break;

            //    default: //else
            //        Console.WriteLine("Sayı 1 - 5 aralığında değil");
            //        break;
            //}


            #region  Klavyeden iki sayı, bir işlem(+,-,*,/) girilecek. Sayılar girilen işleme göre sonucu ekrana yazdıran switch case.

            //Console.Write("Birinci sayıyı girin: ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("İkinci sayıyı girin: ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Bir işlem girin (+, -, *, /): ");
            //string islemTuru = Console.ReadLine();

            //double sonuc;

            //if (islemTuru == "+")
            //{
            //    sonuc = sayi1 + sayi2;
            //}
            //else if (islemTuru == "-")
            //{
            //    sonuc = sayi1 - sayi2;
            //}
            //else
            //{
            //    sonuc = 0;
            //}
            //Console.WriteLine("Sonuç:"+sonuc);


            //switch (islemTuru)
            //{
            //    case "+":
            //        sonuc = sayi1 + sayi2;
            //        break;
            //    case "-":
            //        sonuc = sayi1 - sayi2;
            //        break;
            //    case "*":
            //        sonuc = sayi1 * sayi2;
            //        break;
            //    case "/":
            //        if (sayi2 != 0)
            //        {
            //            sonuc = sayi1 / sayi2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz!");
            //            sonuc = 0;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz işlem!");
            //        sonuc = 0;
            //        break;
            //}

            //Console.WriteLine("Sonuç: " + sonuc);



            #endregion

            #region BATUHAN
            //Console.WriteLine("Birinci sayıyı giriniz");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());


            //Console.Write("Yapmak istediğiniz işlemi girin (+, -, *, /): ");
            //char islem = Convert.ToChar(Console.ReadLine());

            //double sonuc;

            //switch (islem)
            //{
            //    case '+':
            //        sonuc = sayi1 + sayi2;
            //        Console.WriteLine("Sonuç: " + sonuc);
            //        break;
            //    case '-':
            //        sonuc = sayi1 - sayi2;
            //        Console.WriteLine("Sonuç : " + sonuc);

            //        break;

            //    case '*':
            //        sonuc = sayi1 * sayi2;
            //        Console.WriteLine("Sonuç : " + sonuc);
            //        break;

            //    case '/':

            //        if (sayi2 != 0) // Bölme işleminde payda sıfır olmamalı
            //        {
            //            sonuc = sayi1 / sayi2;
            //            Console.WriteLine("Sonuç: " + sonuc);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hata: Sıfıra bölme yapılamaz!");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Geçersiz işlem seçildi.");
            //        break;

            //}
            #endregion

            /*
          kullanıcıdan alınan cinsiyet bilgisine göre
          ==> ERKEK ise
          yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
          ==> KADIN ise
           yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 3600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 3600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
          ==> cinsiyet bilgisi switch-case ile sorgulanacak
           */

        }
    }
}