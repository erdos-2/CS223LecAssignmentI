using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223LecAssignmentI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();

            if (label1.Text == label2.Text && label2.Text == label3.Text)
            {
                MessageBox.Show("You Won!", "Game Over");
                label1.Text = "00";
                label2.Text = "00";
                label3.Text = "00";
            } else
            {
                MessageBox.Show("You Lost!", "Game Over");
                label1.Text = "00";
                label2.Text = "00";
                label3.Text = "00";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int intLabel1 = Convert.ToInt32(label1.Text);
            intLabel1++;
            if (intLabel1 == 60)
            {
                intLabel1 = 0;
            }
            
            if (intLabel1 < 10)
            {
                label1.Text = "0" + Convert.ToString(intLabel1);
            } else
            {
                label1.Text = Convert.ToString(intLabel1);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int intLabel2 = Convert.ToInt32(label2.Text);
            intLabel2++;
            if (intLabel2 == 60)
            {
                intLabel2 = 0;
            }

            if (intLabel2 < 10)
            {
                label2.Text = "0" + Convert.ToString(intLabel2);
            }
            else
            {
                label2.Text = Convert.ToString(intLabel2);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int intLabel3 = Convert.ToInt32(label3.Text);
            intLabel3++;
            if (intLabel3 == 60)
            {
                intLabel3 = 0;
            }

            if (intLabel3 < 10)
            {
                label3.Text = "0" + Convert.ToString(intLabel3);
            }
            else
            {
                label3.Text = Convert.ToString(intLabel3);
            }
        }
    }
}
