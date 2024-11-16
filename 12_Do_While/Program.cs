namespace _12_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;

            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int j = 1; j < 10; j++)
            //{
            //    Console.WriteLine(j);
            //}

            // While ve For loop ları önce koşulu kontrol eder. Koşul TRUE ise döngüye girip kodu çalıştırır. Kodu çalıştırdıktan sonra tekrar koşul satırına dönerek true/false kontrolü yapar.

            // Do While loop ilk olarak kodu çalıştırır ve sonra koşul kontrolü yaparak, koşul TRUE ise tekrar kod satırına döner.

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;

            //} while (i<10);


            #region Kullanıcı 0 girene kadar girilen sayıları toplayarak ekrana yazdırınız.

            int toplam = 0;
            int sayi;
            do
            {                
                Console.WriteLine("Sayı giriniz:");
                sayi= Convert.ToInt32(Console.ReadLine());
                toplam += sayi;

            } while (sayi!=0);

            Console.WriteLine("Toplam:"+toplam);

            #endregion
        }
    }
}
