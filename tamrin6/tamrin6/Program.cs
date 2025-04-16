using System;

namespace tamrin6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int entry = int.Parse(Console.ReadLine());
            if (entry < 10 )
            {
                count = 1;
            }
            while (entry >= 10)
            {
                entry /= 10;
                count++;
                if (entry < 10 )
                {
                    count += 1;
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
