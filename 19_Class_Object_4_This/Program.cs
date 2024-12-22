namespace _19_Class_Object_4_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Insert(1, "Ahmet", "Mehmet");

            Console.WriteLine(customer.Name);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //this: Kendi içinde bulunduğu class'ı temsil eder. 
        public void Insert(int Id,string Name,string Surname)
        {
            //class properies ile parametreler aynı isimde olduğundan property belirtmek için this kullanılır.
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
        }
    }
}
