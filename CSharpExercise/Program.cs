//Event Sample 3
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
            MyForm form = new MyForm();

            form.Click += form.Action;
            form.ShowDialog();
        }
    }

    class MyForm : Form
    {
        internal void Action(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}