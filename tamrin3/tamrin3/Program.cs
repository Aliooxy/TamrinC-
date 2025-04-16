using System;

namespace tamrin3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dest = 20;
            int avg = 0, sum = 0,entry;
            for (int i = 0; i < dest; i++)
            {
                Console.WriteLine("enter number to see avg at the end");
                entry = int.Parse(Console.ReadLine());
                sum += entry;
            }
            avg = sum / dest;
            Console.WriteLine("AVG is : "+ avg);
        }
    }
}
