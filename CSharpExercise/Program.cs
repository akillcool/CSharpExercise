//Statements Example
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
            string input = Console.ReadLine();
            try
            {
                double score = double.Parse(input);
                if (score >= 60)
                {
                    Console.WriteLine("Pass!");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
            catch 
            {
                Console.WriteLine("Not a number!");
            }
        }
    }
}
