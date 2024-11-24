namespace _15_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  METOTLAR 
             *  Belirli işlemleri bir başlık altında tanımlayarak, ihtiyaç halinde başlık ile ulaşılan ve kullanılan yazılım yapılarıdır.
             *  Metotları () parantezleri temsil eder.
             *  Metotlar 2 ye ayrılır. 
                * Değer Döndüren(option parametre)
                * Değer Döndürmeyen(option parametre)
             * SOLID prensiblerinden ilki olan S — Single-responsibility principle : her metot bir iş için tasarlanmalıdır.
             
             */

            /* DEĞER DÖNDÜRMEYEN METOTLAR
             * Değer döndürmeyen metotları 'void' keyword belirtir.
             
             void MethodName()
            {

            }
             
             */
            #region Parametresiz Değer Döndürmeyen Metot
            //Toplama();
            //Toplama();
            //Toplama();
            //Toplama();
            #endregion

            #region Parametreli Değer Döndürmeyen Metot

            //Console.WriteLine("1.sayıyı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Toplama2(sayi1, sayi2);
            #endregion

            #region Kullanıcıdan 2 sayı bir işlem alınız ve alınan sayılara istenilen işlemi uygulayarak ekran yazdıran metot

            DortIslem();

            #endregion
        }

        static void DortIslem()
        {
            Console.WriteLine("İşlem giriniz:(+,-,*,/)");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Toplama();
            }
            else if (islem == "-")
            {
                Cikarma();
            }
            else if (islem == "*")
            {
                Carpma();
            }
            else if (islem == "/")
            {
                Bolme();
            }
            else
            {
                Console.WriteLine("Hatalı işlem Seçimi!!");
            }
        }

        static void Toplama()
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç:" + (sayi1 + sayi2));
        }

        static void Cikarma()
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç:" + (sayi1 - sayi2));
        }
        static void Carpma()
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç:" + (sayi1 * sayi2));
        }
        static void Bolme()
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç:" + (sayi1 / sayi2));
        }


        static void Toplama2(int sayi1, int sayi2)
        {
            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        }


    }
}
