using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class AnagramCheck
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter first word");
            String firstInput = Console.ReadLine();
            Console.WriteLine("Enter second word");
            string secondInput = Console.ReadLine();
            if (firstInput.Length != secondInput.Length)
            {
                Console.WriteLine("Thw eords are not anagram");
            }
            else
            {
                char[] result1 = firstInput.ToCharArray();
                Array.Sort(result1);
                String word1 = result1.ToString();
                char[] result2 = secondInput.ToCharArray();
                Array.Sort(result2);
                String word2 = result2.ToString();
                if (word1.Equals(word2))
                {
                    Console.WriteLine("The words are anagram");
                }
                else
                {
                    Console.WriteLine("The words are not anagram");
                }
            }
        }
    }
}
