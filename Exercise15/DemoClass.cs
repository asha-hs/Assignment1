using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise15
{
    class DemoClass : IFirstInterface,ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Some other text");
        }
    }
}
