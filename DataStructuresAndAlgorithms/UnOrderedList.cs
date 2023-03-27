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
            LinkedList<String> list = new LinkedList<string>();
            String readData = File.ReadAllText(filePath);
            String[] words = readData.Split(" ");
            foreach (var data in words)
            {
                list.AddNode(data);
            }
            String input = Console.ReadLine();
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
