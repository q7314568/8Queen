using System;
using System.Collections;

namespace _8Queen
{
    class Program
    {
        private static int N = 8;
        static int[] position = new int[N];
        static int solNum = 0;
        static void Main(string[] args)
        {
            Solution(0);
            Console.ReadKey();
        }
      

        static void Solution(int k)
        {
            if (k == N)
            {
                solNum++;
                Console.WriteLine("solution " + solNum + ":");
                foreach (int p in position)
                {
                    string ans = "";
                    for(int i = 0; i < 8; i++)
                    {
                        if(i==p)
                        {
                            ans += "Q";
                        }
                        else
                        {
                            ans += ".";
                        }
                    }
                    Console.WriteLine(ans);
                }
            }
            else
            {
                for (int p = 0; p < N; p++)
                {
                    bool IsOk = true;
                    for (int i = 1; i <= k; i++)
                    {
                        int other = position[k - i];
                        if (other == p || other == p - i || other == p + i)
                        {
                            IsOk= false;
                        }
                    }
                    if (IsOk)
                    {
                        position[k] = p;
                        Solution(k + 1);
                    }
                }
            }
        }
    }
}
