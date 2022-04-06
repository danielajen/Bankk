using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bankk
{
    public partial class Form2 : Form
    {
        string name, address, postalcode;
        double c1 = 1000, c2 = 1000, savings = 1000;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            name = textBox2.Text;
            address = textBox3.Text;
            postalcode = textBox4.Text;
            label9.Text = name;
            label10.Text = address;
            label11.Text = postalcode;
            MessageBox.Show("Information has succesfully been changed. Thank you for choosing us for your Bank Heist!");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 3)
            panel2.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi " + name + "! Your Cheques have been ordered to " + address + " at " + postalcode + " Thank you for contributing to our Heist! We will take over the world with this heist!");
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get amount of money
            double amount = double.Parse(textBox1.Text);

            // c1 to c2
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex ==1)
            {
                c1 = c1 - amount;
                c2 = c2 + amount;
                label12.Text = c1.ToString();
                label13.Text = c2.ToString();
                MessageBox.Show("You Have Now Transferred $" + amount + " from Chequing 1 to Chequing 2! Thank you for contributing to our Heist!");
            }
            // c1 to savings 
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                c1 = c1 - amount;
                savings = savings + amount;
                label12.Text = c1.ToString();
                label14.Text = savings.ToString();
                MessageBox.Show("You Have Now Transferred $" + amount + " from Chequing 1 to Savings! Thank you for contributing to our Heist!");
            }
            // c2 to c1
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                c2 = c2 - amount;
                c1 = c1 + amount;
                label13.Text = c2.ToString();
                label12.Text = c1.ToString();
                MessageBox.Show("You Have Now Transferred $" + amount + " from Chequing 2 to Chequing 1! Thank you for contributing to our Heist!");
            }
            // c2 to savings
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                c2 = c2 - amount;
                savings = savings + amount;
                label13.Text = c2.ToString();
                label14.Text = savings.ToString();
                MessageBox.Show("You Have Now Transferred $" + amount + " from Chequing 2 to Savings! Thank you for contributing to our Heist!");
            }
            // savings to chequing 1
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                savings = savings - amount;
                c1 = c1 + amount;
                label14.Text = savings.ToString();
                label12.Text = c1.ToString();
                MessageBox.Show("You Have Now Transferred $" + amount + " from Savings to Chequing 1. Thank you for contributing to our Heist!") ;
            }
            // savings to chequing 2
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                savings = savings - amount;
                c2 = c2 + amount;
                label14.Text = savings.ToString();
                label13.Text = c2.ToString();
                MessageBox.Show("You Have Now Transferred $" + amount + " from Savings to Chequing 2! Thank you for contributing to our Heist!");
            }

            // chequing 1 to payee
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
            {
                c1 = c1 - amount;
                label12.Text = c1.ToString();
                MessageBox.Show("You Have Now Transferred $" + amount + " from Chequing 1 to " + textBox6.Text + "! Thank you for contributing to our Heist!");
            }
            // chequing 2 to payee
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
            {
                c2 = c2 - amount;
                label13.Text = c2.ToString();
                MessageBox.Show("You Have Now Transferred $" + amount + " from Chequing 2 to " + textBox6.Text + "! Thank you for contributing to our Heist!");
            }
            // Savings to payee
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
            {
                savings = savings - amount;
                label14.Text = savings.ToString();
                MessageBox.Show("You Have Now Transferred $" + amount + " from Savings to " + textBox6.Text + "! Thank you for contributing to our Heist!");
            }


        }

        public Form2(string x, string y, string z)
        {
            InitializeComponent();
            name = x;
            address = y;
            postalcode = z;
            label9.Text = name;
            label10.Text = address;
            label11.Text = postalcode;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
