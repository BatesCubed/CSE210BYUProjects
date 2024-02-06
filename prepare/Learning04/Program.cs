using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment assignment = new Assignment("Jonathan Brinkerhoff","Algebra");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("");
        MathAssignment mathAssignment = new MathAssignment("Michael Collins", "Calculus","15.9","10-28");
        Console.WriteLine(mathAssignment.GetHomeWorkList());
        Console.WriteLine("");
        WritingAssignment writingAssignment = new WritingAssignment("Benjamin Phillips", "American History", "The Revolutionary War: And what came after");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}