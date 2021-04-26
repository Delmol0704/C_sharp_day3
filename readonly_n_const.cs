using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class7
    {
        /* public const double PI = 3.14;
         public static void Main()
         {
             const int RollNo = 1234;
             const int age = 10;
             //RollNo = 156; gives error
             Console.WriteLine(RollNo);
             Console.ReadLine();
          }*/

        public readonly double pi = 3.14;
        public Class7(double pi)
        {
            this.pi = pi;
        }
        public static void Main()
        {
            const double PI = 3.14;
            Class7 class7 = new Class7(45);
            Console.WriteLine(class7.pi);
            Console.WriteLine(PI);
            Console.ReadLine();
        }
     }
}