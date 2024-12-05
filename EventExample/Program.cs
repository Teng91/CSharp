using System;
using System.Timers;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000; // 單位:毫秒
            Boy boy = new Boy();
            Girl girl = new Girl();
            timer.Elapsed += boy.Action; // 事件訂閱的操作符+=，操作符左邊是事件、右邊是事件處理器
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();
        }
    }

    class Boy
    {
        internal void Action(object sender, EventArgs e)
        {
            System.Console.WriteLine("Jump!"); 
        }
    }

    class Girl
    {
        internal void Action(object sender, EventArgs e)
        {
            System.Console.WriteLine("Sing!"); 
        }
    }
}