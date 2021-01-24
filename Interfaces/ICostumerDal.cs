using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICostumerDal
    {
        void Add();
        void Updated();
        void Delete();
    }
    class SqlServerCostumerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("SglSever Added!");
        }

        public void Delete()
        {
            Console.WriteLine("SglSever deleted!");
        }

        public void Updated()
        {
            Console.WriteLine("SglSever updated!");
        }
    }

    class Oracle : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }

        public void Updated()
        {
            Console.WriteLine("Oracle updates!");
        }
        public class CostumerManager
        {
            public void Add(ICostumerDal costumerDal)
            {
                costumerDal.Add();
            }
        }
    }
}
