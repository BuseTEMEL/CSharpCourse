using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "engin";
            students[1] = "derin";
            students[2] = "salih";

            //string[] students2 = new string[3] { "engin", "derin", "salih" };
            //string[] students3 = { "engin", "derin", "salih" };

            //Bu şekillerde de kullanılabilir bence 3. kullanım daha mantıklı...


            //foreach (var student in students) 
            //{
            //    Console.WriteLine(student); 
            //}
            //Console.ReadLine();

            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit","Balıkesir"},
                { "ankara", "konya","kırıkkale"},
                { "antalya", "adana", "mersin"},
                { "rize","trabzon","samsun" },
                { "muğla", "izmir" , "manisa" }
            };
            

            for (int i = 0; i < regions.GetLength(0); i++)
            {
                for (int j = 0; j < regions.GetLength(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
        
    }
}
