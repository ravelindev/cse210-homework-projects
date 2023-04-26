using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (number != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");

            }
            else if(number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guess it!");
            }
        }

    }
}
