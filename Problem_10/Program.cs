using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 2, prime = 3, i;
            double sq;
            while(prime < 2000000)
            {
                sum += prime;
                while(true)
                {
                    prime += 2;
                    i = 2;
                    sq = Math.Sqrt(prime);
                    while (prime % i != 0 && i < sq) i++;
                    if (i > sq) break;
                }
            }
            Console.WriteLine("Hello World!  " + sum);
            Console.ReadKey();
        }
    }
}
