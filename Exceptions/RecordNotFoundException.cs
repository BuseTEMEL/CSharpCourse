using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class RecordNotFoundException : Exception // bir veritabanında veya listede bir kayıt aradığınızda o kayıt bulunamazsa böyle bir hata versin istiyorum .
    {                                       //exception ile inherit ettim çünkü tüm hatalar arka planda excepsion dan inherit alıyor. yani bu hata da artık exception.
        public RecordNotFoundException(string message) : base(message) 
        { 
            
        }
    }
}

// ben bi class yarattım. bu class a oluşturduğum bir hatanın ismiini verdim. tüm hatalarda olduğu gibi bu oluşturduğum hatayı da exception dan kalıtım(inherit) aldırdım. 
//(inheritance =kalıtım aldırmaktır ve kalıtım aldığı bir nesenenin tüm özelliklerini kullanabilir.)
//daha sonra kullanıcı oluşturduğum hatayla karşılaştığında exception.message sonucu ortaya çıkan mesajı değil de benim yazdığım mesajı görsün isteedim.
// bu mesajı yazabilmek içinse class ımın içinde bir constructor oluşturdum.
// (constructor ı bu classta bir nesen oluşturmak ve bu nesneyi ihtiyaç halinde çağırmak için kullandım. nesnem message.)
// diğer taraftan string bir message ı classımdaki constructor a göndermem gerek. ("Record not found!") 
// daha sonra böyle bir hatayı aldığında kullanıcı "Record not found!" mesajını görmesi için bu mesajı ben base e yani exception a attım. 