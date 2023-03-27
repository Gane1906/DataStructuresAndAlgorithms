using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class BankEnquiry
    {
        LinkedListQueue<String> queue = new LinkedListQueue<string>();
        int amount = 100000;
        public BankEnquiry()
        {

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Display();
        }
        public void Operation()
        {
            int count = queue.Size();
            for (int i = 0; i < count; i++)
            {
                Console.Write("1.Withdraw\n2.Deposit\n3.Chcek balance\nEnter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        WithDraw();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        CheckBalance();
                        break;
                }
                queue.Dequeue();
            }
        }
        public void WithDraw()
        {
            Console.WriteLine("Enter amount to withdraw");
            int withDrawAmount = Convert.ToInt32(Console.ReadLine());
            if (amount >= withDrawAmount)
                amount -= withDrawAmount;
            else
                Console.WriteLine("Insufficient funds,pls try later");
        }
        public void Deposit()
        {
            Console.WriteLine("Enter amount to Deposit");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            amount += depositAmount;
        }
        public void CheckBalance()
        {
            Console.WriteLine(amount);
        }
    }
}
