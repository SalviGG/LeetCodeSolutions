// See https://aka.ms/new-console-template for more information
namespace LeetCode;

class Program
{
    static void Main(string[] args)
    {
        var strs = new string[] { "reflower","flow","flight" };
        string result = LongestCommonPrefix(strs);
        Console.WriteLine(result);
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        string longestPrefix = "";

        if (strs.Any(x => !string.IsNullOrEmpty(x)))
        {
            string shortest = strs.MinBy(x => x.Length);

            for (int i = 0; i < shortest.Length; i++)
            {
                bool validation = false;
                foreach (var word in strs)
                {
                    if (word[i] == shortest[i])
                    {
                        validation = true;
                    }else{
                        validation = false;
                        break;
                    }
                }
                if (validation)
                {
                    longestPrefix += shortest[i];
                }else
                {
                    break;    
                }
            }
        }

        return longestPrefix;

    }
}

