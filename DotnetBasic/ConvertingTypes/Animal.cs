using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingTypes
{
    class Animal
    {
        public void Eat() { Console.WriteLine("Eating."); }
        public override string ToString()
        {
            return "I am an animal.";
        }
    }
    class Mammal : Animal { }
    class Giraffe : Mammal { }

    class SuperNova { }
}
