using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Console.WriteLine("闹钟启动，滴答滴答...");
            Console.Write("请输入设置的闹钟时间(hh-mm-ss):");
            string alarmTime = Console.ReadLine();
            DateTime alarmDateTime = DateTime.ParseExact(alarmTime, "HH-m-s", System.Globalization.CultureInfo.CurrentCulture);
            clock.AlarmRun(alarmDateTime);
            //clock.Run();


        }
    }

    public delegate void TickHanlder();
    public delegate void AlarmHanlder(DateTime dataTime);
    public class Clock
    {
        public event TickHanlder Tick;
        public event AlarmHanlder Alarm;
        public void TimeFly()
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }

        public void Run()
        {
            Tick();
        }

        public void AlarmRemind(DateTime dataTime)
        {
            while (Math.Abs(dataTime.Ticks - DateTime.Now.Ticks) > 10e7)//1tick=10e-7s
            {
                Run();
            }
            Console.WriteLine();
            Console.WriteLine("叮铃铃叮铃铃！！！闹钟响啦！！！");
            for (int i = 0; i < 10; i++)//响铃后，再运行十秒钟
            {
                Run();
            }
            Console.WriteLine();
        }

        public void AlarmRun(DateTime dataTime)
        {
            Alarm(dataTime);
        }
        public Clock()
        {
            Tick += TimeFly;
            Alarm += AlarmRemind;
        }
    }
}