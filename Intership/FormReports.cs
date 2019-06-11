using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Intership
{
    public partial class FormReports : Form
    {
        SqlConnection con;
        string selectedTeacher, selectedCompany;
        string dateStartfrom, dateStartUntil, dateEndfrom, dateEndUntil;
        
        public FormReports()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();

            fillStudent1Combobox();
            fillcomboBoxTeachers();
            fillCheckedListBoxTeachers();
            fillcomboBoxCompany();
            fillcheckedListBoxTeacherRepSt();
            fillcheckedListBoxCompaniesRepSt();
            fillcheckedListBoxCompanies();
            clearStudentReport1();
            ClearStudentReport2();
            clearTeachersReport();
            clearCompanyReport1();

                       
        }

 /* --------------------------Configure Student Report 1 -------------------------------------- */
        private void fillStudent1Combobox()
        {
            //fill Teacher Combobox with all registered Teachers

            SqlDataAdapter daStudent1 = new SqlDataAdapter("SELECT aem, aem + ' - ' + LastName + ' ' + FirstName as 'Name' FROM Student ORDER BY LastName", con);
            DataTable dtStudent1 = new DataTable();
            daStudent1.Fill(dtStudent1);
            comboBoxSelectStudent.DataSource = dtStudent1;
            string displayTextStudent1 = "Name";
            string displayIdStudent1 = "aem";
            comboBoxSelectStudent.DisplayMember = displayTextStudent1;
            comboBoxSelectStudent.ValueMember = displayIdStudent1;
        }



        private void comboBoxSelectStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectStudent.SelectedIndex != -1)
            {
                textBoxAEM.Text = comboBoxSelectStudent.SelectedValue.ToString();
            }            
        }

        private void clearStudentReport1()
        {
            textBoxAEM.Text = "";
            comboBoxSelectStudent.SelectedIndex = -1; //set Teacher combobox with no value
        }
 /* --------------------------------------------------------------------------------------------- */


 /* --------------------------Configure Student Report 2 -3 -------------------------------------- */
      


        private void dateTimePickerStartUntil_ValueChanged(object sender, EventArgs e)
        {   // transform date to acceptable format mm/dd/yyyy for Select query
            dateStartUntil = dateTimePickerStartUntil.Value.Month.ToString() + "/" + dateTimePickerStartUntil.Value.Day.ToString() + "/" + dateTimePickerStartUntil.Value.Year.ToString();
        }

        private void dateTimePickerStartFrom_ValueChanged(object sender, EventArgs e)
        {  // transform date to acceptable format mm/dd/yyyy for Select query
            dateStartfrom = dateTimePickerStartFrom.Value.Month.ToString() + "/" + dateTimePickerStartFrom.Value.Day.ToString() + "/" + dateTimePickerStartFrom.Value.Year.ToString();
        }


        private void dateTimePickerStartFrom_MouseDown(object sender, MouseEventArgs e)
        {   //set dateTimePicker to visible format dd/MM/yyyy
            dateTimePickerStartFrom.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePickerStartUntil_MouseDown(object sender, MouseEventArgs e)
        {   //set dateTimePicker to visible format dd/MM/yyyy
            dateTimePickerStartUntil.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePickerEndFrom_ValueChanged(object sender, EventArgs e)
        {   // transform date to acceptable format mm/dd/yyyy for Select query
            dateEndfrom = dateTimePickerEndFrom.Value.Month.ToString() + "/" + dateTimePickerEndFrom.Value.Day.ToString() + "/" + dateTimePickerEndFrom.Value.Year.ToString();
        }

        private void dateTimePickerEndUntil_ValueChanged(object sender, EventArgs e)
        {   // transform date to acceptable format mm/dd/yyyy for Select query
            dateEndUntil = dateTimePickerEndUntil.Value.Month.ToString() + "/" + dateTimePickerEndUntil.Value.Day.ToString() + "/" + dateTimePickerEndUntil.Value.Year.ToString();
        }

        private void dateTimePickerEndFrom_MouseDown(object sender, MouseEventArgs e)
        {   //set dateTimePicker to visible format dd/MM/yyyy
            dateTimePickerEndFrom.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePickerEndUntil_MouseDown(object sender, MouseEventArgs e)
        {   //set dateTimePicker to visible format dd/MM/yyyy
            dateTimePickerEndUntil.CustomFormat = "dd/MM/yyyy";
        }

        private void ClearStudentReport2()
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

        private void fillcheckedListBoxTeacherRepSt()
        {
            SqlDataAdapter daTeacher = new SqlDataAdapter("SELECT * FROM SupervisorTeacher ORDER BY Name", con);
            DataTable dtTeacher = new DataTable();
            daTeacher.Fill(dtTeacher);
            checkedListBoxTeacherStRpt.DataSource = null;
            checkedListBoxTeacherStRpt.DataSource = dtTeacher;
            checkedListBoxTeacherStRpt.DisplayMember = "Name";
            checkedListBoxTeacherStRpt.ValueMember = "TID";
        }
        private void buttonTall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxTeacherStRpt.Items.Count; i++)
            {
                checkedListBoxTeacherStRpt.SetItemChecked(i, true);
            }
        }

        private void buttonTnone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxTeacherStRpt.Items.Count; i++)
            {
                checkedListBoxTeacherStRpt.SetItemChecked(i, false);
            }
        }

        private void fillcheckedListBoxCompaniesRepSt()
        {
            SqlDataAdapter daCompany = new SqlDataAdapter("SELECT * FROM Company ORDER BY Name", con);
            DataTable dtCompany = new DataTable();
            daCompany.Fill(dtCompany);
            checkedListBoxCompanyStRpt.DataSource = null;
            checkedListBoxCompanyStRpt.DataSource = dtCompany;
            checkedListBoxCompanyStRpt.DisplayMember = "Name";
            checkedListBoxCompanyStRpt.ValueMember = "ComID";
        }
       
        private void buttonCall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxCompanyStRpt.Items.Count; i++)
            {
                checkedListBoxCompanyStRpt.SetItemChecked(i, true);
            }
        }

        private void buttonCnone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxCompanyStRpt.Items.Count; i++)
            {
                checkedListBoxCompanyStRpt.SetItemChecked(i, false);
            }
        }
        private void clearCheckListBoxes()
        {
            for (int i = 0; i < checkedListBoxTeacherStRpt.Items.Count; i++)
            {
                checkedListBoxTeacherStRpt.SetItemChecked(i, false);
               
            }
            for (int i = 0; i < checkedListBoxCompanyStRpt.Items.Count; i++)
            {
                checkedListBoxCompanyStRpt.SetItemChecked(i, false);
            }
         }
            

 /* --------------------------------------------------------------------------------------------- */

 /* --------------------------Configure Teacher Report 1 -------------------------------------- */
        private void fillcomboBoxTeachers()
        {
            //fill Teacher Combobox with all registered Teachers

            SqlDataAdapter daTeacher = new SqlDataAdapter("SELECT TID, Name FROM SupervisorTeacher ORDER BY Name", con);
            DataTable dtTeacher = new DataTable();
            daTeacher.Fill(dtTeacher);
            comboBoxTeachers.DataSource = dtTeacher;
            string displayTextTeacher = "Name";
            string displayIdTeacher = "TID";
            comboBoxTeachers.DisplayMember = displayTextTeacher;
            comboBoxTeachers.ValueMember = displayIdTeacher;
        }



        private void comboBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTeachers.SelectedIndex != -1)
            {
                selectedTeacher = comboBoxTeachers.SelectedValue.ToString();
            }
        }

        private void clearTeachersReport()
        {
            comboBoxTeachers.SelectedIndex = -1; //set Teacher combobox with no value
            selectedTeacher = "";
        }
/* --------------------------------------------------------------------------------------------- */
        
/* ----------------------------Configure Teacher Report 2 -------------------------------------- */

        private void fillCheckedListBoxTeachers()
        {
            SqlDataAdapter daTeacher = new SqlDataAdapter("SELECT TID, Name FROM SupervisorTeacher ORDER BY Name", con);
            DataTable dtTeacher = new DataTable();
            daTeacher.Fill(dtTeacher);
            checkedListBoxTeachers.DataSource = null;
            checkedListBoxTeachers.DataSource = dtTeacher;
            checkedListBoxTeachers.DisplayMember = "Name";
            checkedListBoxTeachers.ValueMember = "TID";
        }

        private void buttonChecked_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxTeachers.Items.Count; i++)
            {
                checkedListBoxTeachers.SetItemChecked(i, true);
            }
        }

        private void clearTeachersReport2()
        {
            for (int i = 0; i < checkedListBoxTeachers.Items.Count; i++)
            {
                checkedListBoxTeachers.SetItemChecked(i, false);
            }
        }

        private void buttonUnchecked_Click(object sender, EventArgs e)
        {
            clearTeachersReport2();
        }

/* --------------------------------------------------------------------------------------------- */
        


/* ----------------------------Configure Company Report 1 - 2 -------------------------------------- */
        private void fillcomboBoxCompany()
        {
            //fill Teacher Combobox with all registered Teachers

            SqlDataAdapter daCompany = new SqlDataAdapter("SELECT ComID, Name FROM Company ORDER BY Name", con);
            DataTable dtCompany = new DataTable();
            daCompany.Fill(dtCompany);
            ComboboxCompany.DataSource = dtCompany;
            string displayTextCompany = "Name";
            string displayIdCompany = "ComID";
            ComboboxCompany.DisplayMember = displayTextCompany;
            ComboboxCompany.ValueMember = displayIdCompany;
        }

        private void clearCompanyReport1()
        {
            ComboboxCompany.SelectedIndex = -1; //set Teacher combobox with no value
            selectedCompany = "";
        }

        private void ComboboxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboboxCompany.SelectedIndex != -1)
            {
                selectedCompany = ComboboxCompany.SelectedValue.ToString();
            }
        }
/* ------------------------------------------------------------------------------------------------- */

/* ----------------------------Configure Company Report 3 -------------------------------------- */
        private void fillcheckedListBoxCompanies()
        {
            SqlDataAdapter daCompanies = new SqlDataAdapter("SELECT ComID, Name FROM Company ORDER BY Name", con);
            DataTable dtCompanies = new DataTable();
            daCompanies.Fill(dtCompanies);
            checkedListBoxCompanies.DataSource = null;
            checkedListBoxCompanies.DataSource = dtCompanies;
            checkedListBoxCompanies.DisplayMember = "Name";
            checkedListBoxCompanies.ValueMember = "ComID";
        }

        private void buttonCompanyAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxCompanies.Items.Count; i++)
            {
                checkedListBoxCompanies.SetItemChecked(i, true);
            }
        }

        private void clearCompanyReport3()
        {
            for (int i = 0; i < checkedListBoxCompanies.Items.Count; i++)
            {
                checkedListBoxCompanies.SetItemChecked(i, false);
            }
        }

        private void buttonCompanyNone_Click(object sender, EventArgs e)
        {
            clearCompanyReport3();
        }

/* --------------------------------------------------------------------------------------------- */

        private void myButtonReport_Click(object sender, EventArgs e)
        {
            if (treeViewReports.Nodes[0].Nodes[0].IsSelected)
            {
                string searchAem = textBoxAEM.Text.ToString();
                if (searchAem == "")
                {
                    searchAem = "0";
                }

                string query = "Select Student.AEM, Student.LastName, Student.FirstName, Student.AFM, SupervisorTeacher.Name, Student.StartingDate, Student.EndingDate, Supervisor.Name, Company.Name from Student, SupervisorTeacher, Supervisor, Company where (Student.AEM = " + searchAem + ") AND (Student.SupervisorTeacher_TID = SupervisorTeacher.TID) AND (Supervisor.ID = Student.Supervisor_ID) AND (Company.ComID= Supervisor.Company_ComID) ";


                SqlDataAdapter daReport1 = new SqlDataAdapter(query, con);
            
                DataSet DataSetReportStudent1 = new DataSet();
                daReport1.Fill(DataSetReportStudent1);
                DataTable dtReport1 = new DataTable();
                DataSetReportStudent1.Tables.Add(dtReport1);
                DataSetReportStudent1.WriteXmlSchema("ReportStudent1.xml");

                ReportStudent1 cr = new ReportStudent1();
                cr.SetDataSource(DataSetReportStudent1);
                crystalReportViewer.ReportSource = cr;
            }

            if (treeViewReports.Nodes[0].Nodes[1].IsSelected)
            {
                string searchAem = textBoxAEM.Text.ToString();
                if (searchAem == "")
                {
                    searchAem = "0";
                }

                string query = "Select Student.AEM, Student.LastName, Student.FirstName, Student.AFM, SupervisorTeacher.Name, Student.StartingDate, Student.EndingDate, Supervisor.Name, Company.Name from Student, SupervisorTeacher, Supervisor, Company where (Student.AEM = " + searchAem + ") AND (Student.SupervisorTeacher_TID = SupervisorTeacher.TID) AND (Supervisor.ID = Student.Supervisor_ID) AND (Company.ComID= Supervisor.Company_ComID) ";


                SqlDataAdapter daReport1 = new SqlDataAdapter(query, con);

                DataSet DataSetReportStudent1 = new DataSet();
                daReport1.Fill(DataSetReportStudent1);
                DataTable dtReport1 = new DataTable();
                DataSetReportStudent1.Tables.Add(dtReport1);
                DataSetReportStudent1.WriteXmlSchema("ReportStudent1.xml");

                string query2 = "Select Contacts.type, Contacts.details from Contacts, Student WHERE  (Student.AEM = " + searchAem + ") AND (Student.StudID = Contacts.Student_ID)";


                SqlDataAdapter daReport2 = new SqlDataAdapter(query2, con);

                DataSet DataSetReportStudent2 = new DataSet();
                daReport2.Fill(DataSetReportStudent2);
                DataTable dtReport2 = new DataTable();
                DataSetReportStudent2.Tables.Add(dtReport2);
                DataSetReportStudent2.WriteXmlSchema("ReportStudent1c.xml");

                string query3 = "Select address + ' ' + number, city, zipcode from address, Student WHERE  (Student.AEM = " + searchAem + ") AND (Student.StudID = address.Student_StudID)";


                SqlDataAdapter daReport3 = new SqlDataAdapter(query3, con);

                DataSet DataSetReportStudent3 = new DataSet();
                daReport3.Fill(DataSetReportStudent3);
                DataTable dtReport3 = new DataTable();
                DataSetReportStudent3.Tables.Add(dtReport3);
                DataSetReportStudent3.WriteXmlSchema("ReportStudent1a.xml");




                ReportStudent5 cr = new ReportStudent5();
                cr.SetDataSource(DataSetReportStudent1);
                cr.Subreports["contacts"].SetDataSource(DataSetReportStudent2);
                cr.Subreports["address"].SetDataSource(DataSetReportStudent3);
                crystalReportViewer.ReportSource = cr;
                


            }


            if (treeViewReports.Nodes[0].Nodes[2].IsSelected)
            {

                string sqlquery = "Select Student.AEM, Student.LastName, Student.FirstName, Student.AFM, SupervisorTeacher.Name, Student.StartingDate, Student.EndingDate, Supervisor.Name, Company.Name from Student, SupervisorTeacher, Supervisor, Company where (Student.SupervisorTeacher_TID = SupervisorTeacher.TID) AND (Supervisor.ID = Student.Supervisor_ID) AND (Company.ComID= Supervisor.Company_ComID) AND (Student.EndingDate between '" + dateEndfrom + "' AND '" + dateEndUntil + "') AND (Student.StartingDate between '" + dateStartfrom + "' AND '" + dateStartUntil + "') ";
         
                sqlquery += "  AND ((TID = -1)";
                string tid;
                if (checkedListBoxTeacherStRpt.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBoxTeacherStRpt.CheckedItems.Count; i++)
                    {
                        tid = ((DataRowView)checkedListBoxTeacherStRpt.CheckedItems[i]).Row["TID"].ToString();
                        sqlquery += " or (TID ='" + tid + "')";
                    }
                }

                sqlquery += ") AND ((ComId = -1)";
                string ComId;
                if (checkedListBoxCompanyStRpt.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBoxCompanyStRpt.CheckedItems.Count; i++)
                    {
                        ComId = ((DataRowView)checkedListBoxCompanyStRpt.CheckedItems[i]).Row["ComId"].ToString();
                        sqlquery += " or (ComId ='" + ComId + "')";
                    }
                }
                sqlquery += ")";
         
                SqlDataAdapter daReport2 = new SqlDataAdapter(sqlquery, con);

                DataSet DataSetReportStudent2 = new DataSet();
                daReport2.Fill(DataSetReportStudent2);
                DataTable dtReport2 = new DataTable();
                DataSetReportStudent2.Tables.Add(dtReport2);
                DataSetReportStudent2.WriteXmlSchema("ReportStudent2.xml");

                ReportStudent2 cr = new ReportStudent2();
                cr.SetDataSource(DataSetReportStudent2);
                crystalReportViewer.ReportSource = cr;
                
            }
            if (treeViewReports.Nodes[0].Nodes[3].IsSelected)
            {
                string sqlquery = "Select Student.AEM, Student.LastName, Student.FirstName, Student.AFM, SupervisorTeacher.Name as 'SupervisorTeacher name', Student.StartingDate, Student.EndingDate, Supervisor.Name as 'Supervisor name', Company.Name as 'company name' from Student, SupervisorTeacher, Supervisor, Company where (Student.SupervisorTeacher_TID = SupervisorTeacher.TID) AND (Supervisor.ID = Student.Supervisor_ID) AND (Company.ComID= Supervisor.Company_ComID) AND (Student.EndingDate between '" + dateEndfrom + "' AND '" + dateEndUntil + "') AND (Student.StartingDate between '" + dateStartfrom + "' AND '" + dateStartUntil + "') ";

                sqlquery += "  AND ((TID = -1)";
                string tid;
                if (checkedListBoxTeacherStRpt.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBoxTeacherStRpt.CheckedItems.Count; i++)
                    {
                        tid = ((DataRowView)checkedListBoxTeacherStRpt.CheckedItems[i]).Row["TID"].ToString();
                        sqlquery += " or (TID ='" + tid + "')";
                    }
                }

                sqlquery += ") AND ((ComId = -1)";
                string ComId;
                if (checkedListBoxCompanyStRpt.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBoxCompanyStRpt.CheckedItems.Count; i++)
                    {
                        ComId = ((DataRowView)checkedListBoxCompanyStRpt.CheckedItems[i]).Row["ComId"].ToString();
                        sqlquery += " or (ComId ='" + ComId + "')";
                    }
                }
                sqlquery += ")";
         

                SqlDataAdapter daReport3 = new SqlDataAdapter(sqlquery, con);

                DataSet DataSetReportStudent3 = new DataSet();
                daReport3.Fill(DataSetReportStudent3);
                DataTable dtReport3 = new DataTable();
                DataSetReportStudent3.Tables.Add(dtReport3);
                DataSetReportStudent3.WriteXmlSchema("ReportStudent2.xml");

                ReportStudent3 cr = new ReportStudent3();
                cr.SetDataSource(DataSetReportStudent3);
                crystalReportViewer.ReportSource = cr;
            }

            if (treeViewReports.Nodes[0].Nodes[4].IsSelected)
            {
                string sqlquery = "Select Student.AEM, Student.LastName, Student.FirstName, Student.AFM, SupervisorTeacher.Name as 'SupervisorTeacher name', Student.StartingDate, Student.EndingDate, Supervisor.Name as 'Supervisor name', Company.Name as 'company name' from Student, SupervisorTeacher, Supervisor, Company where (Student.SupervisorTeacher_TID = SupervisorTeacher.TID) AND (Supervisor.ID = Student.Supervisor_ID) AND (Company.ComID= Supervisor.Company_ComID) AND (Student.EndingDate between '" + dateEndfrom + "' AND '" + dateEndUntil + "') AND (Student.StartingDate between '" + dateStartfrom + "' AND '" + dateStartUntil + "') ";
                sqlquery += "  AND ((TID = -1)";
                string tid;
                if (checkedListBoxTeacherStRpt.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBoxTeacherStRpt.CheckedItems.Count; i++)
                    {
                        tid = ((DataRowView)checkedListBoxTeacherStRpt.CheckedItems[i]).Row["TID"].ToString();
                        sqlquery += " or (TID ='" + tid + "')";
                    }
                }

                sqlquery += ") AND ((ComId = -1)";
                string ComId;
                if (checkedListBoxCompanyStRpt.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBoxCompanyStRpt.CheckedItems.Count; i++)
                    {
                        ComId = ((DataRowView)checkedListBoxCompanyStRpt.CheckedItems[i]).Row["ComId"].ToString();
                        sqlquery += " or (ComId ='" + ComId + "')";
                    }
                }
                sqlquery += ")";
         

                SqlDataAdapter daReport4 = new SqlDataAdapter(sqlquery, con);

                DataSet DataSetReportStudent4 = new DataSet();
                daReport4.Fill(DataSetReportStudent4);
                DataTable dtReport4 = new DataTable();
                DataSetReportStudent4.Tables.Add(dtReport4);
                DataSetReportStudent4.WriteXmlSchema("ReportStudent3.xml");

                ReportStudent4 cr = new ReportStudent4();
                cr.SetDataSource(DataSetReportStudent4);
                crystalReportViewer.ReportSource = cr;
            }
           
            if (treeViewReports.Nodes[1].Nodes[0].IsSelected)
            {
                
                if (selectedTeacher == "")
                {
                    selectedTeacher = "0";
                }

                string query = "Select * FROM SupervisorTeacher WHERE TID = '" + selectedTeacher + "'";


                SqlDataAdapter daReport1 = new SqlDataAdapter(query, con);

                DataSet DataSetReportTeacher1 = new DataSet();
                daReport1.Fill(DataSetReportTeacher1);
                DataTable dtReport1 = new DataTable();
                DataSetReportTeacher1.Tables.Add(dtReport1);
                DataSetReportTeacher1.WriteXmlSchema("ReportTeacher1.xml");

                ReportTeacher1 cr = new ReportTeacher1();
                cr.SetDataSource(DataSetReportTeacher1);
                crystalReportViewer.ReportSource = cr;
            }

            if (treeViewReports.Nodes[1].Nodes[1].IsSelected)
            {


                string query = "Select * FROM SupervisorTeacher WHERE (TID = '-1')";
                string tid;
                if (checkedListBoxTeachers.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBoxTeachers.CheckedItems.Count; i++)
                    {
                        tid = ((DataRowView)checkedListBoxTeachers.CheckedItems[i]).Row["TID"].ToString();
                            query = query + " or (TID ='" + tid + "')";                                           
                    }
                }                                             

                SqlDataAdapter daReport2 = new SqlDataAdapter(query, con);

                DataSet DataSetReportTeacher2 = new DataSet();
                daReport2.Fill(DataSetReportTeacher2);
                DataTable dtReport2 = new DataTable();
                DataSetReportTeacher2.Tables.Add(dtReport2);
                DataSetReportTeacher2.WriteXmlSchema("ReportTeacher2.xml");

                ReportTeacher2 cr = new ReportTeacher2();
                cr.SetDataSource(DataSetReportTeacher2);
                crystalReportViewer.ReportSource = cr;
            }
            if (treeViewReports.Nodes[2].Nodes[0].IsSelected)
            {

                if (selectedCompany == "")
                {
                    selectedCompany = "0";
                }

                string query = "Select * FROM Company, CompanyType WHERE (ComID = '" + selectedCompany + "') and (CompanyType.typeId = Company.CompanyType_TypeID)";


                SqlDataAdapter daReport1 = new SqlDataAdapter(query, con);

                DataSet DataSetReportCompany1 = new DataSet();
                daReport1.Fill(DataSetReportCompany1);
                DataTable dtReport1 = new DataTable();
                DataSetReportCompany1.Tables.Add(dtReport1);
                DataSetReportCompany1.WriteXmlSchema("ReportCompany1.xml");



                string query2 = "Select Type, CompanyContacts.details from CompanyContacts, Company WHERE (ComID = '" + selectedCompany + "') AND (Company.ComID=CompanyContacts.Company_ComID) ";

                SqlDataAdapter daReport2 = new SqlDataAdapter(query2, con);

                DataSet DataSetReportCompany2 = new DataSet();
                daReport2.Fill(DataSetReportCompany2);
                DataTable dtReport2 = new DataTable();
                DataSetReportCompany2.Tables.Add(dtReport2);
                DataSetReportCompany2.WriteXmlSchema("ReportCompany1c.xml");



                ReportCompany1 cr = new ReportCompany1();
                cr.SetDataSource(DataSetReportCompany1);
                cr.Subreports["contacts"].SetDataSource(DataSetReportCompany2);
                crystalReportViewer.ReportSource = cr;
            }

            if (treeViewReports.Nodes[2].Nodes[1].IsSelected)
            {

                if (selectedCompany == "")
                {
                    selectedCompany = "0";
                }

                string query = "Select * FROM Company, CompanyType WHERE (ComID = '" + selectedCompany + "') and (CompanyType.typeId = Company.CompanyType_TypeID)";


                SqlDataAdapter daReport1 = new SqlDataAdapter(query, con);

                DataSet DataSetReportCompany1 = new DataSet();
                daReport1.Fill(DataSetReportCompany1);
                DataTable dtReport1 = new DataTable();
                DataSetReportCompany1.Tables.Add(dtReport1);
                DataSetReportCompany1.WriteXmlSchema("ReportCompany2.xml");



                string query2 = "Select Type, CompanyContacts.details from CompanyContacts, Company WHERE (ComID = '" + selectedCompany + "') AND (Company.ComID = CompanyContacts.Company_ComID) ";

                SqlDataAdapter daReport2 = new SqlDataAdapter(query2, con);

                DataSet DataSetReportCompany2 = new DataSet();
                daReport2.Fill(DataSetReportCompany2);
                DataTable dtReport2 = new DataTable();
                DataSetReportCompany2.Tables.Add(dtReport2);
                DataSetReportCompany2.WriteXmlSchema("ReportCompany2c.xml");

                string query3 = "Select Supervisor.Name, Supervisor.Position from Supervisor, Company WHERE (ComID = '" + selectedCompany + "') AND (Company.ComID = Supervisor.Company_ComID) ";

                SqlDataAdapter daReport3 = new SqlDataAdapter(query3, con);

                DataSet DataSetReportCompany3 = new DataSet();
                daReport3.Fill(DataSetReportCompany3);
                DataTable dtReport3 = new DataTable();
                DataSetReportCompany3.Tables.Add(dtReport3);
                DataSetReportCompany3.WriteXmlSchema("ReportCompany2s.xml");


                ReportCompany2 cr = new ReportCompany2();
                cr.SetDataSource(DataSetReportCompany1);
                cr.Subreports["contacts"].SetDataSource(DataSetReportCompany2);
                cr.Subreports["supervisors"].SetDataSource(DataSetReportCompany3);
                crystalReportViewer.ReportSource = cr;
            }
            if (treeViewReports.Nodes[2].Nodes[2].IsSelected || treeViewReports.Nodes[2].Nodes[3].IsSelected || treeViewReports.Nodes[2].Nodes[4].IsSelected || treeViewReports.Nodes[2].Nodes[5].IsSelected)
            {
                string query = "Select Company.Name, Company.AFM, Company.LegalForm, Company.Address + ' ' + Company.Number + ' ' + Company.ZipCode as 'AddressFull', Company.City, CompanyType.Name FROM Company INNER JOIN companyType ON Company.CompanyType_TypeID = companyType.TypeId WHERE (ComID = '-1')";
                string ComID;
                if (checkedListBoxCompanies.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBoxCompanies.CheckedItems.Count; i++)
                    {
                        ComID = ((DataRowView)checkedListBoxCompanies.CheckedItems[i]).Row["ComID"].ToString();
                        query = query + " or (ComID ='" + ComID + "')";

                    }
                }




                SqlDataAdapter daReport3 = new SqlDataAdapter(query, con);

                DataSet DataSetReportCompany3 = new DataSet();
                daReport3.Fill(DataSetReportCompany3);
                DataTable dtReport3 = new DataTable();
                DataSetReportCompany3.Tables.Add(dtReport3);
                DataSetReportCompany3.WriteXmlSchema("ReportCompany3.xml");
                if (treeViewReports.Nodes[2].Nodes[2].IsSelected)
                {
                    ReportCompany3 cr = new ReportCompany3();
                    cr.SetDataSource(DataSetReportCompany3);
                    crystalReportViewer.ReportSource = cr;
                }
                if (treeViewReports.Nodes[2].Nodes[3].IsSelected)
                {
                    ReportCompany4 cr = new ReportCompany4();
                    cr.SetDataSource(DataSetReportCompany3);
                    crystalReportViewer.ReportSource = cr;
                }
                if (treeViewReports.Nodes[2].Nodes[4].IsSelected)
                {
                    ReportCompany5 cr = new ReportCompany5();
                    cr.SetDataSource(DataSetReportCompany3);
                    crystalReportViewer.ReportSource = cr;
                }
                if (treeViewReports.Nodes[2].Nodes[5].IsSelected)
                {
                    ReportCompany6 cr = new ReportCompany6();
                    cr.SetDataSource(DataSetReportCompany3);
                    crystalReportViewer.ReportSource = cr;
                }
            }
            
        }

        private void treeViewReports_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewReports.Nodes[0].Nodes[0].IsSelected || treeViewReports.Nodes[0].Nodes[1].IsSelected)
            {
                panelStudent1.Visible = true;
                panelStudent2.Visible = false;
                panelTeacher1.Visible = false;
                panelTeacher2.Visible = false;
                panelCompanies1.Visible = false;
                panelCompanies2.Visible = false;
            }
            if (treeViewReports.Nodes[0].Nodes[2].IsSelected || treeViewReports.Nodes[0].Nodes[3].IsSelected || treeViewReports.Nodes[0].Nodes[4].IsSelected)
            {
                panelStudent1.Visible = false;
                panelStudent2.Visible = true;
                panelTeacher1.Visible = false;
                panelTeacher2.Visible = false;
                panelCompanies1.Visible = false;
                panelCompanies2.Visible = false;

            }
            if (treeViewReports.Nodes[1].Nodes[0].IsSelected)
            {
                panelTeacher1.Visible = true;
                panelStudent1.Visible = false;
                panelStudent2.Visible = false;
                panelTeacher2.Visible = false;
                panelCompanies1.Visible = false;
                panelCompanies2.Visible = false;
            }
            if (treeViewReports.Nodes[1].Nodes[1].IsSelected)
            {
                panelTeacher1.Visible = false;
                panelStudent1.Visible = false;
                panelStudent2.Visible = false;
                panelTeacher2.Visible = true;
                panelCompanies1.Visible = false;
                panelCompanies2.Visible = false;
            }
            if (treeViewReports.Nodes[2].Nodes[0].IsSelected || treeViewReports.Nodes[2].Nodes[1].IsSelected)
            {
                panelTeacher1.Visible = false;
                panelStudent1.Visible = false;
                panelStudent2.Visible = false;
                panelTeacher2.Visible = false;
                panelCompanies1.Visible = true;
                panelCompanies2.Visible = false;

            }
            if (treeViewReports.Nodes[2].Nodes[2].IsSelected || treeViewReports.Nodes[2].Nodes[3].IsSelected || treeViewReports.Nodes[2].Nodes[4].IsSelected || treeViewReports.Nodes[2].Nodes[5].IsSelected)
            {
                panelTeacher1.Visible = false;
                panelStudent1.Visible = false;
                panelStudent2.Visible = false;
                panelTeacher2.Visible = false;
                panelCompanies1.Visible = false;
                panelCompanies2.Visible = true;

            }

        }

        private void myButtonClear_Click(object sender, EventArgs e)
        {
            if (treeViewReports.Nodes[0].Nodes[0].IsSelected || treeViewReports.Nodes[0].Nodes[1].IsSelected)
            {
                clearStudentReport1();
            }
            if (treeViewReports.Nodes[0].Nodes[2].IsSelected || treeViewReports.Nodes[0].Nodes[3].IsSelected || treeViewReports.Nodes[0].Nodes[4].IsSelected)
            {
                ClearStudentReport2();
                clearCheckListBoxes();
            }
            if (treeViewReports.Nodes[1].Nodes[0].IsSelected)
            {
                clearTeachersReport();
            }
            if (treeViewReports.Nodes[1].Nodes[1].IsSelected)
            {
                clearTeachersReport2();
            }
            if (treeViewReports.Nodes[2].Nodes[0].IsSelected || treeViewReports.Nodes[2].Nodes[1].IsSelected)
            {
                clearCompanyReport1();
            }
            if (treeViewReports.Nodes[2].Nodes[2].IsSelected || treeViewReports.Nodes[2].Nodes[3].IsSelected || treeViewReports.Nodes[2].Nodes[4].IsSelected || treeViewReports.Nodes[2].Nodes[5].IsSelected)
            {
                clearCompanyReport3();
            }
        }

        
    }
}
