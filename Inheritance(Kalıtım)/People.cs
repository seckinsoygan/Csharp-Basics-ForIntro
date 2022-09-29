using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalıtım_
{
    public class People
    {
        public string namee { get; set; }    
        public string surname { get; set; }
        public int age { get; set; }

        public void goster(string _name,string _surname, int _age)
        {
            _name = namee;
            _surname = _surname;
            _age = _age;
            Console.WriteLine($"Name={_name} , Surname={_surname} , Age={_age}");
        }

        
    }
}
