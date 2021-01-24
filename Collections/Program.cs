using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["book"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsValue("bilgisayar"));
            Console.WriteLine(dictionary.Count);
            dictionary.Add("door", "kapı");
            

            Console.ReadKey();

        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("ankara");
            cities.Add("istanbul");   // tipi string olarak verdiğim için sadece string veriler ekleyebilirim.

            Console.WriteLine(cities.Contains("ankara"));   // contains eğer eleman listede varsa true yoksa false döner.

            List<Customer> customers = new List<Customer>
            {
                new Customer {Id=1, Firstname = "ÖZKAN"},
                new Customer{Id=2, Firstname="BUSE"}
            };


            // customers.Add()  ekleme işlemi yapıyordu zaten farklı bir şekilde ekleme yapalım aşağıda.
            var customer2 = new Customer
            {
                Id = 3,
                Firstname = "SİMGE"
            };
            customers.Add(customer2);

            customers.AddRange(new Customer[2]     //AddRange Array bazlı liste verirsin o listeyi daha önceki listene ekler. customers listesine.
            {                                       // Burada new Customer aşağıdaki class ıma ıd ve fistname türünden yeni veri eklemek için.
                new Customer { Id=4, Firstname= "ZEYNEP"},    // bu veriler de addrange ile customers koleksiyonuma ekler.
                new Customer { Id=5, Firstname= "YUSUF"}
            });

            //customers.Clear();

            var index = customers.IndexOf(customer2);   // indexof listedeki elemanın kaçıncı sırada olduğunu gösterir
            Console.WriteLine("index : {0}", index);

            var index2 = customers.LastIndexOf(customer2); // lastindexof listedeki elemanı aramaya sondan başlayarak kaçıncı sırada olduğunu söyler ama eğer bir elemandan iki tane varsa ilk bulduğunun sırasını söyler.
            Console.WriteLine("index2:{0}", index2);

            customers.Insert(0, customer2);  // kaçıncı sıaraya ne eklemek isterseniz onu yazarsınız insert ile.

            customers.Remove(customer2);    // remove bulduğu ilk veriyi siler parantez içerisine yazdığımız.

            //customers.RemoveAll(c => c.Firstname = "SİMGE");  firstname i simge ise tüm simgeleri siler.

            var count = customers.Count;     // customers koleksiyonundaki eleman sayısını yazar 
            Console.WriteLine("Count : {0}", count);


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Firstname);
            }

            Console.WriteLine(customers.Contains(new Customer { Id = 1, Firstname = "ÖZKAN" }));


            //veya


            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, Firstname = "ÖZKAN" });
            //customers.Add(new Customer { Id = 2, Firstname = "BUSE" });

            // bu şekilde de ekleyebilirim.

        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();  //herhangi bir sınırlama yapmadan istediğim kadar ekleme yapabişlirim.
            cities.Add("Ankara");
            cities.Add("istanbul");
            cities.Add(1);
            cities.Add('A');     // eğer tip güvenli çalışmıyorsak ArrayList kullanırız.

            cities.Add("Bursa");
            //Console.WriteLine(cities[2]);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
    }
}
