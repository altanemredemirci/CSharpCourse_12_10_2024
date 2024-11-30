namespace _14_Arrays_Otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 0;
            double totalPrice = 0;
            string[] orders = new string[1];

            string[] products = { "Kola", "Fanta", "Çikolata" };
            double[] prices = { 50, 45.50, 14 };

            while (true)
            {
                for (int i = 0; i < products.Length; i++) //0,1,2
                {
                    Console.WriteLine($"{i}-{products[i]}:{prices[i]}"); // $ ifadesi "(string)" içinde kod yazacağınız belirtir.
                }

                Console.WriteLine("Ürün Seçiniz:");
                int index = Convert.ToInt32(Console.ReadLine());


                if (index == -100)
                {
                    Console.WriteLine("Ürün Ekle-1\nÜrün Sil-2\nÜrün Güncelle-3\nÜrün Listele-4\nGün Sonu-5\nÇıkış 6\n Seçiminiz:");
                    int secim= Convert.ToInt32(Console.ReadLine());

                    if(secim<1 || secim > 6)
                    {
                        Console.WriteLine("Hatalı Tuşlama!!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        continue;
                    }

                    if (secim == 1) //Ürün Ekle
                    {
                        Console.WriteLine("Ürün Adı:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ürün Fiyatı:");
                        double price = Convert.ToDouble(Console.ReadLine());

                        bool IsAdd = false;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] == "")
                            {
                                products[i] = name;
                                prices[i] = price;
                                IsAdd = true;
                                break;
                            }
                        }

                        if (!IsAdd)
                        {
                            Array.Resize(ref products, products.Length + 1);
                            Array.Resize(ref prices, prices.Length + 1);
                            products[products.Length-1] = name;
                            prices[prices.Length-1] = price;
                        }
                    }
                    else if (secim == 2) //Ürün Sil
                    {
                        for (int i = 0; i < products.Length; i++) //0,1,2
                        {
                            Console.WriteLine($"{i}-{products[i]}:{prices[i]}"); 
                        }

                        Console.WriteLine("Silinecek Ürün Seçiniz:");
                        int silinecekIndex = Convert.ToInt32(Console.ReadLine());
                        if(silinecekIndex>-1 && silinecekIndex < products.Length)
                        {
                            Array.Clear(products, silinecekIndex, 1);
                            Array.Clear(prices, silinecekIndex, 1);
                            Console.WriteLine("Ürün Silindi.");
                        }
                        else
                        {
                            Console.WriteLine("Ürün Silinemedi!");
                        }
                    }
                    else if (secim == 3) //Ürün Güncelle
                    {
                        for (int i = 0; i < products.Length; i++) //0,1,2
                        {
                            Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                        }

                        Console.WriteLine("Ürün Seçiniz:");
                        int guncellenecekIndex = Convert.ToInt32(Console.ReadLine());
                        if (guncellenecekIndex > -1 && guncellenecekIndex < products.Length)
                        {
                            Console.WriteLine("Ürün Adı:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Ürün Fiyatı:");
                            double price = Convert.ToDouble(Console.ReadLine());

                            products[guncellenecekIndex] = name??"ürün yok"; // ?? null ise "ürün yok" eklenecek
                            prices[guncellenecekIndex] = price;
                            Console.WriteLine("Ürün Güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Ürün Güncellenemedi!");
                        }
                    }
                    else if (secim == 4)
                    {
                        for (int i = 0; i < products.Length; i++) //0,1,2
                        {
                            Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                        }
                    }
                    else if (secim == 5) 
                    {
                        foreach (var item in orders)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Toplam Gelir:"+totalPrice);
                    }
                    else if (secim == 6) 
                    {
                        break;
                    }
                }

                else if (-1 < index && index < prices.Length)
                {
                    while (true)
                    {
                        Console.WriteLine("Para Girişi:");
                        balance += Convert.ToInt32(Console.ReadLine());

                        #region 1.Yöntem
                        //double state = balance >= prices[index] ? balance - prices[index] : -1;

                        //if (balance >= 0)
                        //{
                        //    string result = balance > 0 ? "Afiyet Olsun.Para üstü:" + state : "Afiyet Olsun";

                        //    Console.WriteLine(result);

                        //}
                        #endregion

                        if (balance >= prices[index])
                        {
                            Console.WriteLine("Afiyet Olsun. Para Üstü:" + (balance - prices[index]));
                            balance = 0;
                            totalPrice += prices[index];
                            Array.Resize(ref orders, orders.Length + 1);
                            orders[orders.Length - 1] = products[index];
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye.");
                            Console.WriteLine("Para Ekle-1\nİade-2\nSeçiminiz:");
                            int result = Convert.ToInt32(Console.ReadLine());
                            if (result != 1)
                            {
                                Console.WriteLine("Paranız:" + balance);
                                balance = 0;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                                
                            }
                        }
                    }
                   

                }
                else
                {
                    Console.WriteLine("Yanlış Ürün Seçimi!!");
                }


            }

        }
    }
}
