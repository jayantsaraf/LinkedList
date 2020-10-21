﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedListImplement
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
                this.head = node;
            else
            {
                Node temp = head;
                while(temp.next!=null)
                    temp = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} Data inserted in Linked List ", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
                Console.WriteLine("Linked List is empty");
            while(temp.next!=null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void AddAtFirst(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                head = node;
            else
            {
                node.next = head;
            }
            head = node;
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            Node temp = this.head;
            if (temp == null)
                temp = node;
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }
        public void InsertAtSpecificPosition(int data, int pos)
        {
            Node node = new Node(data);
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp.next!=null)
            {
                if(temp.data==pos)
                {
                    node.next = temp.next;
                    temp.next = node;
                    break;
                }
                temp = temp.next;
            }
        }
        public void DeleteFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            head = head.next;
            Console.WriteLine("Deleted 1st element"); 
        }
        public void DeleteLast()
        {
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp.next != null)
                temp = null;
            Console.WriteLine("Deleted 1st element");
        }
        public bool SearchValue(int searchValue)
        {
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
                return false;
            }
            while(temp.next!=null)
            {
                if(temp.data==searchValue)
                {
                    Console.WriteLine("Given element present in Linked List");
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
    }
}