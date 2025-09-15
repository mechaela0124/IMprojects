using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob2
{
  

    class Program
    {
      
        static void ConvertCurrency(int dollar)
        {
            double peso = dollar * 57.17;
            double yen = dollar * 146.67;
            Console.WriteLine($"{dollar,-10}\t{peso:F2}\t\t{yen:F2}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter currency in ($): ");
            string[] dollars = Console.ReadLine().Split(',');

            Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen(Y)");
            foreach (string d in dollars)
            {
                int dollar = int.Parse(d.Trim());
                ConvertCurrency(dollar);
            }

            Console.ReadKey();
        }
    }

}
