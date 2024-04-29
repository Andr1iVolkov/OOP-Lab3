using System;

namespace Lab3
{

    public static class StartupProject
    {
        static void PrintPrimeNumbers(int[] arr) //Знайти та вивести прості числа
        {
            int n = arr.Max();
            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            bool existsPrime = false;
            foreach (int num in arr)
            {
                if (num >= 0 && isPrime[num])
                {
                    Console.Write(num + "\t");
                    existsPrime = true;
                }
            }
            if (!existsPrime)
            {
                Console.Write("Прості числа відсутні");
            }

            Console.WriteLine();
        }

        static void PrintMinPositive(int[] arr) //Знайти та вивести мінімальне додатнє число
        {
            bool isFind = false;
            if (arr[arr.Length - 1] > 0)
            {
                for (int i = arr.Length - 2; i > 0; i--)
                {
                    if (arr[i] <= 0)
                    {
                        isFind = true;
                        Console.WriteLine("Мінімальне додатнє число -> " + arr[i + 1]);
                        Console.WriteLine("Індекс -> " + (i + 1));
                        break;
                    }
                }
                if (!isFind && arr[0] > 0)
                {
                    Console.WriteLine("Мінімальне додатнє число -> " + arr[0]);
                    Console.WriteLine("Індекс -> " + 0);
                }
            }
            else
            {
                Console.WriteLine("В масиві відсутні додатні числа");
            }
        }

        static void PrintMaxNegative(int[] arr) //Знайти найбільше від'ємне число та вивести його
        {
            int key = 0;
            bool isFind = false;
            if (arr[0] < 0)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] >= key)
                    {
                        isFind = true;
                        Console.WriteLine("Найбільше від'ємне число -> " + arr[i - 1]);
                        Console.WriteLine("Індекс -> " + (i - 1));
                        break;
                    }
                }
                if (!isFind && arr[arr.Length - 1] < 0)
                {
                    Console.WriteLine("Найбільше від'ємне число -> " + arr[arr.Length - 1]);
                    Console.WriteLine("Індекс -> " + (arr.Length - 1));
                }
            }
            else
            {
                Console.WriteLine("В масиві відсутні від'ємні числа");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    
}