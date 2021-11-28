using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float AdadiHaqiqi = float.Parse(textBox1.Text);
            int AdadiButun = int.Parse(textBox2.Text);
            float a = 1, result = 1;
            for (int i = 0; i <= AdadiButun; ++i)
            {
                a *= -AdadiHaqiqi;
                result += a;
            }
            label3.Text = result.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int AdadiButun = int.Parse(textBox3.Text);
            while ((AdadiButun > 0) & ((AdadiButun % 10) != 2))
            {
                AdadiButun /= 10;
            }
            if ((AdadiButun > 0) && (AdadiButun % 10) == 2)
                label5.Text = "true";
            else
                label5.Text = "false";

        }
    }
}

