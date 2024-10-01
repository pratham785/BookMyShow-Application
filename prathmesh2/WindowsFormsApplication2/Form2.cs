using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string i;
        private void Next_Click(object sender, EventArgs e)
        {
            //Form3 f3 = new Form3();
            //f3.Show();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
         //   Form1 f1 = new Form1();
            //f1.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                i = radioButton1.Text.ToString();
            }
            else
                if (radioButton2.Checked == true)
                {
                    i = radioButton2.Text.ToString();
                }
                else
                    if (radioButton3.Checked == true)
                    {
                        i = radioButton3.Text.ToString();
                    }

            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Previous_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
