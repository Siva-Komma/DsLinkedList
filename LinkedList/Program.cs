using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Linked List");
            DsLinkedList ds= new DsLinkedList();
            ds.Add(56);
            ds.Add(30);
            ds.Add(70);
            ds.AddFirst(70);
            ds.AddFirst(30);
            ds.AddFirst(56);
            ds.Add(56);
            ds.Add(70);
            ds.Append(30);
            ds.Display();
            Console.ReadLine();
        }
    }
}
