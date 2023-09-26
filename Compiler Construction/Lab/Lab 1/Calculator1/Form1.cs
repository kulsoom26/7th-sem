using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        private double accumulator = 0;
        private char lastOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operator_Pressed(sender,e);   
        }

        private void Operator_Pressed(object sender, EventArgs e)
        {
            // An operator was pressed; perform the last operation and store the new operator.
            char operation = (sender as System.Windows.Forms.Button).Text[0];
            if (operation == 'C')
            {
                accumulator = 0;
            }
            else
            {
                double currentValue = double.Parse(text.Text);
                switch (lastOperation)
                {
                    case '+': accumulator += currentValue; break;
                    case '-': accumulator -= currentValue; break;
                    case '×': accumulator *= currentValue; break;
                    case '/': accumulator /= currentValue; break;
                    default: accumulator = currentValue; break;
                }
            }

            lastOperation = operation;
            text.Text = operation == '=' ? accumulator.ToString() : "0";
        }

        private void Number_Pressed(object sender, EventArgs e)
        {
            // Add it to the display.
            string number = (sender as System.Windows.Forms.Button).Text;
            text.Text = text.Text == "0" ? number : text.Text + number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void numDec_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Operator_Pressed(sender, e);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Operator_Pressed(sender, e);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            Operator_Pressed(sender, e);
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            Operator_Pressed(sender, e);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            Operator_Pressed(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Number_Pressed(sender, e);
        }

        private void sine_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(text.Text);
            double ans = Math.Sin(currentValue);
            text.Text = ans.ToString();
        }

        private void cosine_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(text.Text);
            double ans = Math.Cos(currentValue);
            text.Text = ans.ToString();
        }

        private void tangent_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(text.Text);
            double ans = Math.Tan(currentValue);
            text.Text = ans.ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(text.Text);
            double ans = Math.Log10(currentValue);
            text.Text = ans.ToString();
        }
    }
}
