using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int first_number { get; set; }
        private int second_number { get; set; }
        private string operation { get; set; }
        private int result { get; set; }

        private int calc(int first, int second, string op)
        {
            int calculation_result = 0;
            switch (op)
            {
                case "/":
                    calculation_result = first / second;
                    break;
                case "*":
                    calculation_result = first * second;
                    break;
                case "-":
                    calculation_result = first - second;
                    break;
                case "+":
                    calculation_result = first + second;
                    break;
                default:
                    break;
            }
            return calculation_result;
        }

        private int current_number = 0;
        public string Get_current_number(int number)
        {
            return number.ToString();
        }
        public int Set_current_number(string number)
        {
            return Int32.Parse(number);
        }

        private void number_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
            current_number = (Set_current_number(Get_current_number(current_number) + (sender as Button).Text));
            this.ActiveControl = button_eq;
        }


        private void operation_btn_Click(object sender, EventArgs e)
        {
            first_number = current_number;
            current_number = 0;
            textBox1.Text = textBox1.Text + (sender as Button).Text;
            operation = (sender as Button).Text;
            this.ActiveControl = button_eq;
        }
        private void button_eq_Click(object sender, EventArgs e)
        {
            second_number = current_number;
            current_number = 0;
            result = calc(first_number, second_number, operation);
            textBox1.Text = result.ToString();
            operation = "";
            this.ActiveControl = button_eq;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            current_number = 0;
            this.ActiveControl = button_eq;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    break;
                case Keys.NumPad0:
                    button10.PerformClick();
                    break;
                case Keys.Enter:
                    button_eq.PerformClick();
                    break;
                case Keys.Add:
                    button_add.PerformClick();
                    break;
                case Keys.Subtract:
                    button_sub.PerformClick();
                    break;
                case Keys.Multiply:
                    button_multi.PerformClick();
                    break;
                case Keys.Divide:
                    button_div.PerformClick();
                    break;
                case Keys.Delete:
                    button_clear.PerformClick();
                    break;
                //case Keys.Oemcomma:
                //    button1.PerformClick();
                //    break;
                default:
                    break;
            }
        }
    }
}

// TODO:
// fix comma key event
// add comma button event
// check and debug calculations
// add commas
// handle exeptions (zero division)