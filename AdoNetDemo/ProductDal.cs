using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdoNetDemo
{
    public class ProductDal
    {
        

        public List<Product> GetAll()  //bütün productları listele.
        {
            SqlConnection connection = new SqlConnection(@"server= lokaldb\mssqllokaldb; initial catolog =ETrade; integrated security= true");  // Uzaktan bağlanacaksan ; uid = özkan; password= buse210919eklemelisin içine.
                                                                                                                                                // intagrated security veritabanına windows otantication ile bağlan demek. yani sen kullanıcı adı ve şifrenle bu database e başka bilgisayardan da erişim sağlayabilirsin ama burda integrated security true olunca kendi bilgisayarından gir dmeek.
                                                                                                                                                //yani kullanıcı adı ve şifreye gerek yok .  Uzaktaki bir database e bağlanmak istersen bunu false yapıyorsun . bunun için kullanıcı adı ve şifre gerekiyor.
                                                                                                                                                //initial catalog hangi veri tabanına bağlanacağımı söyler.
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open(); // bağlantı aç demek ama bağlantı açıkken tekrar açmak sıkıntı olur bu yüzden bir şartla açmamız gerek.
            }

            SqlCommand command = new SqlCommand("Select * from Products");

             


        }

    }
}
