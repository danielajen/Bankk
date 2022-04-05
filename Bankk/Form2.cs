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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form2(string x, string y, string z)
        {
            InitializeComponent();
            name = x;
            address = y;
            postalcode = z;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
