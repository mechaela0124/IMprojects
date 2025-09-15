using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("\nEnter string: ");
                string input = Console.ReadLine();

                if (input == "*")
                {
                    Console.WriteLine("\n//End execution");
                    break;
                }

                string original = input;
                string lower = input.ToLower();

                string reversed = "";
                for (int i = lower.Length - 1; i >= 0; i--)
                {
                    reversed += lower[i];
                }

                
                string result = (lower == reversed) ? "Yes" : "No";

                Console.WriteLine("\nOriginal String\t\tReversed String\t\tPalindrome?");
                Console.WriteLine($"  {original}\t\t\t{reversed}\t\t\t{result}");

                Console.ReadKey();

            }
        }
    }

}
