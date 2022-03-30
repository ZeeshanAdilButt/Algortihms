using System;

namespace LinkedList_01_Easy_Find_Middle
{
    // C# program to find middle of linked list
    using System;

    class LinkedList
    {

        // Head of linked list
        Node head;

        // Linked list node
        class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        // Function to print middle of linked list
        void printMiddle()
        {
            Node slow_ptr = head;
            Node fast_ptr = head;

            if (head != null)
            {
                while (fast_ptr != null &&
                    fast_ptr.next != null)
                {
                    fast_ptr = fast_ptr.next.next;
                    slow_ptr = slow_ptr.next;
                }
                Console.WriteLine("The middle element is [" +
                                slow_ptr.data + "] \n");
            }
        }

        // Inserts a new Node at front of the list.
        public void push(int new_data)
        {
            /* 1 & 2: Allocate the Node &
					Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }

        // This function prints contents of linked
        // list starting from the given node
        public void printList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.data + "->");
                tnode = tnode.next;
            }
            Console.WriteLine("NULL");
        }

        // Driver code
        static public void Main()
        {
            LinkedList llist = new LinkedList();
            for (int i = 6; i > 0; --i)
            {
                llist.push(i);
            }
            llist.printList();
            llist.printMiddle();
        }
    }

    // This code is contributed by Dharanendra L V.

}
