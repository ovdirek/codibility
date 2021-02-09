using System;

class Solution
{
    public int solution(int[] A)
    {
        int sonuc = -10000;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 10 && A[i] > -10)
            {
                if (A[i]>sonuc)
                {
                    sonuc = A[i];
                }
            }
        }
        return sonuc;
    }
}
