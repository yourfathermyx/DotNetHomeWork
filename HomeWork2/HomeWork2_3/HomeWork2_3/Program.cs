using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool[] noPrime = new bool[101];
            for (int i = 2; i <= 100; i++)
            {
                if (noPrime[i] == true)
                    continue;
                //未被删除
                int start = i * 2;
                if (start > 100)
                {
                    continue;
                }
                while (start <= 100)
                {
                    noPrime[start] = true;
                    start += i;
                }

            }
            for (int i = 2; i <= 100; i++)
            {
                if (noPrime[i] == false)
                    Console.Write(i + " ");
            }
        }
    }
}
