using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            // create animal object
            Animal myAnimal = new Animal();
            // create a dog Object
            Animal myDog = new Dog();
            //Create a pig Obect
            Animal myPig = new Pig();

            myAnimal.animalSound();
            myDog.animalSound();
            myPig.animalSound();  
        }
    }
}
