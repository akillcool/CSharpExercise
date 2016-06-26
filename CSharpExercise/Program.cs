//属性实例 C#
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
            try
            {
                Student stu1 = new Student();
                stu1.Age = 20;
                Student stu2 = new Student();
                stu2.Age = 20;
                Student stu3 = new Student();
                stu3.Age = 200;

                int averageAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
                Console.WriteLine(averageAge);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Student
    {
        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Age value has error!");
                }
            }
        }

        //public int GetAge()
        //{
        //    return this.age;
        //}

        //public void SetAge(int value)
        //{
        //    if (value >= 0 && value <= 120)
        //    {
        //        this.age = value;
        //    }
        //    else
        //    {
        //        throw new Exception("Age value has error!");
        //    }
        //}
    }
}
