using TesteCase;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.CheckSubarraySum(new int[] { 23, 2, 4, 6, 7 }, 6));  
        Console.WriteLine(solution.CheckSubarraySum(new int[] { 23, 2, 6, 4, 7 }, 6));  
        Console.WriteLine(solution.CheckSubarraySum(new int[] { 23, 2, 6, 4, 7 }, 13)); 
    }
}