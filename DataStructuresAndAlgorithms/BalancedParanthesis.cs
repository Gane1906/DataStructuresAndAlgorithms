using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class BalancedParanthesis
    {
        public void ReadFile(String filePath)
        {
            LinkedListStack<String> list = new LinkedListStack<String>();
            String readData = File.ReadAllText(filePath);
            String[] words = readData.Split(" ");
            foreach (var data in words)
            {
                if (data.Equals("("))
                    list.Push("(");
                if (data.Equals(")"))
                    list.Pop();
            }
            if (list.Peek() == -1)
                Console.WriteLine("Given equation has balanced paranthesis");
            else
                Console.WriteLine("Given equation doesnot has balanced paranthesis");
        }
    }
}

