using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个正整数：");
            int num = int.Parse(Console.ReadLine());
            int[] prime = new int[100];
            prime = FindPrime(num);
            int count = 0;
            while (prime[count] != 0)
            {
                Console.Write(prime[count] + " ");
                count++;
            }

        }

        static int[] FindPrime(int num)
        {
            int count = 0;
            int[] prime = new int[100];
            int mid = (int)Math.Sqrt(num);
            for (int i = 2; i <= mid; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    prime[count - 1] = i;
                }
                while (num % i == 0)
                {
                    num /= i;
                }
            }
            return prime;
        }
    }
}
