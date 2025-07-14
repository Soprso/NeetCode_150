using System;
using System.Text;

namespace NeetCode_150.Arrays___Hashing;

// Encode and Decode Strings
// Design an algorithm to encode a list of strings to a single string. The encoded string is then decoded back to the original list of strings.

// Please implement encode and decode

// Example 1:

// Input: ["neet","code","love","you"]

// Output:["neet","code","love","you"]
// Example 2:

// Input: ["we","say",":","yes"]

// Output: ["we","say",":","yes"]
// Constraints:

// 0 <= strs.length < 100
// 0 <= strs[i].length < 200
// strs[i] contains only UTF-8 characters.

// ✅ Common Solution Strategy:
// Use length-prefix encoding:

// For each string, store its length, then a delimiter, then the string content.

// For example: "4#neet4#code4#love3#you"
public class EncodingandDecoding
{
    public string Encode(IList<string> strs)
    {
        StringBuilder encoded = new StringBuilder();
        foreach (string s in strs)
        {
            encoded.Append(s.Length);
            encoded.Append("#");
            encoded.Append(s);
        }
        return encoded.ToString();

    }
    public List<string> Decode(string s)
    {
        List<string> res = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            //Find the neext # which ends the length prefix
            int delimIndex = s.IndexOf('#', i);
            //get the length of the string before this index
            int length = int.Parse(s.Substring(i, delimIndex - i));
            //Move the i past the # to the start of the actual string
            i = delimIndex + 1;
            //extract the string of the given length
            string str = s.Substring(i, length);
            res.Add(str);
            //move the i forward to the next block
            i += length;
        }
        return res;
    }
}
