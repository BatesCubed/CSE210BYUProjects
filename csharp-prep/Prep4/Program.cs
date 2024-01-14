using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);
            if (number != 0)
            {
                numList.Add(number);
            }
        }
        float sum = 0;
        foreach (int num in numList)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        float averageOfList = sum / numList.Count;
        Console.WriteLine($"The average is: {averageOfList}");
        int highNum = -1000000000;
        int smallNum = 1000000000;
        foreach (int numb in numList)
        {
            if (numb > highNum)
            {
                highNum = numb;
            }
            if (numb > 0 && numb < smallNum)
            {
                smallNum = numb;
            }
        }
        Console.WriteLine($"The largest number is: {highNum}");
        Console.WriteLine($"The smallest positive number is: {smallNum}");
        numList.Sort();
        Console.WriteLine("Here is the sorted list:");
        Console.Write("(");
        foreach (int sortedNum in numList)
        {
            Console.Write($"{sortedNum}, ");
        }
        Console.Write(")");
    }
}