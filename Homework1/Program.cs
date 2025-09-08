using System;


namespace Homework1

{
    class PalindromeChecker
    {
        static void Main()
        {
            string input;

            while (true)
            {
                Console.Write("Enter string: ");
                input = Console.ReadLine();

                if (input == "*")
                    break;

                string original = input;
                string lowered = input.ToLower();
                string reversed = "";

                for (int i = lowered.Length - 1; i >= 0; i--)
                {
                    reversed += lowered[i];
                }
                string result = (lowered == reversed) ? "Yes" : "No";

                Console.WriteLine("\nOriginal String         Reversed String            Palindrome?");
                Console.WriteLine($"  {original,-20} {reversed,-25} {result}\n");
            }
        }
    }
}

