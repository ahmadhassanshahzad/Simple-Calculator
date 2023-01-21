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

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        
    }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Write Numbers!");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int sum = num1 + num2;
                MessageBox.Show(sum.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Write Numbers!");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int subtract = num1 - num2;
                MessageBox.Show(subtract.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Write Numbers!");
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);
                float divide = num1 / num2;
                MessageBox.Show(divide.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Write Numbers!");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int multiply = num1 * num2;
                MessageBox.Show(multiply.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Write Numbers!");
            }
            else
            {
                float num1 = Int32.Parse(textBox1.Text);
                float num2 = Int32.Parse(textBox2.Text);
                int remainder = num1 % num2;
                MessageBox.Show(remainder.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Write Numbers!");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int e = 1;
                for(int i=0; i<num2; i++)
                {
                    e = e * num1;
                }
                MessageBox.Show(e.ToString());
            
        }
    }
}



