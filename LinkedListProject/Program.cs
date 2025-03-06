using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Print();
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList : IEnumerable<Node>
    {
        public Node Head;

        public IEnumerator<Node> GetEnumerator()
        {
            Node current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Print()
        {
            foreach (Node node in this)
            {
                Console.WriteLine(node.Value);
            }
        }

        public void Add(int value)
        {
            Node newNode = new Node() { Value = value };

            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                newNode.Next = this.Head.Next;
                this.Head.Next = newNode;
            }
        }

        //1. Знайти перше входження елементу, більшого за задане значення.
        public Node Find(int value)
        {
            Node currentNode = this.Head;
            do
            {
                if (currentNode.Value > value)
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;

                return null;
            } while (currentNode != null);
        }

        //2. Знайти суму елементів, значення яких менші за задане значення
        //(нумерація починається з голови списку).
        public int GetSumm(int value)
        {
            Node currentNode = this.Head;
            int summ = 0;

            do
            {
                if (currentNode.Value < value)
                {
                    summ += currentNode.Value;
                }

                currentNode = currentNode.Next;
            } while (currentNode != null);

            return summ;
        }

        //3. Отримати новий список зі значень елементів, значення
        // яких більші за задане значення.

        public LinkedList GetNewList(int value)
        {
            LinkedList newList = new LinkedList();
            Node currentNode = this.Head;

            do
            {
                if (currentNode.Value > value)
                {
                    newList.Add(currentNode.Value);
                }

                currentNode = currentNode.Next;
            } while (currentNode != null);

            return newList;
        }

        // 4. Видалити елементи, які розташовані після максимального елементу.
        public void DeleteAfterMax()
        {
            Node currentNode = this.Head;
            Node maxNode = this.Head;

            while (currentNode != null)
            {
                if (currentNode.Value > maxNode.Value)
                {
                    maxNode = currentNode;
                }

                currentNode = currentNode.Next;
            }

            maxNode.Next = null;
        }
    }
}