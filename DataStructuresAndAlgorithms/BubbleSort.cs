using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class BubbleSort
    {
        public void ReadFile(String filePath)
        {
            String readFile = File.ReadAllText(filePath);
            String[] words = readFile.Split(" ");
            int[] numbers = new int[words.Length];
            int count = 0;
            foreach(String data in words)
            {
                numbers[count] = Convert.ToInt32(data);
                Console.WriteLine(data);
                count++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int num = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = num;
                    }
                }
            }
            foreach(int num in numbers)
                Console.Write(num+" ");
        }
    }
}
