using System;

namespace 课堂练习_一_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入数字1： ");
            String a1 = Console.ReadLine();
            Console.Write("请输入数字2： ");
            String a2 = Console.ReadLine();
            int b1 = int.Parse(a1);
            int b2 = int.Parse(a2);
            Console.WriteLine("请输入运算符 + - * /");
            String a3 = Console.ReadLine();
            if(a3 == "+") Console.WriteLine($"{b1 + b2}");
            if(a3 == "-") Console.WriteLine($"{b1 - b2}");
            if(a3 == "*") Console.WriteLine($"{b1 * b2}");
            if(a3 == "/") Console.WriteLine($"{b1 / b2}");
        }
    }
}
