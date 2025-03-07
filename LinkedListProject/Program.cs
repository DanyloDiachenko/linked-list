using System;
using LinkedListLib;

namespace LinkedListApp
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

            Console.WriteLine("List:");
            list.Print();
            // 1, 5, 4, 3, 2

            Console.WriteLine("\nFirst element bigger than 2:");
            Node found = list.Find(2);
            if (found != null) Console.WriteLine(found.Value);
            // 5

            Console.WriteLine("\nSum of elements less than 4: " + list.GetSumm(4));
            // 1 + 2 + 3 = 6

            Console.WriteLine("\nNew list of elements bigger than 3:");
            LinkedList newList = list.GetNewList(3);
            newList.Print();
            // 5, 4

            Console.WriteLine("\nDeleting elements after the maximum:");
            list.DeleteAfterMax();
            list.Print();
            // 1, 5
        }
    }
}
