using System;

namespace NeetCode_150.Linked_List;

public class PalindromeLL
{
    public bool IsPalindrome(ListNode head)
    {
        List<int> values = new List<int>();
        var current = head;
        while (current != null)
        {
            values.Add(current.val);
            current = current.next;
        }
        int start = 0, end = values.Count() - 1;
        while (start < end)
        {
            if (values[start++] != values[end--])
            {
                return false;
            }
        }
        return true;
    }
}
