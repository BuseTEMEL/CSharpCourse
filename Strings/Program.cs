using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Özkan Toraman";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is BUSE";

            bool result3 = sentence.EndsWith("n");
            bool result4 = sentence.StartsWith("my name");
            var result5 = sentence.IndexOf("name");   /*kaçıncı karakterde olduğunu gösterir*/
            var result6 = sentence.IndexOf(" ");       /*ilk boşluk kaçıncı karakterdeyse onu yazar*/
            var result7 = sentence.LastIndexOf(" ");     /*aramaya sondan başlar*/
            var result8 = sentence.Insert(0, "Hello, ");        /*girilen karakterden sonra yazı ekler*/
            var result9 = sentence.Substring(3);            /* girilen karakterden sonrasını yazdırır*/
            var result10 = sentence.ToLower();            /* tümünü küçük harf yapar*/
            var result11 = sentence.ToUpper();            /*tümünü büyük harf yapar*/
            var result12 = sentence.Replace(" ", "-");    /*ilk girilen karakter yerine yanındaki karakteri koyar*/
            var result13 = sentence.Remove(2);            /*girilen karakterden sonrasını atar,yazdırmaz*/
            var result14 = sentence.Remove(2, 5);    /* girilen ikinci karakter kadar girilen ilk karakterden itibaren atar*/

            Console.WriteLine(result14);
            Console.ReadLine();


            string city = "Ankara";

            //Console.WriteLine(city[0]);

            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}

            string city2 = "İstanbul";

            //string result = city + " " + city2;
            //Console.WriteLine(result);

            //Console.WriteLine(String.Format("{0} {1}", city, city2));
            //Console.ReadLine();



        }
    }
}
