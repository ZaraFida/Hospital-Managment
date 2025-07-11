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
    public partial class Full_history_of_patient : Form
    {
        public Full_history_of_patient()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = (Dashboard)Application.OpenForms["Dashboard"];
            dashboardForm.ShowDashboard();
            this.Close();

        }

        private void Full_history_of_patient_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =DESKTOP-FR2ER1H\\MSSQLSERVER01;database= Hospital;integrated security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select *from  ADPATIENTinfo inner join PatientMore1 on ADPATIENTinfo.pid=PatientMore1.pid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];

        }
    }
}
