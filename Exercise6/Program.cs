using System;

namespace Exercise6
{
    class Car
    {
        public string color;
        public string model;
        public int year;

        // Create a Constructor with Parameters

        public Car(string modelName, string modelColor, int modelYear)
        {
            color = modelColor;
            model = modelName;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Mustang", "Red", 2004);
            Console.WriteLine(myCar.model);
        }
    }
}
