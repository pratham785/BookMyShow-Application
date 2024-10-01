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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            //Form4 f4 = new Form4();
            //f4.Show();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDataSet.theater' table. You can move, or remove it, as needed.
            this.theaterTableAdapter.Fill(this.movieDataSet.theater);
            textBox1.Text = Form2.i;
        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Previous_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Narnia")
            {
                textBox2.Text = "Narnia";
            }
            else
                if (comboBox1.SelectedItem == "Avengers")
                {
                    textBox2.Text = "Avengers";
                }
                else
                    if (comboBox1.SelectedItem == "John wick")
                    {
                        textBox2.Text = "John wick";
                    }
                    else
                        if (comboBox1.SelectedItem == "Jurrasic world")
                        {
                            textBox2.Text = "Jurrasic world";
                        }else
                            if (comboBox1.SelectedItem == "Anebella")
                            {
                                textBox2.Text = "Anebella";
                            }
                                
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Pathan")
            {
                textBox2.Text = "Pathan";
            }
            else
                if (comboBox2.SelectedItem == "Dangal")
                {
                    textBox2.Text = "Dangal";
                }
                else
                    if (comboBox2.SelectedItem == "Drishyam")
                    {
                        textBox2.Text = "Drishyam";
                    }
                    else
                        if (comboBox2.SelectedItem == "Tanhaji")
                        {
                            textBox2.Text = "Tanhaji";
                        }
                        else
                            if (comboBox2.SelectedItem == "3 Idiots")
                            {
                                textBox2.Text = "3 Idiots";
                            } 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "A.AA2")
            {
                textBox2.Text = "A.AA2";
            }
            else
                if (comboBox3.SelectedItem == "Robot")
                {
                    textBox2.Text = "Robot";
                }
                else
                    if (comboBox3.SelectedItem == "Dasara")
                    {
                        textBox2.Text = "Dasara";
                    }
                    else
                        if (comboBox3.SelectedItem == "Pushpa")
                        {
                            textBox2.Text = "Pushpa";
                        }
                        else
                            if (comboBox3.SelectedItem == "Bahuballi")
                            {
                                textBox2.Text = "Bahuballi";
                            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == "Maharashtra")
            {
                textBox3.Text = "Maharashtra";
            }
            else
                if (comboBox4.SelectedItem == "Rajsthan	")
            {
                textBox3.Text = "Rajsthan";
            }
            else
                if (comboBox4.SelectedItem == "Goa")
                {
                    textBox3.Text = "Goa";
                }
                else
                    if (comboBox4.SelectedItem == "Punjab")
                    {
                        textBox3.Text = "Punjab";
                    }
                    else
                        if (comboBox4.SelectedItem == "Gujrat")
                        {
                            textBox3.Text = "Gujrat";
                        }
            
 
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem == "Nashik")
            {
                textBox4.Text = "Nashik";
            }else
                if (comboBox5.SelectedItem == "Jalgaon")
                {
                    textBox4.Text = "Jalgaon";
                }else
                    if (comboBox5.SelectedItem == "Jaypur")
                    {
                        textBox4.Text = "Jaypur";
                    }else
                        if (comboBox5.SelectedItem == "Udaypur")
                        {
                            textBox4.Text = "Udaypur";
                        }else
                            if (comboBox5.SelectedItem == "NorthGoa")
                            {
                                textBox4.Text = "NorthGoa";
                            }else
                                if (comboBox5.SelectedItem == "SouthGoa")
                                {
                                    textBox4.Text = "SouthGoa";
                                }else
                                    if (comboBox5.SelectedItem == "Patiala")
                                    {
                                        textBox4.Text = "Patiala";
                                    }else
                                        if (comboBox5.SelectedItem == "Amritsar")
                                        {
                                            textBox4.Text = "Amritsar";
                                        }else
                                            if (comboBox5.SelectedItem == "Ahemdabad")
                                            {
                                                textBox4.Text = "Ahemdabad";
                                            }else
                                                if (comboBox5.SelectedItem == "Surat")
                                                {
                                                    textBox4.Text = "Surat";
                                                }
                    
                     
                    
                    
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedItem == "Inox(MH)")
            {
                textBox5.Text = "Inox(MH)";
                textBox6.Text = "GM Road";
            }else
                if (comboBox6.SelectedItem == "PVR(MH)")
                {
                    textBox5.Text = "PVR(MH)";
                    textBox6.Text = "Ambedkar Chauk,Sakari road";
                }else
                    if (comboBox6.SelectedItem == "Manohar_Cinema(RJ)")
                    {
                        textBox5.Text = "Manohar_Cinema(RJ)";
                        textBox6.Text = "Dwarkadhish Road";
                    }else
                        if (comboBox6.SelectedItem == "7_Star(RJ)")
                        {
                            textBox5.Text = "7_Star(RJ)";
                            textBox6.Text = "Maharana Pratap Road";
                        }else
                            if (comboBox6.SelectedItem == "Universal_Cinema(Goa)")
                            {
                                textBox5.Text = "Unoiversal_Cinema(Goa)";
                                textBox6.Text = "Near by Classic beach";
                            }else
                                if (comboBox6.SelectedItem == "Spotlight(Goa)")
                                {
                                    textBox5.Text = "Spotloght(Goa)";
                                    textBox6.Text = "FC Road";
                                }else
                                    if (comboBox6.SelectedItem == "Royal_Cinema(PJ)")
                                    {
                                        textBox5.Text = "Royal_Cinema(PJ)";
                                        textBox6.Text = "Gurugram road";
                                    }else
                                    if (comboBox6.SelectedItem == "Guardian_Cinema(PJ)")
                                    {
                                        textBox5.Text = "Guardian_Cinema(PJ)";
                                      textBox6.Text = "Deccan Road";
                                    }else
                                         if (comboBox6.SelectedItem == "Eagle_Cinema(GJ)")
                                         {
                                           textBox5.Text = "Eagle_Cinema(GJ)";
                                            textBox6.Text = "Patel Road";
                                          }else
                                          if (comboBox6.SelectedItem == "Peacock_Cinema(GJ)")
                                          {
                                             textBox5.Text = "Peacock_Cinema(GJ)";
                                             textBox6.Text = "RC Patel Road ";
                                           }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox7.Text = "9am-12pm";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox7.Text = "12am-3pm";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox7.Text = "3pm-6pm";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                textBox7.Text = "6pm-9pm";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                textBox10.Text = "Gold(1 to 50)";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                textBox10.Text = "Silver(51 to 100)";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                textBox10.Text = "Platanium(101 to 150)";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            theaterBindingSource.EndEdit();
            theaterTableAdapter.Update(movieDataSet.theater);
            MessageBox.Show("Saved");
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            theaterBindingSource.AddNew();
        }
    }
}
