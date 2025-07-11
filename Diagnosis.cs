using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int pid = Convert.ToInt32(textBox1.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =DESKTOP-FR2ER1H\\MSSQLSERVER01;database= Hospital;integrated security=true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select *from ADPATIENTinfo where pid=" + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);//
                dataGridView1.DataSource = DS.Tables[0];
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                String symptoms = txtsymptoms.Text;
                String diagnosis = txtdiagnosis.Text;
                String med = txtmedicines.Text;
                String wardR = comboBoxwardr.Text;
                String ward = comboBoxward.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =DESKTOP-FR2ER1H\\MSSQLSERVER01;database= Hospital;integrated security=true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into PatientMore1 values(" + pid + ",'" + symptoms + "','" + diagnosis + "','" + med + "','" + ward + "','" + wardR + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Value in pid");
            }
            MessageBox.Show("Data Save successfully");
            textBox1.Clear();
            txtsymptoms.Clear();
             txtdiagnosis.Clear();
           txtmedicines.Clear();
             comboBoxwardr.ResetText();
             comboBoxward.ResetText();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = (Dashboard)Application.OpenForms["Dashboard"];
            dashboardForm.ShowDashboard();
            this.Close();
           
        }
    }
}
