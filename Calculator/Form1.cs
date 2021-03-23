using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string oper, oper1, oper2;
        private double a, b;
        private bool equally = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (textBox1.Text == "0" || oper1 != null)
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text += B.Text;
            }
            oper1 = null;
            equally = false;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (oper1 != null)
            {
                textBox1.Text = "0.";
            }
            else
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += ".";
                }
            }
            oper1 = null;
            equally = false;
        }

        private void oper_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            switch (oper)
            {
                case "÷":
                    a /= Convert.ToDouble(textBox1.Text);
                    break;
                case "×":
                    a *= Convert.ToDouble(textBox1.Text);
                    break;
                case "+":
                    a += Convert.ToDouble(textBox1.Text);
                    break;
                case "-":
                    a -= Convert.ToDouble(textBox1.Text);
                    break;
                default:
                    a = Convert.ToDouble(textBox1.Text);
                    break;
            }
            oper = B.Text;
            oper1 = oper;
            oper2 = oper;
            equally = false;
        }

        private void equally_Click(object sender, EventArgs e)
        {
            if (!equally)
            {
                b = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                switch (oper2)
                {
                    case "÷":
                        textBox1.Text = (a / b).ToString();
                        break;
                    case "×":
                        textBox1.Text = (a * b).ToString();
                        break;
                    case "+":
                        textBox1.Text = (a + b).ToString();
                        break;
                    case "-":
                        textBox1.Text = (a - b).ToString();
                        break;
                }
            }
            switch (oper)
            {
                case "÷":
                    textBox1.Text = (a / b).ToString();
                    break;
                case "×":
                    textBox1.Text = (a * b).ToString();
                    break;
                case "+":
                    textBox1.Text = (a + b).ToString();
                    break;
                case "-":
                    textBox1.Text = (a - b).ToString();
                    break;
            }
            oper1 = "X";
            oper = null;
            equally = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            oper = null;
            oper1 = null;
            oper2 = null;
            a = 0;
            b = 0;
            equally = false;
        }

        private void cleanlast_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
