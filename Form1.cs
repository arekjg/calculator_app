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
        private char operation { get; set; }

        private int calc(int first, int second, char op)
        {
            int result = 0;
            switch (op)
            {
                case '/':
                    result = first / second;
                    break;
                case '*':
                    result = first * second;
                    break;
                case '-':
                    result = first - second;
                    break;
                case '+':
                    result = first + second;
                    break;
                default:
                    break;
            }
            return result;
        }

        private int current_number;
        public int Get_current_number()
        {
            return current_number;
        }
        public int Set_current_number(string number)
        {
            return Int32.Parse(number);
        }

        private void number_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
            current_number = (Set_current_number((sender as Button).Text));
        }


        private void operation_btn_Click(object sender, EventArgs e)
        {
            first_number = current_number;
            current_number = 0;
            // TO DO: FINISH THIS FUNCTION
        }
        private void button_eq_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            current_number = 0;
        }
    }
}
