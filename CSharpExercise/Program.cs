//超EZ的99乘法表
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise
{

    class Program
    {

        static void Main(string[] args)
        {
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    //if (b > a)
                    //{
                    //    break;
                    //}
                    Console.Write("{0} X {1} = {2}\t", a, b, a * b);
                }
                Console.WriteLine();
            }
        }
    }
}
