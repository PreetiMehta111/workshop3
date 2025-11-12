using System;

class Program
{
    static void Main()
    {
        // Part 1: Sum from 1 to N using for loop
        Console.Write("Enter a number N: ");
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum from 1 to {N} is: {sum}");

        // Part 2: Print numbers 1 to 20 using while loop, skip multiples of 4, stop at 15
        int number = 1;
        Console.WriteLine("Numbers from 1 to 20 (skip multiples of 4, stop at 15):");
        while (number <= 20)
        {
            if (number % 4 == 0)
            {
                number++;
                continue;
            }
            if (number == 15)
            {
                break;
            }
            Console.WriteLine(number);
            number++;
        }

        // Part 3: Sum of all elements in an array using foreach loop
        int[] arr = { 2, 4, 6, 8, 10 }; // Example array
        int total = 0;
        foreach (int item in arr)
        {
            total += item;
        }
        Console.WriteLine($"Sum of all elements in the array is: {total}");
    }
}