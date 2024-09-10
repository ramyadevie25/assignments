using System;

public class Solution2
{
    public int solution2(int[] A)
    {
        if (A.Length == 1)
        {
            return A[0];
        }

        int maxEndingHere = A[0];
        int maxSoFar = A[0];

        for (int i = 1; i < A.Length; i++)
        {
            maxEndingHere = Math.Max(A[i], maxEndingHere + A[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}
