using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class SearchWord
    {
        public void ReadFile(String filePath)
        {
            String readFile = File.ReadAllText(filePath);
            String[] words = readFile.Split(" ");
            foreach(String data in words)
                Console.WriteLine(data);
            Console.WriteLine("Enter word to search");
            String input = Console.ReadLine();
            foreach(String data in words)
            {
                if (data.Equals(input))
                {
                    Console.WriteLine("Word is found in file");
                    return;
                }
            }
            Console.WriteLine("Word is not found in the file");
        }
    }
}
