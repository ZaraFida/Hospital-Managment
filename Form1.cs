using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            String password = txepassword.Text;
            if (username == "sparko" && password == "panel")
            {
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Wrong Entries");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
