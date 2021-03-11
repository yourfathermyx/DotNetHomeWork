namespace WindowsFormsHomework1
{
    class computer
    {
        static void Main(string[] args)
        {
            //先输入第一个数
            Console.WriteLine("请输入第一个数：");
            string num1 = Console.ReadLine();
            //接着判断输入的这个数是否为整数，如果不是整数，提示重新输入第一个数
            //实参：真正进行方法中使用的参数
            int number1 = CheckNum(num1);
            //先输入第二个数
            Console.WriteLine("请输入第二个数：");
            string num2 = Console.ReadLine();
            int number2 = CheckNum(num2);
            //选择运算符
            Console.WriteLine("请选择运算符：1.+  2.-  3.x  4.÷  5.%");
            string fun = Console.ReadLine();
            GetResualt(fun, number1, number2);
            Console.ReadLine();
        }

        /// <summary>
        /// 检测这个字符串是否能够转换为32位有符号整数
        /// </summary>
        /// <param name="num">要进行判断的字符串</param>
        static int CheckNum(string num)
        {
            try
            {
                int i = int.Parse(num);
                return i;
            }
            catch (Exception e)
            {
                Console.WriteLine("输入有误，请重新输入：");
                string str = Console.ReadLine();
                //递归算法
                return CheckNum(str);
            }
        }

        static void GetResualt(string fun, int num1, int num2)
        {
            int res = 0;
            string yun = "";
            switch (fun)
            {
                case "1":
                    res = num1 + num2;
                    yun = "+";
                    break;
                case "2":
                    res = num1 - num2;
                    yun = "-";
                    break;
                case "3":
                    res = num1 * num2;
                    yun = "x";
                    break;
                case "4":
                    res = num1 / num2;
                    yun = "÷";
                    break;
                case "5":
                    res = num1 % num2;
                    yun = "%";
                    break;
                default:
                    Console.WriteLine("请重新选择：");
                    string str = Console.ReadLine();
                    GetResualt(str, num1, num2);
                    return;
            }
            Console.WriteLine("{0}{3}{1}={2}", num1, num2, res, yun);
        }

