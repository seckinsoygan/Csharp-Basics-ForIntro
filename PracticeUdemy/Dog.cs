using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUdemy
{
    internal class Dog : IAnimal
    {
        public void giveVoice()
        {
            Console.WriteLine("Hav hav!");

        }
    }
}
