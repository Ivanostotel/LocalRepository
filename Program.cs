using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool isPrime = true;
            List<int> roundNum = new List<int>();
            for (int i = 2; i < N; i++)
            {
                for (int j = 2; j < Math.Sqrt(N); j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    roundNum.Add(i);
                }
                isPrime = true;
            }
            for (int i = 0; i < roundNum.Count; i++)
            {
                if (i<roundNum.Count-1)
                {
                    Console.Write("{0}, ", roundNum[i]);
                }
                else
                {
                    Console.Write(roundNum[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
