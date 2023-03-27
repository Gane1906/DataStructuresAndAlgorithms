using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class LinkedListStack<T>
    {
        private Node<T> top;
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} element is pushed into stack", value);
        }
        public void Display()
        {
            Node<T> node = this.top;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
        public int Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            Console.WriteLine("value at Peek is {0}", this.top.data);
            return 1;
        }
        public void Pop()
        {
            if (this.top == null)
                Console.WriteLine("Stack is empty");
            Console.WriteLine("value popped {0} is ", this.top.data);
            this.top = this.top.next;
        }
    }
}
