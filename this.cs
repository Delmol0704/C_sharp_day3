using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class5
    {
        public int a;
        Class5(int a)
        {
            this.a = a; //only a=a gives a=0
        }
        public static void Main()
        {
            Class5 class5 = new Class5(6);
            Console.WriteLine(class5.a);
            Console.ReadLine();
        }
    }
}
