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
            list.Add(-2);
            list.Add(8);
            list.Add(-4);
            list.Add(15);
            list.Add(13);

            Console.WriteLine("List:");
            list.Print();

            Console.WriteLine("\nFirst element bigger than 2:");
            Node found = list.Find(2);
            if (found != null) Console.WriteLine(found.Value);

            Console.WriteLine("\nSum of elements less than 4: " + list.GetSumm(4));

            Console.WriteLine("\nNew list of elements bigger than 3:");
            LinkedList newList = list.GetNewList(3);
            newList.Print();

            Console.WriteLine("\nDeleting elements after the maximum:");
            list.DeleteAfterMax();
            list.Print();
        }
    }
}
