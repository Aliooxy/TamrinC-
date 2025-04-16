using System;

namespace tamrin10
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= entry; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
