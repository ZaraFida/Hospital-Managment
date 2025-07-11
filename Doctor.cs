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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = (Dashboard)Application.OpenForms["Dashboard"];
            dashboardForm.ShowDashboard();
            this.Close();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBoxname.Text;
                Int32 id = Convert.ToInt32(textBoxid.Text);
                String gender = comboBoxgender.Text;
                Int64 exp = Convert.ToInt64(textBoxexp.Text);
                Int64 lis = Convert.ToInt64(textBoxlicesnce.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =DESKTOP-FR2ER1H\\MSSQLSERVER01;database= Hospital;integrated security=true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into DoctorINFO values (" + id + ",'" + name + "','" + gender + "'," + exp + "," + lis + ")";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data format");
            }
            MessageBox.Show("DATA SAVED");
            textBoxname.Clear();
            textBoxid.Clear();
            textBoxexp.Clear();
            textBoxlicesnce.Clear();
            comboBoxgender.ResetText();
        }
    }
}

