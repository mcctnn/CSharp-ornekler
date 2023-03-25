using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arraylist();
            //List();
            //Dictionary();
            Console.ReadLine();
        }

        private static void Dictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("computer", "bilgisayar");
            dictionary.Add("table", "tablo");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            var dmg = dictionary.ContainsKey("book");
            var dmg2 = dictionary.ContainsKey("glass");
            Console.WriteLine(dmg + "  " + dmg2);
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("İstanbul");
            cities.Add("Ankara");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Mehmet" });
            //customers.Add(new Customer { Id = 2, FirstName = "Can" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Mehmet" },
                new Customer { Id = 2, FirstName = "Can" }
            };
            var customer2 = new Customer { Id = 3, FirstName = "Ali" };
            customers.Add(customer2);
            customers.AddRange(new Customer[2] {
                new Customer { Id = 4, FirstName = "Mahmut" }, new Customer { Id = 5, FirstName = "Ahmet" }
            });

            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Mehmet" }));
            //customers.Clear();
            customers.RemoveAll(c => c.FirstName == "Mehmet");
            var count = customers.Count;
            Console.WriteLine("Count:{0}", count);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        private static void Arraylist()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Mehmet");
            cities.Add("Can");
            cities.Add(1);
            cities.Add('B');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
