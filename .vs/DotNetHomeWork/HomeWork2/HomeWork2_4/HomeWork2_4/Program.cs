using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //输入矩阵
            Console.Write("请输入矩阵的行数：");
            int numOfRow = int.Parse(Console.ReadLine());
            Console.Write("请输入矩阵的列数：");
            int numOfCol = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numOfRow, numOfCol];
            for (int i = 0; i < numOfRow; i++)
            {
                for (int j = 0; j < numOfCol; j++)
                {
                    matrix[i, j] = Console.Read() - 48;
                    int temp = Console.Read();
                }
                Console.Read();
            }
            //判断是否符合条件
            bool result = IsToeplita(matrix);
            Console.WriteLine(result);

        }
        static bool IsToeplita(int[,] matrix)
        {
            //第一行
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int row = 0;
                int col = i;
                while (matrix[row, col] == matrix[0, i])
                {
                    row++;
                    col++;
                    if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
                        break;
                }
                if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
                    return false;
            }
            //第一列
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int row = j;
                int col = 0;
                while (matrix[row, col] == matrix[j, 0])
                {
                    row++;
                    col++;
                    if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
                        break;
                }
                if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
                    return false;
            }
            return true;
        }
    }
}
