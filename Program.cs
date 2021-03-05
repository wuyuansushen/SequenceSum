using System;

namespace SequenceSum
{
    class Program
    {
        static int Main(string[] args)
        {
            double N, L;
            string[] input = Console.ReadLine().Split(" ");
            N = Convert.ToDouble(input[0]);
            L = Convert.ToDouble(input[1]);

            for(int n=Convert.ToInt32(L);n<=100; n++)
            {
                double start = (2 * N - n - n * n) / (2 * n);
                if (start%1==0)
                {
                    int startReally = Convert.ToInt32(start);
                    for(int i=startReally;i<(n+startReally-1);i++)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.Write($"{n+startReally-1}");
                    return 0;
                }
            }
            Console.WriteLine("No");
            return 0;
        }
    }
}
