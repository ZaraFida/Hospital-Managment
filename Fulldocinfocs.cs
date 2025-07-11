using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FP
{
    public partial class Fulldocinfocs : Form
    {
        public Fulldocinfocs()
        {
            InitializeComponent();
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = (Dashboard)Application.OpenForms["Dashboard"];
            dashboardForm.ShowDashboard();
            this.Close();
        }
        private void Fulldocinfocs_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =DESKTOP-FR2ER1H\\MSSQLSERVER01;database= Hospital;integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select *from  DoctorINFO";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}

