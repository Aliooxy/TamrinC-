using System;

namespace tamrin12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;

            Console.WriteLine("");

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                    count++;
                }
            }
            Console.WriteLine("Sum of divisors : " + sum);
            Console.WriteLine("count of divisors : "+count);

        }
    }
}
