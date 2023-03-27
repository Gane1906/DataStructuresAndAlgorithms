using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class Prime
    {
        public bool IsPrime(int num)
        {
            for(int i=2;i<num; i++)
            {
                if(num%i==0)
                    return false;
            }
            return true;
        }
        public void CheckPrime()
        {
            Console.Write("Enter lower limit value: ");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter upper limit value: ");
            int upper = Convert.ToInt32(Console.ReadLine());
            for(int num = lower; num <= upper; num++)
            {
                if(IsPrime(num))
                    Console.Write(num+" ");
            }
        }
    }
}
