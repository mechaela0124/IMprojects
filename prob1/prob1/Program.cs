using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    class Program
    {
       
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                int num = int.Parse(input[i]);
                if (IsPrime(num))
                    Console.WriteLine($"{i + 1}. {num,-5} Prime");
                else
                    Console.WriteLine($"{i + 1}. {num,-5} Composite");
            }

            Console.ReadKey();
        }
    }
}

