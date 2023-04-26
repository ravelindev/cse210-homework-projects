using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (enter 0 to stop): ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            numbers.Add(num);
        }

        Console.WriteLine("List of numbers: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = (double)sum / numbers.Count;

        int maximum = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maximum)
            {
                maximum = num;
            }
        }

        Console.WriteLine("\nSum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Maximum: " + maximum);
    }
}
