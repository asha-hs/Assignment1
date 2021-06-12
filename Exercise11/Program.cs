using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar Object
            Car myCar = new Car();

            //Display value of brand from Vehicle class value of modelName from Car class
            Console.WriteLine(myCar.brand + " "+ myCar.modelName);
            myCar.honk();

        }
    }
}
