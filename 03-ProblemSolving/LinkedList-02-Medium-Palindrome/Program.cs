using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList_02_Medium_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Start with the empty list */
            LinkedList llist = new LinkedList();

            //char[] str = { 'a', 'b', 'a', 'c', 'a', 'b', 'a' };
            char[] str = { '1', '2', '3', '4', '3', '2', '1' };

            for (int i = 0; i < str.Length; i++)
            {
                llist.AddLast(str[i]);
                //llist.AddFirst(str[i]);
            }

            //llist.printList(llist.head);

            if (llist.isPalindrome(llist.head) != false)
            {
                Console.WriteLine("Is Palindrome");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
                Console.WriteLine("");
            }
        }

        private class LinkedList
        {

            public class Node
            {
                public Node(char dataParam)
                {
                    data = dataParam;
                }

                public char data { get; set; }
                public Node next { get; set; }
            }

            public LinkedList()
            {
            }

            public Node head;
            public Node tail;


            internal void AddLast(char v)
            {
                if (head == null)
                {
                    head = new Node(v);
                    tail = head;
                }
                else
                {
                    var currentNode = new Node(v);
                    tail.next = currentNode;
                    tail = currentNode;
                }
            }

            internal bool isPalindrome(Node head)
            {
                if (head == null || head.next == null)
                {
                    return true;
                }

                Node middle = GetMiddleNode(head);

                var list1head = head;
                var list2head = middle;

                return CompareLists(list1head, list2head);
            }

            private bool CompareLists(Node list1head, Node list2head)
            {

                Stack<Node> Stack = new Stack<Node>();

                while (list2head != null) {

                    Stack.Push(list2head);
                    list2head = list2head.next;
                }

                while (list1head != null && Stack.Count != 0)
                {
                    if (list1head.data != Stack.Pop().data)
                        return false ;

                    list1head = list1head.next;
                }

                return true;
            }

            private Node GetMiddleNode(Node head)
            {
                var slowPointer = head;
                var fastPointer = head;


                while (fastPointer != null && fastPointer.next != null)
                {
                    fastPointer = fastPointer.next.next;

                    slowPointer = slowPointer.next;
                }

                //fast pointer will be null if the list is even
                if (fastPointer == null)
                {
                    return slowPointer;
                }

                return slowPointer.next;
            }

            internal void AddFirst(char v)
            {
                if (head == null)
                    head = new Node(v);
                else
                {
                    var node = new Node(v);
                    node.next = head;
                    head = node;
                }
            }



            internal void printList(Node head)
            {
                while (head != null)
                {

                    Console.WriteLine(head.data + "->");
                    head = head.next;
                }
            }
        }
    }
}
