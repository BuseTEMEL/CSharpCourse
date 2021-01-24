using System;

namespace Constructors
{
    // object oriented da bir class tan nesne türetirken new sözcüğünü kullanırız. **Ayakkabi pabuc = new Ayakkabi()
    //derken ayakkabı class ındaki tüm üyeleri pabuc nesnesine aktarırız. **nesne türetmek=instance almak
    //Aslında, nesne üretmenizi sağlayan şey class’ ınızın içinde bulunan oluşturucu metot (constructor) dediğimiz üyedir.
    // Constructor herhangi bir değer döndüren bir metod değildir. void olarak da düşünülemez.
    // Constructor yalnızca üyesi bulunduğu class tan nesne üretildiğinde çalışacak metoddur.
    // Class ımdan nesne türetirken üyelerin varsayılan değerlerini ayarlamak için constructor kullanırım.
    // Ayakkabı class ında ctor oluşturmadan da pabuc nesnesini türetebiliyoruz ama bu nasıl oluyor? 
    // Aslında yazdığımız her class ta varsayılan bir ctor  bulkunur biz sadece değerleri ayarlamak için ctor oluştururuz.
    // Çoğu constructor ın access modifier ı public tir.class dışında da erişebilmemiz için . yoksa tukarıda new leyemeyiz.
    //
    class Program
    {

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();
            Product product = new Product { Id = 1, Name = "laptop" };
            Product product1 = new Product { Id = 2, Name = "computer" };
            //Product product = new Product();
            //product.Id();
            //product.Name();
            //Product product1 = new Product();
            //product1.Id();
            //product1.Name(); de diyebilirdim.

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());

            //DatabaseLogger databaseLogger = new DatabaseLogger();
            //EmployeeManager employeeManager = new EmployeeManager(databaseLogger);
            //böyle de çağırabilirim daha güzel olur

            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");  /*istenen mesajı yazdım*/ 
            personManager.Add();

            teacher.Number = 15;
            Utilities.Validate();
            Manager.DoSomething();
            Manager.DoSomething2();
            Manager manager = new Manager();
            manager.DoSomething3();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            int _id = id;
            string _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logger to Database.");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logger to File.");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {

        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }

    }

     class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)     /* burası bir constructor ve ben bu constructorla base bir sınıfa(PersonManager) parametre yolladım.*/
        {
           
        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();                      /* PersonManager ı inherit ettiğim için message ı burada kullanabilirim.*/
        }
    }

    static class teacher
    {
        public  static int Number{ get; set; }
    }

    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validate is done ");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public static void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
        public void DoSomething3()
        {
            Console.WriteLine("done3");
        }
    }



}
