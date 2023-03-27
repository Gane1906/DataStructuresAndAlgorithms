using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class UnOrderedList
    {
        public void ReadFile(String filePath)
        {
            LinkedList<int> list = new LinkedList<int>();
            String readData = File.ReadAllText(filePath);
            String[] words = readData.Split(" ");
            int[] numbers = new int[words.Length];
            foreach (var data in words)
            {
                int num = Convert.ToInt32(data);
                list.AddNode(num);
            }
            Console.WriteLine("Enter input");
            int input = Convert.ToInt32(Console.ReadLine());
            if (list.SearchElement(input) != -1)
            {
                list.DeleteParticularPosition(list.SearchElement(input));
            }
            else
            {
                list.AddNode(input);
            }
            list.Display();
        }
    }
}
