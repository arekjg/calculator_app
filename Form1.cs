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

        private int current_number;
        private void number_btn_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }

    public class calculate
    {
        private int first_number;
        private int second_number;
        private char operation;

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
    }
}
