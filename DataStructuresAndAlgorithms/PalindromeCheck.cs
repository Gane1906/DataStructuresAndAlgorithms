using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class PalindromeCheck
    {
        public void CheckPalindrome()
        {
            Console.WriteLine("Enter string to check palindrome");
            String word = Console.ReadLine();
            String palin = " ";
            LinkedListQueue<char> queue=new LinkedListQueue<char>();
            foreach(char ch in word)
            {
                queue.Enqueue(ch);
            }
            int count = queue.Size();
            for (int i= 0;i <=count ;i++)
            {
                char ch = queue.Dequeue();
                palin=ch+palin;
            }
            Console.WriteLine(palin+" is word");
            if (palin.Equals(word))
                Console.WriteLine("The word is a palindrome");
            else
                Console.WriteLine("The word is not a palindrome!");
        }
    }
}
