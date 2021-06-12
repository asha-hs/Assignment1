using System;
using System.Collections.Generic;
using System.Text;

namespace Exerrcise13
{
    //Abstract class
    abstract class Animal
    {
        // abstract method, no method body
        public abstract void animalSound();

        // regular method
        public void sleep()
        {
            Console.WriteLine("ZZZ  ");
        }
    }
}
