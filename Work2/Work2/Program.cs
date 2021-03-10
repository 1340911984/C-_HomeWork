using System;

namespace Work2{
    class Program {

       
        public static Tuple<int, int ,int> GetMaxMinSum(int[] nums)
        {
            if (nums.Length == 0) { return null; }
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
            return Tuple.Create(max, min, sum); //
        }
  
        static void Main(string[] args) {
            //课题2
            Console.WriteLine("**********课题2**********");
            int[] nums = { 4, 5, 6, 1, 3, 7, 71, 3, 4, 129 };
            var ans =  GetMaxMinSum(nums);
            float ave =  ans.Item3/(float)(nums.Length);
            Console.WriteLine($"最大值：{ans.Item1}，最小值：{ans.Item2}，求和:{ans.Item3}，平均值:{ave}\n\n");


            
/*Main*/
        }
/*Class*/}
/*NameSpace*/}
