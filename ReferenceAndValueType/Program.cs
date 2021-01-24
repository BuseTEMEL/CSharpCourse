using System;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;          /*number2 nin değeri number1 in değeridir artık .*/      
            number1 = 30;

            Console.WriteLine(number2);  /*Console.WriteLine(number1) deseydim 30 yazardı. şu an number 2 dediğimden number1=30 un bir anlamı yok yukarıda.*/

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" }; //101   bellekte cities1 ve içindeki değerler ayrı ayrı tutulur cities1 ve 101 olarak diyelim.
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };  //102  içindekiler 102 olarak kodluyor bellek. yani cities 2 ve 102 olarqak kodlanıyor.
            cities2 = cities1;       // artık citites 2 referansı citites 1 referansıdır. yani 102 artık 101 oluyor. 102 çöp.
            cities1[0] = "İstanbul";   // ankara artık istanbul olarak değişti.
            Console.WriteLine(cities2[0]);    // cities2 artık cities1 olmuştu yani 102 artık 101. istanbul yazdırır.

            Datatable datatable;  // burada new datatable yazmanın bir mantığı yok zaten aşağıda datatable diye bir referansım var.
            Datatable datatable1 = new Datatable();  
            datatable = datatable1;   // datatable1 deki verileri çekip datatable a atıyorum. her zaman sağdan sola aktarılır.


            Console.ReadKey();
        }
    }
}
