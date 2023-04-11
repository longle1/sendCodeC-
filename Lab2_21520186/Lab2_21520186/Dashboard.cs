using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_21520186
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Question1_Click(object sender, EventArgs e)
        {
            Question1 Q1 = new Question1();
            Q1.Show();
        }

        private void Question2_Click(object sender, EventArgs e)
        {
            Question2 Q2 = new Question2();
            Q2.Show();
        }

        private void Question3_Click(object sender, EventArgs e)
        {
            Question3 Q3 = new Question3();
            Q3.Show();
        }

        private void Question4_Click(object sender, EventArgs e)
        {
            Question4 Q4 = new Question4();
            Q4.Show();
        }

        private void Question5_Click(object sender, EventArgs e)
        {
            Question5 Q5 = new Question5();
            Q5.Show();
        }

        private void Question6_Click(object sender, EventArgs e)
        {
            Question6 Q6 = new Question6();
            Q6.Show();
        }
    }
}
