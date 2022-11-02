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

        private double first_number { get; set; }
        private double second_number { get; set; }
        private string operation { get; set; }
        private double result { get; set; }

        private double current_number = 0;
        public string Get_current_number(double number)
        {
            return number.ToString();
        }
        public double Set_current_number(string number)
        {
            return Double.Parse(number);
        }

        private double calc(double first, double second, string op)
        {
            double calculation_result = 0;
            switch (op)
            {
                case "/":
                    try
                    {
                        calculation_result = first / second;
                    }
                    catch (DivideByZeroException)
                    {
                        current_number = 0;
                        textBox1.Text = "0 division";
                        this.ActiveControl = button_eq;
                    }
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

        private void number_btn_Click(object sender, EventArgs e)
        {
            // DOES NOT WORK WITH DOUBLES
            textBox1.Text = textBox1.Text + (sender as Button).Text;
            if (textBox1.Text[textBox1.Text.Length - 1] == '.')
            {
                current_number = (Set_current_number(Get_current_number(current_number) + "," + (sender as Button).Text));
            }
            else
            {
                current_number = (Set_current_number(Get_current_number(current_number) + (sender as Button).Text));
            }
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
            if (textBox1.Text != "0 division")
            {
                textBox1.Text = result.ToString().Replace(',', '.');
            }
            operation = "";
            this.ActiveControl = button_eq;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            current_number = 0;
            this.ActiveControl = button_eq;
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            // EVENT HANDLER TO FINISH
            textBox1.Text = textBox1.Text + '.';
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
                case Keys.Decimal:
                    button_comma.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}

// TODO:
// add comma button event
// check and debug calculations (next operation, next operation after calculating)

// DONE:
// fixed comma key event
// handled exeptions (zero division)
// set comma to display as dot in textBox