using System;

public class Solution1
{
    static int solution1(int[] A)
    {
        int result = 0;
        foreach (int number in A)
        {
            result ^= number;
        }
        return result;
    }
    public static void Main()
    {
        int[] a = { 9, 3, 9, 3, 9, 7, 9 };
        Console.WriteLine("Maximum contiguous sum is " + solution1(a));
        int[] b = { 3, 2, -6, 4, 0 };
        Solution2 s2 = new Solution2();
        Console.WriteLine("Maximum sum of any slice of A is " + s2.solution2(b));
    }
}
