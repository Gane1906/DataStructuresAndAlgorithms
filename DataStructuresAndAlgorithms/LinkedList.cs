using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class LinkedList<T>
    {
        internal Node<T> head;
        internal void AddNode(T data)
        {
            Node<T> node = new Node<T>(data);
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void AddReverseOrder(T data)
        {
            Node<T> head;
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                this.head = newNode;
                this.head.next = temp;
            }
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();

        }
        public void InsertAtPosition(int position, T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
                this.head = newNode;
            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            prev.next = newNode;
        }
        public void DeleteFirstNode()
        {
            if (this.head == null)
                Console.WriteLine("Linked list is empty");
            this.head = this.head.next;
        }
        public void DeleteLastNode()
        {
            if (this.head == null)
                Console.WriteLine("Linked list is empty");
            if (head.next == null)
                this.head = null;
            Node<T> temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
        public int SearchElement(T data)
        {
            Node<T> node = this.head;
            int position = 0;
            while (node != null)
            {
                if (node.data.Equals(data))
                {
                    Console.WriteLine("The element " + data + " is found at " + position + " position");
                    return position;
                }
                node = node.next;
                position++;
            }
            return -1;
        }
        public void DeleteParticularPosition(int position)
        {
            Node<T> temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; i < position - 1 && temp.next != null; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
                return;
            Node<T> next = temp.next.next;
            temp.next = next;
            Size();
        }
        public void Size()
        {
            int count = 0;
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("The size of linkedlist is: " + count);
        }
    }
}
