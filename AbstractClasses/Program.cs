using System;

namespace AbstractClasses
// abstract class ları interface ve virtual metodların birleşimi gibi düşünebiliriz. 
//Tamamen inheritance amacı ile kullanılır.
//interface ve virtualların kullanım amaçlarını bir araya getirdiğimizde abstract ların kullanım amacı olur.
// abstractlarla hem tamamlanmış hem tamamalanmamış metodlar yapabiliriz.
// Abstract sınıfları new leyemeyiz.
// Bir class sadece bir Abstract class tan inherite edilebilir. Ama birden fazla Interface le implemente edilebilir.
// Abstract class lar başka  bir class veya başka bir abstract sınıfla implemente edilemezler..
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Delete();

            Database database1 = new Oracle();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete(); // aslında abstract içi dolu olmayan virtual metoddur. virtuallarda da override ederiz.


    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    } 

    public class Deneme
    {
        public virtual void Naber()
        {
            Console.WriteLine("Deneme");
        }
    }

    class NoSQL : Deneme
    {
        public override void Naber()
        {
            base.Naber();
        }
    }

    interface Buse
    {
        void Ozkan();
    }

    class Ask : Buse
    {
        public void Ozkan()
        {
            Console.WriteLine("Seni çok seviyorum!");
        }
    }
}
