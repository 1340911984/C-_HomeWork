using System;

namespace NumFour
{
    class Program
    {
        public static Boolean JudgeTheMartix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row * col != 0 && matrix[row, col] != matrix[row - 1, col - 1])
                        return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //课题4
            Console.WriteLine("**********课题4**********");
            int[,] martix = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 }, };
            if (JudgeTheMartix(martix))
            {
                Console.WriteLine("是符合托普利茨的矩阵 ");
            }
            else
            {
                Console.WriteLine("不符合 ");
            }
        }
    }
}
