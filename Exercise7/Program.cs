using System;

namespace Exercise7
{
    class Car
    {
        private string model = "Mustang";
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.model);
        }
    }
}
