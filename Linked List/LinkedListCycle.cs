using System;

namespace NeetCode_150.Linked_List;

public class LinkedListCycle
{

    //tortoise and hare algorithm.
    public bool HasCycle(ListNode head)
    {
        var fast = head;
        while (fast != null && fast.next != null)
        {
            head = head.next;
            fast = fast.next.next;
            if (head == fast)
            {
                return true;
            }
        }
        return false;
    }
}
