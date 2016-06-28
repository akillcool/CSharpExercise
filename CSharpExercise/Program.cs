﻿//显式异步调用 Thread
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            Thread thread1 = new Thread(stu1.DoHomework);
            Thread thread2 = new Thread(stu2.DoHomework);
            Thread thread3 = new Thread(stu3.DoHomework);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}",i);
                Thread.Sleep(1000);
            }
        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} doing homework {1} hour(s).", this.ID, i);
                Thread.Sleep(1000);
            }
        }
    }
}
