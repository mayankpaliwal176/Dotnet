using System;

public class If_else
{
    public static void Run()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age = int.Parse(input);

        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote yet.");
        }
    }
}
