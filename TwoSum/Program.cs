// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace LeetCode;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[]{3,2,4};
        var result = TwoSum(nums, 6);
        Console.WriteLine("[{0}]", string.Join(",", result));
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        var indexArray = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var currentIndex = Array.IndexOf(nums, nums[i]);
            var currentValue = nums[i];
            for (int x = 0; x < nums.Length; x++)
            {
                var currentSearch = nums[x];
                if (x != i && currentValue + currentSearch == target)
                {
                    indexArray.Add(x);
                }
            }
        }
        
        return indexArray.OrderBy(x => x).ToArray();  
    }
} 