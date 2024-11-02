using System.Drawing;

namespace _08_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bankamatik
            string sfr = "ab18";
            double bakiye = 25000;
            int hak = 3;

            KARTLI:
            Console.WriteLine("*** X BANKA HOŞGELDİNİZ *** ");
            Console.WriteLine("Kartlı İşlem - 1\nKartsız İşlem - 2");
            string kartli = Console.ReadLine();

            if (kartli == "1") 
            {
                SIFRE:
                if (hak > 0)
                {
                    Console.WriteLine("Şifre Giriniz:");
                    string sifre = Console.ReadLine();                    

                    if (sfr == sifre) 
                    {
                        ANAMENU:
                        Console.WriteLine("*** ANA MENÜ ***");
                        Console.WriteLine("1-Para Çekme\n2-Para Yatırma\n3-Para Transfer\n4-Eğitim Ödemeleri\n5-Fatura Ödemeleri\n6-Bilgi Güncelle\nSeçiminiz:");
                        string anamenuSecim = Console.ReadLine();

                        if (anamenuSecim == "1") 
                        {
                            Console.WriteLine("Çekilecek Miktar:");
                            int miktar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= miktar)
                            {
                                bakiye -= miktar;
                                Console.WriteLine("Paranızı Alınız.");
                                Console.WriteLine("Yeni bakiye:"+bakiye);
                            }
                            else
                            {
                                //Her iki komutta aynı işi yapar. String " ları arasında c# komutları kullanmak için çift tırnak başına $ işareti konulur.
                                Console.WriteLine("Yetersiz Bakiye.\nMevcut Bakiyeniz:"+bakiye+" Çekmek İstenilen Miktar:"+miktar);
                                //Console.WriteLine($"Yetersiz Bakiye.\nMevcut Bakiyeniz:{bakiye} Çekmek İstenilen Miktar:{miktar}");
                            }

                        }
                        else if (anamenuSecim == "2") 
                        {
                            Console.WriteLine("1-Kendi hesabına\n2-Kredi kartına\nSeçiminiz:");
                            string yatirmaSecim = Console.ReadLine();

                            if (yatirmaSecim == "1") 
                            {
                                Console.WriteLine("Yatırılacak Miktar:");
                                int miktar = Convert.ToInt32(Console.ReadLine());

                                bakiye += miktar;
                                Console.WriteLine("Yeni bakiye:"+bakiye);
                            }
                            else if (yatirmaSecim == "2") 
                            {
                                Console.WriteLine("12 haneli kart no:");
                                string kartNoStr = Console.ReadLine();

                                long kartNo;

                                if(long.TryParse(kartNoStr, out kartNo) && kartNoStr.Length==12)
                                {
                                    Console.WriteLine("Yatırılacak Miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Yeni bakiye:"+bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Yetersiz Bakiye.\nMevcut Bakiyeniz:{bakiye} Yatırmak İstenilen Miktar:{miktar}");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Kart numarası 12 rakamdan oluşmalıdır.");
                                }



                                #region long olarak kart no alma ve kontrol
                                //long kartNo = Convert.ToInt64(Console.ReadLine());

                                //if(kartNo>99999999999 && kartNo < 1000000000000) { }
                                #endregion



                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama!!");
                            }

                        }
                        else if (anamenuSecim == "3") 
                        {
                            Console.WriteLine("EFT - 1\nHavale - 2\nSeçiminiz:");
                            string transferSecim = Console.ReadLine();

                            if (transferSecim == "1") 
                            {
                                Console.WriteLine("Başında TR olacak şekilde IBAN giriniz:");
                                string IBAN = Console.ReadLine().ToUpper();

                                //TR123456789098
                                //if ((IBAN[0] + IBAN[1]).ToString() == "TR"){ }

                                string IbanTR = IBAN.Substring(0, 2); //0.Indexden başlayarak 2 karakter al.
                                string IbanNo = IBAN.Substring(2); //2. Indexden başlayarak sonuna kadar olan karakterleri al.

                                long Iban;

                                if(IbanTR=="TR" && IbanNo.Length==12 && long.TryParse(IbanNo, out Iban))
                                {
                                    Console.WriteLine("Transfer yapılacak miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Transfer Başarılı.");
                                        Console.WriteLine("Yeni bakiye:"+bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Yetersiz Bakiye.\nMevcut Bakiyeniz:{bakiye} Transfer İstenilen Miktar:{miktar}");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Girilen IBAN bilgisi Hatalı!! TR + 12 rakamdan oluşmalıdır.");
                                }
                            }
                            else if (transferSecim == "2") 
                            {
                                Console.WriteLine("11 haneli hesap no giriniz:");
                                string hesapNo = Console.ReadLine();

                                long hesapNumarasi;

                                if (hesapNo.Length == 11 && long.TryParse(hesapNo, out hesapNumarasi))
                                {
                                    Console.WriteLine("Transfer yapılacak miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Transfer Başarılı.");
                                        Console.WriteLine("Yeni bakiye:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Yetersiz Bakiye.\nMevcut Bakiyeniz:{bakiye} Transfer İstenilen Miktar:{miktar}");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Girilen Hesap bilgisi Hatalı!! 11 haneli rakamdan oluşmalıdır.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama!!");
                            }
                        }
                        else if (anamenuSecim == "4") 
                        {
                            Console.WriteLine("Eğitim Ödemeleri Arızalı!!");
                        }
                        else if (anamenuSecim == "5") { }
                        else if (anamenuSecim == "6") { }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama!!");
                        }

                        Console.WriteLine("Anamenü - 9\nÇıkış - 0\nSeçiminiz:");
                        string donus = Console.ReadLine();
                        if (donus == "9")
                        {
                            Console.Clear();
                            goto ANAMENU;
                        }                           
                        else
                            Environment.Exit(0); //Program Biter.


                    }
                    else
                    {
                        hak--; // hak değerini 1 azaltır.
                        Console.WriteLine("Şifre Hatalı!!");
                        goto SIFRE;
                    }
                }
                else
                {
                    Console.WriteLine("Giriş Hakkınız Bitti.");
                    Console.WriteLine("Sistem 5 saniye kilitlendi.");
                    Thread.Sleep(5000);
                    Console.Clear();
                    hak = 3;
                    goto KARTLI;
                }
               


            }
            else if (kartli == "2") { }
            else 
            { 
                Console.WriteLine("Hatalı Tuşlama!!");
                Thread.Sleep(3000); // Verilen milisaniye kadar bekleme yapar.                
                Console.Clear(); //Console ekranını temiz
                goto KARTLI;
            }
        }
    }
}
