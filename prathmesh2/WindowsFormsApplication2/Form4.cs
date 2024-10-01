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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Form5 f5= new Form5();
            f5.Show();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Nashik")
            {
                textBox7.Text = "Nashik";
            }
            else
                if (comboBox1.SelectedItem == "Jalgaon")
                {
                    textBox7.Text = "Jalgaon";
                }
                else
                    if (comboBox1.SelectedItem == "Jaypur")
                    {
                        textBox7.Text = "Jaypur";
                    }
                    else
                        if (comboBox1.SelectedItem == "Udaypur")
                        {
                            textBox7.Text = "Udaypur";
                        }
                        else
                            if (comboBox1.SelectedItem == "NorthGoa")
                            {
                                textBox7.Text = "NorthGoa";
                            }
                            else
                                if (comboBox1.SelectedItem == "SouthGoa")
                                {
                                    textBox7.Text = "SouthGoa";
                                }
                                else
                                    if (comboBox1.SelectedItem == "Patiala")
                                    {
                                        textBox7.Text = "Patiala";
                                    }
                                    else
                                        if (comboBox1.SelectedItem == "Amritsar")
                                        {
                                            textBox7.Text = "Amritsar";
                                        }
                                        else
                                            if (comboBox1.SelectedItem == "Ahemdabad")
                                            {
                                                textBox7.Text = "Ahemdabad";
                                            }
                                            else
                                                if (comboBox1.SelectedItem == "Surat")
                                                {
                                                    textBox7.Text = "Surat";
                                                }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Maharashtra")
            {
                textBox8.Text = "Maharashtra";
            }
            else
                if (comboBox2.SelectedItem == "RJ")
                {
                    textBox8.Text = "RJ";
                }
                else
                    if (comboBox2.SelectedItem == "Goa")
                    {
                        textBox8.Text = "Goa";
                    }
                    else
                        if (comboBox2.SelectedItem == "Punjab")
                        {
                            textBox8.Text = "Punjab";
                        }
                        else
                            if (comboBox2.SelectedItem == "Gujrat")
                            {
                                textBox8.Text = "Gujrat";
                            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox5.Text = "Male";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox5.Text = "Female";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDataSet1.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.movieDataSet1.user);

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            userBindingSource.AddNew();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            userBindingSource.EndEdit();
            userTableAdapter.Update(movieDataSet1.user);
            MessageBox.Show("Saved");
        }

      
        
    }
}
