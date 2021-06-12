using System;

namespace Exercise3
{
    //Demonstrates Class fields, methods and Constructor
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);

            // to demonstrate acces to fields and methods
            Car Ford = new Car();
            Ford.color = "Gray";
            Ford.model = "Mustang";
            Ford.year = 2000;

            Car Opel = new Car();
            Opel.color = "Red";
            Opel.model = "Astra";
            Opel.year = 2005;

            Console.WriteLine(Ford.color);
            Console.WriteLine(Opel.color);

            //to illustrate Constructor

            // Create an object of the Car class, this will call constructor.
            Car myCar = new Car();
            Console.WriteLine(myCar.model);
        }
    }
}
