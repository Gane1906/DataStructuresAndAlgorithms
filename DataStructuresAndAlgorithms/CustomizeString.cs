using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class CustomizeString
    {
        public void Customize()
        {
            String line = "Hello <<name>>, We have your fullname as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.";
            line = line.Replace("<<name>>", "Ganesh");
            line = line.Replace("<<full name>>", "Ganesh Doppani");
            line = line.Replace("91-xxxxxxxxxx", "91-9876543214");
            Console.WriteLine(line);
        }
    }
}
