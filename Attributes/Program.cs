using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Verstappen", Age = 25 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }
    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]//Doldurulması zorunlu nesne
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, İnstead use AddNew Method")]//bu method eski bunu kullanma 
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]//Bunu Sadece Nesnelere kullan demek //allowMultiple =true ise Ard arda 2 kere kullanılabilir demek ama false ise 2. kere yazışta hata verir kızar.
    class RequiredPropertyAttribute:Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]//bunu sadece classlar da kullan demek //allowMultiple =true ise Ard arda 2 kere kullanılabilir demek ama false ise 2. kere yazışta hata verir kızar.
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

}
