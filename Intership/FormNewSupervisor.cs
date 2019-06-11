using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Intership
{
    public partial class FormNewSupervisor : Form
    {

        public string companyID { get; set; }
        SqlConnection con;

        public FormNewSupervisor()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();
        }

        private void FormNewSupervisor_Load(object sender, EventArgs e)
        {
            loadCompany();
            fillDataGridView();
        }

        private void loadCompany() 
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Name from Company where ComID = '" + companyID + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                labelCompanyName.Text = dr["Name"].ToString();
            }
        }

        private void fillDataGridView()
        {

            string sqlquerySupervisor = "Select ID, Supervisor.Name as 'Όνομα', Position as 'Θέση' FROM Supervisor, Company WHERE (ComID = '" + companyID + "') AND (ComID = Company_ComID)  ORDER BY Supervisor.Name";
            SqlDataAdapter daSupervisor = new SqlDataAdapter(sqlquerySupervisor, con);
            DataSet DsSupervisor = new DataSet();
            daSupervisor.Fill(DsSupervisor);
            BindingSource BsSupervisor = new BindingSource();
            BsSupervisor.DataSource = DsSupervisor.Tables[0].DefaultView;
            dataGridViewSupervisor.DataSource = BsSupervisor;
            dataGridViewSupervisor.Columns["ID"].Visible = false;

        }

        private void checkBlankField()
        {
            if (textBoxSupervisorName.Text == "")
            {
                pictureBoxErrorSupervisor.Visible = true;
                myButtonAdd.Enabled = false;
            }
            else
            {
                pictureBoxErrorSupervisor.Visible = false;
                myButtonAdd.Enabled = true;
            }
            
        }

        private void textBoxSupervisorName_TextChanged(object sender, EventArgs e)
        {
            checkBlankField();
        }

        private void myButtonAdd_Click(object sender, EventArgs e)
        {
             SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Supervisor (name, position, Company_ComID) values ('" + textBoxSupervisorName.Text.ToString() + "', '" + textBoxSupervisorPosition.Text.ToString() + "', '" + companyID + "')"; 
            cmd.ExecuteNonQuery();
            fillDataGridView();
            textBoxSupervisorName.Text = "";
            textBoxSupervisorPosition.Text = "";
            checkBlankField();
                
        }

        private void myButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      


       
    }
}
