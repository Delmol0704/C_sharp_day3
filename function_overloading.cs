using System;

public class Class1
{
	void sum(int a, int b)
    {
        Console.WriteLine("sum is " + (a + b));
    }
    void sum(double a, double b)
    {
        Console.WriteLine("sum is " + (a + b));
    }
    public static void Main()
        {
            Class1 class1 = new Class1();
            class1.sum(1,2);
            class1.sum(1.2, 1.2);
            Console.ReadLine();
    }
    
}
