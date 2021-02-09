using System;

class Solution
{
    public int solution(int N)
    {
        int sonuc = 0;
        //5, 50, 500, 5000, 6745, 100, 5555
        //-374, -3574, 3754 -500, -5674, -22252, -22225
        // -2, -25, -52

        string sayimiz = N.ToString();
        if (N < 0)
        {
            //Sıfırdan küçükse - yi at
            sayimiz = sayimiz.Substring(1);
            for (int i = 0; i < sayimiz.Length; i++)
            {
                if (Convert.ToInt32(sayimiz[i].ToString()) > 5)
                {
                    sayimiz = sayimiz.Substring(0, i) + "5" + sayimiz.Substring(i);
                    break;
                }
                else if (i == sayimiz.Length - 1)
                {
                    sayimiz = sayimiz + "5";
                    break;
                }
            }
            sayimiz = "-" + sayimiz;
        }
        else if (N > 0)
        {
            for (int i = 0; i < sayimiz.Length; i++)
            {
                if (Convert.ToInt32(sayimiz[i].ToString()) < 5)
                {
                    //674
                    sayimiz = sayimiz.Substring(0, i) + "5" + sayimiz.Substring(i);
                    break;
                }
                else if (i == sayimiz.Length - 1)
                {
                    sayimiz = sayimiz + "5";
                    break;
                }
            }
        }
        else if (N == 0)
        {
            sayimiz = "50";
        }
        sonuc = Convert.ToInt32(sayimiz);
        return sonuc;
    }
}
