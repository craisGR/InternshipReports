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
           

    public partial class FormStudent : Form
    {

        string displayTeacher, displayCompany;
        string dateStartfrom, dateStartUntil, dateEndfrom, dateEndUntil;
        SqlConnection con;
        int selectedStudentRow;
      
        public FormStudent()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();
           
           
            ClearDateTimePicker(); //set DateTimePickers blank
            fillDataSet();
            fillTeacherCombobox();
            fillCompanyCombobox();
            comboBox_Teacher.SelectedIndex = -1; //set Teacher combobox with no value
            comboBox_Company.SelectedIndex = -1; //set Company combobox with no value

            dataGridViewsStudentForm.Columns["StID"].Visible = false;
                                       
        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // execute the Search button action

            fillDataSet();
        }

       
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // clear all search fields

            textBoxAEM.Text = null;
            textBoxAFM.Text = null;
            textBoxFirstName.Text = null;
            textBoxLastName.Text = null;
            fillTeacherCombobox();
            fillCompanyCombobox();
            comboBox_Teacher.SelectedIndex = -1; 
            comboBox_Company.SelectedIndex = -1; 
            ClearDateTimePicker();
            buttonSearch_Click(null,null);
        }

        private void comboBox_Teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if Teacher combobox is blank do not consider it for Select query

            if (comboBox_Teacher.SelectedIndex > -1)
            {

                displayTeacher = comboBox_Teacher.SelectedValue.ToString();

            }
                    
        }

/* --------------------------Configure DateTimePicker Options-------------------------------------- */

        private void dateTimePickerStartUntil_ValueChanged(object sender, EventArgs e)
        {
            // transform date to acceptable format mm/dd/yyyy for Select query

            dateStartUntil = dateTimePickerStartUntil.Value.Month.ToString() + "/" + dateTimePickerStartUntil.Value.Day.ToString() + "/" + dateTimePickerStartUntil.Value.Year.ToString();
        }

        private void dateTimePickerStartFrom_ValueChanged(object sender, EventArgs e)
        {
            // transform date to acceptable format mm/dd/yyyy for Select query

            dateStartfrom = dateTimePickerStartFrom.Value.Month.ToString() + "/" + dateTimePickerStartFrom.Value.Day.ToString() + "/" + dateTimePickerStartFrom.Value.Year.ToString();
        }
                       
        
        private void dateTimePickerStartFrom_MouseDown(object sender, MouseEventArgs e)
        {
            //set dateTimePicker to visible format dd/MM/yyyy

            dateTimePickerStartFrom.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePickerStartUntil_MouseDown(object sender, MouseEventArgs e)
        {
            //set dateTimePicker to visible format dd/MM/yyyy

            dateTimePickerStartUntil.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePickerEndFrom_ValueChanged(object sender, EventArgs e)
        {
            // transform date to acceptable format mm/dd/yyyy for Select query

            dateEndfrom = dateTimePickerEndFrom.Value.Month.ToString() + "/" + dateTimePickerEndFrom.Value.Day.ToString() + "/" + dateTimePickerEndFrom.Value.Year.ToString();

        }

        private void dateTimePickerEndUntil_ValueChanged(object sender, EventArgs e)
        {
            // transform date to acceptable format mm/dd/yyyy for Select query

            dateEndUntil = dateTimePickerEndUntil.Value.Month.ToString() + "/" + dateTimePickerEndUntil.Value.Day.ToString() + "/" + dateTimePickerEndUntil.Value.Year.ToString();

        }

        private void dateTimePickerEndFrom_MouseDown(object sender, MouseEventArgs e)
        {
            //set dateTimePicker to visible format dd/MM/yyyy

            dateTimePickerEndFrom.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePickerEndUntil_MouseDown(object sender, MouseEventArgs e)
        {
            //set dateTimePicker to visible format dd/MM/yyyy

            dateTimePickerEndUntil.CustomFormat = "dd/MM/yyyy";
        }

        private void ClearDateTimePicker()
        {
            //Clear DateTimePicker so you can make a Select query with no date parametrs

            dateTimePickerStartUntil.CustomFormat = " ";
            dateTimePickerStartUntil.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartFrom.CustomFormat = " ";
            dateTimePickerStartFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndUntil.CustomFormat = " ";
            dateTimePickerEndUntil.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndFrom.CustomFormat = " ";
            dateTimePickerEndFrom.Format = DateTimePickerFormat.Custom;
            dateStartfrom = "01/01/1900";
            dateStartUntil = "01/01/2100";
            dateEndfrom = "01/01/1900";
            dateEndUntil = "01/01/2100";

        }

/* ------------------------------------------------------------------------------------------------------ */


        private void fillDataSet()
        {
            
            // Execute Select query with preferable parametrs

            string select = "Select Student.StudID as StID, Student.AEM as ΑΕΜ, Student.LastName as Επίθετο, Student.FirstName as Όνομα , Student.AFM as ΑΦΜ, SupervisorTeacher.Name as 'Επ. Καθηγητής', Student.StartingDate as 'Ημ. Έναρξης', Student.EndingDate as 'Ημ. Λήξης', Supervisor.Name as 'Επόπτης Φορέα', Company.Name as 'Εταιρία' from Student, SupervisorTeacher, Supervisor, Company where ";
            string join = "AND (Student.SupervisorTeacher_TID = SupervisorTeacher.TID) AND (Supervisor.ID = Student.Supervisor_ID) AND (Company.ComID= Supervisor.Company_ComID) ";
            string searchAem = "(Student.AEM LIKE'" + textBoxAEM.Text.ToString() + "%' OR Student.AEM IS NULL) ";
            string searchLastName = "AND (Student.LastName LIKE '" + textBoxLastName.Text.ToString() + "%' OR Student.LastName IS NULL) ";
            string searchFirstName = "AND (Student.FirstName LIKE '" + textBoxFirstName.Text.ToString() + "%' OR Student.FirstName IS NULL) ";
            string searchAFM = "AND (Student.AFM LIKE '" + textBoxAFM.Text.ToString() + "%' OR Student.AFM IS NULL) ";
            string searchEndingDate = "AND (Student.EndingDate between '" + dateEndfrom + "' AND '" + dateEndUntil + "') ";
            string searchStartingDate = "AND (Student.StartingDate between '" + dateStartfrom + "' AND '" + dateStartUntil + "') ";
            string searchCompany = "AND (Company.ComID = '" + displayCompany +"') ";
            string searchTeacher = "AND (SupervisorTeacher.TID = '" + displayTeacher + "') ";
            
            string sqlquery = select + searchAem + searchAFM + searchStartingDate + searchEndingDate + searchLastName + searchFirstName + join;


            if (comboBox_Company.SelectedIndex > -1)
            {
                sqlquery += searchCompany;
            }

            if (comboBox_Teacher.SelectedIndex > -1)
            {
                sqlquery += searchTeacher;
            }

            SqlDataAdapter da1 = new SqlDataAdapter(sqlquery, con);
           
            DataSet Ds1 = new DataSet();
            da1.Fill(Ds1);
            BindingSource Bs1 = new BindingSource();
          
            Bs1.DataSource = Ds1.Tables[0].DefaultView;
            dataGridViewsStudentForm.DataSource = Bs1;

            
        }

        private void fillTeacherCombobox()
        {
            //fill Teacher Combobox with all registered Teachers

            SqlDataAdapter daTeacher = new SqlDataAdapter("SELECT TID, Name FROM SupervisorTeacher ORDER BY Name", con);
            DataTable dtTeacher = new DataTable();
            daTeacher.Fill(dtTeacher);
            comboBox_Teacher.DataSource = dtTeacher;
            string displayTextTeacher = "Name";
            string displayIdTeacher = "TID";
            comboBox_Teacher.DisplayMember = displayTextTeacher;
            comboBox_Teacher.ValueMember = displayIdTeacher;
        }

        private void fillCompanyCombobox()
        {
            //fill Company Combobox with all registered Teachers

            SqlDataAdapter daCompany = new SqlDataAdapter("SELECT ComID, Name FROM Company ORDER BY Name", con);
            DataTable dtCompany = new DataTable();
            daCompany.Fill(dtCompany);
            comboBox_Company.DataSource = dtCompany;
            string displayTextCompany = "Name";
            string displayIdCompany = "ComID";
            comboBox_Company.DisplayMember = displayTextCompany;
            comboBox_Company.ValueMember = displayIdCompany;


        }

        private void dataGridViewsStudentForm_Click(object sender, EventArgs e)
        {
            // Open new form FormViewSingleStudent

            FormViewSingleStudent newform = new FormViewSingleStudent();

            // transfer to FormViewSingleStudent Student ID

            newform.view = true;
            newform.selectedStudentID = dataGridViewsStudentForm.CurrentRow.Cells[0].Value.ToString();

                   
            newform.Activate();
            newform.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormViewSingleStudent newform = new FormViewSingleStudent();
            newform.selectedStudentID = null;
            newform.view = false;
            newform.Activate();
            newform.Show();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            string removeStudentId;

            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος οτι θέλετε να διαγράψετε τον Φοιτητή: " + dataGridViewsStudentForm.Rows[selectedStudentRow].Cells["Επίθετο"].Value.ToString() + " " + dataGridViewsStudentForm.Rows[selectedStudentRow].Cells["Όνομα"].Value.ToString() + " ;", "Διαγραφή Φοιτητή!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                removeStudentId = dataGridViewsStudentForm.Rows[selectedStudentRow].Cells["StID"].Value.ToString();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "DELETE FROM Address WHERE Student_StudID='" + removeStudentId + "'";
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "DELETE FROM Contacts WHERE Student_ID='" + removeStudentId + "'";
                cmd2.ExecuteNonQuery();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Student WHERE StudID='" + removeStudentId + "'";
                cmd.ExecuteNonQuery();
                buttonSearch_Click(null, null);

            }
        }

        private void dataGridViewsStudentForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedStudentRow = e.RowIndex;
        }

        private void comboBox_Company_SelectedIndexChanged(object sender, EventArgs e)
        {

            // if Teacher Company is blank do not consider it for Select query

            if (comboBox_Company.SelectedIndex > -1)
            {

                displayCompany = comboBox_Company.SelectedValue.ToString();
                
            }
                    
        }

        private void comboBox_Teacher_DragDrop(object sender, DragEventArgs e)
        {
            fillTeacherCombobox();
        }

       
    }
}
