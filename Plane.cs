using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counterOne = (n*3-1)/2;
            int counterTwo = 1;
            Console.Write(new string('.', counterOne));
            Console.Write("*");
            Console.WriteLine(new string('.', counterOne));
            for (int i = 0; i < n/2+1; i++)
            {
                counterOne -=1;
                Console.Write(new string('.', counterOne));
                Console.Write("*");
                Console.Write(new string('.', counterTwo));
                Console.Write("*");
                Console.WriteLine(new string('.', counterOne));
                counterTwo += 2;
            }
            counterOne -= 1;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', counterOne));
                Console.Write("*");
                Console.Write(new string('.', counterTwo));
                Console.Write("*");
                Console.WriteLine(new string('.', counterOne));
                counterTwo += 4;
                counterOne -= 2;
            }
            Console.Write("*");
            Console.Write(new string('.',(n*3-(n+4))/2));
            Console.Write("*");
            Console.Write(new string('.', n ));
            Console.Write("*");
            Console.Write(new string('.', (n * 3 - (n + 4)) / 2));
            Console.WriteLine("*");
            counterOne = ((n * 3 - (n + 4)) / 2) - 2;
            counterTwo = n;
            int counterThree = 1;
            for (int i = 0; i < n/2-1; i++)
            {
                Console.Write("*");
                Console.Write(new string('.',counterOne));
                Console.Write("*");
                Console.Write(new string('.', counterThree));
                Console.Write("*");
                Console.Write(new string('.', counterTwo));
                Console.Write("*");
                Console.Write(new string('.', counterThree));
                Console.Write("*");
                Console.Write(new string('.', counterOne));
                Console.WriteLine("*");
                counterOne -= 2;
                counterThree += 2;
            }
            counterOne = n - 1;
            counterTwo = n;
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(new string('.', counterOne));
                Console.Write("*");
                Console.Write(new string('.', counterTwo));
                Console.Write("*");
                Console.WriteLine(new string('.', counterOne));
                counterOne -= 1;
                counterTwo += 2;
            }
            Console.WriteLine(new string('*',n*3));
        }
    }
}
