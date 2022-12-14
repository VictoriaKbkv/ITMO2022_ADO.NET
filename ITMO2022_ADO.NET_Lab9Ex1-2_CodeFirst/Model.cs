using System.Data.Entity;

namespace ITMO2022_ADO.NET_Lab9Ex1_2_CodeFirst
{
    public class Model
    {
        public class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            public byte[] Photo { get; set; }

            public override string ToString()
            {
                string s = Name + ", электронный адрес: " + Email;
                return s;
            }
            // Ссылка на заказы
            public virtual List<Order> Orders { get; set; }
            public Customer()
            {
                Orders = new List<Order>();
            }
        }

        public class Order
        {
            public int OrderId { get; set; }
            public string ProductName { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
            public DateTime PurchaseDate { get; set; }

            // Ссылка на покупателя
            public Customer Customer { get; set; }

            public override string ToString()
            {
                string s = ProductName + " " + Quantity + "шт., дата: " + PurchaseDate;
                return s;
            }

        }

        public class SampleContext : DbContext
        {
            public SampleContext() : base("MyShop")
            { }

            public DbSet<Customer> Customers { get; set; }
            public DbSet<Order> Orders { get; set; }

        }

    }
}