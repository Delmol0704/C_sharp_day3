using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class6
    {
        abstract class Employee //abstract class
        {
            public virtual string VirtualMethod()
            {
                return "I am called from base.";
            }
        }
        class Class11 : Employee //concrete class
        {
            public override string VirtualMethod()
            {
                return "I am called from child.";
            }
            public static void Main()
            {
                Class11 class11 = new Class11();
                Console.WriteLine(class11.VirtualMethod());
                Console.ReadLine();
            }
        }
    }
}