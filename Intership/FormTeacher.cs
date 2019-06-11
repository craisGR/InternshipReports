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
    public partial class FormTeacher : Form
    {
        string selectedTeacherId;
        SqlConnection con;
        public bool view { get; set; }
        bool saveAndExit = false;


        public FormTeacher()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();
                       
            fillData();
            fillDataGridView(selectedTeacherId);
            dataGridViewsStudentForm.Columns["StudID"].Visible = false;
            
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
                      
            this.supervisorTeacherTableAdapter.Fill(this.intershipDataSet.SupervisorTeacher);
            if (view)
            {                
                selectedTeacherId = listBoxTeachers.GetItemText(listBoxTeachers.SelectedValue);
                fillData();
                fillDataGridView(selectedTeacherId);
                disableEdit();
            }
            else
            {
                enableEdit();
                checkBlankField(textBoxName, pictureBoxErrorName);
                toolStripButtonRestore.Enabled = false;
                saveAndExit = true;
            }
            

        }

        
        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeacherId = listBoxTeachers.GetItemText(listBoxTeachers.SelectedValue);
            
            fillData();
            fillDataGridView(selectedTeacherId);
        }

        private void fillData()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from SupervisorTeacher where TID = '" + selectedTeacherId + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //set in the textboxes the saved values

                textBoxName.Text = dr["Name"].ToString();                
                textBoxEmail.Text = dr["Email"].ToString();
                textBoxPhone.Text = dr["Telephone"].ToString();
                textBoxMobile.Text = dr["Mobile"].ToString();
                richTextBoxDetails.Text = dr["Details"].ToString();
               
            }
           

            cmd.ExecuteNonQuery(); //execute query
        }

        private void fillDataGridView(string TeacherId)
        {
            string sqlquery = "Select AEM, LastName + ' ' + FirstName as 'Ονοματεπώνυμο',  FatherName as 'Πατρώνυμο', StudID FROM Student WHERE SupervisorTeacher_TId = '" + TeacherId + "' ORDER BY AEM";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataSet Ds = new DataSet();
            da.Fill(Ds);
            BindingSource Bs = new BindingSource();
            Bs.DataSource = Ds.Tables[0].DefaultView;
            dataGridViewsStudentForm.DataSource = Bs;
            dataGridViewsStudentForm.Columns["StudID"].Visible = false;
            
        }

              
        private void enableEdit() 
        {
            textBoxName.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxMobile.ReadOnly = false;
            textBoxPhone.ReadOnly = false;
            richTextBoxDetails.ReadOnly = false;
            toolStripCreate.Enabled = false; 
            toolStripButtonEdit.Enabled = false;
            toolStripButtonSave.Enabled = true;
            toolStripButtonDelete.Enabled = false;
            toolStripButtonRestore.Enabled = true;
            listBoxTeachers.Enabled = false;

        }

        private void disableEdit()
        {
            textBoxName.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxMobile.ReadOnly = true;
            textBoxPhone.ReadOnly = true;
            richTextBoxDetails.ReadOnly = true;
            toolStripCreate.Enabled = true;
            toolStripButtonEdit.Enabled = true;
            toolStripButtonSave.Enabled = false;
            toolStripButtonRestore.Enabled = false;
            toolStripButtonDelete.Enabled = true;
            listBoxTeachers.Enabled = true;


        }

        private void clearFields()
        {
            selectedTeacherId = null;
            toolStripButtonSave.Enabled = true;
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxMobile.Text = "";
            textBoxPhone.Text = "";
            richTextBoxDetails.Text = "";
            fillDataGridView(selectedTeacherId);
        }



        private void checkBlankField(TextBox tb, PictureBox pb)
        {
            if (tb.Text == "")
            {
                pb.Visible = true;
                toolStripButtonSave.Enabled = false;
            }
            else
            {
                pb.Visible = false;
                if (!toolStripButtonEdit.Enabled)
                {
                    toolStripButtonSave.Enabled = true;
                }
            }
        }

        private void toolStripCreate_Click(object sender, EventArgs e)
        {
            view = false;
            clearFields();
            enableEdit();            
            checkBlankField(textBoxName, pictureBoxErrorName);
            listBoxTeachers.Enabled = false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxName, pictureBoxErrorName);
        }

      
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            enableEdit();
            toolStripButtonEdit.Enabled = false;
            toolStripButtonSave.Enabled = true;
            toolStripButtonRestore.Enabled = true;
        }

        private void updateField()
        {
            string setName, setEmail, setPhone, setMobile, setDetails;

            //colect all parametrs either they hab been changed ir not
            setName = textBoxName.Text.ToString();
            setEmail = textBoxEmail.Text.ToString();
            setPhone = textBoxPhone.Text.ToString();
            setMobile = textBoxMobile.Text.ToString();
            setDetails = richTextBoxDetails.Text.ToString();
            
            //company id is not needed for updated the record due to the Supervisor from a company are unique

            if (view)
            {
                //constract the UPDATE query
                SqlCommand commandsave = con.CreateCommand();
                commandsave.CommandType = CommandType.Text;
                commandsave.CommandText = "UPDATE SupervisorTeacher SET Name = '" + setName + "', Email = '" + setEmail + "', Telephone = '" + setPhone + "', Mobile = '" + setMobile + "', Details = '" + setDetails + "' WHERE TID = '" + selectedTeacherId + "'";
                commandsave.ExecuteNonQuery();
                MessageBox.Show("Η Εγγραφή '" + setName + "' Ενημερώθηκε", "Ενημέρωση Εγγραφής", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation message
               
            }
            else
            {
                //constract the INSERT query
                SqlCommand commandsave = con.CreateCommand();
                commandsave.CommandType = CommandType.Text;
                commandsave.CommandText = "INSERT into SupervisorTeacher (Name, Email, Telephone, Mobile, Details) values ('" + setName + "', '" + setEmail + "', '" + setPhone + "', '" + setMobile + "', '" + setDetails + "')";
                commandsave.ExecuteNonQuery();
                MessageBox.Show("Η Εγγραφή'" + setName + "' Αποθηκεύτηκε", "Αποθήκευση Εγγραφής", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation message
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            updateField();
            disableEdit();
            supervisorTeacherTableAdapter.Fill(intershipDataSet.SupervisorTeacher);
            selectedTeacherId = listBoxTeachers.GetItemText(listBoxTeachers.SelectedValue);
            int index = listBoxTeachers.Items.Count - 1;
            listBoxTeachers.SetSelected(index, true);
            fillData();
            fillDataGridView(selectedTeacherId);
            if (saveAndExit)
            {
                this.Close();
            }
        }

        private void toolStripButtonRestore_Click(object sender, EventArgs e)
        {
            if (view) //for editing a contact
            {
                //restore all unsaved editings to previus record
                fillData();
                fillDataGridView(selectedTeacherId);
                disableEdit(); //disable the edit features after the restore action
            }
            else //for adding new Student
            {
                clearFields();
                disableEdit();
                supervisorTeacherTableAdapter.Fill(intershipDataSet.SupervisorTeacher);
                selectedTeacherId = listBoxTeachers.GetItemText(listBoxTeachers.SelectedValue);
                fillData();
                fillDataGridView(selectedTeacherId);
                view = true;
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος οτι θέλετε να διαγράψετε τον Καθηγητή: " + textBoxName.Text.ToString() + " ;", "Διαγραφή Καθηγητή!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridViewsStudentForm.RowCount > 0)
                {
                    MessageBox.Show("Ο καθηγήτη: '" + textBoxName.Text.ToString() + "' έχει συνδεδεμένους φοιτητές. Η διαγραφή του δεν είναι εφικτή.", "Μη Δυνατή Διαγραφή!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "DELETE FROM SupervisorTeacher WHERE TID='" + selectedTeacherId + "'";
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Η Εγγραφή '" + textBoxName.Text.ToString() + "' έχει διαγραφεί", "Διαγραφή Καθηγητή", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                supervisorTeacherTableAdapter.Fill(intershipDataSet.SupervisorTeacher);
                selectedTeacherId = listBoxTeachers.GetItemText(listBoxTeachers.SelectedValue);
                fillData();
                fillDataGridView(selectedTeacherId);
                view = true;
                
            }
        }

        private void dataGridViewsStudentForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormViewSingleStudent newform = new FormViewSingleStudent();
            newform.view = true;
            newform.selectedStudentID = dataGridViewsStudentForm.CurrentRow.Cells[3].Value.ToString();
            newform.Activate();
            newform.Show();
        }

        

    }
}
