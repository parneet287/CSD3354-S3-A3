using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
          var a= new LinkedList();
          a.CreateLinkedList();
        }
    }
}
    
     class Node
    {
        public string nodeName;
        public Node nextLink;
        public Node prevLink;
    }
     class LinkedList
        {
            Node Head,Orange,Tangerine,Tail;
            public void CreateLinkedList()
            {
                 Head = new Node();
                    Orange = new Node();
                    Tangerine= new Node();
                    Tail= Tangerine;
                    Head.nextLink = Orange;
                    Console.WriteLine("yeah....!!!");
                    Console.ReadLine();
                 
            }
        }

