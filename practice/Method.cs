using System;

public class Method
{
    static int Add(int a, int b)
    {
        return a + b;
    }

   public static void Run()
    {
        int result = Add(5, 3);
        Console.WriteLine("Sum: " + result); 
    }
}
