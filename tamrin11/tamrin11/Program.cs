using System;

namespace tamrin11
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = int.Parse(Console.ReadLine());
            double sum = 0;
            double sub = 1;
            for (int i = 1; i <= entry; i++)
            {
                sum += sub/i;
            }
            Console.WriteLine(sum);
        }
    }
}
