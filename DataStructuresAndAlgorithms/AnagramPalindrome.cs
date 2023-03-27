using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class AnagramPalindrome
    {
        public bool IsPalindrome(int num)
        {
            int temp = num, palin = 0;
            while (num > 0)
            {
                int rem = num % 10; 
                palin = (palin * 10) + rem;
                num = num / 10;
            }
            if (temp == palin)
                return true;
            return false;
        }
        public void CheckNumber()
        {
            List<int> list = new List<int>();
            Prime prime = new Prime();
            for(int i = 1; i < 1000; i++)
            {
                if (prime.IsPrime(i))
                {
                    list.Add(i);
                }
            }
            AnagramCheck anagramCheck = new AnagramCheck(); 
            for(int i = 1; i < list.Count(); i++)
            {
                for(int j = i + 1; j < list.Count(); j++)
                {
                    String word1 = list[i].ToString();
                    String word2 = list[j].ToString();
                    if (anagramCheck.CheckAnagram(word1, word2) && IsPalindrome(list[i]))
                    {
                        Console.Write(list[i]+" ");
                    }
                }
            }
        }
    }
}
