using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    //Private=Başka hiç bir yerden erişilemez.  (Classlar private olarak belirtilemez.)
    //İnternal=Classın sadece kendi projesinde kullanılmasını sağlıyor.
    //Public=Her yerden erişim sağlanabilir başka projelerden de erişilebilir.
    internal class User 
    {
        public User()
        {

        }

        public string Mail { get; set; }  
        public string Password { get; set; }

        public static void Metot1(string Mail2,string Password2)
        {
            
            Console.WriteLine($"Mail adresi={Mail2} , Password={Password2}");
        }
    }
}
