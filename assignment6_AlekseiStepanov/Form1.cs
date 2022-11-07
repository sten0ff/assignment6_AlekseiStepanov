using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6_AlekseiStepanov
{
    public partial class Form1 : Form
    {
        int rnd;
        
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            rnd = random.Next(1,4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rnd == 1)
            {
                label1.Text = "Draw";
                label2.Text = "Rock";
            }
            if (rnd == 2)
            {
                label1.Text = "Lose";
                label2.Text = "Paper";
            }
            if (rnd == 3)
            {
                label1.Text = "Win";
                label2.Text = "Scissors";
            }
            Random random = new Random();
            rnd = random.Next(1, 4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rnd == 1)
            {
                label1.Text = "Win";
                label2.Text = "Rock";
            }
            if (rnd == 2)
            {
                label1.Text = "Draw";
                label2.Text = "Paper";
            }
            if (rnd == 3)
            {
                label1.Text = "Lose";
                label2.Text = "Scissors";
            }
            Random random = new Random();
            rnd = random.Next(1, 4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rnd == 1)
            {
                label1.Text = "Lose";
                label2.Text = "Rock";
            }
            if (rnd == 2)
            {
                label1.Text = "Win";
                label2.Text = "Paper";
            }
            if (rnd == 3)
            {
                label1.Text = "Draw";
                label2.Text = "Scissors";
            }
            Random random = new Random();
            rnd = random.Next(1, 4);
        }
    }
}
