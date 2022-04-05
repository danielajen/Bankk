using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankk
{
    public partial class Form1 : Form
    {
        string Name,Address,PostalCode;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Name1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //log in button 
            Name = Name1.Text;
            Address = label1.Text;
            PostalCode = label2.Text;

            // new code for next form
            Form2 main = new Form2(Name, Address, PostalCode);
            main.Show();
            this.Hide();

        }
    }
}
