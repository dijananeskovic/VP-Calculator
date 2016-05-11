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
    public partial class Form2 : Form
    {
        public Form2(Double value)
        {
            InitializeComponent();
            textBox1.Text = value.ToString();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            lblResult.Text = (Convert.ToDouble(textBox1.Text) * 0.016).ToString() + " Euros.";
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = (Convert.ToDouble(textBox1.Text) * 0.019).ToString() + " Dollars.";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = (Convert.ToDouble(textBox1.Text) * 0.013).ToString() + " Pounds.";
        }

        
    }
}
