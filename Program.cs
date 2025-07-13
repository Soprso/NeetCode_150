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
    }
}