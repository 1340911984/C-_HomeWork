using System;

namespace NumOne
{
    class Program
    {
        public static String GetPrime(int input)
        {
            if (input == 1 && input == 0)
            {
                return null;
            }
            String res = null;
            for (int i = 2; i*i <= input; i++)
            {
                while (input % i == 0)
                {
                    res = res + i.ToString() + ",";
                    input /= i;
                }
            }
            return res + input.ToString();
        }

        static void Main(string[] args)
        {
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
        }
    }
}
