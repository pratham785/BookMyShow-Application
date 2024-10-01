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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Phone pay(Online)")
            {
                textBox1.Text = "Phone pay(Online)";
            } 
            else
                if (comboBox1.SelectedItem == "Google Pay(Online)")
                {
                    textBox1.Text = "Google Pay(Online)";
                } 
                else
                    if (comboBox1.SelectedItem == "Paytm(Online)")
                    {
                        textBox1.Text = "Paytm(Online)";
                    } 
                    else
                        if (comboBox1.SelectedItem == "Amazon Pay(Online)")
                        {
                            textBox1.Text = "Amazon Pay(Online)";
                        } 
                        else
                            if (comboBox1.SelectedItem == "Bharat pay(Online)")
                            {
                                textBox1.Text = "Bharat pay(Online)";

                            }
                            else
                                if (comboBox1.SelectedItem == "BHEEM(Online)")
                                {
                                    textBox1.Text = "BHEEM(Online)";

                                }else
                                    if (comboBox1.SelectedItem == "Offline")
                                    {
                                        textBox1.Text = "Offline";

                                    }
                            
                         

                 
            

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            paymentBindingSource.EndEdit();
            paymentTableAdapter.Update(movieDataSet2.payment);
            MessageBox.Show("Booking successfully");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDataSet2.payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.movieDataSet2.payment);

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            paymentBindingSource.AddNew();
        }
    }
}
