using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
       
        static void Main(string[] args)
        {

            var a = new linkedlist();
            a.CreateLinkedList();
        }
    }

    
}

class Node
{
    public string studentname;
    public Node next;
    public Node prev;
    public string nodeName;
    public Node nextLink;
    public Node prevLink;
}

     class linkedlist
{
    Node Head, Orange, Tangerine, Tail;
    public void CreateLinkedList()
    {
        Head = new Node();
        Orange = new Node();
        Tangerine = new Node();
        Tail = Tangerine;
        Head.nextLink = Orange;
        Console.WriteLine("yeah....!!!");
        Console.ReadLine();

    }
}
    

