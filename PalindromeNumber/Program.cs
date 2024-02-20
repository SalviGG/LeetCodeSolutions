// See https://aka.ms/new-console-template for more information
namespace Palindrome;


class Progam
{
    static void Main(string[] args)
    {
        var result = IsPalindrome2(10); 
        Console.WriteLine(result);
    }
    public static bool IsPalindrome(int x) {
        var original = x.ToString();
        string reversed = "";
        for (int i = original.Length - 1; i >= 0; i--)
        {
            reversed += original[i];
        }

        return original == reversed;
    }

    public static bool IsPalindrome2(int x) {
        var original = x.ToString();
        var reversed = new string(original.Reverse().ToArray());
        return original == reversed;
    }
}