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
    public partial class FormCompany : Form
    {
        string selectedCompanyId, selectedTypeID, editContactId, editSupervisorId;
        SqlConnection con;
        public bool view { get; set; }
        bool editContact = false;
        bool editSupervisor = false;
        int selectedContactRow, selectedSupervisorRow, contactIndex, supervisorIndex;
       
        public FormCompany()
        {
            
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();
        }

        private void fillData()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Company where ComID = '" + selectedCompanyId + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //set in the textboxes the saved values

                textBoxName.Text = dr["Name"].ToString();
                textBoxAFM.Text = dr["AFM"].ToString();
                textBoxLegalForm.Text = dr["LegalForm"].ToString();
                textBoxAddress.Text = dr["Address"].ToString();
                textBoxCity.Text = dr["City"].ToString();
                textBoxStreetNumber.Text = dr["Number"].ToString();
                textBoxZipCode.Text = dr["ZipCode"].ToString();
                richTextBoxDetails.Text = dr["Details"].ToString();

            }

            cmd.ExecuteNonQuery(); //execute query
        }

        private void fillComboboxType()
        {
            SqlDataAdapter daCompanyType = new SqlDataAdapter("SELECT TypeID, Name FROM CompanyType ORDER BY Name", con);
            DataTable dtCompanyType = new DataTable();
            daCompanyType.Fill(dtCompanyType);
            comboBoxCompanyType.DataSource = dtCompanyType;
            string displayTextType = "Name";
            string displayIDType = "TypeID";
            comboBoxCompanyType.DisplayMember = displayTextType;
            comboBoxCompanyType.ValueMember = displayIDType;      
        }


        private void fillType()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TypeID, CompanyType.Name as TNAME from CompanyType, Company where (ComID = '" + selectedCompanyId + "') and (TypeID = CompanyType_TypeID) ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //set in the textboxes the saved values

                selectedTypeID = dr["TypeID"].ToString();
                textBoxCompanyType.Text = dr["TNAME"].ToString();
                
            }

           
        }

        private void fillDataGridView()
        {
            string sqlqueryStudents = "Select AEM, LastName + ' ' + FirstName as 'Ονοματεπώνυμο',  FatherName as 'Πατρώνυμο', Supervisor.Name as 'Επόπτης', StudID FROM Student, Supervisor, Company WHERE (ComID = '" + selectedCompanyId + "') AND (ComID = Company_ComID) AND (Supervisor_ID = ID)  ORDER BY Supervisor.Name";
            SqlDataAdapter daStudents = new SqlDataAdapter(sqlqueryStudents, con);
            DataSet DsStudents = new DataSet();
            daStudents.Fill(DsStudents);
            BindingSource BsStudents = new BindingSource();
            BsStudents.DataSource = DsStudents.Tables[0].DefaultView;
            dataGridViewStudents.DataSource = BsStudents;
            dataGridViewStudents.Columns["StudID"].Visible = false;

            string sqlquerySupervisor = "Select ID, Supervisor.Name as 'Όνομα', Position as 'Θέση' FROM Supervisor, Company WHERE (ComID = '" + selectedCompanyId + "') AND (ComID = Company_ComID)  ORDER BY Supervisor.Name";
            SqlDataAdapter daSupervisor = new SqlDataAdapter(sqlquerySupervisor, con);
            DataSet DsSupervisor = new DataSet();
            daSupervisor.Fill(DsSupervisor);
            BindingSource BsSupervisor = new BindingSource();
            BsSupervisor.DataSource = DsSupervisor.Tables[0].DefaultView;
            dataGridViewSupervisor.DataSource = BsSupervisor;
            dataGridViewSupervisor.Columns["ID"].Visible = false;

        }

        private void loadContact(string companyid)
        {
            
            // load Contact list from the selected Student ID 
            SqlDataAdapter DaCont = new SqlDataAdapter("Select Type as 'Είδος Επαφής', Details as 'Λεπτομέριες', ID FROM CompanyContacts Where Company_ComID ='" + selectedCompanyId + "'", con);
            DataSet DsCont = new DataSet();
            DaCont.Fill(DsCont);
            BindingSource BsCont = new BindingSource();
            BsCont.DataSource = DsCont.Tables[0].DefaultView;
            dataGridViewContact.DataSource = BsCont;

            dataGridViewContact.DataSource = BsCont;
            dataGridViewContact.Columns["ID"].Visible = false;


           

        }

        private void FormCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intershipDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.intershipDataSet.Company);
           
            if (view)
            {
                selectedCompanyId = listBoxCompany.GetItemText(listBoxCompany.SelectedValue);

                fillData();
                fillType();
                loadContact(selectedCompanyId);
                fillDataGridView();
                panelEditButtons.Visible = true;
            }
            else
            {
                enableEdit();
                checkBlankField(textBoxName, pictureBoxErrorName);
                checkBlankField(textBoxCompanyType, pictureBoxErrorCompanyType);
                checkBlankField(textBoxAFM, pictureBoxErrorAFM);
                checkBlankField(textBoxLegalForm, pictureBoxErrorLegalForm);
                checkBlankField(textBoxAddress, pictureBoxErrorStreetName);
                checkBlankField(textBoxCity, pictureBoxErrorCity);
                checkAFM();
                showContactsSupervisors(false);
                
            }
            checkAFM();
            fillComboboxType();

            
            
         }

        private void listBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedCompanyId != listBoxCompany.GetItemText(listBoxCompany.SelectedValue ))
            {
                groupBoxContactEdit.Visible = false;
                groupBoxSupervisorEdit.Visible = false;
            }
            selectedCompanyId = listBoxCompany.GetItemText(listBoxCompany.SelectedValue);
                        
            fillData();
            fillType();
            loadContact(selectedCompanyId);
            fillDataGridView();
            checkAFM();
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
            if (textBoxName.Text == "" || textBoxAFM.Text == "" || textBoxLegalForm.Text == "" || textBoxCompanyType.Text == "" || textBoxAddress.Text == "" || textBoxCity.Text == "")
            {
                toolStripButtonSave.Enabled = false;
            }
        }

        private void checkAFM()
        {

            if (Intership.Repo.AFM.ValidateAFM(textBoxAFM.Text.ToString()))
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

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxName,pictureBoxErrorName);
        }

        private void textBoxCompanyType_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxCompanyType, pictureBoxErrorCompanyType);
        }

        private void textBoxAFM_TextChanged(object sender, EventArgs e)
        {
            checkAFM();
            checkBlankField(textBoxAFM, pictureBoxErrorAFM);
        }

        private void textBoxLegalForm_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxLegalForm, pictureBoxErrorLegalForm);
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxAddress, pictureBoxErrorStreetName);
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            checkBlankField(textBoxCity, pictureBoxErrorCity);
        }

        
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            enableEdit();
        }

        private void enableEdit()
        {
            //make all edit features enabled
            toolStripButtonSave.Enabled = true;
            toolStripButtonEdit.Enabled = false;
            toolStripButtonRestore.Enabled = true;
            toolStripCreate.Enabled = false;
            toolStripButtonDelete.Enabled = false;
            buttonEditType.Enabled = true;
            textBoxName.ReadOnly = false;
            textBoxAFM.ReadOnly = false;
            textBoxLegalForm.ReadOnly = false;
            textBoxAddress.ReadOnly = false;
            textBoxStreetNumber.ReadOnly = false;
            textBoxCity.ReadOnly = false;
            textBoxZipCode.ReadOnly = false;
            listBoxCompany.Enabled = false;
            
        }

        private void disableEdit()
        {
            //make all edit features enabled
            toolStripButtonSave.Enabled = false;
            toolStripButtonEdit.Enabled = true;
            toolStripButtonRestore.Enabled = false;
            toolStripCreate.Enabled = true;
            toolStripButtonDelete.Enabled = true;
            buttonEditType.Enabled = false;
            textBoxName.ReadOnly = true;
            textBoxAFM.ReadOnly = true;
            textBoxLegalForm.ReadOnly = true;
            textBoxAddress.ReadOnly = true;
            textBoxStreetNumber.ReadOnly = true;
            textBoxCity.ReadOnly = true;
            textBoxZipCode.ReadOnly = true;
            listBoxCompany.Enabled = true;

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            disableEdit();
            updateField();            
        }

        private void buttonEditType_Click(object sender, EventArgs e)
        {
            buttonTypeChecked.Enabled = false;
            comboBoxCompanyType.Visible = true;
            buttonTypeChecked.Visible = true;
            buttonTypeNonChecked.Visible = true;
            buttonNewType.Visible = true;
            buttonEditType.Visible = false;
            textBoxCompanyType.Visible = false;
            comboBoxCompanyType.SelectedIndex = -1;     
        }

        private void comboBoxCompanyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonTypeChecked.Enabled = true;

        }

        private void buttonTypeChecked_Click(object sender, EventArgs e)
        {
            textBoxCompanyType.Text = comboBoxCompanyType.Text.ToString();
            selectedTypeID = comboBoxCompanyType.SelectedValue.ToString();
            textBoxCompanyType.Visible = true;
            comboBoxCompanyType.Visible = false;
            buttonTypeChecked.Visible = false;
            buttonTypeNonChecked.Visible = false;
            buttonNewType.Visible = false;
            buttonEditType.Visible = true;
        }

        private void buttonTypeNonChecked_Click(object sender, EventArgs e)
        {
            comboBoxCompanyType.Visible = false;
            textBoxCompanyType.Visible = true;
            buttonTypeChecked.Visible = false;
            buttonTypeNonChecked.Visible = false;
            buttonNewType.Visible = false;
            buttonEditType.Visible = true;
        }


        private void clearContactEditBoxes()
        {   //clear Fiels for contact's editing
            textBoxContactDetail.Text = "";
            comboBoxContactType.Text = "";
        }

        private void clearSupervisorEditBoxes()
        {   //clear Fiels for contact's editing
            textBoxSupervisorName.Text = "";
            textBoxSupervisorPosition.Text = "";            
        }


        private void buttonContactNew_Click(object sender, EventArgs e)
        {   //Enable Add new Contact
            groupBoxContactEdit.Visible = true;
            editContact = false;
            groupBoxContactEdit.Text = "Προσθήκη Επαφής";
            clearContactEditBoxes();
            pictureBoxErrorContactDetail.Visible = true;
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
                cmd.CommandText = "INSERT into CompanyContacts ([type], details, Company_ComID) values ('" + comboBoxContactType.Text.ToString() + "', '" + textBoxContactDetail.Text.ToString() + "', '" + selectedCompanyId + "')";
                clearContactEditBoxes();
                cmd.ExecuteNonQuery();
                loadContact(selectedCompanyId); //reload Contacts to show the new ones
            }
            else
            {   //edit selected contact
                cmd.CommandText = "UPDATE CompanyContacts set Type='" + comboBoxContactType.Text.ToString() + "', details='" + textBoxContactDetail.Text.ToString() + "' where ID=" + editContactId + "";
                cmd.ExecuteNonQuery();
                loadContact(selectedCompanyId); //reload Contacts to show the new ones
                dataGridViewContact.Rows[contactIndex].Selected = true;
                cmd.ExecuteNonQuery();
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
                editContactId = dataGridViewContact.Rows[e.RowIndex].Cells["ID"].Value.ToString();
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
            editContactId = dataGridViewContact.Rows[selectedContactRow].Cells["ID"].Value.ToString();
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
        {   //mark the fields that must be filled
            pictureBoxErrorContactDetail.Visible = false;
            buttonContactSave.Enabled = true;
            if (textBoxContactDetail.Text == "")
            {
                
                pictureBoxErrorContactDetail.Visible = true;
                buttonContactSave.Enabled = false;
            }
                        
        }

        private void buttonContactDelete_Click(object sender, EventArgs e)
        {   //delete selected contact
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος οτι θέλετε να διαγράψετε την επαφή: " + dataGridViewContact.Rows[selectedContactRow].Cells["Είδος Επαφής"].Value.ToString() + " <" + dataGridViewContact.Rows[selectedContactRow].Cells["Λεπτομέριες"].Value.ToString() + "> ;", "Διαγραφή Επαφής!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                editContactId = dataGridViewContact.Rows[selectedContactRow].Cells["ID"].Value.ToString();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM CompanyContacts WHERE ID='" + editContactId + "'";
                cmd.ExecuteNonQuery();
                loadContact(selectedCompanyId);
                clearContactEditBoxes();
                groupBoxContactEdit.Visible = false;
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

        private void updateField()
        {
            string setName, setAfm, setLegalForm, setAddress, setNumber, setCity, setZipCode;

            setName = textBoxName.Text.ToString();
            setAfm = textBoxAFM.Text.ToString();
            setLegalForm = textBoxLegalForm.Text.ToString();
            setAddress = textBoxAddress.Text.ToString();
            setNumber = textBoxStreetNumber.Text.ToString();
            setCity = textBoxCity.Text.ToString();
            setZipCode = textBoxZipCode.Text.ToString();

            if (view)
            {
                //constract the UPDATE query
                SqlCommand commandsave = con.CreateCommand();
                commandsave.CommandType = CommandType.Text;
                commandsave.CommandText = "UPDATE Company SET Name = '" + setName + "', AFM = '" + setAfm + "', LegalForm = '" + setLegalForm + "', Address = '" + setAddress + "', Number = '" + setNumber + "', City = '" + setCity + "', ZipCode = '" + setZipCode + "', CompanyType_TypeID = '" + selectedTypeID + "' WHERE ComID = '" + selectedCompanyId + "'";
                commandsave.ExecuteNonQuery();
                MessageBox.Show("Η Εγγραφή Ενημερώθηκε", "Ενημέρωση Εγγραφής", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation message
            }
            else
            {
                //constract the INSERT query
                SqlCommand commandsave = con.CreateCommand();
                commandsave.CommandType = CommandType.Text;
                commandsave.CommandText = "INSERT into Company (Name, AFM, LegalForm, Address, Number, City, ZipCode, CompanyType_TypeID) values ('" + setName + "', '" + setAfm + "', '" + setLegalForm + "', '" + setAddress + "', '" + setNumber + "', '" + setCity + "', '" + setZipCode + "', '" + selectedTypeID + "')";
                commandsave.ExecuteNonQuery();
                MessageBox.Show("Η Εγγραφή Αποθηκεύτηκε", "Αποθήκευση Εγγραφής", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation message

                //recover the Id from the New record
                SqlCommand cmdFindId = con.CreateCommand();
                cmdFindId.CommandType = CommandType.Text;
                cmdFindId.CommandText = "SELECT ComID FROM Company ORDER BY ComID";
                DataTable dtFindId = new DataTable();
                SqlDataAdapter daFindId = new SqlDataAdapter(cmdFindId);
                daFindId.Fill(dtFindId);
                foreach (DataRow drFindId in dtFindId.Rows)
                {
                    selectedCompanyId = drFindId["ComID"].ToString();
                }
                cmdFindId.ExecuteNonQuery();

                showContactsSupervisors(true);
                this.companyTableAdapter.Fill(this.intershipDataSet.Company);
                selectedCompanyId = listBoxCompany.GetItemText(listBoxCompany.SelectedValue);
                int index = listBoxCompany.Items.Count - 1;
                listBoxCompany.SetSelected(index, true);

            }
        }

        private void toolStripCreate_Click(object sender, EventArgs e)
        {
            view = false;
            clearFields();
            enableEdit();
            toolStripButtonSave.Enabled = false;
            toolStripButtonDelete.Enabled = false;
            showContactsSupervisors(false);
        }

        private void clearFields()
        {
            selectedCompanyId = null;
            textBoxName.Text = "";
            textBoxAFM.Text = "";
            textBoxLegalForm.Text = "";
            textBoxAddress.Text = "";
            textBoxStreetNumber.Text = "";
            textBoxCity.Text = "";
            textBoxZipCode.Text = "";
            richTextBoxDetails.Text = "";
            textBoxCompanyType.Text = "";
            loadContact(selectedCompanyId);
            fillDataGridView();

        }

        private void showContactsSupervisors(bool show)
        {
            panelContacts.Visible = show;
            dataGridViewContact.Visible = show;
            panelEditButtons.Visible = show;
            panelEditDetails.Visible = show;
            groupBoxContactEdit.Visible = false;
            groupBoxSupervisorEdit.Visible = false;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος οτι θέλετε να διαγράψετε την Εταιρία: " + textBoxName.Text.ToString() + "; Μαζί με την Εταιρία θα διαγραφούν και οι επόπτες εργασίας που είναι συνδεδεμένη σε αυτήν.", "Διαγραφή Εταιρίας!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                fillDataGridView(); //load students again to check if a student was added in the company while form was opened
                if (dataGridViewStudents.RowCount > 0)
                {
                    MessageBox.Show("Η εταιρία: '" + textBoxName.Text.ToString() + "' έχει συνδεδεμένους φοιτητές. Η διαγραφή της δεν είναι εφικτή.", "Μη Δυνατή Διαγραφή!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "DELETE FROM CompanyContacts WHERE Company_ComID='" + selectedCompanyId + "'";
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "DELETE FROM Supervisor WHERE Company_ComID='" + selectedCompanyId + "'";
                    cmd2.ExecuteNonQuery();
                    
                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "DELETE FROM COMPANY WHERE ComID='" + selectedCompanyId + "'";
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Η Εγγραφή '" + textBoxName.Text.ToString() + "' έχει διαγραφεί", "Διαγραφή Εταιρίας", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.companyTableAdapter.Fill(this.intershipDataSet.Company);
                selectedCompanyId = listBoxCompany.GetItemText(listBoxCompany.SelectedValue);
                fillData();
                fillDataGridView();
                view = true;

            }
        }

        private void textBoxSupervisorName_TextChanged(object sender, EventArgs e)
        {   //mark the fields tha must be filled
            pictureBoxErrorSupervisor.Visible = false;
            buttonSupervisorSave.Enabled = true;
            if (textBoxSupervisorName.Text == "")
            {

                pictureBoxErrorSupervisor.Visible = true;
                buttonSupervisorSave.Enabled = false;
            }

        }

        private void buttonNewSupervisor_Click(object sender, EventArgs e)
        {   //Enable Add new Supervisor
            groupBoxSupervisorEdit.Visible = true;
            editSupervisor = false;
            groupBoxSupervisorEdit.Text = "Προσθήκη Επόπτη Εργασίας";
            clearSupervisorEditBoxes();
            pictureBoxErrorSupervisor.Visible = true;
            buttonSupervisorCancelEdit.Enabled = true;

        }

        private void buttonEditSupervisor_Click(object sender, EventArgs e)
        {   //enable editing Supervisor
            editSupervisor = true;
            groupBoxSupervisorEdit.Visible = true;
            groupBoxSupervisorEdit.Text = "Επεξεργασία Επόπτη Εργασίας";

            // load data from the selected Supervisor if the row was selected before edit is enabled
            textBoxSupervisorName.Text = dataGridViewSupervisor.Rows[selectedSupervisorRow].Cells["Όνομα"].Value.ToString();
            textBoxSupervisorPosition.Text = dataGridViewSupervisor.Rows[selectedSupervisorRow].Cells["Θέση"].Value.ToString();
            editSupervisorId = dataGridViewSupervisor.Rows[selectedSupervisorRow].Cells["ID"].Value.ToString();
            supervisorIndex =  dataGridViewSupervisor.CurrentRow.Index;
            groupBoxSupervisorEdit.Visible = true;         
            buttonSupervisorCancelEdit.Enabled = true;
            buttonSupervisorSave.Enabled = true;
            if (textBoxSupervisorName.Text == "")
            {
                buttonSupervisorSave.Enabled = false;
            }

           

        }

        private void dataGridViewSupervisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedSupervisorRow = e.RowIndex;
            editSupervisorId = dataGridViewSupervisor.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            if (selectedSupervisorRow < 0)
            {   // if there is not a selected row, editing contacts is disabled
                buttonEditSupervisor.Enabled = false;
                buttonDeleteSupervisor.Enabled = false;
            }
            else
            {   // if there is  a selected row ,editing contacts is enabled

                buttonEditSupervisor.Enabled = true;
                buttonDeleteSupervisor.Enabled = true;
            }
            if (editSupervisor && e.RowIndex >= 0)
            {   // load data from the selected contact for editing 
                textBoxSupervisorName.Text = dataGridViewSupervisor.Rows[e.RowIndex].Cells["Όνομα"].Value.ToString();
                textBoxSupervisorPosition.Text = dataGridViewSupervisor.Rows[e.RowIndex].Cells["Θέση"].Value.ToString();
//                editSupervisorId = dataGridViewSupervisor.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                supervisorIndex = e.RowIndex;

            }


        }

        private void buttonDeleteSupervisor_Click(object sender, EventArgs e)
        {   //delete selected Supervisor
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος οτι θέλετε να διαγράψετε τον Επόπτη Εργασίας: " + dataGridViewSupervisor.Rows[selectedSupervisorRow].Cells["Όνομα"].Value.ToString() + " με θέση: '" + dataGridViewSupervisor.Rows[selectedSupervisorRow].Cells["Θέση"].Value.ToString() + "' ;", "Διαγραφή Επόπτη Εργασίας!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                editSupervisorId = dataGridViewSupervisor.Rows[selectedSupervisorRow].Cells["ID"].Value.ToString();
                string query = "SELECT * from Student where Supervisor_ID = '" + editSupervisorId  +"'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);           
                if (dt1.Rows.Count>0)
                {
                    MessageBox.Show("O Επόπτης Εργασίας: '" + dataGridViewSupervisor.Rows[selectedSupervisorRow].Cells["Όνομα"].Value.ToString() + "' έχει συνδεδεμένους φοιτητές. Η διαγραφή του δεν είναι εφικτή.", "Μη Δυνατή Διαγραφή!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selectedSupervisorRow = 0;
                
                }
                else
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "DELETE FROM Supervisor WHERE ID='" + editSupervisorId + "'";
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Ο επόπτης '" + dataGridViewSupervisor.Rows[selectedSupervisorRow].Cells["Όνομα"].Value.ToString() + "' έχει διαγραφεί", "Διαγραφή Επόπτη", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fillData();
                fillDataGridView();
                view = true;
               
            }
        }

        private void dataGridViewSupervisor_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {   //disable edit option if there is no supervisor
            if (dataGridViewSupervisor.RowCount == 0)
            {
                buttonEditSupervisor.Enabled = false;
                buttonDeleteSupervisor.Enabled = false;
            }
        }


        private void dataGridViewSupervisor_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {   //enable edit option if there is at least a supervisor
            buttonEditSupervisor.Enabled = true;
            buttonDeleteSupervisor.Enabled = true;
        }

        private void buttonSupervisorSave_Click(object sender, EventArgs e)
        {   //Save supervisor
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (!editSupervisor)
            {   //add new supervisor
                cmd.CommandText = "INSERT into Supervisor (name, position, Company_ComID) values ('" + textBoxSupervisorName.Text.ToString() + "', '" + textBoxSupervisorPosition.Text.ToString() + "', '" + selectedCompanyId + "')";
                clearContactEditBoxes();
                cmd.ExecuteNonQuery();
                fillDataGridView(); //reload supervisors to show the new ones
            }
            else
            {   //edit selected supervisor
                cmd.CommandText = "UPDATE Supervisor set Name='" + textBoxSupervisorName.Text.ToString() + "', Position='" + textBoxSupervisorPosition.Text.ToString() + "' where ID=" + editSupervisorId + "";
                cmd.ExecuteNonQuery();
                fillDataGridView(); //reload supervisors to show the new ones
                dataGridViewSupervisor.Rows[supervisorIndex].Selected = true;
            }
            
        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {   //Disable editing Contacts
            clearSupervisorEditBoxes();
            groupBoxSupervisorEdit.Visible = false;
            buttonSupervisorCancelEdit.Enabled = false;
        }

        private void toolStripButtonRestore_Click(object sender, EventArgs e)
        {
            if (view) //for editing a contact
            {
                //restore all unsaved editings to previus record
                fillData();
                fillDataGridView();
                fillType();
                disableEdit(); //disable the edit features after the restore action
            }
            else //for adding new Student
            {
                clearFields();
                disableEdit();
                this.companyTableAdapter.Fill(this.intershipDataSet.Company);                
                selectedCompanyId = listBoxCompany.GetItemText(listBoxCompany.SelectedValue);      
                fillData();
                fillDataGridView();
                fillType();
                view = true;
            }
            showContactsSupervisors(true);
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormViewSingleStudent newform = new FormViewSingleStudent();
            newform.view = true;
            newform.selectedStudentID = dataGridViewStudents.CurrentRow.Cells[4].Value.ToString();
            newform.Activate();
            newform.Show();
        }

        private void buttonNewType_Click(object sender, EventArgs e)
        {
            FormNewCompanyType newform = new FormNewCompanyType();                     
            newform.Activate();
            newform.Show();
        }

        private void comboBoxCompanyType_DropDown(object sender, EventArgs e)
        {
            fillComboboxType();
        }

        private void buttonDetailsEdit_Click(object sender, EventArgs e)
        {
            detailEdit(true);
        }

        private void buttonDetailsSave_Click(object sender, EventArgs e)
        {
            //constract the UPDATE query
            SqlCommand commandsave = con.CreateCommand();
            commandsave.CommandType = CommandType.Text;
            commandsave.CommandText = "UPDATE Company SET Details = '" + richTextBoxDetails.Text.ToString() + "' WHERE ComID = '" + selectedCompanyId + "'";
            commandsave.ExecuteNonQuery();
            fillCompanyDetails();
            detailEdit(false);
        }

        private void fillCompanyDetails()
        {
            SqlCommand cmdRestore = con.CreateCommand();
            cmdRestore.CommandType = CommandType.Text;
            cmdRestore.CommandText = "Select Details from Company WHERE ComID = '" + selectedCompanyId + "'";
            DataTable dtRestore = new DataTable();
            SqlDataAdapter daRestore = new SqlDataAdapter(cmdRestore);
            daRestore.Fill(dtRestore);
            foreach (DataRow drRestore in dtRestore.Rows)
            {
                richTextBoxDetails.Text = drRestore["Details"].ToString();
            }
            cmdRestore.ExecuteNonQuery(); //execute query
        }

        private void buttonDetailsCancel_Click(object sender, EventArgs e)
        {
            fillCompanyDetails();
            detailEdit(false);
        }

        private void detailEdit(bool edit) 
        {
            buttonDetailsEdit.Enabled = !edit;
            buttonDetailsSave.Enabled = edit;
            buttonDetailsCancel.Enabled = edit;
            richTextBoxDetails.ReadOnly = !edit;
        }

        
    }
}
