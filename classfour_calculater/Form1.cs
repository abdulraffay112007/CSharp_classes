using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classfour_calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2;
        string result;
        string oprator;
        private void button1_Click(object sender, EventArgs e)
        {
             ResultBox.Text+=button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultBox.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResultBox.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResultBox.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResultBox.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResultBox.Text += button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ResultBox.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResultBox.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResultBox.Text += button7.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResultBox.Text += button10.Text;
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ResultBox.Clear();
        }

        private void Cutbtn_Click(object sender, EventArgs e)
        {
            int text = ResultBox.Text.Length;
            if (text > 0)
            {
                ResultBox.Text = ResultBox.Text.Remove(text - 1);
            }
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(ResultBox.Text);
            oprator = "-";
            ResultBox.Clear();
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            num2=Convert.ToDouble(ResultBox.Text);
            switch (oprator)
            {
                case "+":
                    result=$"Add:{num1+num2}"; 
                    break;
                case "-":
                    result = $"sub:{num1 - num2}";
                    break;
                case "*":
                    result = $"multi:{num1 * num2}";
                    break;
                case "/":
                    result = $"divide:{num1 / num2}";
                    break;
            }
            ResultBox.Text = result;
        }

        private void multibtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(ResultBox.Text);
            oprator = "*";
            ResultBox.Clear();
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(ResultBox.Text);
            oprator = "/";
            ResultBox.Clear();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            num1=Convert.ToDouble(ResultBox.Text);
            oprator = "+";
            ResultBox.Clear();
        }
    }
}
