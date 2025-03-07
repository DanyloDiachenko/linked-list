using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListLib
{
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

        public Node Find(int value)
        {
            Node currentNode = this.Head;

            while (currentNode != null)
            {
                if (currentNode.Value > value)
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }

            return null;
        }

        public int GetSumm(int value)
        {
            Node currentNode = this.Head;
            int summ = 0;

            while (currentNode != null)
            {
                if (currentNode.Value < value)
                {
                    summ += currentNode.Value;
                }
                currentNode = currentNode.Next;
            }

            return summ;
        }

        public LinkedList GetNewList(int value)
        {
            LinkedList newList = new LinkedList();
            Node currentNode = this.Head;

            while (currentNode != null)
            {
                if (currentNode.Value > value)
                {
                    newList.Add(currentNode.Value);
                }
                currentNode = currentNode.Next;
            }

            return newList;
        }

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
            if (maxNode != null)
            {
                maxNode.Next = null;
            }
        }
    }
}