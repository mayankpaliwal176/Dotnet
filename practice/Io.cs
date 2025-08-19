using System;
public class Io
{
   public static void Run()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
                string ageInput = Console.ReadLine(); 
        int age = int.Parse(ageInput);        

        Console.WriteLine("Hello " + name + ", you are " + age + " years old");
    }
}
