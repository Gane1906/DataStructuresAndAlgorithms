using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class InsertionSort
    {
        public void ReadFile(String filePath)
        {
            String readFile = File.ReadAllText(filePath);
            String[] words = readFile.Split(" ");
            for(int i = 0; i < words.Length; i++)
            {
                for(int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].CompareTo(words[j]) > 0)
                    {
                        String word = words[i];
                        words[i] = words[j];
                        words[j] = word;
                    }
                }
            }
            foreach(String data in words)
                Console.WriteLine(data);
        }
    }
}
