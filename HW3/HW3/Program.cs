using System;
using System.Collections.Generic;

namespace HW3
{
    class Program
    {
     
        static Dictionary<char, int> GetCharFrequency(string input)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            HashSet<char> order = new HashSet<char>(); 

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c)) 
                    continue;

                char key = char.ToUpper(c);

                if (freq.ContainsKey(key))
                    freq[key]++;
                else
                    freq[key] = 1;
            }

            return freq;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

           
            string[] parts = input.Split(',');

            foreach (string part in parts)
            {
                string word = part.Trim();

                Dictionary<char, int> freq = GetCharFrequency(word);

               
                List<string> output = new List<string>();
                foreach (char c in word)
                {
                    if (char.IsWhiteSpace(c)) continue;

                    char key = char.ToUpper(c);
                    if (freq.ContainsKey(key))
                    {
                        output.Add($"{key}={freq[key]}");
                        freq.Remove(key);
                    }
                }

                Console.WriteLine(string.Join(", ", output));
            }

            Console.ReadKey();
        }
    }
}
