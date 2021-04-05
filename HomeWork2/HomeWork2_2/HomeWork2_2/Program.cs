using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("请输入一串整数数组，用空格分开：");
            string str = Console.ReadLine();
            string[] numstr = str.Split(' ');
            int[] num = Array.ConvertAll<string, int>(numstr, s => int.Parse(s));
            double[] result = FindSomeNum(num);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
        static double[] FindSomeNum(int[] num)
        {
            double[] result = new double[4];
            int sum = 0, max = 0, min = 10000;
            double mean = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
                if (max < num[i])
                {
                    max = num[i];
                }
                if (min > num[i])
                {
                    min = num[i];
                }
            }
            mean = (sum + 0.0) / num.Length;
            result[0] = max;
            result[1] = min;
            result[2] = mean;
            result[3] = sum;
            return result;
        }
    }
}
