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
using System.Xml.Linq;

namespace FP
{
    public partial class Addpatient : Form
    {
        public Addpatient()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                try
                {
                    String name = textBoxname.Text;
                    String address = textBoxaddress.Text;
                    Int64 contact = Convert.ToInt64(textBoxcontact.Text);
                    String gender = comboBoxgender.Text;
                    int age = Convert.ToInt32(textBoxage.Text);
                    String any = textBoxany.Text;
                    String blood = textBoxblood.Text;
                    int pid = Convert.ToInt32(textBoxpid.Text);
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source =DESKTOP-FR2ER1H\\MSSQLSERVER01;database= Hospital;integrated security=true";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into ADPATIENTinfo values (" + pid + ",'" + name + "','" + address + "'," + contact + "," + age + ",'" + blood + "','" + gender + "','" + any + "')";
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
                textBoxaddress.Clear();
                textBoxblood.Clear();
                textBoxage.Clear();
                textBoxcontact.Clear();
                textBoxpid.Clear();
                textBoxany.Clear();
                comboBoxgender.ResetText();
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = (Dashboard)Application.OpenForms["Dashboard"];
            dashboardForm.ShowDashboard();
            this.Close();
            }
    }
}
