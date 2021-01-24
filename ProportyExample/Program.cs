using System;

namespace ProportyExample
{

    //Proporty ler verileri saklar. 
    //Get Ve Set ifadesini kullanmamızın temel amacı A sınıfındaki private erişim tipi olan değişkene B sınıfından erişmeye çalışırken kullanmamızdır.
    // SET ifadesi nesnenin özelliklerine değer atandığında çalışır.
    //GET ifadesi ise özellik değeri okunduğunda ya da farklı bir ifadeye aktarılmaya çalıştığında çalışır.
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer = new Costumer();
            costumer.Id = 2;
            costumer.Name = "özkan";
            costumer.Surname = "toraman";
            Console.WriteLine(costumer.Surname);
            
            Ogrenci ogrenci = new Ogrenci();  
            Console.WriteLine(ogrenci.ADI);
            Console.ReadKey(); 
        }
    }
    class Ogrenci
    {
        string Ad="buse";
        string Soyad = "toraman";

        public string ADI
        {
            get { return Ad; }    

            set { Ad = value; }   
        }
        
        public string SOYADI
        {
            get { return Soyad; }
            set { Soyad = value; }
        }
       
    } 
    class Costumer
    { 

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
