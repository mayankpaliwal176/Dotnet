using System;
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }
}
public class Object
{
    public static void Run()
    {
        Student student1 = new Student();
        student1.Name = "Alice";
        student1.Age = 16;
        student1.Grade = "10th";
        student1.DisplayInfo();
    }
}
