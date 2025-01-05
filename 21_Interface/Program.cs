namespace _21_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*INTERFACE(ARAYUZ) NEDİR?

               *Bir sınıftan kalıtımla almak güçlü bir mekanizmadır, asıl kalıtımın gücü bir arayüzden kalıtımla almasında yatar. 
               Bir sınıf kalıtımla sadece bir sınıftan türetilebilir ancak bu kısıtlama kalıtımla arayüzden türetme söz konusu olduğunda ortadan kalkar
               yani bir sınıf birden çok arayüzden kalıtımla türeyebilir. 

               Arayüzler sınıflar gibi kod ve veri içermez,sadece tanım içerir. 
               Aslında soyut sınıflar arabirimlere benzerler ancak soyut sınıflar kod ve veri içerebildikleri için arayüzlerden ayrılır. 
               Ancak çoğu zaman arayüzler soyut sınıflarla beraber kullanılarak güçlü uygulamalar geliştirilir. 

               INTERFACE NEDEN KULLANILIR, VE FAYDALARI NELERDİR
               *Arayüz uygulamasının kullanım amacı büyük çaplı ve çok sayıda geliştiricinin çalıştığı projelerde belirli kurallar tanımlayıp bu kurallar yardımı
                ile sınıfların hangi özellikleri barındırması gerektiğini belirterek geliştiricilere yol göstermektedir. 
                Küçük çaplı ve bireysel olarak geliştirilen projelerde geliştirici hangi sınıfta hangi metotları kullanması gerektiğini kendisi belirlediği için
                arayüz kullanmak gerekmemektedir. Büyük projelerde ise yazılım mimarı altında çalışan geliştiricilere yol göstermek için arayüz tanımlayabilir.

               Arayüz tanımlamak için class ya da struct sözcükleri yerine “interface” (interfeys) sözcüğü kullanılır. 
               Arayüz içinde metotları aynen bir sınıf (class) ya da yapı (struct) içerisinde olduğu gibi bildirilir.
               Farklı olarak herhangi bir erişim belirteci (public) , private  ya da protected kullanılmaz ve metot gövdesi noktalı virgülle ayrılır. 
               Örneğin,

               Arayüz isminin başında I harfi kullanıldığına dikkat edilmelidir. 
               Bu kullanılan sınıfın bir arayüz olduğunu anlamamıza yarayan bir isim kullanma tekniğidir. 
               Bu sayede, sınıfların kalıtımsal olarak aldığı elemanların arayüz olup olmadığı daha kolayca anlaşılabilir.ör: IArayuz


               Bir arayüzün hiçbir zaman bir uygulama (tanımlama dışında deyim ve ifadeler)
               içermeyeceği unutulmamalıdır. Bu durumun doğal sonucu olarak aşağıdaki kısıtlamalar
               ortaya çıkar:

                -Bir arayüz için herhangi bir alan (field) tanımlanamaz (statik olsa bile). Çünkü
                alan bir sınıf ya da bir yapının uygulama detayıdır.

                -Bir arayüz içinde kurucu (constructor) tanımlamaya da izin verilmez. Bu da
                uygulama detayı kabul edilir.

                -Bir arayüz içinde bir yıkıcı (destructor) da tanımlanamaz.

                -Bir metot için bir erişim belirteci de belirtilemez. Çünkü bir arayüzdeki tüm
                metotlar dolaylı olarak ortaktır (public).

                -Bir arayüz içerisinde hiçbir türü yuvarlanamaz. Bir başka deyişle arayüzler
                sınıf, yapı ya da numaralandırma içeremez.

                -Bir arayüzü bir sınıf ya da yapıdan kalıtımla alamazsınız yani türetemezsiniz.

                -Arayüzler ,arayüzlerden türeyebilir. Yapılar ve sınıflar uygulama içerdikleri için
                bu kısıtlama olmasaydı üstteki bazı kısıtlamalar ihlal edilirdi.



               Bir Arayüz Uygulamak

               Bir arayüzü uygulamak için arayüzden kalıtımla alan ve arayüzde belirtilen tüm  yöntemleri sağlayan bir sınıf ya da yapı bildirilir. Öğrenme faaliyeti -1 içinde temel sınıf olan insan hatırlanmalıdır. Bu sınıfın içerisinde Buyu adında bir metot kullanılmıştı. Insan sınıfı IInsan adında bir arayüzü uyguluyor olsun. Bu arayüz de aşağıdaki gibi tanımlanmış olsun. */


            /*INTERFACE KULLANIMININ IMPLEMENTASYON KURALLARI*/

            /*Bir arayüzü uygulandığında her metodun kendine uygun bir arayüz metoduyla tam
              olarak eşleşmesi garantiye alınmalıdır.

             Metot adları ve dönüş türleri kesin olarak eşleşmelidir.
             Parametreler (ref ve out anahtar sözcükleri dahil) tam olarak eşleşmelidir.
             Arayüz tanımı ve arayüz uygulaması arasında bir fark varsa uygulama
            derlenmez.
             Arayüzden türetilen sınıf içerisinde oluşturulan arayüze ait metotlar mutlaka
            public olarak tanımlanmalıdır*/



            /*BİR SINIFIN HEM SINIFTAN HEMDE INTERFACE DEN MIRAS ALMASI*/

            /* Bir sınıf hem bir sınıftan devralıyor hem de bir arayüzü uyguluyorsa aşağıdaki gibi
             kodlanır:*/
        }
    }
}
