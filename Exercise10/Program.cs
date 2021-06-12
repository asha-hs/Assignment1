using System;

namespace Exercise10
{
    // To demonstrate automatic short hand properties
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Asha";
            Console.WriteLine(myObj.Name);
        }
    }
}
