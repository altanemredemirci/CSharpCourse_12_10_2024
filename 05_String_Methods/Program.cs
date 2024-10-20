namespace _05_String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Length

            //string isim = "Altan Emre DEMİRCİ";
            //int uzunluk =isim.Length;

            #endregion

            #region Index Of
            //Koleksiyonlar içindeki elemanları INDEX adı verilen 0'dan başlayarak 1'er 1'er artan numaralandırma sistemi ile tutarlar.
            //string de char lardan oluşan bir koleksiyondur.
            //Index Of: ilk bulduğu değerin index numarasını döndürür.
            //string isim = "Altan Emre DEMİRCİ";
            //int index = isim.IndexOf('E');
            //Console.WriteLine(index);

            #endregion

            #region Last Index Of

            //LastIndex Of: son bulduğu değerin index numarasını döndürür.
            //string isim = "Altan Emre DEMİRCİ";
            //int index = isim.LastIndexOf('E');
            //Console.WriteLine(index);

            #endregion

            #region StartsWith

            //string isim = "Altan Emre";
            //Console.WriteLine(isim.StartsWith("Al"));

            #endregion

            #region EndsWith

            //string isim = "Altan Emre";
            //Console.WriteLine(isim.EndsWith("re"));

            #endregion

            #region Trim

            //string isim = "    Altan Emre    ";
            //string yeniIsim = isim.TrimStart(' ').TrimStart('A');
            //string yeniIsim2 = isim.TrimEnd(' ');
            //string yeniIsim3 = isim.Trim();

            //Console.WriteLine(yeniIsim);
            //Console.WriteLine(yeniIsim2);
            //Console.WriteLine(yeniIsim3);
            #endregion

            #region ToLower()
            //string isim = "ALTAN";
            //isim = isim.ToLower();
            //Console.WriteLine(isim);
            #endregion

            #region ToUpper()
            //string ad = "altan";
            //ad = ad.ToUpper();
            //Console.WriteLine(ad);
            #endregion

            #region Remove

            //string isim = "ALTAN EMRE";
            ////isim = isim.Remove(2);
            //string isim2 = isim.Remove(2,2); //Silmeye 2.indexden başla 2 karakter sil. 
            //Console.WriteLine(isim2);

            #endregion

            #region Replace

            //string isim = "ALTAN EMRE";
            //isim = isim.Replace("EMRE", "URAS");
            //Console.WriteLine(isim);

            #endregion

            #region Insert

            //string isim = "ALTAN EMRE";
            //isim = isim.Insert(6,"URAS ");
            //Console.WriteLine(isim);

            #endregion

            #region Substring
            //Substring: Bir string datanın bir bölümünü almaya yarar. Başlangıç index değeri verildiğinde o indexten sonuna kadar olan kısmı, alınacak karakter sayısı verildiğinde ise başlangıç indexinden istenilen karakter kadar kısmını dilim olarak alır.
            //string isim = "ALTAN EMRE";
            //isim = isim.Substring(2,4);
            //Console.WriteLine(isim);

            #endregion
        }
    }
}
