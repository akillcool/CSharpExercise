//Event Sample 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);

            form.ShowDialog();      //防止程序跳出
        }

        class Controller
        {
            private Form form;

            public Controller(Form form)    //构造器
            {
                if (form != null)
                {
                    this.form = form;
                    this.form.Click += FormClicked;
                }
            }

            private void FormClicked(object sender, EventArgs e)
            {
                this.form.Text = DateTime.Now.ToString();
            }
        }
    }
}