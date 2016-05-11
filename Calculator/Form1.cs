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
        public Double resultValue { get; set; }
        String operationPerformed = "";
        bool isOperatingPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultValue = 0.0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")  || (isOperatingPerformed))
            {
                textBox1.Clear();
            }
            isOperatingPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            } else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button op = (Button)sender;

            if (resultValue != 0.0)
            {
                buttonEdnakvo.PerformClick();
                operationPerformed = op.Text;
                isOperatingPerformed = true;
            }else
            {
                operationPerformed = op.Text;
                resultValue = Double.Parse(textBox1.Text);
                isOperatingPerformed = true;
            }
            
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";         
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0.0;
        }

        private void buttonEdnakvo_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    resultValue = Convert.ToDouble(textBox1.Text);
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    resultValue = Convert.ToDouble(textBox1.Text);
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    resultValue = Convert.ToDouble(textBox1.Text);
                    break;
                case "/":
                    textBox1.Text = (Convert.ToDouble(resultValue) / Double.Parse(textBox1.Text)).ToString();
                    resultValue = Convert.ToDouble(textBox1.Text);
                    break;

                default:
                    break;
            }
            resultValue = Double.Parse(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 convert = new Form2(resultValue);
            convert.Show();

        }
    }
}
