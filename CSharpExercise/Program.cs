//Event Sample 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace CSharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            Boy boy = new Boy();
            Girl girl = new Girl();

            timer.Interval = 1000;
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();     //等待读取，让事件响应
        }

        class Boy
        {
            internal void Action(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine("Jump!");
            }
        }

        class Girl
        {
            internal void Action(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine("Sing!");
            }
        }
    }
}