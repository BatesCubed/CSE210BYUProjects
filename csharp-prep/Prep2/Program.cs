using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string givenGradeString = Console.ReadLine();
        int givenGrade = int.Parse(givenGradeString);
        int gradeRemainder = givenGrade % 10;
        string gradeSign;
        string letterGrade;
        string statement;
        if (givenGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (givenGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (givenGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (givenGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (givenGrade >= 70)
        {
            statement = "Congratulations! You passed the class!";
        }
        else
        {
            statement = "I'm sorry, you didn't pass the class this time!";
        }

        if (gradeRemainder >= 7)
        {
            gradeSign = "+";
        }
        else
        {
            gradeSign ="-";
        }

        if ((letterGrade == "A" && gradeSign == "+") || (letterGrade == "F"))
        {
            Console.WriteLine($"{statement} Your final grade was {letterGrade}"); 
        }
        else
        {
            Console.WriteLine($"{statement} Your final grade was {letterGrade}{gradeSign}");
        }
        
    }
}