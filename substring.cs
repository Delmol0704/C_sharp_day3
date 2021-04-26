using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class8
    {
        static void Main()
        {
            string str = "It is a bad color";
            if (str.Contains("is a"))
                Console.WriteLine("It is a substring");
            else
                Console.WriteLine("It is not a substring");
            Console.ReadLine();
        }
    }
}