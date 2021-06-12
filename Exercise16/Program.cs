using System;

namespace Exercise16
{
    class Program
    {
        enum Level
        {
            High,
            Medium,
            Low
        }
        enum Month{
            January,
            February,
            March=6,
            April,
            May,
            June
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            int num = (int)Month.April;
            Console.WriteLine(num);
            Console.WriteLine(myVar);
            switch(myVar)
            {
                case Level.High:
                    Console.WriteLine("High level");
                break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                
            }
        }
    }
}
