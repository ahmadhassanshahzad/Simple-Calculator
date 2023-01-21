using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m1, m2, m3, m4, m5, m6;
            int u1, u2, u3, u4, u5, u6;
            m1 = Int32.Parse(txts1.Text);
            m2 = Int32.Parse(txts2.Text);
            m3 = Int32.Parse(txts3.Text);
            m4 = Int32.Parse(txts4.Text);
            m5 = Int32.Parse(txts5.Text);
            m6 = Int32.Parse(txts6.Text);

            u1 = Int32.Parse(txtu1.Text);
            u2 = Int32.Parse(txtu2.Text);
            u3 = Int32.Parse(txtu3.Text);
            u4 = Int32.Parse(txtu4.Text);
            u5 = Int32.Parse(txtu5.Text);
            u6 = Int32.Parse(txtu6.Text);
            int gpa = point(m1) * u1 + point(m2) * u2 + point(m3) * u3 + point(m4) * u4 + point(m5) * u5 + point(m6) * u6;
       
            int tu = u1 + u2 + u3 + u4 + u5 + u6;
            int cgpa = gpa / tu;
            string grade1 = GPA(cgpa);
            G1.Text = grade(m1);
            G2.Text = grade(m2);
            G3.Text = grade(m3);
            G4.Text = grade(m4);
            G5.Text = grade(m5);
            G6.Text = grade(m6);

            P1.Text = Convert.ToString(point(m1));
            P2.Text = Convert.ToString(point(m2));
            P3.Text = Convert.ToString(point(m3));
            P4.Text = Convert.ToString(point(m4));
            P5.Text = Convert.ToString(point(m5));
            P6.Text = Convert.ToString(point(m6));

            CP.Text= Convert.ToString(tu);
            GPA01.Text = Convert.ToString(cgpa);
            OGP.Text = grade1;
        }
        int point(int score)
        {
            int p = 0;
            if(score<40)
            {
                p = 0;
            }
            else if(score>=40 && score < 50)
            {
                p = 1;
            }
            else if (score >= 50 && score < 60)
            {
                p = 2;
            }
            else if (score >= 60 && score < 70)
            {
                p = 3;
            }
            else if (score >= 70 && score < 80)
            {
                p = 4;
            }
            else if (score >= 80 && score < 100)
            {
                p = 5;
            }
            
            return p;
      
        }
        string grade(int score)
        {
            string p = "";
            if (score <40)
            {
                p = "F";
            }
            else if (score >= 40 && score < 50)
            {
                p = "E";
            }
            else if (score >= 50 && score < 60)
            {
                p = "D";
            }
            else if (score >= 60 && score < 70)
            {
                p = "C";
            }
            else if (score >= 70 && score < 80)
            {
                p = "B";
            }
            else if (score >= 80 && score < 100)
            {
                p = "A";
            }
            return p;
        }
        string GPA(int score)
        {
            string p = "";
            if (score < 40)
            {
                p = "Fail";
            }
            else if (score >= 40 && score < 50)
            {
                p = "Pass";
            }
            else if (score >= 50 && score < 60)
            {
                p = "Not Good";
            }
            else if (score >= 60 && score < 70)
            {
                p = "Satisfy";
            }
            else if (score >= 70 && score < 80)
            {
                p = "Very Good";
            }
            else if (score >= 80 && score < 100)
            {
                p = "Excellent";
            }
            return p;
        }
    }
}

