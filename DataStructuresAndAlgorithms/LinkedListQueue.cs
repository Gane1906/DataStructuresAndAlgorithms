using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class LinkedListQueue<T>
    {
        public Node<T> head;
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public T Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty,We cant delete");
                return (T)Convert.ChangeType(0, typeof(T));
            }
            else
            {
                //Console.WriteLine("The value dequeued is {0}", this.head.data);
                T temp = this.head.data;
                this.head = this.head.next;
                return temp;
            }
            return (T)Convert.ChangeType(0, typeof(T));
        }
        public int Size()
        {
            Node<T> temp = this.head;
            int count = 0;
            if (temp == null)
                return -1;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }
    }
}
