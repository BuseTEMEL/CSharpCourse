using System;

namespace VirtualMethods
    // virtual metodunu eğer sonradan değiştireceğim bir durum veya her yerde farklı çalışan bir veri varsa (delete gibi)
    // o zaman kullanırım. değişiklik yaapacağım zaman override(ezmek) etmem gerekir veriyi.
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Delete();

            Console.ReadLine();
        }
        
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer :Database
    {
        public override void Add()
        {
            Console.WriteLine("Added  by Sql Server");
        }
    }
    class MySqlServer: Database
    {

    }

}
