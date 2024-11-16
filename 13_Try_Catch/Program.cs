namespace _13_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    //kontrol edilecek veya hata olma olasılığı olan kod bloğu yazılır.
            //}
            //catch (Exception)
            //{
            //    //try bloğunda hata olması durumunda bu alanda yapılması istenen kod bloğu yazılır.
            //}


            //while (true)
            //{
            //try
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(12 / sayi);
            //    break;
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Lütfen sayı değerini RAKAM olarak giriniz");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0'a bölünme hatası!!");
            //}
            //catch (Exception) // Bütün hataları yakalar.
            //{
            //    Console.WriteLine("Bilinmeyen hata! Sistem yöneticiniz ile görüşünüz.");
            //    //throw;//Hata fırlatma
            //}

            //}

            // Program kullanıcısı bir hata alması ve sistem yöneticisine iletmesi için LOG Alma yöntemi kullanılır.

            //try
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //}
            ////catch (Exception e)
            ////{
            ////    Console.WriteLine(e.Message);
            ////}
            //catch (Exception e)
            //{
            //    Console.WriteLine(DateTime.Now+" "+e);
            //}

            #region Kullanıcıdan iki sayı alınacak ve toplamı yazdırılacak

            //int sayi;
            //int sayi2;
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("1.Sayı:");
            //        sayi = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Lütfen sayı değerini RAKAM olarak giriniz"); 
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Int max 10 basamaklı sayı alabilir.");
            //    }
            //}

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("2.Sayı:");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Lütfen sayı değerini RAKAM olarak giriniz");
            //    }
            //}

            //Console.WriteLine("Toplam:"+(sayi+sayi2));


            #endregion


            //try
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Lütfen sayı değerini RAKAM olarak giriniz");
            //}
            //finally // Genelde try içinde açılan Sql Bağlantısını başarılı veya hata alınması gibi iki durumda da kapatmak için kullanılır.
            //{
            //    Console.WriteLine("Try veya Catch bloklarını ayırmaksızın her zaman çalışır.");
            //}
        }
    }
}
