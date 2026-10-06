using System;

class GradesProgram
{
    static void Main()
    {
        Console.Write("Enter first grade: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second grade: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third grade: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());

        double sum = grade1 + grade2 + grade3;
        double average = sum / 3;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);

        if (average >= 60)
        {
            Console.WriteLine("Average is 60 or higher.");
        }
        else
        {
            Console.WriteLine("Average is less than 60.");
        }
    }
}