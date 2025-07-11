using FP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FP
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void ShowDashboard()
        {
            this.Show();
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void Addpr_Click(object sender, EventArgs e)
        {
            labelindicator1.ForeColor = System.Drawing.Color.Orange;

            Addpatient ap = new Addpatient();
            ap.Show();

        }

        private void AddDI_Click(object sender, EventArgs e)
        {
            labelindicator1.ForeColor = System.Drawing.Color.Black;
            labelindicator2.ForeColor = System.Drawing.Color.Orange;
            labelindicator3.ForeColor = System.Drawing.Color.Black;
            labelind.ForeColor = System.Drawing.Color.Black;
            labelind5.ForeColor = System.Drawing.Color.Black;
            this.Hide();
            Diagnosis dig = new Diagnosis();
            dig.Show();

        }

        private void btnpf_Click(object sender, EventArgs e)
        {
            labelindicator1.ForeColor = System.Drawing.Color.Black;
            labelindicator2.ForeColor = System.Drawing.Color.Black;
            labelindicator3.ForeColor = System.Drawing.Color.Orange;
            labelind.ForeColor = System.Drawing.Color.Black;
            labelind5.ForeColor = System.Drawing.Color.Black;

            this.Hide();
            Full_history_of_patient FP = new Full_history_of_patient();
            FP.Show();

        }

        private void btnhinfo_Click(object sender, EventArgs e)
        {
            labelindicator1.ForeColor = System.Drawing.Color.Black;
            labelindicator2.ForeColor = System.Drawing.Color.Black;
            labelindicator3.ForeColor = System.Drawing.Color.Black;
            labelind.ForeColor = System.Drawing.Color.Black;

            
        }
        private void Dashboard_Load(object sender, EventArgs e)

        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndocinfo_Click(object sender, EventArgs e)
        {
            labelindicator1.ForeColor = System.Drawing.Color.Black;
            labelindicator2.ForeColor = System.Drawing.Color.Black;
            labelindicator3.ForeColor = System.Drawing.Color.Black;
            labelind.ForeColor = System.Drawing.Color.Orange;
            labelind5.ForeColor = System.Drawing.Color.Black;

            this.Hide();
            Doctor D = new Doctor();
            D.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelindicator1.ForeColor = System.Drawing.Color.Black;
            labelindicator2.ForeColor = System.Drawing.Color.Black;
            labelindicator3.ForeColor = System.Drawing.Color.Black;
            labelind.ForeColor = System.Drawing.Color.Black;
            labelind5.ForeColor = System.Drawing.Color.Orange;
            this.Hide();
            Fulldocinfocs DI = new Fulldocinfocs();
            DI.Show();

        }
    }
}

