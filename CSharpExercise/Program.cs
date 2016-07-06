//Event Sample 4
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

            form.ShowDialog();
        }
    }

    class MyForm : Form
    {
        private TextBox textBox;
        private Button button;

        public MyForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();

            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button);

            this.button.Top = 20;
            this.button.Text = "Say Hello";
            this.button.Click += ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello World!";   
        }
    }
}