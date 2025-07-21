using System;

namespace NeetCode_150.Linked_List
{
    public class ReverseLinkedList
    {
        public ListNode head;

        public ListNode ReverseList()
        {
            if (head == null || head.next == null)
                return head;

            ListNode prev = null;
            var current = head;

            while (current != null)
            {
                ListNode nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }

            head = prev;
            return head;
        }

        public void AddLast(int val)
        {
            ListNode newNode = new ListNode(val);
            if (head == null)
            {
                head = newNode;
                return;
            }

            var current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
        }

        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("Empty List");
                return;
            }

            var current = head;
            Console.WriteLine("The Linked List is as follows: ");
            while (current != null)
            {
                Console.Write(current.val + " -> ");
                current = current.next;
            }
            Console.WriteLine("null");
        }
    }


}
