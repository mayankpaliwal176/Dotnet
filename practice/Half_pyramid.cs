using System;

public class Half_pyramid
{
    public static void Run()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine()!);//int parsing without  assigning to any variable

        for (int i = 1; i <= rows; i++) 
        {
            for (int j = 1; j <= i; j++) 
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }
}
