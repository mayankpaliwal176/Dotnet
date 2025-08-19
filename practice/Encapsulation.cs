using System;

class Mayank
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else
                Console.WriteLine("Age cannot be negative.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

public class Encapsulation
{
    public static void Run()
    {
        Mayank s1 = new Mayank();
        s1.Name = "Mayank";   
        s1.Age = 16;         
        s1.DisplayInfo();    
    }
}
