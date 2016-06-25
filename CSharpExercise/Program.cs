//try catch finally
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
            Calculator c = new Calculator();
            int result = 0;
            try
            {
                result = c.Add(null, "200");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            Console.WriteLine(result);
        }
    }
    class Calculator
    {
        public int Add(string arg1, string arg2)
        {
            int a = 0;
            int b = 0;
            //bool hasError = false;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            catch (ArgumentNullException ane)
            {
                //hasError = true;
                //Console.WriteLine(ane.Message);
                throw ane;
            }
            catch(FormatException fe)
            {
                //hasError = true;
                Console.WriteLine(fe.Message);
            }
            catch(OverflowException ofe)
            {
                //hasError = true;
                Console.WriteLine(ofe.Message);
            }
            //finally
            //{
            //    if (hasError)
            //    {
            //        Console.WriteLine("Something happened.");
            //    }
            //}
            int result = checked(a + b);
            return result;
        }
    }
}
