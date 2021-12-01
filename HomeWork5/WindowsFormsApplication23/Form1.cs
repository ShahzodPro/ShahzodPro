using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
             int AdadiButuniA = int.Parse(textBox1.Text);
             int AdadiButuniB = int.Parse(textBox2.Text);
                 int sum = intadad(AdadiButuniA, AdadiButuniB);
             label1.Text = sum.ToString();
            }
            catch (Exception)
            {
                label1.Text = "Ин адади бутун нест !!!";
            }

        }
        public int intadad(int intA, int intB)
        {
            int adad, AdadiButuni_ = 2147483647;
            adad = intA * intB;
            if (adad <= AdadiButuni_)
            {
                return adad;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Ин адади бутун нест!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int adadA = int.Parse(textBox3.Text);
                int adadB = int.Parse(textBox4.Text);
                double m = adadiButun(adadA, adadB);
                label6.Text = m.ToString();
            }
            catch (Exception ex)
            {
                label6.Text = ex.Message;
            }
        }
        public double adadiButun(int adadiA, int adadiB)
        {
            double adad = adadiA;
           
            if (adadiB == 0)
            {
                throw new ArgumentOutOfRangeException("Ададро ба '0' тақсим кунед ҳосил '0' мекунад!");
            }
            else
            {
                return adad / adadiB;
            }

        }
    }
}
