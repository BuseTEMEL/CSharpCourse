using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try                                   // şimdi madem try la kontrol altına alabiliyorum, aşağıda neden throw ile hata fırtlattım ki?
                                                  // katmanlı mimarilerde backhand denen kısımda arka tarafta aşağıda bu kodlar (throwun bulunduğu blok) yazılır.  
            {
                Find();                           // ön kısımda bu kod yazılır.
            }
            catch (RecordNotFoundException exception)  // backhand aslında arka tarafta kodla oluşturulan bir mantıktır. backhand öntarafa hata fılatır, ön tarafta bunu kontrol altına alır.
            {
                Console.WriteLine(exception.Message);  //.Message bu kısım artık Record not found! yazdıracak.

            }

            catch (Exception exception
           )
            {
                
            }

            HandleException(() =>     // methodun içine method gönderdim
            {
                Find();
            });


            
            Console.ReadKey();
        }

        private static void HandleException(Action action)  //action parametresiz kod bloğu. void fonk. için kullanılır değer döndürmez.
        {
            try
            {
                action.Invoke();    //action ı invoke et. buradaki action find a karşılık geliyor. find ı çalıştır demek. try da çalştırıyor.
            }
            catch (Exception exception )
            {
                Console.WriteLine(exception.Message);
               
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "özkan", "buse", "simge" };

            if (!students.Contains("yusuf"))  // students listesi içerisinde yusuf elemanı yoksa
            {
                throw new RecordNotFoundException("Record not found!");  //{Message = "Record not found!" } bu şekilde yazmaya kalksam message ın altını çizerdi çünkü message ı ezemedim.
            }                                     // record not founndu bu şekilde yazabilmek için class ta constructor oluşturdum. constructor zaten bir sınıftan nesne oluşturmamızı sağlardı. bu nesneyi ilk kullanıma hazırlardı.
            else
            {
                Console.WriteLine("Record Found!");
            }

        }
       

        private static void ExceptionIntro()
        {
            try  //dene
            {
                string[] students = new string[3] { "ÖZKAN", "BUSE", "SİMGE" };   // hata alabileceğini düşündüğün kodu buraya yaz.

                students[3] = "YUSUF";
            }

            catch (IndexOutOfRangeException exception)  // eğer hata ındex of the range exception türünde ise burayı çalıştır.
                                                        // indexoutofrangeexception üzerine gelip f12 ye basınca hata türlerinin aslında 'exception' base li olduğunu görürüz.
            {
                Console.WriteLine(exception.InnerException); // inner exception hata ile ilgili daha detaylı bilgi verir.
            }

            catch (DivideByZeroException exception)   // birden fazla türde hat alabileceğini düşünüyorsan catch ları arttırabilirsin.
            {
                Console.WriteLine(exception.Message);  // hata ile ilgili bilgi verir ama biz bunları kullanıcıya göstermemek için loglarız ve kendimiz inceleriz.
            }
            catch (Exception exception)  // eğer yukarıdaki hata türletrinden biri değilse bunu çalıştır.
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
