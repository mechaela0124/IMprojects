using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
   
    class Program
    {
        static void Main()
        {
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            double[,] numbers = new double[rows, cols];
            double sum = 0;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter number{j + 1}: ");
                    numbers[i, j] = double.Parse(Console.ReadLine());
                    sum += numbers[i, j];
                }
            }

            
            Console.WriteLine("\nThe numbers are:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

           
            double average = sum / (rows * cols);

            Console.WriteLine($"\nSum: {sum} ; Average: {average}");
            Console.ReadKey();
        }
    }

}
