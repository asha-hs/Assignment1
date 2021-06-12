using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise12
{
    class Pig : Animal      // Derived class
    {
        public override void animalSound()
        {
            Console.WriteLine("The Pig Says Wee Wee");
        }
    }
}
