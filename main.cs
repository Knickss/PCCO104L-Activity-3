using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        do
        {
            Console.Write("Enter a number (enter 0 to exit): ");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                continue;
            }
            if (n == 0)
            {
                Console.WriteLine("Closing Program...");
                return;
            }

            PrintTriangle(n);

        } while (true);
    }

    static void PrintTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write("  ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

