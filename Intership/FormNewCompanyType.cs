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
    public partial class FormNewCompanyType : Form
    {
        SqlConnection con;
        bool editType;
        int selectedRow;
        string editTypeId;
        int index=0;

        public FormNewCompanyType()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();
        }

        private void FormNewCompanyType_Load(object sender, EventArgs e)
        {
            loadType();
        }

        private void loadType()
        {
            string sqlquery = "Select TypeId, Name as 'Είδος Εταιρίας' FROM CompanyType ORDER BY Name";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataSet Ds = new DataSet();
            da.Fill(Ds);
            BindingSource Bs = new BindingSource();
            Bs.DataSource = Ds.Tables[0].DefaultView;
            dataGridViewType.DataSource = Bs;
            dataGridViewType.Columns["TypeId"].Visible = false;
        }

        private void buttonContactNew_Click(object sender, EventArgs e)
        {
            panelEditType.Visible = true;
            editType = false;
            groupBoxEditType.Text = "Προσθήκη Είδους Εταιρίας";
            textBoxTypeName.Text = "";
            pictureBoxErrorTypeName.Visible = true;
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            panelEditType.Visible = true;
            groupBoxEditType.Text = "Επεξεργασία Είδους Εταιρίας";
            // load data from the selected contact if the row was selected before edit is enabled
            textBoxTypeName.Text = dataGridViewType.Rows[selectedRow].Cells["Είδος Εταιρίας"].Value.ToString();
            editTypeId = dataGridViewType.Rows[selectedRow].Cells["TypeId"].Value.ToString();
            editType = true;
            if (textBoxTypeName.Text == "")
            {
                buttonTypeSave.Enabled = false;
            }

           
        }

        private void buttonCancelContactEdit_Click(object sender, EventArgs e)
        {
            panelEditType.Visible = false;
        }

        private void textBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            pictureBoxErrorTypeName.Visible = false;
            buttonTypeSave.Enabled = true;
            if (textBoxTypeName.Text == "")
            {
                pictureBoxErrorTypeName.Visible = true;
                buttonTypeSave.Enabled = false;
            }
        }

        private void buttonTypeSave_Click(object sender, EventArgs e)
        {   //Save Type
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (!editType)
            {   //add new Type
                cmd.CommandText = "INSERT into CompanyType (Name) values ('" + textBoxTypeName.Text.ToString() + "')";
                textBoxTypeName.Text = "";
                cmd.ExecuteNonQuery();
                loadType(); //reload Type to show the new ones
            }
            else
            {   //edit selected Type
                cmd.CommandText = "UPDATE CompanyType set Name='" + textBoxTypeName.Text.ToString() + "' where TypeId=" + editTypeId + "";
                cmd.ExecuteNonQuery();
                loadType(); //reload Type to show the new ones
                dataGridViewType.Rows[index].Selected = true;
            }
                       
        }

        private void dataGridViewType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            editTypeId = dataGridViewType.Rows[e.RowIndex].Cells["TypeId"].Value.ToString();
            if (selectedRow < 0)
            {   // if there is not a selected row, editing contacts is disabled
                buttonEditType.Enabled = false;
                buttonTypeDelete.Enabled = false;
            }
            else
            {   // if there is  a selected row ,editing contacts is enabled
                buttonEditType.Enabled = true;
                buttonTypeDelete.Enabled = true;
            }
            if (editType && e.RowIndex >= 0)
            {   // load data from the selected contact for editing                 
                textBoxTypeName.Text = dataGridViewType.Rows[e.RowIndex].Cells["Είδος Εταιρίας"].Value.ToString();
                index = e.RowIndex;

            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTypeDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος οτι θέλετε να διαγράψετε το Είδος Εταιρίας: " + dataGridViewType.Rows[selectedRow].Cells["Είδος Εταιρίας"].Value.ToString() + "';", "Διαγραφή Είδους Επειχήρησης!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                editTypeId = dataGridViewType.Rows[selectedRow].Cells["TypeId"].Value.ToString();
                string query = "SELECT * from Company where CompanyType_TypeID = '" + editTypeId + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);           
                if (dt1.Rows.Count>0)
                {
                    MessageBox.Show("To Είδος Εταιρίας: '" + dataGridViewType.Rows[selectedRow].Cells["Είδος Εταιρίας"].Value.ToString() + "' είναι συνδεδεμένο σε εταιρία. Η διαγραφή του δεν είναι εφικτή.", "Μη Δυνατή Διαγραφή!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selectedRow = 0;
                
                }
                else
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "DELETE FROM CompanyType WHERE TypeId='" + editTypeId + "'";
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("To Είδος Εταιρίας '" + dataGridViewType.Rows[selectedRow].Cells["Είδος Εταιρίας"].Value.ToString() + "' έχει διαγραφεί", "Διαγραφή Είδος Εταιρίας", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadType();
                
               
            }
       
        }

       
    }
}
