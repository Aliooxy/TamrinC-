using System;

namespace tamrin13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("month");
            int emonth = int.Parse(Console.ReadLine());
            Console.WriteLine("day");
            int eday = int.Parse(Console.ReadLine());
            int sum = 0;

            if (emonth >= 1 && emonth <= 6)
            {
                sum = ((emonth - 1) * 31) + eday;
            }

            else if (emonth >= 7 && emonth <= 12)
            {
                sum = (emonth - (emonth - 6)) * 31 + (emonth - 7) * 30 + eday;


            }
            Console.WriteLine(sum);



        }
    }
}
