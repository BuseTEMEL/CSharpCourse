using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();  //list te string verirsen add in içi string olur.  int verirsen add in içi de int olur.
            sehirler.Add("Ankara");                    //bunu mylist te yapabilmek için mylist e de generic yapı ekledik.
            Console.WriteLine(sehirler.Count);  //count şuan 0.
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T>  //GENERIC CLASS
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0]; // yukarıda önce new ledim o yüzden ctor oluşturdum. sonra count u 0 dı arrayi kullanmak için newledim burda.
        }

        
        public void Add(T item) //parametre
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1]; 
           

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }
        public int Count   //propfull tab*2 ile oluşturdum. kendi countumu yarattım.
        {
            get { return _array.Length; }   //kendi count umu oluşturarak yukarıda şehirler2 nin de countunu çağırabilirim. 
            //set { myVar = value; } //yukarıda count un üzerine geldiğimde sadece get; olduğunu görürüm. bu nedenle set kullanmayacağım.
        }

    }
}
