﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Customers frm2 = new Customers();

            frm2.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bookform frm2 = new Bookform();

            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Orders frm2 = new Orders();

            frm2.Show();

        }
    }
}
