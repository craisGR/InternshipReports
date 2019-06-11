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
    public partial class FormViewSingleStudent : Form
    {
        SqlDataAdapter DaAddr,DaCont;
        DataSet DsAddr, DsCont;
        BindingSource BsAddr, BsCont;
        SqlConnection con;
        public string selectedStudentID { get; set; }
        public bool view { get; set; }
        string selectedCompanyID, editContactId, editAddressId, details, startdate, enddate, selectedSupervisorID, selectedTeacherID;
        int selectedContactRow, selectedAddressRow, contactIndex, addressIndex;        
        bool editContact = false, editAddress = false;     
        
        public FormViewSingleStudent()
        {
            InitializeComponent();

            con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();

            dateTimePickerStart.CustomFormat = "dd/MM/yyyy";
            dateTimePickerEnd.CustomFormat = "dd/MM/yyyy";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;

            showTooltips();

            //disable contact Editing if there is no Contacts
            if (dataGridViewContact.RowCount == 0) 
            {
                buttonEditContact.Enabled = false;
                buttonContactDelete.Enabled = false;
            }

            //disable Address Editing if there is no Addresses
            if (dataGridViewAddress.RowCount == 0)
            {
                buttonEditAddress.Enabled = false;
                buttonAddressDelete.Enabled = false;
            }            
        }


        private void loadCompanyCombobox()
        {
            SqlDataAdapter daCompany = new SqlDataAdapter("SELECT ComID, Name FROM Company ORDER BY Name", con);
            DataTable dtCompany = new DataTable();
            daCompany.Fill(dtCompany);
            comboBoxViewCompany.DataSource = dtCompany;
            string displayTextCompany = "Name";
            string displayIDCompany = "ComID";
            comboBoxViewCompany.DisplayMember = displayTextCompany;
            comboBoxViewCompany.ValueMember = displayIDCompany;
        }


        private void fillDataSet()
        {                       
            loadAddressContact(selectedStudentID);
            loadTeacherCombobox();
            loadCompanyCombobox();
                   
        }

        private void loadTeacherCombobox()
        {
            SqlDataAdapter daTeacher = new SqlDataAdapter("SELECT TID, Name FROM SupervisorTeacher ORDER BY name", con);
            DataTable dtTeacher = new DataTable();
            daTeacher.Fill(dtTeacher);
            comboBoxViewTeacher.DataSource = dtTeacher;
            string displayTextTeacher = "Name";
            string displayIDTeacher = "TID";
            comboBoxViewTeacher.DisplayMember = displayTextTeacher;
            comboBoxViewTeacher.ValueMember = displayIDTeacher;
        }

        private void FormViewSingleStudent_Load(object sender, EventArgs e)
        {            
            if (view)
            {   //edit Student           
                fillDataSet();
                fillSingleStudentForm();
                fillSingleStudentDetails();
            }
            else //Add new Student            
            {   //Add new Student 
                enableEdit();
                buttonEditSupervisor.Enabled = false;
                toolStripCreate.Enabled = false;
                toolStripButtonRestore.Enabled = true;
                toolStripButtonEdit.Enabled = false;
                toolStripButtonSave.Enabled = false;
                buttonContactNew.Enabled = false;
                buttonAddressNew.Enabled = false;
                buttonDetailsEdit.Enabled = false;
                fillDataSet();

                pictureBoxErrorAEM.Visible = true;
                pictureBoxErrorAFM.Visible = true;
                pictureBoxErrorCompany.Visible = true;
                pictureBoxErrorSupervisor.Visible = true;
                pictureBoxErrorTeacher.Visible = true;
                pictureBoxErrotFatherName.Visible = true;
                pictureBoxErrotFirstName.Visible = true;
                pictureBoxErrotLastName.Visible = true;
                //tabControlInfo.Visible = false;
                panelContacts.Visible = false;
                panelAddress.Visible = false;
                panelDetails.Visible = false;
            }
            dataGridViewContact.Columns["CID"].Visible = false;
            dataGridViewAddress.Columns["AID"].Visible = false;            
        }

        private void fillSingleStudentForm()
        {
            SqlCommand cmdRestore = con.CreateCommand();
            cmdRestore.CommandType = CommandType.Text;
            cmdRestore.CommandText = "Select AEM, LastName, FirstName, FatherName, Student.AFM AS 'AFM', SupervisorTeacher.Name AS 'TeacherName',SupervisorTeacher.TID AS 'TeacherID', StartingDate, EndingDate,Supervisor.ID AS 'SupervisorID', Supervisor.Name AS 'SupervisoreName',Company.ComID AS 'ComID', Company.Name AS 'CompanyName' from Student, SupervisorTeacher, Supervisor, Company where (Student.SupervisorTeacher_TID = SupervisorTeacher.TID) AND (Supervisor.ID = Student.Supervisor_ID) AND (Company.ComID= Supervisor.Company_ComID) AND (Student.StudId = '" + selectedStudentID + "')";
            DataTable dtRestore = new DataTable();
            SqlDataAdapter daRestore = new SqlDataAdapter(cmdRestore);
            daRestore.Fill(dtRestore);
            foreach (DataRow drRestore in dtRestore.Rows)
            {
                //set in the textboxes the saved values
                textBoxViewSingleStudentFirstName.Text = drRestore["FirstName"].ToString();
                textBoxViewSingleStudentLastName.Text = drRestore["LastName"].ToString();
                textBoxViewSingleStudentAEM.Text = drRestore["AEM"].ToString();
                textBoxViewSingleStudentAFM.Text = drRestore["AFM"].ToString();
                textBoxViewSingleFathersName.Text = drRestore["FatherName"].ToString();
                textBoxViewSingleTeacher.Text = drRestore["TeacherName"].ToString();
                textBoxViewSingleCompany.Text = drRestore["CompanyName"].ToString();
                textBoxViewSingleSupervisor.Text = drRestore["SupervisoreName"].ToString();
                startdate = drRestore["StartingDate"].ToString(); //save the date in string form
                enddate = drRestore["EndingDate"].ToString(); //save the date in string form
                selectedCompanyID = drRestore["ComID"].ToString();
                selectedSupervisorID = drRestore["SupervisorID"].ToString();
                selectedTeacherID = drRestore["TeacherID"].ToString();
            }
            // convert  the sting form of the dates to DateTime format 
            DateTime myDateStart = DateTime.ParseExact(startdate, "d/M/yyyy h:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);
            DateTime myDateEnd = DateTime.ParseExact(enddate, "d/M/yyyy h:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);

            //set the dates to DateTimePickers
            dateTimePickerStart.Value = myDateStart;
            dateTimePickerEnd.Value = myDateEnd;            

            cmdRestore.ExecuteNonQuery(); //execute query
        }

        private void fillSingleStudentDetails()
        {
            SqlCommand cmdRestore = con.CreateCommand();
            cmdRestore.CommandType = CommandType.Text;
            cmdRestore.CommandText = "Select details from Student WHERE StudId = '" + selectedStudentID + "'";
            DataTable dtRestore = new DataTable();
            SqlDataAdapter daRestore = new SqlDataAdapter(cmdRestore);
            daRestore.Fill(dtRestore);
            foreach (DataRow drRestore in dtRestore.Rows)
            {
                richTextBoxNotes.Text = drRestore["details"].ToString();
            }
            cmdRestore.ExecuteNonQuery(); //execute query
        }


        /* ---------- Teacher edit ---------- */

        private void buttonEditTeacher_Click(object sender, EventArgs e)
        {            
            buttonTeacherChecked.Enabled = false;           
            comboBoxViewTeacher.Visible = true;
            buttonTeacherChecked.Visible = true;
            buttonTeacherNonChecked.Visible = true;
            buttonNewTeacher.Visible = true;
            buttonEditTeacher.Visible = false;
            textBoxViewSingleTeacher.Visible = false;
            comboBoxViewTeacher.SelectedIndex = -1;                         
        }

        private void buttonTeacherNonChecked_Click(object sender, EventArgs e)
        {
            comboBoxViewTeacher.Visible = false;
            textBoxViewSingleTeacher.Visible = true;
            buttonTeacherChecked.Visible = false;
            buttonTeacherNonChecked.Visible = false;
            buttonNewTeacher.Visible = false;
            buttonEditTeacher.Visible = true;
        }

        private void buttonTeacherChecked_Click(object sender, EventArgs e)
        {
            textBoxViewSingleTeacher.Text = comboBoxViewTeacher.Text.ToString();
            selectedTeacherID = comboBoxViewTeacher.SelectedValue.ToString();
            textBoxViewSingleTeacher.Visible = true;
            comboBoxViewTeacher.Visible = false;
            buttonTeacherChecked.Visible = false;
            buttonTeacherNonChecked.Visible = false;
            buttonNewTeacher.Visible = false;
            buttonEditTeacher.Visible = true;
        }

        private void comboBoxViewTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonTeacherChecked.Enabled = true;
        }
        /* ---------- End Teacher edit ---------- */


        /* ---------- Company edit ---------- */

        private void buttonEditCompany_Click(object sender, EventArgs e)
        {
            // enable edit features for Company
            comboBoxViewCompany.SelectedIndex = -1;
            buttonCompanyChecked.Enabled = false;
            comboBoxViewCompany.Visible = true;
            buttonCompanyChecked.Visible = true;
            buttonCompanyNonChecked.Visible = true;
            buttonNewCompany.Visible = true;
            buttonEditCompany.Visible = false;
            buttonEditSupervisor.Enabled = false;
            textBoxViewSingleCompany.Visible = false;            
        }

        private void buttonCompanyChecked_Click(object sender, EventArgs e)
        {
            // set the selected company
            textBoxViewSingleCompany.Text = comboBoxViewCompany.Text.ToString();

            // if editing company is enabled and there isnt a selected company check button is disabled
            if (comboBoxViewCompany.SelectedIndex == -1)
            {
                buttonCompanyChecked.Enabled = false;
            }

            // if selected company is changed   a supervisor must be Selected from the selected company
            if (comboBoxViewCompany.SelectedValue.ToString() != selectedCompanyID)
            {
                textBoxViewSingleSupervisor.Text = "";
                selectedCompanyID = comboBoxViewCompany.SelectedValue.ToString();                
                buttonSupervisorRoutine();
                buttonSupervisorNonChecked.Enabled = false;
                loadSupervisorCombobox();
                if (comboBoxViewSupervisor.SelectedIndex == -1)
                {
                    buttonSupervisorChecked.Enabled = false;//a new supervisor must be selected 
                    toolStripButtonSave.Enabled = false; //disable saving until a new supervisor is selected
                }
                else
                {
                    comboBoxViewSupervisor.SelectedIndex = 0;
                    pictureBoxErrorSupervisor.Visible = true;//visual notice
                    toolStripButtonSave.Enabled = false; //disable saving until a new supervisor is selected     
                }
                          
                                     
            }

            //close edit features from company and make visible the view features
            comboBoxViewCompany.Visible = false;
            buttonCompanyChecked.Visible = false;
            buttonCompanyNonChecked.Visible = false;
            buttonNewCompany.Visible = false;
            buttonEditCompany.Visible = true;
            buttonEditSupervisor.Enabled = true;
            textBoxViewSingleCompany.Visible = true;
        }

        private void buttonCompanyNonChecked_Click(object sender, EventArgs e)
        {
            //close edit features from company and make visible the view features with no changings
            comboBoxViewCompany.Visible = false;
            buttonCompanyChecked.Visible = false;
            buttonCompanyNonChecked.Visible = false;
            buttonNewCompany.Visible = false;
            buttonEditCompany.Visible = true;
            if (view)
            {
                buttonEditSupervisor.Enabled = true;
            }
            else
            {
                buttonEditSupervisor.Enabled = false;
            }
            
            textBoxViewSingleCompany.Visible = true;
        }

        private void comboBoxViewCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable ckecked button after a company is selected 
            buttonCompanyChecked.Enabled = true;
        }
        /* ----------End Company edit ---------- */


        /* ---------- Supervisor edit ---------- */

        private void buttonEditSupervisor_Click(object sender, EventArgs e)
        {
            // if editing superrvisor is enabled and there isnt a selected supervisor check button is disabled
            buttonSupervisorRoutine();
            buttonNewSupervisor.Visible = true;
            if (comboBoxViewSupervisor.SelectedIndex == -1)
            {
                buttonSupervisorChecked.Enabled = false;
            }
        }

        private void buttonSupervisorChecked_Click(object sender, EventArgs e)
        {
            // set the new supervisor close edit features from supervisor and make visible the view features
            textBoxViewSingleSupervisor.Text = comboBoxViewSupervisor.Text.ToString();
            comboBoxViewSupervisor.Visible = false;
            buttonSupervisorChecked.Visible = false;
            buttonSupervisorNonChecked.Visible = false;
            buttonNewSupervisor.Visible = false;
            buttonEditSupervisor.Visible = true;
            buttonEditCompany.Enabled = true;
            textBoxViewSingleSupervisor.Visible = true;
            selectedSupervisorID = comboBoxViewSupervisor.SelectedValue.ToString();
        }

        private void buttonSupervisorNonChecked_Click(object sender, EventArgs e)
        {
            //close edit features from supervisor and make visible the view features with no changings
            comboBoxViewSupervisor.Visible = false;
            buttonSupervisorChecked.Visible = false;
            buttonSupervisorNonChecked.Visible = false;
            buttonNewSupervisor.Visible = false;
            buttonEditSupervisor.Visible = true;
            buttonEditCompany.Enabled = true;
            textBoxViewSingleSupervisor.Visible = true;
        }


        private void loadSupervisorCombobox()
        {
            //load supervisors from the selected company
            SqlDataAdapter daSupervisor = new SqlDataAdapter("SELECT Supervisor.ID, Supervisor.Name FROM Supervisor INNER JOIN Company ON Company_ComID = ComID Where Company.ComID ='" + selectedCompanyID + "'", con);
            DataTable dtSupervisor = new DataTable();
            daSupervisor.Fill(dtSupervisor);
            comboBoxViewSupervisor.DataSource = dtSupervisor;
            string displayTextSupervisor = "Name";
            string displayIDSupervisor = "ID";
            comboBoxViewSupervisor.DisplayMember = displayTextSupervisor;
            comboBoxViewSupervisor.ValueMember = displayIDSupervisor;
            //comboBoxViewSupervisor.SelectedIndex = -1;
        }

        private void buttonSupervisorRoutine()
        {
            loadSupervisorCombobox();

            // make visible the features to edit supervisor
            comboBoxViewSupervisor.Visible = true;
            buttonSupervisorChecked.Visible = true;
            buttonNewSupervisor.Visible = true;
            buttonSupervisorNonChecked.Visible = true;
            buttonEditSupervisor.Visible = false;
            buttonEditCompany.Enabled = false;
            textBoxViewSingleSupervisor.Visible = false;        
        }

        private void comboBoxViewSupervisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable ckecked button after a supervisor is selected 
            buttonSupervisorChecked.Enabled = true;
        }
        /* ----------End Supervisor edit ---------- */


        /* ----------Edit Button ---------- */
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            //enable edit features when edit button is clicked
            enableEdit();
            checkAFM();
        }


        /* ----------Save Button ---------- */
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {          
                //save changes and disable edit features
                updateField();
                disaleEdit();
                checkAFM();
        }

        /* ---------- Check valid AFM ---------- */
       
        private void textBoxViewSingleStudentAFM_TextChanged(object sender, EventArgs e)
        {
            checkAFM();
            checkBlankField(textBoxViewSingleStudentAFM, pictureBoxErrorAFM);
        }

        private void checkAFM()
        {

            if (Intership.Repo.AFM.ValidateAFM(textBoxViewSingleStudentAFM.Text.ToString()))
            {   //visual effects for a valid AFM
                pictureBoxCorrect.Visible = true;
                pictureBoxWrong.Visible = false;
            }
            else
            {   //visual effects for an  invalid AFM
                pictureBoxCorrect.Visible = false;
                pictureBoxWrong.Visible = true;
            }
        }

        /* ---------- End Check valid AFM ---------- */


        /* ---------- Configure edit ---------- */

        private void disaleEdit()
        {
            //make all edit features disabled
            toolStripButtonSave.Enabled = false;
            toolStripButtonEdit.Enabled = true;
            toolStripCreate.Enabled = true;
            buttonEditCompany.Enabled = false;
            buttonEditSupervisor.Enabled = false;
            buttonEditTeacher.Enabled = false;
            buttonNewCompany.Visible = false;
            buttonNewSupervisor.Visible = false;
            buttonNewTeacher.Visible = false;
            textBoxViewSingleStudentLastName.ReadOnly = true;
            textBoxViewSingleStudentFirstName.ReadOnly = true;
            textBoxViewSingleStudentAEM.ReadOnly = true;
            textBoxViewSingleStudentAFM.ReadOnly = true;
            textBoxViewSingleCompany.Visible = true;
            textBoxViewSingleSupervisor.Visible = true;
            textBoxViewSingleTeacher.Visible = true;
            textBoxViewSingleFathersName.ReadOnly = true;
            buttonEditTeacher.Visible = true;
            buttonEditSupervisor.Visible = true;
            buttonEditCompany.Visible = true;
            comboBoxViewCompany.Visible = false;
            buttonCompanyChecked.Visible = false;
            buttonCompanyNonChecked.Visible = false;
            comboBoxViewTeacher.Visible = false;
            buttonTeacherChecked.Visible = false;
            buttonTeacherNonChecked.Visible = false;
            comboBoxViewSupervisor.Visible = false;
            buttonSupervisorChecked.Visible = false;
            buttonSupervisorNonChecked.Visible = false;
            dateTimePickerStart.Enabled = false;
            dateTimePickerEnd.Enabled = false;
            toolStripButtonRestore.Enabled = false; 
        }

        private void enableEdit()
        {
            //make all edit features enabled
            toolStripButtonSave.Enabled = true;
            toolStripButtonEdit.Enabled = false;
            toolStripCreate.Enabled = false;
            buttonEditCompany.Enabled = true;
            buttonEditSupervisor.Enabled = true;
            buttonEditTeacher.Enabled = true;            
            textBoxViewSingleStudentLastName.ReadOnly = false;
            textBoxViewSingleStudentFirstName.ReadOnly = false;
            textBoxViewSingleStudentAEM.ReadOnly = false;
            textBoxViewSingleStudentAFM.ReadOnly = false;
            textBoxViewSingleFathersName.ReadOnly = false;
            dateTimePickerStart.Enabled = true;
            dateTimePickerEnd.Enabled = true;
            toolStripButtonRestore.Enabled = true;     
        }

        /* ---------- Update a record  ---------- */
        private void updateField()
        {
            string setAFM, setlastname, setFirstName, SetSupervisorId, SetTeacherId,  setΑΕΜ, setFatherName, setStartingTime, setEndingtingTime;

            //colect all parametrs either they hab been changed ir not
            setlastname = textBoxViewSingleStudentLastName.Text.ToString();
            setFirstName = textBoxViewSingleStudentFirstName.Text.ToString();
            setAFM = textBoxViewSingleStudentAFM.Text.ToString();
            setΑΕΜ = textBoxViewSingleStudentAEM.Text.ToString();
            setFatherName = textBoxViewSingleFathersName.Text.ToString();
            setStartingTime = dateTimePickerStart.Value.Month.ToString() + "/" + dateTimePickerStart.Value.Day.ToString() + "/" + dateTimePickerStart.Value.Year.ToString();
            setEndingtingTime = dateTimePickerEnd.Value.Month.ToString() + "/" + dateTimePickerEnd.Value.Day.ToString() + "/" + dateTimePickerEnd.Value.Year.ToString();
            SetSupervisorId = selectedSupervisorID;
            SetTeacherId = selectedTeacherID;           
            //company id is not needed for updated the record due to the Supervisor from a company are unique

            if (view)
            {
                //constract the UPDATE query
                SqlCommand commandsave = con.CreateCommand();
                commandsave.CommandType = CommandType.Text;
                commandsave.CommandText = "UPDATE Student SET aem = '" + setΑΕΜ + "', Lastname = '" + setlastname + "', FirstName = '" + setFirstName + "', AFM = '" + setAFM + "', FatherName = '" + setFatherName + "', SupervisorTeacher_TID = '" + SetTeacherId + "', StartingDate = '" + setStartingTime + "', EndingDate = '" + setEndingtingTime + "', Supervisor_ID = '" + SetSupervisorId + "', details = '" + details + "' WHERE StudID = '" + selectedStudentID + "'";
                commandsave.ExecuteNonQuery();
                MessageBox.Show("Η Εγγραφή Ενημερώθηκε", "Ενημέρωση Εγγραφής",MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation message
            }
            else
            {
                //constract the INSERT query
                SqlCommand commandsave = con.CreateCommand();
                commandsave.CommandType = CommandType.Text;
                commandsave.CommandText = "INSERT into Student (aem, Lastname, FirstName, AFM, FatherName, SupervisorTeacher_TID, StartingDate, EndingDate, Supervisor_ID, details) values ('" + setΑΕΜ + "', '" + setlastname + "', '" + setFirstName + "', '" + setAFM + "', '" + setFatherName + "', '" + SetTeacherId + "', '" + setStartingTime + "', '" + setEndingtingTime + "', '" + SetSupervisorId + "', '" + details + "')";
                commandsave.ExecuteNonQuery();
                MessageBox.Show("Η Εγγραφή Αποθηκεύτηκε", "Αποθήκευση Εγγραφής", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation message

                //recover the Id from the New record
                SqlCommand cmdFindId = con.CreateCommand();
                cmdFindId.CommandType = CommandType.Text;
                cmdFindId.CommandText = "SELECT StudID FROM Student ORDER BY StudID";
                DataTable dtFindId = new DataTable();
                SqlDataAdapter daFindId = new SqlDataAdapter(cmdFindId);
                daFindId.Fill(dtFindId);
                foreach (DataRow drFindId in dtFindId.Rows)
                {
                    selectedStudentID = drFindId["StudID"].ToString();
                }
                cmdFindId.ExecuteNonQuery();

                //allow to add Adderss and Contact Info
                buttonAddressNew.Enabled = true;
                buttonContactNew.Enabled = true;
                buttonDetailsEdit.Enabled = true;
                view = true; //return to view feature
                //tabControlInfo.Visible = true;
                panelContacts.Visible = true;
                panelAddress.Visible = true;
                panelDetails.Visible = true;
            }
        }

        
        /* ----------End Configure edit ---------- */

        private void toolStripButtonRestore_Click(object sender, EventArgs e)
        {
            if (view) //for editing a contact
            {
                //restore all unsaved editings to previus record

                fillSingleStudentForm();               
                disaleEdit(); //disable the edit features after the restore action
            }
            else //for adding new Student
            {
                clearFieleds();
                buttonSupervisorChecked.Visible = false;
                buttonSupervisorNonChecked.Visible = false;
                comboBoxViewSupervisor.Visible = false;
                textBoxViewSingleSupervisor.Visible = true;
                buttonEditSupervisor.Visible = true;
                buttonEditSupervisor.Enabled = false;
                buttonEditCompany.Enabled = true;
            }

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //check if Startig date is after the ending Date. time paradox!!!

            if (dateTimePickerStart.Value >= dateTimePickerEnd.Value)
            {
                toolStripButtonSave.Enabled = false; //disable save
                pictureBoxErrorDuration.Visible = true;//visual alert
            }
            else if (dateTimePickerStart.Value < dateTimePickerEnd.Value)
            {
                // only if editing mode is enabled and "time paradox" don't exist save button is enabled
                if (!toolStripButtonEdit.Enabled)
                {
                    toolStripButtonSave.Enabled = true; //enable save
                }
                pictureBoxErrorDuration.Visible = false; //disable visual alert
            }
        }

        private void loadAddressContact(string studentid)
        {
            // load Address list from the selected Student ID 
            DaAddr = new SqlDataAdapter("Select AID, Address as 'Οδός', Number as 'Αριθμός', City as 'Πόλη', ZipCode as 'Ταχ. Κώδικας' FROM Address Where Student_StudID ='" + studentid + "'", con);
            DsAddr = new DataSet();
            DaAddr.Fill(DsAddr);
            BsAddr = new BindingSource();
            BsAddr.DataSource = DsAddr.Tables[0].DefaultView;
            dataGridViewAddress.DataSource = BsAddr;

            // load Contact list from the selected Student ID 
            DaCont = new SqlDataAdapter("Select CID, Type as 'Είδος Επαφής', Details as 'Λεπτομέριες' FROM Contacts Where Student_ID ='" + studentid + "'", con);
            DsCont = new DataSet();
            DaCont.Fill(DsCont);
            BsCont = new BindingSource();
            BsCont.DataSource = DsCont.Tables[0].DefaultView;
            
            dataGridViewContact.DataSource = BsCont;
            
            
        }

        private void toolStripCreate_Click(object sender, EventArgs e)
        {   //Make preparations to add new Student
            selectedStudentID = null;
            selectedCompanyID = null;
            clearFieleds();
            enableEdit();
            toolStripButtonRestore.Enabled = true;
            toolStripButtonSave.Enabled = false;
            view = false;
            buttonAddressNew.Enabled = false;
            buttonContactNew.Enabled = false;
            toolStripCreate.Enabled = false;
            //tabControlInfo.Visible = false;
            panelContacts.Visible = false;
            panelAddress.Visible = false;
            panelDetails.Visible = false;
            buttonEditSupervisor.Enabled = false;
            checkAFM();
            
          
            
        }

       
        private void clearFieleds()
        {   //clear all fields
            textBoxViewSingleStudentFirstName.Text = "";
            textBoxViewSingleStudentLastName.Text = "";
            textBoxViewSingleStudentAEM.Text = "";
            textBoxViewSingleStudentAFM.Text = "";
            textBoxViewSingleTeacher.Text = "";
            textBoxViewSingleSupervisor.Text = "";
            textBoxViewSingleCompany.Text = "";
            textBoxViewSingleFathersName.Text = "";
            loadAddressContact(selectedStudentID);
            dateTimePickerStart.Value = System.DateTime.Today;
            dateTimePickerEnd.Value = System.DateTime.Today;

          
        }

       
        //check if textboxs are blank and diable save with visual effects
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
                // only if editing mode is enabled and textBox has value save button is enabled
                if (!toolStripButtonEdit.Enabled)
                {
                    toolStripButtonSave.Enabled = true;
                }
            }
            if (textBoxViewSingleStudentFirstName.Text == "" || textBoxViewSingleStudentLastName.Text == "" || textBoxViewSingleStudentAEM.Text == "" || textBoxViewSingleStudentAFM.Text == "" || textBoxViewSingleTeacher.Text == "" || textBoxViewSingleSupervisor.Text == "" || textBoxViewSingleCompany.Text == "" || textBoxViewSingleFathersName.Text == "")
            {
                toolStripButtonSave.Enabled = false;
            }
        }


        //check if field is empty
        private void textBoxViewSingleStudentFirstName_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxViewSingleStudentFirstName, pictureBoxErrotFirstName);//check if field is empty
        }

        /* ------------ Empty Fields ckeck ----------*/
        private void textBoxViewSingleStudentLastName_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxViewSingleStudentLastName, pictureBoxErrotLastName);//check if field is empty
        }

        private void textBoxViewSingleFathersName_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxViewSingleFathersName, pictureBoxErrotFatherName);//check if field is empty
        }

        private void textBoxViewSingleStudentAEM_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxViewSingleStudentAEM, pictureBoxErrorAEM);//check if field is empty
        }

        private void textBoxViewSingleTeacher_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxViewSingleTeacher, pictureBoxErrorTeacher);//check if field is empty
        }

        private void textBoxViewSingleSupervisor_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxViewSingleSupervisor, pictureBoxErrorSupervisor);//check if field is empty
        }

        private void textBoxViewSingleCompany_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxViewSingleCompany, pictureBoxErrorCompany);//check if field is empty
        }
        
        private void showTooltips()
        {
            //Show tips for Contact and Address Buttons
            System.Windows.Forms.ToolTip ToolTipButtonContactNew = new System.Windows.Forms.ToolTip();
            ToolTipButtonContactNew.SetToolTip(this.buttonContactNew, "Προσθήκη Επαφής");

            System.Windows.Forms.ToolTip ToolTipButtonEditContact = new System.Windows.Forms.ToolTip();
            ToolTipButtonEditContact.SetToolTip(this.buttonEditContact, "Επεξεργασία Επαφης");

            System.Windows.Forms.ToolTip ToolTipButtonContactDelete = new System.Windows.Forms.ToolTip();
            ToolTipButtonContactDelete.SetToolTip(this.buttonContactDelete, "Διαγραφή Επαφής");

            System.Windows.Forms.ToolTip ToolTipButtonCancelContactEdit = new System.Windows.Forms.ToolTip();
            ToolTipButtonCancelContactEdit.SetToolTip(this.buttonCancelContactEdit, "Ακύρωση Επεξεργασίας");

            System.Windows.Forms.ToolTip ToolTipButtonAddressNew = new System.Windows.Forms.ToolTip();
            ToolTipButtonAddressNew.SetToolTip(this.buttonAddressNew, "Προσθήκη Διεύθυνσης");

            System.Windows.Forms.ToolTip ToolTipButtonEditAddress = new System.Windows.Forms.ToolTip();
            ToolTipButtonEditAddress.SetToolTip(this.buttonEditAddress, "Επεξεργασία Διεύθυνσης");

            System.Windows.Forms.ToolTip ToolTipButtonAddressDelete = new System.Windows.Forms.ToolTip();
            ToolTipButtonAddressDelete.SetToolTip(this.buttonAddressDelete, "Διαγραφή Διεύθυνσης");

            System.Windows.Forms.ToolTip ToolTipButtonCancelAddressEdit = new System.Windows.Forms.ToolTip();
            ToolTipButtonCancelAddressEdit.SetToolTip(this.buttonCancelAddressEdit, "Ακύρωση Διεύθυνσης");

            System.Windows.Forms.ToolTip ToolTipButtonDeteailsEdit = new System.Windows.Forms.ToolTip();
            ToolTipButtonDeteailsEdit.SetToolTip(this.buttonDetailsEdit, "Επεξεργασία Σημειώσεων");

        }


        private void buttonContactNew_Click(object sender, EventArgs e)
        {   //Enable Add new Contact
            groupBoxContactEdit.Visible = true;
            editContact = false;
            groupBoxContactEdit.Text = "Προσθήκη Επαφής";
            clearContactEditBoxes();
            pictureBoxErrorContact.Visible = true;
            buttonCancelContactEdit.Enabled = true;
        }

             

        private void buttonContactCancel_Click(object sender, EventArgs e)
        {   //Disable editing Contacts
            clearContactEditBoxes();
            groupBoxContactEdit.Visible = false;
            buttonCancelContactEdit.Enabled = false;            
        }

        private void buttonContactSave_Click(object sender, EventArgs e)
        {   //Save Contacts
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text; 
            if (!editContact)
            {   //add new contact
                cmd.CommandText = "INSERT into Contacts ([type], details, Student_ID) values ('" + comboBoxContactType.Text.ToString() + "', '" + textBoxContactDetail.Text.ToString() +"', '"  + selectedStudentID + "')";
                clearContactEditBoxes();
                cmd.ExecuteNonQuery();
                loadAddressContact(selectedStudentID); //reload Contacts to show the new ones
            }
            else
            {   //edit selected contact
                cmd.CommandText = "UPDATE Contacts set Type='" + comboBoxContactType.Text.ToString() + "', details='" +  textBoxContactDetail.Text.ToString() + "' where CID=" + editContactId + "";
                cmd.ExecuteNonQuery();
                loadAddressContact(selectedStudentID); //reload Contacts to show the new ones
                dataGridViewContact.Rows[contactIndex].Selected = true;
            }           
            
        }

        private void dataGridViewContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedContactRow = e.RowIndex;
            if (selectedContactRow < 0)
            {   // if there is not a selected row, editing contacts is disabled
                buttonEditContact.Enabled = false;
                buttonContactDelete.Enabled = false;
            }
            else
            {   // if there is  a selected row ,editing contacts is enabled
                buttonEditContact.Enabled = true;
                buttonContactDelete.Enabled = true;
            }
            if (editContact && e.RowIndex>=0)
            {   // load data from the selected contact for editing 
                comboBoxContactType.Text = dataGridViewContact.Rows[e.RowIndex].Cells["Είδος Επαφής"].Value.ToString();
                textBoxContactDetail.Text = dataGridViewContact.Rows[e.RowIndex].Cells["Λεπτομέριες"].Value.ToString();
                editContactId = dataGridViewContact.Rows[e.RowIndex].Cells["CID"].Value.ToString();
                contactIndex = e.RowIndex;
                
            }
           
            
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {   //enable editing contact
            groupBoxContactEdit.Visible = true;
            groupBoxContactEdit.Text = "Επεξεργασία Επαφής";

            // load data from the selected contact if the row was selected before edit is enabled
            comboBoxContactType.Text = dataGridViewContact.Rows[selectedContactRow].Cells["Είδος Επαφής"].Value.ToString();
            textBoxContactDetail.Text = dataGridViewContact.Rows[selectedContactRow].Cells["Λεπτομέριες"].Value.ToString();
            editContactId = dataGridViewContact.Rows[selectedContactRow].Cells["CID"].Value.ToString();
            editContact = true;
            groupBoxContactEdit.Visible = true;
            contactIndex = dataGridViewContact.CurrentRow.Index;
            if (textBoxContactDetail.Text == "")
            {
                buttonContactSave.Enabled = false;
            }

            buttonCancelContactEdit.Enabled = true;
            
        }

        private void textBoxContactDetail_TextChanged(object sender, EventArgs e)
        {   //mark the fields tha must be filled
            pictureBoxErrorContact.Visible = false;
            buttonContactSave.Enabled = true;
            if (textBoxContactDetail.Text == "")
            {
                
                pictureBoxErrorContact.Visible = true;
                buttonContactSave.Enabled = false;
            }
                        
        }

        private void buttonContactDelete_Click(object sender, EventArgs e)
        {   //delete selected contact
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος οτι θέλετε να διαγράψετε την επαφή: " + dataGridViewContact.Rows[selectedContactRow].Cells["Είδος Επαφής"].Value.ToString() + " <" + dataGridViewContact.Rows[selectedContactRow].Cells["Λεπτομέριες"].Value.ToString() + "> ;", "Διαγραφή Επαφής!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                editContactId = dataGridViewContact.Rows[selectedContactRow].Cells["CID"].Value.ToString();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Contacts WHERE CID='" + editContactId + "'";
                cmd.ExecuteNonQuery();
                loadAddressContact(selectedStudentID);
                clearContactEditBoxes();
            }            
        }

       

        private void dataGridViewContact_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {   //disable edit option if there is no contacts
            if (dataGridViewContact.RowCount == 0)
            {
                buttonEditContact.Enabled = false;
                buttonContactDelete.Enabled = false;
            }
        }

        private void dataGridViewContact_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {   //enable edit option if there is at least a contact
            buttonEditContact.Enabled = true;
            buttonContactDelete.Enabled = true;           
        }
       
        private void richTextBoxNotes_TextChanged(object sender, EventArgs e)
        {   //save details
            details = richTextBoxNotes.Text.ToString();
        }

        private void buttonAddressNew_Click(object sender, EventArgs e)
        {   //Enable Add new Address
            editAddress = false;
            groupBoxAddressEdit.Visible = true;
            groupBoxAddressEdit.Text = "Προσθήκη Διεύθυνσης";
            clearAddressEditBoxes();
            buttonCancelAddressEdit.Enabled = true;
            pictureBoxErrorCity.Visible = true;
            pictureBoxErrorAddress.Visible = true;
            
        }

        private void buttonEditAddress_Click(object sender, EventArgs e)
        {   //enable editing address
            groupBoxAddressEdit.Visible = true;
            groupBoxAddressEdit.Text = "Επεξεργασία Διεύθυνσης";

            // load data from the selected address if the row was selected before edit is enabled
            textBoxCity.Text = dataGridViewAddress.Rows[selectedAddressRow].Cells["Πόλη"].Value.ToString();
            textBoxStreetNumber.Text = dataGridViewAddress.Rows[selectedAddressRow].Cells["Αριθμός"].Value.ToString();
            textBoxStreetName.Text = dataGridViewAddress.Rows[selectedAddressRow].Cells["Οδός"].Value.ToString();
            textBoxZipCode.Text = dataGridViewAddress.Rows[selectedAddressRow].Cells["Ταχ. Κώδικας"].Value.ToString();
            editAddressId = dataGridViewAddress.Rows[selectedAddressRow].Cells["AID"].Value.ToString();
            editAddress = true;
            groupBoxAddressEdit.Visible = true;
            addressIndex = dataGridViewAddress.CurrentRow.Index;
            if (textBoxCity.Text == "" || textBoxStreetName.Text == "")
            {
                buttonAddressSave.Enabled = false;
            }
            buttonCancelAddressEdit.Enabled = true;
        }

        private void dataGridViewAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {   

            selectedAddressRow = e.RowIndex;
            if (selectedAddressRow < 0)
            {   // if there is not a selected row, editing Address is disabled
                buttonEditAddress.Enabled = false;
                buttonAddressDelete.Enabled = false;
            }
            else
            {  // if there is  a selected row, editing Address is enabled
                buttonEditAddress.Enabled = true;
                buttonAddressDelete.Enabled = true;
            }
            if (editAddress && e.RowIndex>=0)
            {   // load data from the selected Address for editing
                textBoxCity.Text = dataGridViewAddress.Rows[e.RowIndex].Cells["Πόλη"].Value.ToString();
                textBoxStreetNumber.Text = dataGridViewAddress.Rows[e.RowIndex].Cells["Αριθμός"].Value.ToString();
                textBoxStreetName.Text = dataGridViewAddress.Rows[e.RowIndex].Cells["Οδός"].Value.ToString();
                textBoxZipCode.Text = dataGridViewAddress.Rows[e.RowIndex].Cells["Ταχ. Κώδικας"].Value.ToString();
                editAddressId = dataGridViewAddress.Rows[e.RowIndex].Cells["AID"].Value.ToString();
                addressIndex = e.RowIndex;
            }
           
        }

        private void buttonCancelAddressEdit_Click(object sender, EventArgs e)
        {   //Disable editing Address
            groupBoxAddressEdit.Visible = false;
            clearAddressEditBoxes();
            buttonCancelAddressEdit.Enabled = false;                
        }

        private void buttonAddressDelete_Click(object sender, EventArgs e)
        {   //delete selected Address
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος οτι θέλετε να διαγράψετε την Διεύθυνση: '" + dataGridViewAddress.Rows[selectedAddressRow].Cells["Οδός"].Value.ToString() + " " + dataGridViewAddress.Rows[selectedAddressRow].Cells["Αριθμός"].Value.ToString() + " " + dataGridViewAddress.Rows[selectedAddressRow].Cells["Πόλη"].Value.ToString() + " " + dataGridViewAddress.Rows[selectedAddressRow].Cells["Ταχ. Κώδικας"].Value.ToString() + "' ;", "Διαγραφή Επαφής!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                editAddressId = dataGridViewAddress.Rows[selectedAddressRow].Cells["AID"].Value.ToString(); ;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Address WHERE AID='" + editAddressId + "'";
                cmd.ExecuteNonQuery();
                loadAddressContact(selectedStudentID);
                clearAddressEditBoxes();
            }
        }

        private void buttonAddressSave_Click(object sender, EventArgs e)
        {   //save address
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (!editAddress)
            {   //add new address
                cmd.CommandText = "INSERT into Address (address, Number, City, ZipCode, Student_StudID) values ('" + textBoxStreetName.Text.ToString() + "','" + textBoxStreetNumber.Text.ToString() + "','" + textBoxCity.Text.ToString() + "','" + textBoxZipCode.Text.ToString() + "','" + selectedStudentID + "')";
                clearAddressEditBoxes();
                cmd.ExecuteNonQuery();
                loadAddressContact(selectedStudentID);//reload Contacts to show the new ones
            }
            else
            {   //edit selected Address
                cmd.CommandText = "UPDATE Address set address='" + textBoxStreetName.Text.ToString() + "', Number ='" + textBoxStreetNumber.Text.ToString() + "', City ='" + textBoxCity.Text.ToString() + "', ZipCode ='" + textBoxZipCode.Text.ToString() + "' where AID=" + editAddressId + "";
                cmd.ExecuteNonQuery();
                loadAddressContact(selectedStudentID);//reload Contacts to show the new ones
                dataGridViewAddress.Rows[addressIndex].Selected = true;
            }            
        }

        private void AddressChanged_TextChanged(object sender, EventArgs e)
        {   //mark the fields tha must be filled
            buttonAddressSave.Enabled = true;
            if (textBoxCity.Text == "")
            {
                pictureBoxErrorCity.Visible = true;
            }
            else
            {
                pictureBoxErrorCity.Visible = false;
            }
            if (textBoxStreetName.Text == "")
            {
                pictureBoxErrorAddress.Visible = true;
            }
            else
            {
                pictureBoxErrorAddress.Visible = false;
            }
            
            if (textBoxCity.Text == "" || textBoxStreetName.Text == "")
            {
                buttonAddressSave.Enabled = false;
            }          
        }

        private void dataGridViewAddress_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {   //disable edit if there are no Addresses
            if (dataGridViewAddress.RowCount == 0)
            {
                buttonEditAddress.Enabled = false;
                buttonAddressDelete.Enabled = false;
            }
        }

        private void dataGridViewAddress_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {   //enable edit if there ia at least an Address
            buttonEditAddress.Enabled = true;
            buttonAddressDelete.Enabled = true;
        }

        private void clearAddressEditBoxes()
        {   //clear Fiels for address' editing
            textBoxCity.Text = "";     
            textBoxStreetNumber.Text = "";
            textBoxStreetName.Text = "";
            textBoxZipCode.Text = "";
        }
                      
        private void clearContactEditBoxes()
        {   //clear Fiels for contact's editing
            textBoxContactDetail.Text = "";
            comboBoxContactType.SelectedIndex = -1;
        }

        private void buttonDetailsEdit_Click(object sender, EventArgs e)
        {
            richTextBoxNotes.ReadOnly = false;
            buttonDetailsSave.Enabled = true;
            buttonDetailsCancel.Enabled = true;
            buttonDetailsEdit.Enabled = false;
        }

        private void buttonDetailsSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandsave = con.CreateCommand();
            commandsave.CommandType = CommandType.Text;
            commandsave.CommandText = "UPDATE Student SET Details = '" + details + "' WHERE StudID = '" + selectedStudentID + "'";
            commandsave.ExecuteNonQuery();
            buttonDetailsEdit.Enabled = true;
            buttonDetailsSave.Enabled = false;
            buttonDetailsCancel.Enabled = false;
            richTextBoxNotes.ReadOnly = true;
        }

        private void buttonDetailsCancel_Click(object sender, EventArgs e)
        {
            fillSingleStudentDetails();
            
            buttonDetailsEdit.Enabled = true;
            buttonDetailsSave.Enabled = false;
            buttonDetailsCancel.Enabled = false;
            richTextBoxNotes.ReadOnly = true;
        }

        private void buttonNewTeacher_Click(object sender, EventArgs e)
        {
            FormTeacher newform = new FormTeacher();
            newform.view = false;
            newform.Activate();
            newform.Show();
        }

        private void comboBoxViewTeacher_DropDown(object sender, EventArgs e)
        {
            loadTeacherCombobox();
        }

        private void buttonNewCompany_Click(object sender, EventArgs e)
        {
            FormCompany newform = new FormCompany();
            newform.view = false;
            newform.Activate();
            newform.Show();
        }

        private void buttonNewSupervisor_Click(object sender, EventArgs e)
        {
            FormNewSupervisor newform = new FormNewSupervisor();
            newform.companyID = selectedCompanyID;
            newform.Activate();
            newform.Show();
        }

        private void comboBoxViewCompany_DropDown(object sender, EventArgs e)
        {
            loadCompanyCombobox();
        }

        private void comboBoxViewSupervisor_DropDown(object sender, EventArgs e)
        {        
            loadSupervisorCombobox();
        }

                       
    }
}
