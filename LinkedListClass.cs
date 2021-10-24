using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAsign
{
    class LinkedListClass
    {
        internal Node head;
        private Node start;
        public LinkedListClass()
        {
            start = null;
        }

        internal void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
                this.head.next = null;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the Linked List", node.data);
        }
        public void DeleteFirstNode()
        {
            if (start == null)
                return;

            start = start.next;
            Console.WriteLine("{0} 1st node got deleted into the Linked List");

        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        

    }
}