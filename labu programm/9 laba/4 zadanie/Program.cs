using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100000, limit = (int)Math.Pow(n, 1.0 / 3.0), count = 0;
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int x = 0; x <= limit; x++)
            {
                for (int y = 0; y <= limit; y++)
                {
                    for (int z = 0; z <= limit; z++)
                    {
                        if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) <= n && Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) > 0)
                        {
                            numbers.Add(++count, (int)(Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3)));
                        }
                    }
                }
            }
            int[] coincidence = new int[n + 1];
            foreach (var number in numbers)
            {
                if (number.Value <= n)
                {
                    coincidence[number.Value]++;
                }
            }
            for (int i = 0; i < coincidence.Length; i++)
            {
                if (coincidence[i] > 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
