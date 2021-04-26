using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class9
    {
        //we have to replace CApital letter/upper case letters to lower/small letters and vice versa
        static void Main()
        {
            string str = "My name is Delmol Denny";
            
            
            for (int i = 0; i <= str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    Console.Write( Char.ToUpper(str[i]));
                    
                }
                else
                {
                    Console.Write(Char.ToLower(str[i]));
                }
            }
           
            Console.ReadLine();
        }
        
    }
}
