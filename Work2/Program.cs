using System;

namespace Work2{
    class Program {
        public static String GetPrime(int input) {
            if (input == 1 && input == 0)
            {
                return null;
            }
            else
            {
                String res = null;
                for (int i = 2; i <= System.Math.Sqrt(input); i++)
                {
                    while (true)
                    {
                        if (input % i == 0)
                        {
                            res = res + i.ToString() + ",";
                            input /= i;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return res + input.ToString();
            }
        }
        public static int[] GetMaxMinSum(int[] nums)
        {
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                else if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            int[] res = { max, min, sum };
            return res;
        }
        public static bool[] GetPrimeWithFunct(int length)
        {
            Boolean[] ans = new Boolean[length + 1];
            int MinPrime = 2;
            while (MinPrime * MinPrime < ans.Length - 1)
            {
                for (int i = 1; i < ans.Length; i++)
                {
                    if (i % MinPrime == 0 && i != MinPrime)
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
        public static Boolean JudgeTheMartix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    if (row * col != 0 && matrix[row][col] != matrix[row - 1][col - 1])
                        return false;
                }
            }
            return true;
        }
        static void Main(string[] args) {
            // 课题1
            Console.WriteLine("**********课题1**********");
            Console.Write("请输入您想要的求的素数因子： ");
            String input1 = Console.ReadLine();
            try
            {
                String output1 = GetPrime(int.Parse(input1));
                Console.WriteLine($"{input1}的素数因子是1,{output1}\n\n");
            }
            catch
            {
                Console.WriteLine("输入错误\n\n");
            }

            //课题2
            Console.WriteLine("**********课题2**********");
            int[] nums = { 4, 5, 6, 1, 3, 7, 71, 3, 4, 129 };
            int[] ans2 = GetMaxMinSum(nums);
            float ave = ans2[2] / (float)(nums.Length);
            Console.WriteLine($"最大值：{ans2[0]}，最小值：{ans2[1]}，求和:{ans2[2]}，平均值:{ave}\n\n");

            //课题3
            Console.WriteLine("**********课题3**********");
            Boolean[] ans = GetPrimeWithFunct(100);//从2到100
            for (int i = 2; i < ans.Length; i++)
            {
                if (ans[i] == false) { Console.Write($"{i},"); }
                if (i % 10 == 0) { Console.WriteLine(); }
            }
            Console.WriteLine("\n");

            //课题4
            Console.WriteLine("**********课题4**********");
            int[][] martix = new int[3][];
            martix[0] = new int[4] { 1, 2, 3, 4 };
            martix[1] = new int[4] { 5, 1, 2, 3 };
            martix[2] = new int[4] { 9, 5, 1, 2 };
            if (JudgeTheMartix(martix))
            {
                Console.WriteLine("是符合托普利茨的矩阵 ");
            }
            else
            {
                Console.WriteLine("不符合 ");
            }


/*Main*/
        }
/*Class*/}
/*NameSpace*/}
