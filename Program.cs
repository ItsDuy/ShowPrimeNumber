using System.Globalization;

namespace ShowPrimeNumb;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 100; i++)
        {
            if (i < 4)
            {
                Console.Write($"{i} ");
            }
            else
            {
                bool isPrime = true;
                for (int j = 2; j <= MathF.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write($"{i} ");
                }
            }
            }
        }
    }
