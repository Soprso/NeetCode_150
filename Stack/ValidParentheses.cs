using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace NeetCode_150.Stack;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> mapBraces = new Dictionary<char, char>();
        mapBraces.Add(')', '(');
        mapBraces.Add('}', '{');
        mapBraces.Add(']', '[');
        Stack<char> res = new Stack<char>();
        foreach (char c in s)
        {
            if (mapBraces.ContainsKey(c))
            {
                char top = res.Count > 0 ? res.Pop() : '*';
                if (top != mapBraces[c])
                {
                    return false;
                }
            }
            else
                res.Push(c);
        }
        return res.Count == 0;
    }
}
