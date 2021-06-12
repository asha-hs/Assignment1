using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Car
    {
        public string color = "red";
        public string model;
        public int year;

        public Car()
        {
            // set the initial value for model
            model = "Mustang";
        }

        public void fullThrottle()
        {
            Console.WriteLine("Car is moving as fast as it can");
        }
    }
}
