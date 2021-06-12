using System;

namespace Assignment1
{
    // Create Class and Object of a class
    // Create multiple objects of a class
    class Car
    {
        string color = "Gray";
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
   
}
