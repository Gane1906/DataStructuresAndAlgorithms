using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class AnagramCheck
    {
        public bool CheckAnagram(String firstInput,String secondInput)
        {
            /*Console.WriteLine("Enter first word");
            String firstInput = Console.ReadLine();
            Console.WriteLine("Enter second word");
            string secondInput = Console.ReadLine();*/
            if (firstInput.Length != secondInput.Length)
            {
                return false;
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
                    //Console.WriteLine("The words are anagram");
                    return true;
                }
                else
                {
                    //Console.WriteLine("The words are not anagram");
                    return false;
                }
            }
            return false;
        }
    }
}
