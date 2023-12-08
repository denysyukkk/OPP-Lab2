// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть, яке значення обчислити:");
        Console.WriteLine("1. Сума 1^n + 2^(n/2) + ... + k^(n/k)");
        Console.WriteLine("2. Сума 1^k + 2^k + ... + n^k");
        Console.WriteLine("3. Сума (1/n) + (2/n^2) + (3/n^3) + ... + (k/n^k)");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Некоректний вибір. Будь ласка, введіть число від 1 до 3.");
            return;
        }

        Console.WriteLine("Введіть значення n:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректне значення n. Будь ласка, введіть ціле число більше 0.");
            return;
        }

        Console.WriteLine("Введіть значення k:");
        if (!int.TryParse(Console.ReadLine(), out int k) || k <= 0)
        {
            Console.WriteLine("Некоректне значення k. Будь ласка, введіть ціле число більше 0.");
            return;
        }

        double result = 0;

        switch (choice)
        {
            case 1:
                result = CalculateSum1(n, k);
                break;
            case 2:
                result = CalculateSum2(n, k);
                break;
            case 3:
                result = CalculateSum3(n, k);
                break;
            default:
                Console.WriteLine("Некоректний вибір. Будь ласка, введіть число від 1 до 3.");
                return;
        }

        Console.WriteLine($"Результат обчислення: {result}");
    }

    static double CalculateSum1(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += Math.Pow(i, n / (double)i);
        }
        return sum;
    }

    static double CalculateSum2(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(i, k);
        }
        return sum;
    }

    static double CalculateSum3(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += i / Math.Pow(n, i);
        }
        return sum;
    }
}

