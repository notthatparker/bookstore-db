using System;
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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void isbnLab_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu menush = new formMenu();

            menush.Show();
        }
    }
}
