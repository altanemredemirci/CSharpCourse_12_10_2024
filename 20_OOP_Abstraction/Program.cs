using System.Linq.Expressions;

namespace _20_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  *** ABSTRACT - SOYUTLAMA ***
             /*ABSTRACT NEDİR?*/
            /*Abstract class’lar, oluşturulması istenen class’ların sadece base class olarak davranması
             * ve üzerinden bir instance oluşturulmamasının istendiği durumlarda kullanılır. 
             * C#’da bu fonksiyonaliteyi sağlamak için abstract anahtar sözcüğünü kullanmak yeterlidir. */
            /*
     ***** Abstract Sınıfların Normal Sınıflardan Farkı Nedir? *****
     Fark 1: Normal sınıflar içerisinde metot bildirimi yapılamazken, Abstract sınıflar içerisinde tıpkı arayüzler de olduğu gibi metot bildirimi yapılabilir. 
     Bildirimi yapılan metotlar, Abstract sınıftan türeyen sınıflar içerisinde tanımlanmak zorundadır.

     Fark 2: Normal sınıflardan “new()” anahtar sözcüğü ile nesneler oluşturulabilir ancak Abstract sınıflar tamamen kalıtım amaçlı geliştirildiğinden Abstract sınıflardan nesne oluşturulamaz.
     */


            //Insan insan = new Insan(); 
            //Abstract keyword almış sınıflar base class olarak tanımlanır ve INSTANCE alınamaz.
            //Abstract keyword almış metotlar miras alındıkları classlarda tanımlanmak zorundadır. Bu metotlar gövdelerine komut almazlar. Çünkü miras alınan sınıfta yapacakları işlem tanımlanır.

            Product p = new Product();
           
        }
    }
  
    // 6 class her biri için Create,Update,Delete,List,List<Expression>,Find(paramKey)


    //Abstract field tanımlanması için class'ın abstract olması gereklidir. Class Abstract tanımlı diye içindeki fields hepsinin abstract olma zorunluluğu yoktur.
    abstract class Methods
    {
        public abstract void Create();
        public abstract void Update();
        public abstract void Delete();
        public abstract void List();
        public abstract void List(Expression);
        public abstract void Find();

        public void Yaz() //abstract olmayan tanımlar miras yoluyla aktarılır.
        {
            Console.WriteLine("Yazzzzz");
        }
    }

    class Product : Methods
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Find()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void List(Expression )
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Category : Methods
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }
    }

    class Brand
    {

    }

    class Cart
    {

    }

    class Order
    {

    }

    class Customer
    {

    }
}
