using System.Runtime.InteropServices;
using NeetCode_150.Arrays___Hashing;

class Program
{
    static void Main()
    {
        ContainsDuplicate cd = new ContainsDuplicate();
        bool containsDupe = cd.hasDuplicate([1, 2, 3, 3, 4]);
        System.Console.WriteLine(containsDupe);

        ValidAnagram va = new ValidAnagram();
        bool isAnagram = va.IsAnagram("carrace", "racecar");
        System.Console.WriteLine(isAnagram);
        bool isAnagramSort = va.IsAnagramSort("amdam", "madam");
        System.Console.WriteLine(isAnagramSort);

        TwoSum ts = new TwoSum();
        int[] arr = ts.twoSum([2, 7, 11, 15], 9);
        System.Console.WriteLine();
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }

        GroupAnagrams ga = new GroupAnagrams();
        var list = ga.groupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
        foreach (var x in list)
        {
            System.Console.Write("[");
            foreach (string y in x)
            {
                System.Console.Write($"{y} ,");
            }
            System.Console.Write("]");
        }

        TopKFrequentElements tk = new TopKFrequentElements();
        int[] res = tk.TopFreq([1, 1, 1, 3, 2, 2, 4], 2);
        System.Console.WriteLine();
        System.Console.WriteLine($"top 2 frequent elements are:");
        foreach (int i in res)
        {
            System.Console.Write(i + " ");
        }

        EncodingandDecoding ed = new EncodingandDecoding();
        var res1 = ed.Encode(["neet", "code", "love", "you"]);
        var res2 = ed.Decode(res1);
        System.Console.WriteLine();
        System.Console.WriteLine("Decoded String");
        foreach (var x in res2)
        {
            System.Console.WriteLine(x + " ");
        }

        ProductOfArrayExceptSelf pae = new ProductOfArrayExceptSelf();
        int[] respae = pae.ProductExceptSelf([1, 2, 3, 4]);
        System.Console.WriteLine();
        System.Console.WriteLine("Product Array");
        foreach (int i in respae)
        {
            System.Console.Write(i + " ");
        }

        ValidSudoku vs = new ValidSudoku();
        char[][] board = new char[][]
        {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };
        Console.WriteLine(vs.IsValidSudoku(board));

        LongestConsecutiveSequence lcs = new LongestConsecutiveSequence();
        System.Console.WriteLine("Longest Consecutive Subsequence is: ");
        System.Console.WriteLine(lcs.LongestConsecutive([100, 4, 200, 1, 3, 2])); 
    }
}