using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace v._2_cmpe_sw_eni
{
    public partial class Form1 : Form
    {
        double indis = 0, outdis = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a value to the text box .", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a value from combo box .", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
            else if (comboBox1.SelectedItem.ToString() == "kilometer" && comboBox2.SelectedItem.ToString() == "meter")
            {
                 
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 1000;
                label1.Text = Convert.ToString(outdis);

            }
            else if (comboBox1.SelectedItem.ToString() == "kilometer" && comboBox2.SelectedItem.ToString() == "centimeter")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 1000000;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "kilometer" && comboBox2.SelectedItem.ToString() == "feet")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 3280;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "meter" && comboBox2.SelectedItem.ToString() == "kilometer")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 0.001;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "meter" && comboBox2.SelectedItem.ToString() == "centimeter")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 100;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "meter" && comboBox2.SelectedItem.ToString() == "feet")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 3.28084;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "centimeter" && comboBox2.SelectedItem.ToString() == "meter")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 0.01;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "centimeter" && comboBox2.SelectedItem.ToString() == "kilometer")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 0.00001;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "centimeter" && comboBox2.SelectedItem.ToString() == "feet")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 0.0328084;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "feet" && comboBox2.SelectedItem.ToString() == "kilometer")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 0.0003048;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "feet" && comboBox2.SelectedItem.ToString() == "centimeter")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 0.0328084;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == "feet" && comboBox2.SelectedItem.ToString() == "meter")
            {
                indis = Convert.ToSingle(textBox1.Text);
                outdis = indis * 0.3048;
                label1.Text = Convert.ToString(outdis);
            }
            else if (comboBox1.SelectedItem.ToString() == comboBox2.SelectedItem.ToString() )
            {
                MessageBox.Show("Please, Select different items on the comboBox.", "Error",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0.0-9]"))
            {
                MessageBox.Show("Can you enter numbers only ? Thx fam");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightGray;
        }
    }
}
