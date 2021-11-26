
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IF_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1) Шартеро, ки дуруст аст, сабт кунед, вақте:
        //а) ҳар як адади А ва В аз 100 зиёд аст;
        //б) танњо яке аз ададњои А ва В љуфт аст; 
        //в) ақаллан яке аз ададҳои А ва В мусбат аст; 
        //г) њар як ададњои А, В, С ба се баробар аст;
        //д) танњо яке аз ададњои А, В ва С аз 50 камтар аст; 
        //е) ақаллан яке аз ададҳои A, B, C манфӣ аст. 
        //2) Қиматҳои ҳадди аксар ва ҳадди ақали се адади ҳақиқии гуногунро муайян кунед.

        private void button1_Click(object sender, EventArgs e)
        {
            int adadi1 = 0, adadi2 = 0, adadi3 = 0;
            adadi1 = int.Parse(textBox1.Text);
            adadi2 = int.Parse(textBox2.Text);
            adadi3 = int.Parse(textBox3.Text);
            if (radioButton1.Checked == true)
            {
                if ((adadi1 >= 100) && (adadi2 >= 100))
                {
                    label4.Text = "A va B kalon az 100.";
                }
                else
                {
                    label4.Text = "A va B khurd az 100.";
                }
            }
            if (radioButton2.Checked == true)
            {
                if ((adadi1 % 2 == 0) && (adadi2 % 2 == 0))
                {
                    label4.Text = "A va B Juft ast.";
                }
                else
                {
                    label4.Text = "A va B Toq ast";
                }
            }
            if (radioButton3.Checked == true)
            {
                if ((adadi1 > 0) || (adadi2 > 0))
                {
                    label4.Text = "Yake az adadhoi A va B musbat ast.";
                }
                else
                {
                    label4.Text = "Yake az adadhoi A va B manfi ast.";
                }
            }
            if (radioButton4.Checked == true)
            {
                if ((adadi1 == 3) && (adadi2 == 3) && (adadi3 == 3))
                {
                    label4.Text = "Hammai adadhoi A, B va C ba 3 barobarast.";
                }
                else
                {
                    label4.Text = "Hamai adadhoi A, B va C ba 3 barobar  nest.";
                }
            }
            if (radioButton5.Checked == true)
            {
                if ((adadi1 < 50) || (adadi2 < 50) || (adadi3 < 50))
                {
                    label4.Text = "Hammai adadhoi A, B va C az 50 khurd ast.";
                }
                else
                {
                    label4.Text = "Hamai adadhoi A, B va C az 50 khurd  nest.";
                }
            }
            if (radioButton6.Checked == true)
            {
                if ((adadi1 < 0) || (adadi2 < 0) || (adadi3 < 0))
                {
                    label4.Text = "Hammai adadhoi A, B va C manfi ast.";
                }
                else
                {
                    label4.Text = "Hamai adadhoi A, B va C musbat ast.";
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
