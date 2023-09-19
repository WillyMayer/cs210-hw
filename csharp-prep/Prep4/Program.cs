using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int addNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (addNumber != 0)
        {
            Console.Write("Enter number: ");
            string stringValue = Console.ReadLine();

            addNumber = int.Parse(stringValue);

            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }

        }

        //Next part: Sum numbers

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Next part: average numbers

        float average = ((float)sum) / numbers.Count();
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}