using System;

namespace NumThree
{
    class Program
    {
        public static bool[] GetPrimeWithFunct(int length)
        {
            Boolean[] ans = new Boolean[length + 1];
            int MinPrime = 2;
            while (MinPrime * MinPrime < ans.Length - 1)
            {
                for (int i = MinPrime*2 ; i < ans.Length; i+=MinPrime)
                {
                    if (i % MinPrime == 0)
                        ans[i] = true;
                }

                for (int i = 1; i < ans.Length; i++)
                {
                    if (i > MinPrime && ans[i] == false)
                    {
                        MinPrime = i;
                        break;
                    }
                }
            }
            return ans;
        }

        static void Main(string[] args)
        {
            //课题3
            Console.WriteLine("**********课题3**********");
            Boolean[] ans = GetPrimeWithFunct(100);//从2到100
            for (int i = 2; i < ans.Length; i++)
            {
                if (ans[i] == false) { Console.Write($"{i},"); }
                if (i % 10 == 0) { Console.WriteLine(); }
            }
            Console.WriteLine("\n");


        }
    }
}
