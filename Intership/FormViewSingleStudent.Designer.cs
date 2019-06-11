namespace Intership
{
    partial class FormViewSingleStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewSingleStudent));
            this.label_AEM = new System.Windows.Forms.Label();
            this.textBoxViewSingleStudentAFM = new System.Windows.Forms.TextBox();
            this.textBoxViewSingleStudentAEM = new System.Windows.Forms.TextBox();
            this.textBoxViewSingleStudentLastName = new System.Windows.Forms.TextBox();
            this.label_Afm = new System.Windows.Forms.Label();
            this.label_Teacher = new System.Windows.Forms.Label();
            this.label_Company = new System.Windows.Forms.Label();
            this.label_Supervisor = new System.Windows.Forms.Label();
            this.label_Duration = new System.Windows.Forms.Label();
            this.intershipDataSet = new Intership.intershipDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Intership.intershipDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new Intership.intershipDataSetTableAdapters.TableAdapterManager();
            this.textBoxViewSingleStudentFirstName = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label_divader = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxViewTeacher = new System.Windows.Forms.ComboBox();
            this.comboBoxViewCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxViewSupervisor = new System.Windows.Forms.ComboBox();
            this.buttonTeacherChecked = new System.Windows.Forms.Button();
            this.buttonTeacherNonChecked = new System.Windows.Forms.Button();
            this.textBoxViewSingleTeacher = new System.Windows.Forms.TextBox();
            this.buttonCompanyChecked = new System.Windows.Forms.Button();
            this.buttonCompanyNonChecked = new System.Windows.Forms.Button();
            this.buttonSupervisorChecked = new System.Windows.Forms.Button();
            this.buttonSupervisorNonChecked = new System.Windows.Forms.Button();
            this.textBoxViewSingleCompany = new System.Windows.Forms.TextBox();
            this.textBoxViewSingleSupervisor = new System.Windows.Forms.TextBox();
            this.dataGridViewContact = new System.Windows.Forms.DataGridView();
            this.label_Contacts = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRestore = new System.Windows.Forms.ToolStripButton();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_FathersName = new System.Windows.Forms.Label();
            this.textBoxViewSingleFathersName = new System.Windows.Forms.TextBox();
            this.dataGridViewAddress = new System.Windows.Forms.DataGridView();
            this.buttonContactDelete = new System.Windows.Forms.Button();
            this.comboBoxContactType = new System.Windows.Forms.ComboBox();
            this.label_ContactDetail = new System.Windows.Forms.Label();
            this.label_ContactType = new System.Windows.Forms.Label();
            this.groupBoxContactEdit = new System.Windows.Forms.GroupBox();
            this.pictureBoxErrorContact = new System.Windows.Forms.PictureBox();
            this.textBoxContactDetail = new System.Windows.Forms.TextBox();
            this.buttonContactCancel = new System.Windows.Forms.Button();
            this.buttonContactSave = new System.Windows.Forms.Button();
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.groupBoxAddressEdit = new System.Windows.Forms.GroupBox();
            this.pictureBoxErrorAddress = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorCity = new System.Windows.Forms.PictureBox();
            this.textBoxStreetNumber = new System.Windows.Forms.TextBox();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.label_ZipCode = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label_StreetNumber = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_StreetName = new System.Windows.Forms.Label();
            this.buttonAddressCancel = new System.Windows.Forms.Button();
            this.buttonAddressSave = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.buttonAddressNew = new System.Windows.Forms.Button();
            this.buttonAddressDelete = new System.Windows.Forms.Button();
            this.buttonCancelAddressEdit = new System.Windows.Forms.Button();
            this.buttonEditAddress = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabPageContacts = new System.Windows.Forms.TabPage();
            this.panelContacts = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonContactNew = new System.Windows.Forms.Button();
            this.buttonCancelContactEdit = new System.Windows.Forms.Button();
            this.buttonEditContact = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tabPageNotes = new System.Windows.Forms.TabPage();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDetailsEdit = new System.Windows.Forms.Button();
            this.buttonDetailsSave = new System.Windows.Forms.Button();
            this.buttonDetailsCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_LastName = new System.Windows.Forms.Label();
            this.buttonNewTeacher = new System.Windows.Forms.Button();
            this.buttonNewCompany = new System.Windows.Forms.Button();
            this.buttonNewSupervisor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEditTeacher = new System.Windows.Forms.Button();
            this.buttonEditCompany = new System.Windows.Forms.Button();
            this.pictureBoxWrong = new System.Windows.Forms.PictureBox();
            this.pictureBoxCorrect = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorDuration = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorSupervisor = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorCompany = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorTeacher = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorAEM = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrotFatherName = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrotFirstName = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrotLastName = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorAFM = new System.Windows.Forms.PictureBox();
            this.buttonEditSupervisor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).BeginInit();
            this.groupBoxContactEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorContact)).BeginInit();
            this.tabControlInfo.SuspendLayout();
            this.tabPageAddress.SuspendLayout();
            this.panelAddress.SuspendLayout();
            this.panel17.SuspendLayout();
            this.groupBoxAddressEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorCity)).BeginInit();
            this.tabPageContacts.SuspendLayout();
            this.panelContacts.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tabPageNotes.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorSupervisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorAEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrotFatherName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrotFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrotLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorAFM)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_AEM
            // 
            this.label_AEM.AutoSize = true;
            this.label_AEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_AEM.ForeColor = System.Drawing.Color.White;
            this.label_AEM.Location = new System.Drawing.Point(6, 94);
            this.label_AEM.Name = "label_AEM";
            this.label_AEM.Size = new System.Drawing.Size(39, 13);
            this.label_AEM.TabIndex = 12;
            this.label_AEM.Text = "ΑΕΜ :";
            // 
            // textBoxViewSingleStudentAFM
            // 
            this.textBoxViewSingleStudentAFM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxViewSingleStudentAFM.Location = new System.Drawing.Point(151, 117);
            this.textBoxViewSingleStudentAFM.MaxLength = 9;
            this.textBoxViewSingleStudentAFM.Name = "textBoxViewSingleStudentAFM";
            this.textBoxViewSingleStudentAFM.ReadOnly = true;
            this.textBoxViewSingleStudentAFM.Size = new System.Drawing.Size(208, 20);
            this.textBoxViewSingleStudentAFM.TabIndex = 5;
            this.textBoxViewSingleStudentAFM.TextChanged += new System.EventHandler(this.textBoxViewSingleStudentAFM_TextChanged);
            // 
            // textBoxViewSingleStudentAEM
            // 
            this.textBoxViewSingleStudentAEM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxViewSingleStudentAEM.Location = new System.Drawing.Point(151, 91);
            this.textBoxViewSingleStudentAEM.Name = "textBoxViewSingleStudentAEM";
            this.textBoxViewSingleStudentAEM.ReadOnly = true;
            this.textBoxViewSingleStudentAEM.Size = new System.Drawing.Size(228, 20);
            this.textBoxViewSingleStudentAEM.TabIndex = 4;
            this.textBoxViewSingleStudentAEM.TextChanged += new System.EventHandler(this.textBoxViewSingleStudentAEM_TextChanged);
            // 
            // textBoxViewSingleStudentLastName
            // 
            this.textBoxViewSingleStudentLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxViewSingleStudentLastName.Location = new System.Drawing.Point(151, 13);
            this.textBoxViewSingleStudentLastName.Name = "textBoxViewSingleStudentLastName";
            this.textBoxViewSingleStudentLastName.ReadOnly = true;
            this.textBoxViewSingleStudentLastName.Size = new System.Drawing.Size(229, 20);
            this.textBoxViewSingleStudentLastName.TabIndex = 1;
            this.textBoxViewSingleStudentLastName.TextChanged += new System.EventHandler(this.textBoxViewSingleStudentLastName_TextChanged);
            // 
            // label_Afm
            // 
            this.label_Afm.AutoSize = true;
            this.label_Afm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Afm.ForeColor = System.Drawing.Color.White;
            this.label_Afm.Location = new System.Drawing.Point(6, 120);
            this.label_Afm.Name = "label_Afm";
            this.label_Afm.Size = new System.Drawing.Size(43, 13);
            this.label_Afm.TabIndex = 12;
            this.label_Afm.Text = "ΑΦΜ :";
            // 
            // label_Teacher
            // 
            this.label_Teacher.AutoSize = true;
            this.label_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Teacher.ForeColor = System.Drawing.Color.White;
            this.label_Teacher.Location = new System.Drawing.Point(5, 145);
            this.label_Teacher.Name = "label_Teacher";
            this.label_Teacher.Size = new System.Drawing.Size(101, 13);
            this.label_Teacher.TabIndex = 12;
            this.label_Teacher.Text = "Επ. Καθηγητής :";
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Company.ForeColor = System.Drawing.Color.White;
            this.label_Company.Location = new System.Drawing.Point(5, 171);
            this.label_Company.Name = "label_Company";
            this.label_Company.Size = new System.Drawing.Size(60, 13);
            this.label_Company.TabIndex = 12;
            this.label_Company.Text = "Εταιρία :";
            // 
            // label_Supervisor
            // 
            this.label_Supervisor.AutoSize = true;
            this.label_Supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Supervisor.ForeColor = System.Drawing.Color.White;
            this.label_Supervisor.Location = new System.Drawing.Point(4, 197);
            this.label_Supervisor.Name = "label_Supervisor";
            this.label_Supervisor.Size = new System.Drawing.Size(64, 13);
            this.label_Supervisor.TabIndex = 12;
            this.label_Supervisor.Text = "Επόπτης :";
            // 
            // label_Duration
            // 
            this.label_Duration.AutoSize = true;
            this.label_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Duration.ForeColor = System.Drawing.Color.White;
            this.label_Duration.Location = new System.Drawing.Point(4, 223);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(67, 13);
            this.label_Duration.TabIndex = 12;
            this.label_Duration.Text = "Διάρκεια :";
            // 
            // intershipDataSet
            // 
            this.intershipDataSet.DataSetName = "intershipDataSet";
            this.intershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.intershipDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyContactsTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CompanyTypeTableAdapter = null;
            this.tableAdapterManager.ContactsTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.SupervisorTableAdapter = null;
            this.tableAdapterManager.SupervisorTeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Intership.intershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // textBoxViewSingleStudentFirstName
            // 
            this.textBoxViewSingleStudentFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxViewSingleStudentFirstName.Location = new System.Drawing.Point(151, 39);
            this.textBoxViewSingleStudentFirstName.Name = "textBoxViewSingleStudentFirstName";
            this.textBoxViewSingleStudentFirstName.ReadOnly = true;
            this.textBoxViewSingleStudentFirstName.Size = new System.Drawing.Size(229, 20);
            this.textBoxViewSingleStudentFirstName.TabIndex = 2;
            this.textBoxViewSingleStudentFirstName.TextChanged += new System.EventHandler(this.textBoxViewSingleStudentFirstName_TextChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Enabled = false;
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(151, 221);
            this.dateTimePickerStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerStart.TabIndex = 16;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label_divader
            // 
            this.label_divader.AutoSize = true;
            this.label_divader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_divader.ForeColor = System.Drawing.Color.White;
            this.label_divader.Location = new System.Drawing.Point(258, 219);
            this.label_divader.Name = "label_divader";
            this.label_divader.Size = new System.Drawing.Size(14, 19);
            this.label_divader.TabIndex = 13;
            this.label_divader.Text = "-";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Enabled = false;
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(282, 221);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerEnd.TabIndex = 16;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // comboBoxViewTeacher
            // 
            this.comboBoxViewTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewTeacher.FormattingEnabled = true;
            this.comboBoxViewTeacher.Location = new System.Drawing.Point(151, 142);
            this.comboBoxViewTeacher.Name = "comboBoxViewTeacher";
            this.comboBoxViewTeacher.Size = new System.Drawing.Size(160, 21);
            this.comboBoxViewTeacher.TabIndex = 1;
            this.comboBoxViewTeacher.Visible = false;
            this.comboBoxViewTeacher.DropDown += new System.EventHandler(this.comboBoxViewTeacher_DropDown);
            this.comboBoxViewTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewTeacher_SelectedIndexChanged);
            // 
            // comboBoxViewCompany
            // 
            this.comboBoxViewCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewCompany.FormattingEnabled = true;
            this.comboBoxViewCompany.Location = new System.Drawing.Point(151, 168);
            this.comboBoxViewCompany.Name = "comboBoxViewCompany";
            this.comboBoxViewCompany.Size = new System.Drawing.Size(160, 21);
            this.comboBoxViewCompany.TabIndex = 17;
            this.comboBoxViewCompany.TabStop = false;
            this.comboBoxViewCompany.Visible = false;
            this.comboBoxViewCompany.DropDown += new System.EventHandler(this.comboBoxViewCompany_DropDown);
            this.comboBoxViewCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewCompany_SelectedIndexChanged);
            // 
            // comboBoxViewSupervisor
            // 
            this.comboBoxViewSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewSupervisor.FormattingEnabled = true;
            this.comboBoxViewSupervisor.Location = new System.Drawing.Point(151, 194);
            this.comboBoxViewSupervisor.Name = "comboBoxViewSupervisor";
            this.comboBoxViewSupervisor.Size = new System.Drawing.Size(160, 21);
            this.comboBoxViewSupervisor.TabIndex = 17;
            this.comboBoxViewSupervisor.TabStop = false;
            this.comboBoxViewSupervisor.Visible = false;
            this.comboBoxViewSupervisor.DropDown += new System.EventHandler(this.comboBoxViewSupervisor_DropDown);
            this.comboBoxViewSupervisor.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewSupervisor_SelectedIndexChanged);
            // 
            // buttonTeacherChecked
            // 
            this.buttonTeacherChecked.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeacherChecked.ForeColor = System.Drawing.Color.Green;
            this.buttonTeacherChecked.Location = new System.Drawing.Point(338, 142);
            this.buttonTeacherChecked.Name = "buttonTeacherChecked";
            this.buttonTeacherChecked.Size = new System.Drawing.Size(20, 21);
            this.buttonTeacherChecked.TabIndex = 18;
            this.buttonTeacherChecked.Text = "√";
            this.buttonTeacherChecked.UseVisualStyleBackColor = true;
            this.buttonTeacherChecked.Visible = false;
            this.buttonTeacherChecked.Click += new System.EventHandler(this.buttonTeacherChecked_Click);
            // 
            // buttonTeacherNonChecked
            // 
            this.buttonTeacherNonChecked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTeacherNonChecked.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeacherNonChecked.ForeColor = System.Drawing.Color.Red;
            this.buttonTeacherNonChecked.Location = new System.Drawing.Point(360, 142);
            this.buttonTeacherNonChecked.Name = "buttonTeacherNonChecked";
            this.buttonTeacherNonChecked.Size = new System.Drawing.Size(20, 21);
            this.buttonTeacherNonChecked.TabIndex = 18;
            this.buttonTeacherNonChecked.Text = "X";
            this.buttonTeacherNonChecked.UseVisualStyleBackColor = true;
            this.buttonTeacherNonChecked.Visible = false;
            this.buttonTeacherNonChecked.Click += new System.EventHandler(this.buttonTeacherNonChecked_Click);
            // 
            // textBoxViewSingleTeacher
            // 
            this.textBoxViewSingleTeacher.Location = new System.Drawing.Point(151, 142);
            this.textBoxViewSingleTeacher.MinimumSize = new System.Drawing.Size(4, 21);
            this.textBoxViewSingleTeacher.Name = "textBoxViewSingleTeacher";
            this.textBoxViewSingleTeacher.ReadOnly = true;
            this.textBoxViewSingleTeacher.Size = new System.Drawing.Size(208, 20);
            this.textBoxViewSingleTeacher.TabIndex = 6;
            this.textBoxViewSingleTeacher.TextChanged += new System.EventHandler(this.textBoxViewSingleTeacher_TextChanged);
            // 
            // buttonCompanyChecked
            // 
            this.buttonCompanyChecked.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompanyChecked.ForeColor = System.Drawing.Color.Green;
            this.buttonCompanyChecked.Location = new System.Drawing.Point(338, 168);
            this.buttonCompanyChecked.Name = "buttonCompanyChecked";
            this.buttonCompanyChecked.Size = new System.Drawing.Size(20, 21);
            this.buttonCompanyChecked.TabIndex = 18;
            this.buttonCompanyChecked.TabStop = false;
            this.buttonCompanyChecked.Text = "√";
            this.buttonCompanyChecked.UseVisualStyleBackColor = true;
            this.buttonCompanyChecked.Visible = false;
            this.buttonCompanyChecked.Click += new System.EventHandler(this.buttonCompanyChecked_Click);
            // 
            // buttonCompanyNonChecked
            // 
            this.buttonCompanyNonChecked.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompanyNonChecked.ForeColor = System.Drawing.Color.Red;
            this.buttonCompanyNonChecked.Location = new System.Drawing.Point(360, 168);
            this.buttonCompanyNonChecked.Name = "buttonCompanyNonChecked";
            this.buttonCompanyNonChecked.Size = new System.Drawing.Size(20, 21);
            this.buttonCompanyNonChecked.TabIndex = 18;
            this.buttonCompanyNonChecked.TabStop = false;
            this.buttonCompanyNonChecked.Text = "X";
            this.buttonCompanyNonChecked.UseVisualStyleBackColor = true;
            this.buttonCompanyNonChecked.Visible = false;
            this.buttonCompanyNonChecked.Click += new System.EventHandler(this.buttonCompanyNonChecked_Click);
            // 
            // buttonSupervisorChecked
            // 
            this.buttonSupervisorChecked.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupervisorChecked.ForeColor = System.Drawing.Color.Green;
            this.buttonSupervisorChecked.Location = new System.Drawing.Point(338, 194);
            this.buttonSupervisorChecked.Name = "buttonSupervisorChecked";
            this.buttonSupervisorChecked.Size = new System.Drawing.Size(20, 21);
            this.buttonSupervisorChecked.TabIndex = 18;
            this.buttonSupervisorChecked.Text = "√";
            this.buttonSupervisorChecked.UseVisualStyleBackColor = true;
            this.buttonSupervisorChecked.Visible = false;
            this.buttonSupervisorChecked.Click += new System.EventHandler(this.buttonSupervisorChecked_Click);
            // 
            // buttonSupervisorNonChecked
            // 
            this.buttonSupervisorNonChecked.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupervisorNonChecked.ForeColor = System.Drawing.Color.Red;
            this.buttonSupervisorNonChecked.Location = new System.Drawing.Point(360, 194);
            this.buttonSupervisorNonChecked.Name = "buttonSupervisorNonChecked";
            this.buttonSupervisorNonChecked.Size = new System.Drawing.Size(20, 21);
            this.buttonSupervisorNonChecked.TabIndex = 18;
            this.buttonSupervisorNonChecked.Text = "X";
            this.buttonSupervisorNonChecked.UseVisualStyleBackColor = true;
            this.buttonSupervisorNonChecked.Visible = false;
            this.buttonSupervisorNonChecked.Click += new System.EventHandler(this.buttonSupervisorNonChecked_Click);
            // 
            // textBoxViewSingleCompany
            // 
            this.textBoxViewSingleCompany.Location = new System.Drawing.Point(151, 168);
            this.textBoxViewSingleCompany.MaximumSize = new System.Drawing.Size(208, 21);
            this.textBoxViewSingleCompany.MinimumSize = new System.Drawing.Size(208, 21);
            this.textBoxViewSingleCompany.Name = "textBoxViewSingleCompany";
            this.textBoxViewSingleCompany.ReadOnly = true;
            this.textBoxViewSingleCompany.Size = new System.Drawing.Size(208, 20);
            this.textBoxViewSingleCompany.TabIndex = 7;
            this.textBoxViewSingleCompany.TextChanged += new System.EventHandler(this.textBoxViewSingleCompany_TextChanged);
            // 
            // textBoxViewSingleSupervisor
            // 
            this.textBoxViewSingleSupervisor.Location = new System.Drawing.Point(151, 194);
            this.textBoxViewSingleSupervisor.MinimumSize = new System.Drawing.Size(4, 21);
            this.textBoxViewSingleSupervisor.Name = "textBoxViewSingleSupervisor";
            this.textBoxViewSingleSupervisor.ReadOnly = true;
            this.textBoxViewSingleSupervisor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxViewSingleSupervisor.Size = new System.Drawing.Size(208, 20);
            this.textBoxViewSingleSupervisor.TabIndex = 8;
            this.textBoxViewSingleSupervisor.TextChanged += new System.EventHandler(this.textBoxViewSingleSupervisor_TextChanged);
            // 
            // dataGridViewContact
            // 
            this.dataGridViewContact.AllowUserToAddRows = false;
            this.dataGridViewContact.AllowUserToDeleteRows = false;
            this.dataGridViewContact.AllowUserToOrderColumns = true;
            this.dataGridViewContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContact.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContact.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewContact.Location = new System.Drawing.Point(9, 37);
            this.dataGridViewContact.MultiSelect = false;
            this.dataGridViewContact.Name = "dataGridViewContact";
            this.dataGridViewContact.ReadOnly = true;
            this.dataGridViewContact.RowHeadersVisible = false;
            this.dataGridViewContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContact.Size = new System.Drawing.Size(589, 136);
            this.dataGridViewContact.TabIndex = 19;
            this.dataGridViewContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContact_CellClick);
            this.dataGridViewContact.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewContact_RowsAdded);
            this.dataGridViewContact.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewContact_RowsRemoved);
            // 
            // label_Contacts
            // 
            this.label_Contacts.AutoSize = true;
            this.label_Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Contacts.ForeColor = System.Drawing.Color.White;
            this.label_Contacts.Location = new System.Drawing.Point(-1, 10);
            this.label_Contacts.Name = "label_Contacts";
            this.label_Contacts.Size = new System.Drawing.Size(148, 13);
            this.label_Contacts.TabIndex = 12;
            this.label_Contacts.Text = "Στοιχεία Επικοινωνίας :";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Adress.ForeColor = System.Drawing.Color.White;
            this.label_Adress.Location = new System.Drawing.Point(6, 10);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(88, 13);
            this.label_Adress.TabIndex = 12;
            this.label_Adress.Text = "Διευθύνσεις :";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCreate,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator3,
            this.toolStripButtonSave,
            this.toolStripSeparator2,
            this.toolStripButtonRestore});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(610, 25);
            this.toolStripMenu.TabIndex = 20;
            this.toolStripMenu.Text = "toolStripMenu";
            // 
            // toolStripCreate
            // 
            this.toolStripCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.toolStripCreate.BackColor = System.Drawing.Color.LightGray;
            this.toolStripCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCreate.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.toolStripCreate.Name = "toolStripCreate";
            this.toolStripCreate.Size = new System.Drawing.Size(94, 21);
            this.toolStripCreate.Text = "+ Νέα Εγγραφή";
            this.toolStripCreate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripCreate.Click += new System.EventHandler(this.toolStripCreate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.toolStripButtonEdit.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(77, 21);
            this.toolStripButtonEdit.Text = "Επεξεργασία";
            this.toolStripButtonEdit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.toolStripButtonSave.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(80, 21);
            this.toolStripButtonSave.Text = "Αποθήκευση";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRestore
            // 
            this.toolStripButtonRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.toolStripButtonRestore.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButtonRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRestore.Enabled = false;
            this.toolStripButtonRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRestore.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.toolStripButtonRestore.Name = "toolStripButtonRestore";
            this.toolStripButtonRestore.Size = new System.Drawing.Size(75, 21);
            this.toolStripButtonRestore.Text = "Επαναφορά";
            this.toolStripButtonRestore.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButtonRestore.Click += new System.EventHandler(this.toolStripButtonRestore_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_FirstName.ForeColor = System.Drawing.Color.White;
            this.label_FirstName.Location = new System.Drawing.Point(4, 42);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(52, 13);
            this.label_FirstName.TabIndex = 12;
            this.label_FirstName.Text = "Ονομα :";
            // 
            // label_FathersName
            // 
            this.label_FathersName.AutoSize = true;
            this.label_FathersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_FathersName.ForeColor = System.Drawing.Color.White;
            this.label_FathersName.Location = new System.Drawing.Point(5, 68);
            this.label_FathersName.Name = "label_FathersName";
            this.label_FathersName.Size = new System.Drawing.Size(82, 13);
            this.label_FathersName.TabIndex = 12;
            this.label_FathersName.Text = "Πατρώνυμο :";
            // 
            // textBoxViewSingleFathersName
            // 
            this.textBoxViewSingleFathersName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxViewSingleFathersName.Location = new System.Drawing.Point(151, 65);
            this.textBoxViewSingleFathersName.Name = "textBoxViewSingleFathersName";
            this.textBoxViewSingleFathersName.ReadOnly = true;
            this.textBoxViewSingleFathersName.Size = new System.Drawing.Size(229, 20);
            this.textBoxViewSingleFathersName.TabIndex = 3;
            this.textBoxViewSingleFathersName.TextChanged += new System.EventHandler(this.textBoxViewSingleFathersName_TextChanged);
            // 
            // dataGridViewAddress
            // 
            this.dataGridViewAddress.AllowUserToAddRows = false;
            this.dataGridViewAddress.AllowUserToDeleteRows = false;
            this.dataGridViewAddress.AllowUserToOrderColumns = true;
            this.dataGridViewAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddress.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAddress.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewAddress.Location = new System.Drawing.Point(10, 37);
            this.dataGridViewAddress.MultiSelect = false;
            this.dataGridViewAddress.Name = "dataGridViewAddress";
            this.dataGridViewAddress.ReadOnly = true;
            this.dataGridViewAddress.RowHeadersVisible = false;
            this.dataGridViewAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddress.Size = new System.Drawing.Size(576, 223);
            this.dataGridViewAddress.TabIndex = 19;
            this.dataGridViewAddress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddress_CellClick);
            this.dataGridViewAddress.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewAddress_RowsAdded);
            this.dataGridViewAddress.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewAddress_RowsRemoved);
            // 
            // buttonContactDelete
            // 
            this.buttonContactDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonContactDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonContactDelete.Location = new System.Drawing.Point(213, 6);
            this.buttonContactDelete.Name = "buttonContactDelete";
            this.buttonContactDelete.Size = new System.Drawing.Size(20, 21);
            this.buttonContactDelete.TabIndex = 18;
            this.buttonContactDelete.TabStop = false;
            this.buttonContactDelete.Text = "-";
            this.buttonContactDelete.UseVisualStyleBackColor = true;
            this.buttonContactDelete.Click += new System.EventHandler(this.buttonContactDelete_Click);
            // 
            // comboBoxContactType
            // 
            this.comboBoxContactType.Items.AddRange(new object[] {
            "Κινητό",
            "Οικία",
            "Εργασία",
            "Fax",
            "Email",
            "Άλλο"});
            this.comboBoxContactType.Location = new System.Drawing.Point(113, 17);
            this.comboBoxContactType.Name = "comboBoxContactType";
            this.comboBoxContactType.Size = new System.Drawing.Size(128, 21);
            this.comboBoxContactType.TabIndex = 20;
            // 
            // label_ContactDetail
            // 
            this.label_ContactDetail.AutoSize = true;
            this.label_ContactDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_ContactDetail.ForeColor = System.Drawing.Color.White;
            this.label_ContactDetail.Location = new System.Drawing.Point(6, 53);
            this.label_ContactDetail.Name = "label_ContactDetail";
            this.label_ContactDetail.Size = new System.Drawing.Size(49, 13);
            this.label_ContactDetail.TabIndex = 21;
            this.label_ContactDetail.Text = "Επαφή:";
            // 
            // label_ContactType
            // 
            this.label_ContactType.AutoSize = true;
            this.label_ContactType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_ContactType.ForeColor = System.Drawing.Color.White;
            this.label_ContactType.Location = new System.Drawing.Point(6, 20);
            this.label_ContactType.Name = "label_ContactType";
            this.label_ContactType.Size = new System.Drawing.Size(96, 13);
            this.label_ContactType.TabIndex = 22;
            this.label_ContactType.Text = "Είδος Επαφής :";
            // 
            // groupBoxContactEdit
            // 
            this.groupBoxContactEdit.Controls.Add(this.pictureBoxErrorContact);
            this.groupBoxContactEdit.Controls.Add(this.textBoxContactDetail);
            this.groupBoxContactEdit.Controls.Add(this.comboBoxContactType);
            this.groupBoxContactEdit.Controls.Add(this.label_ContactDetail);
            this.groupBoxContactEdit.Controls.Add(this.label_ContactType);
            this.groupBoxContactEdit.Controls.Add(this.buttonContactCancel);
            this.groupBoxContactEdit.Controls.Add(this.buttonContactSave);
            this.groupBoxContactEdit.ForeColor = System.Drawing.Color.White;
            this.groupBoxContactEdit.Location = new System.Drawing.Point(2, 2);
            this.groupBoxContactEdit.Name = "groupBoxContactEdit";
            this.groupBoxContactEdit.Size = new System.Drawing.Size(302, 81);
            this.groupBoxContactEdit.TabIndex = 25;
            this.groupBoxContactEdit.TabStop = false;
            this.groupBoxContactEdit.Text = "Επεξεργασία";
            this.groupBoxContactEdit.Visible = false;
            // 
            // pictureBoxErrorContact
            // 
            this.pictureBoxErrorContact.BackgroundImage = global::Intership.Properties.Resources.attention;
            this.pictureBoxErrorContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorContact.Location = new System.Drawing.Point(95, 53);
            this.pictureBoxErrorContact.Name = "pictureBoxErrorContact";
            this.pictureBoxErrorContact.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorContact.TabIndex = 29;
            this.pictureBoxErrorContact.TabStop = false;
            // 
            // textBoxContactDetail
            // 
            this.textBoxContactDetail.Location = new System.Drawing.Point(113, 50);
            this.textBoxContactDetail.Name = "textBoxContactDetail";
            this.textBoxContactDetail.Size = new System.Drawing.Size(128, 20);
            this.textBoxContactDetail.TabIndex = 21;
            this.textBoxContactDetail.TextChanged += new System.EventHandler(this.textBoxContactDetail_TextChanged);
            // 
            // buttonContactCancel
            // 
            this.buttonContactCancel.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContactCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonContactCancel.Location = new System.Drawing.Point(261, 50);
            this.buttonContactCancel.Name = "buttonContactCancel";
            this.buttonContactCancel.Size = new System.Drawing.Size(20, 21);
            this.buttonContactCancel.TabIndex = 23;
            this.buttonContactCancel.Text = "X";
            this.buttonContactCancel.UseVisualStyleBackColor = true;
            this.buttonContactCancel.Click += new System.EventHandler(this.buttonContactCancel_Click);
            // 
            // buttonContactSave
            // 
            this.buttonContactSave.Enabled = false;
            this.buttonContactSave.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContactSave.ForeColor = System.Drawing.Color.Green;
            this.buttonContactSave.Location = new System.Drawing.Point(261, 17);
            this.buttonContactSave.Name = "buttonContactSave";
            this.buttonContactSave.Size = new System.Drawing.Size(20, 21);
            this.buttonContactSave.TabIndex = 22;
            this.buttonContactSave.Text = "√";
            this.buttonContactSave.UseVisualStyleBackColor = true;
            this.buttonContactSave.Click += new System.EventHandler(this.buttonContactSave_Click);
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Controls.Add(this.tabPageAddress);
            this.tabControlInfo.Controls.Add(this.tabPageContacts);
            this.tabControlInfo.Controls.Add(this.tabPageNotes);
            this.tabControlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlInfo.Location = new System.Drawing.Point(0, 299);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.ShowToolTips = true;
            this.tabControlInfo.Size = new System.Drawing.Size(610, 292);
            this.tabControlInfo.TabIndex = 26;
            this.tabControlInfo.TabStop = false;
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPageAddress.Controls.Add(this.panelAddress);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddress.Size = new System.Drawing.Size(602, 266);
            this.tabPageAddress.TabIndex = 2;
            this.tabPageAddress.Text = "Διεύθυνση";
            // 
            // panelAddress
            // 
            this.panelAddress.Controls.Add(this.panel17);
            this.panelAddress.Controls.Add(this.dataGridViewAddress);
            this.panelAddress.Controls.Add(this.panel16);
            this.panelAddress.Controls.Add(this.panel10);
            this.panelAddress.Controls.Add(this.buttonAddressNew);
            this.panelAddress.Controls.Add(this.buttonAddressDelete);
            this.panelAddress.Controls.Add(this.buttonCancelAddressEdit);
            this.panelAddress.Controls.Add(this.buttonEditAddress);
            this.panelAddress.Controls.Add(this.label_Adress);
            this.panelAddress.Controls.Add(this.panel7);
            this.panelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddress.Location = new System.Drawing.Point(3, 3);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(596, 260);
            this.panelAddress.TabIndex = 27;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.groupBoxAddressEdit);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(10, 170);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(576, 90);
            this.panel17.TabIndex = 30;
            // 
            // groupBoxAddressEdit
            // 
            this.groupBoxAddressEdit.Controls.Add(this.pictureBoxErrorAddress);
            this.groupBoxAddressEdit.Controls.Add(this.pictureBoxErrorCity);
            this.groupBoxAddressEdit.Controls.Add(this.textBoxStreetNumber);
            this.groupBoxAddressEdit.Controls.Add(this.textBoxStreetName);
            this.groupBoxAddressEdit.Controls.Add(this.textBoxZipCode);
            this.groupBoxAddressEdit.Controls.Add(this.label_ZipCode);
            this.groupBoxAddressEdit.Controls.Add(this.textBoxCity);
            this.groupBoxAddressEdit.Controls.Add(this.label_StreetNumber);
            this.groupBoxAddressEdit.Controls.Add(this.label_City);
            this.groupBoxAddressEdit.Controls.Add(this.label_StreetName);
            this.groupBoxAddressEdit.Controls.Add(this.buttonAddressCancel);
            this.groupBoxAddressEdit.Controls.Add(this.buttonAddressSave);
            this.groupBoxAddressEdit.ForeColor = System.Drawing.Color.White;
            this.groupBoxAddressEdit.Location = new System.Drawing.Point(0, 3);
            this.groupBoxAddressEdit.Name = "groupBoxAddressEdit";
            this.groupBoxAddressEdit.Size = new System.Drawing.Size(561, 79);
            this.groupBoxAddressEdit.TabIndex = 26;
            this.groupBoxAddressEdit.TabStop = false;
            this.groupBoxAddressEdit.Text = "Επεξεργασία";
            this.groupBoxAddressEdit.Visible = false;
            // 
            // pictureBoxErrorAddress
            // 
            this.pictureBoxErrorAddress.BackgroundImage = global::Intership.Properties.Resources.attention;
            this.pictureBoxErrorAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorAddress.Location = new System.Drawing.Point(96, 19);
            this.pictureBoxErrorAddress.Name = "pictureBoxErrorAddress";
            this.pictureBoxErrorAddress.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorAddress.TabIndex = 28;
            this.pictureBoxErrorAddress.TabStop = false;
            // 
            // pictureBoxErrorCity
            // 
            this.pictureBoxErrorCity.BackgroundImage = global::Intership.Properties.Resources.attention;
            this.pictureBoxErrorCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorCity.Location = new System.Drawing.Point(96, 52);
            this.pictureBoxErrorCity.Name = "pictureBoxErrorCity";
            this.pictureBoxErrorCity.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorCity.TabIndex = 28;
            this.pictureBoxErrorCity.TabStop = false;
            // 
            // textBoxStreetNumber
            // 
            this.textBoxStreetNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxStreetNumber.Location = new System.Drawing.Point(423, 17);
            this.textBoxStreetNumber.Name = "textBoxStreetNumber";
            this.textBoxStreetNumber.Size = new System.Drawing.Size(80, 20);
            this.textBoxStreetNumber.TabIndex = 11;
            // 
            // textBoxStreetName
            // 
            this.textBoxStreetName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxStreetName.Location = new System.Drawing.Point(113, 17);
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(165, 20);
            this.textBoxStreetName.TabIndex = 10;
            this.textBoxStreetName.TextChanged += new System.EventHandler(this.AddressChanged_TextChanged);
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxZipCode.Location = new System.Drawing.Point(423, 50);
            this.textBoxZipCode.MaxLength = 5;
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(80, 20);
            this.textBoxZipCode.TabIndex = 13;
            // 
            // label_ZipCode
            // 
            this.label_ZipCode.AutoSize = true;
            this.label_ZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_ZipCode.ForeColor = System.Drawing.Color.White;
            this.label_ZipCode.Location = new System.Drawing.Point(307, 53);
            this.label_ZipCode.Name = "label_ZipCode";
            this.label_ZipCode.Size = new System.Drawing.Size(92, 13);
            this.label_ZipCode.TabIndex = 21;
            this.label_ZipCode.Text = "Ταχ. Κωδικός :";
            // 
            // textBoxCity
            // 
            this.textBoxCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCity.Location = new System.Drawing.Point(113, 50);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(165, 20);
            this.textBoxCity.TabIndex = 12;
            this.textBoxCity.TextChanged += new System.EventHandler(this.AddressChanged_TextChanged);
            // 
            // label_StreetNumber
            // 
            this.label_StreetNumber.AutoSize = true;
            this.label_StreetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_StreetNumber.ForeColor = System.Drawing.Color.White;
            this.label_StreetNumber.Location = new System.Drawing.Point(307, 20);
            this.label_StreetNumber.Name = "label_StreetNumber";
            this.label_StreetNumber.Size = new System.Drawing.Size(62, 13);
            this.label_StreetNumber.TabIndex = 22;
            this.label_StreetNumber.Text = "Αριθμός :";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_City.ForeColor = System.Drawing.Color.White;
            this.label_City.Location = new System.Drawing.Point(6, 53);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(43, 13);
            this.label_City.TabIndex = 21;
            this.label_City.Text = "Πόλη :";
            // 
            // label_StreetName
            // 
            this.label_StreetName.AutoSize = true;
            this.label_StreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_StreetName.ForeColor = System.Drawing.Color.White;
            this.label_StreetName.Location = new System.Drawing.Point(6, 20);
            this.label_StreetName.Name = "label_StreetName";
            this.label_StreetName.Size = new System.Drawing.Size(44, 13);
            this.label_StreetName.TabIndex = 22;
            this.label_StreetName.Text = "Οδός :";
            // 
            // buttonAddressCancel
            // 
            this.buttonAddressCancel.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddressCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonAddressCancel.Location = new System.Drawing.Point(525, 50);
            this.buttonAddressCancel.Name = "buttonAddressCancel";
            this.buttonAddressCancel.Size = new System.Drawing.Size(20, 21);
            this.buttonAddressCancel.TabIndex = 15;
            this.buttonAddressCancel.TabStop = false;
            this.buttonAddressCancel.Text = "X";
            this.buttonAddressCancel.UseVisualStyleBackColor = true;
            this.buttonAddressCancel.Click += new System.EventHandler(this.buttonCancelAddressEdit_Click);
            // 
            // buttonAddressSave
            // 
            this.buttonAddressSave.Enabled = false;
            this.buttonAddressSave.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddressSave.ForeColor = System.Drawing.Color.Green;
            this.buttonAddressSave.Location = new System.Drawing.Point(525, 16);
            this.buttonAddressSave.Name = "buttonAddressSave";
            this.buttonAddressSave.Size = new System.Drawing.Size(20, 21);
            this.buttonAddressSave.TabIndex = 14;
            this.buttonAddressSave.TabStop = false;
            this.buttonAddressSave.Text = "√";
            this.buttonAddressSave.UseVisualStyleBackColor = true;
            this.buttonAddressSave.Click += new System.EventHandler(this.buttonAddressSave_Click);
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(586, 37);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(10, 223);
            this.panel16.TabIndex = 29;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 37);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 223);
            this.panel10.TabIndex = 28;
            // 
            // buttonAddressNew
            // 
            this.buttonAddressNew.AccessibleDescription = "";
            this.buttonAddressNew.AccessibleName = "";
            this.buttonAddressNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonAddressNew.ForeColor = System.Drawing.Color.Green;
            this.buttonAddressNew.Location = new System.Drawing.Point(100, 6);
            this.buttonAddressNew.Name = "buttonAddressNew";
            this.buttonAddressNew.Size = new System.Drawing.Size(20, 21);
            this.buttonAddressNew.TabIndex = 20;
            this.buttonAddressNew.TabStop = false;
            this.buttonAddressNew.Text = "+";
            this.buttonAddressNew.UseVisualStyleBackColor = true;
            this.buttonAddressNew.Click += new System.EventHandler(this.buttonAddressNew_Click);
            // 
            // buttonAddressDelete
            // 
            this.buttonAddressDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonAddressDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonAddressDelete.Location = new System.Drawing.Point(152, 6);
            this.buttonAddressDelete.Name = "buttonAddressDelete";
            this.buttonAddressDelete.Size = new System.Drawing.Size(20, 21);
            this.buttonAddressDelete.TabIndex = 21;
            this.buttonAddressDelete.TabStop = false;
            this.buttonAddressDelete.Text = "-";
            this.buttonAddressDelete.UseVisualStyleBackColor = true;
            this.buttonAddressDelete.Click += new System.EventHandler(this.buttonAddressDelete_Click);
            // 
            // buttonCancelAddressEdit
            // 
            this.buttonCancelAddressEdit.Enabled = false;
            this.buttonCancelAddressEdit.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAddressEdit.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelAddressEdit.Location = new System.Drawing.Point(178, 6);
            this.buttonCancelAddressEdit.Name = "buttonCancelAddressEdit";
            this.buttonCancelAddressEdit.Size = new System.Drawing.Size(20, 21);
            this.buttonCancelAddressEdit.TabIndex = 22;
            this.buttonCancelAddressEdit.TabStop = false;
            this.buttonCancelAddressEdit.Text = "X";
            this.buttonCancelAddressEdit.UseVisualStyleBackColor = true;
            this.buttonCancelAddressEdit.Click += new System.EventHandler(this.buttonCancelAddressEdit_Click);
            // 
            // buttonEditAddress
            // 
            this.buttonEditAddress.BackgroundImage = global::Intership.Properties.Resources.edit_button_image_68871;
            this.buttonEditAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditAddress.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditAddress.Location = new System.Drawing.Point(126, 6);
            this.buttonEditAddress.Name = "buttonEditAddress";
            this.buttonEditAddress.Size = new System.Drawing.Size(20, 21);
            this.buttonEditAddress.TabIndex = 23;
            this.buttonEditAddress.TabStop = false;
            this.buttonEditAddress.UseVisualStyleBackColor = true;
            this.buttonEditAddress.Click += new System.EventHandler(this.buttonEditAddress_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(596, 37);
            this.panel7.TabIndex = 27;
            // 
            // tabPageContacts
            // 
            this.tabPageContacts.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPageContacts.Controls.Add(this.panelContacts);
            this.tabPageContacts.Location = new System.Drawing.Point(4, 22);
            this.tabPageContacts.Name = "tabPageContacts";
            this.tabPageContacts.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageContacts.Size = new System.Drawing.Size(602, 266);
            this.tabPageContacts.TabIndex = 1;
            this.tabPageContacts.Text = "Στοιχεία Επικοινωνίας";
            // 
            // panelContacts
            // 
            this.panelContacts.Controls.Add(this.panel14);
            this.panelContacts.Controls.Add(this.dataGridViewContact);
            this.panelContacts.Controls.Add(this.buttonContactNew);
            this.panelContacts.Controls.Add(this.buttonContactDelete);
            this.panelContacts.Controls.Add(this.buttonCancelContactEdit);
            this.panelContacts.Controls.Add(this.buttonEditContact);
            this.panelContacts.Controls.Add(this.panel12);
            this.panelContacts.Controls.Add(this.panel15);
            this.panelContacts.Controls.Add(this.panel13);
            this.panelContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContacts.Location = new System.Drawing.Point(2, 2);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(598, 262);
            this.panelContacts.TabIndex = 26;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(585, 37);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(13, 136);
            this.panel14.TabIndex = 28;
            // 
            // buttonContactNew
            // 
            this.buttonContactNew.AccessibleDescription = "";
            this.buttonContactNew.AccessibleName = "";
            this.buttonContactNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonContactNew.ForeColor = System.Drawing.Color.Green;
            this.buttonContactNew.Location = new System.Drawing.Point(161, 6);
            this.buttonContactNew.Name = "buttonContactNew";
            this.buttonContactNew.Size = new System.Drawing.Size(20, 21);
            this.buttonContactNew.TabIndex = 18;
            this.buttonContactNew.TabStop = false;
            this.buttonContactNew.Text = "+";
            this.buttonContactNew.UseVisualStyleBackColor = true;
            this.buttonContactNew.Click += new System.EventHandler(this.buttonContactNew_Click);
            // 
            // buttonCancelContactEdit
            // 
            this.buttonCancelContactEdit.Enabled = false;
            this.buttonCancelContactEdit.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelContactEdit.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelContactEdit.Location = new System.Drawing.Point(239, 7);
            this.buttonCancelContactEdit.Name = "buttonCancelContactEdit";
            this.buttonCancelContactEdit.Size = new System.Drawing.Size(20, 21);
            this.buttonCancelContactEdit.TabIndex = 18;
            this.buttonCancelContactEdit.TabStop = false;
            this.buttonCancelContactEdit.Text = "X";
            this.buttonCancelContactEdit.UseVisualStyleBackColor = true;
            this.buttonCancelContactEdit.Click += new System.EventHandler(this.buttonContactCancel_Click);
            // 
            // buttonEditContact
            // 
            this.buttonEditContact.BackgroundImage = global::Intership.Properties.Resources.edit_button_image_68871;
            this.buttonEditContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditContact.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditContact.Location = new System.Drawing.Point(187, 6);
            this.buttonEditContact.Name = "buttonEditContact";
            this.buttonEditContact.Size = new System.Drawing.Size(20, 21);
            this.buttonEditContact.TabIndex = 18;
            this.buttonEditContact.TabStop = false;
            this.buttonEditContact.UseVisualStyleBackColor = true;
            this.buttonEditContact.Click += new System.EventHandler(this.buttonEditContact_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label_Contacts);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(9, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(589, 37);
            this.panel12.TabIndex = 26;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.groupBoxContactEdit);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(9, 173);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(589, 89);
            this.panel15.TabIndex = 29;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(9, 262);
            this.panel13.TabIndex = 27;
            // 
            // tabPageNotes
            // 
            this.tabPageNotes.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPageNotes.Controls.Add(this.panelDetails);
            this.tabPageNotes.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotes.Name = "tabPageNotes";
            this.tabPageNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotes.Size = new System.Drawing.Size(602, 266);
            this.tabPageNotes.TabIndex = 3;
            this.tabPageNotes.Text = "Σημειώσεις";
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.panel1);
            this.panelDetails.Controls.Add(this.panel4);
            this.panelDetails.Controls.Add(this.panel3);
            this.panelDetails.Controls.Add(this.richTextBoxNotes);
            this.panelDetails.Controls.Add(this.panel2);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(3, 3);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(596, 260);
            this.panelDetails.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 10);
            this.panel1.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.buttonDetailsEdit);
            this.panel4.Controls.Add(this.buttonDetailsSave);
            this.panel4.Controls.Add(this.buttonDetailsCancel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 32);
            this.panel4.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Σημειώσεις για τον Φοιτητή :";
            // 
            // buttonDetailsEdit
            // 
            this.buttonDetailsEdit.BackgroundImage = global::Intership.Properties.Resources.edit_button_image_68871;
            this.buttonDetailsEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDetailsEdit.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetailsEdit.Location = new System.Drawing.Point(189, 7);
            this.buttonDetailsEdit.Name = "buttonDetailsEdit";
            this.buttonDetailsEdit.Size = new System.Drawing.Size(20, 21);
            this.buttonDetailsEdit.TabIndex = 19;
            this.buttonDetailsEdit.TabStop = false;
            this.buttonDetailsEdit.UseVisualStyleBackColor = true;
            this.buttonDetailsEdit.Click += new System.EventHandler(this.buttonDetailsEdit_Click);
            // 
            // buttonDetailsSave
            // 
            this.buttonDetailsSave.Enabled = false;
            this.buttonDetailsSave.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetailsSave.ForeColor = System.Drawing.Color.Green;
            this.buttonDetailsSave.Location = new System.Drawing.Point(215, 7);
            this.buttonDetailsSave.Name = "buttonDetailsSave";
            this.buttonDetailsSave.Size = new System.Drawing.Size(20, 21);
            this.buttonDetailsSave.TabIndex = 23;
            this.buttonDetailsSave.Text = "√";
            this.buttonDetailsSave.UseVisualStyleBackColor = true;
            this.buttonDetailsSave.Click += new System.EventHandler(this.buttonDetailsSave_Click);
            // 
            // buttonDetailsCancel
            // 
            this.buttonDetailsCancel.Enabled = false;
            this.buttonDetailsCancel.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetailsCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonDetailsCancel.Location = new System.Drawing.Point(241, 7);
            this.buttonDetailsCancel.Name = "buttonDetailsCancel";
            this.buttonDetailsCancel.Size = new System.Drawing.Size(20, 21);
            this.buttonDetailsCancel.TabIndex = 24;
            this.buttonDetailsCancel.TabStop = false;
            this.buttonDetailsCancel.Text = "X";
            this.buttonDetailsCancel.UseVisualStyleBackColor = true;
            this.buttonDetailsCancel.Click += new System.EventHandler(this.buttonDetailsCancel_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 260);
            this.panel3.TabIndex = 27;
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.BackColor = System.Drawing.Color.White;
            this.richTextBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBoxNotes.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxNotes.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.ReadOnly = true;
            this.richTextBoxNotes.Size = new System.Drawing.Size(586, 260);
            this.richTextBoxNotes.TabIndex = 0;
            this.richTextBoxNotes.Text = "";
            this.richTextBoxNotes.TextChanged += new System.EventHandler(this.richTextBoxNotes_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(586, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 260);
            this.panel2.TabIndex = 26;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_LastName.ForeColor = System.Drawing.Color.White;
            this.label_LastName.Location = new System.Drawing.Point(4, 16);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(61, 13);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Επίθετο :";
            // 
            // buttonNewTeacher
            // 
            this.buttonNewTeacher.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewTeacher.ForeColor = System.Drawing.Color.Blue;
            this.buttonNewTeacher.Location = new System.Drawing.Point(314, 142);
            this.buttonNewTeacher.Name = "buttonNewTeacher";
            this.buttonNewTeacher.Size = new System.Drawing.Size(20, 21);
            this.buttonNewTeacher.TabIndex = 18;
            this.buttonNewTeacher.Text = "+";
            this.buttonNewTeacher.UseVisualStyleBackColor = true;
            this.buttonNewTeacher.Visible = false;
            this.buttonNewTeacher.Click += new System.EventHandler(this.buttonNewTeacher_Click);
            // 
            // buttonNewCompany
            // 
            this.buttonNewCompany.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCompany.ForeColor = System.Drawing.Color.Blue;
            this.buttonNewCompany.Location = new System.Drawing.Point(314, 168);
            this.buttonNewCompany.Name = "buttonNewCompany";
            this.buttonNewCompany.Size = new System.Drawing.Size(20, 21);
            this.buttonNewCompany.TabIndex = 18;
            this.buttonNewCompany.Text = "+";
            this.buttonNewCompany.UseVisualStyleBackColor = true;
            this.buttonNewCompany.Visible = false;
            this.buttonNewCompany.Click += new System.EventHandler(this.buttonNewCompany_Click);
            // 
            // buttonNewSupervisor
            // 
            this.buttonNewSupervisor.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewSupervisor.ForeColor = System.Drawing.Color.Blue;
            this.buttonNewSupervisor.Location = new System.Drawing.Point(314, 194);
            this.buttonNewSupervisor.Name = "buttonNewSupervisor";
            this.buttonNewSupervisor.Size = new System.Drawing.Size(20, 21);
            this.buttonNewSupervisor.TabIndex = 18;
            this.buttonNewSupervisor.Text = "+";
            this.buttonNewSupervisor.UseVisualStyleBackColor = true;
            this.buttonNewSupervisor.Visible = false;
            this.buttonNewSupervisor.Click += new System.EventHandler(this.buttonNewSupervisor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSupervisorChecked);
            this.groupBox1.Controls.Add(this.buttonCompanyChecked);
            this.groupBox1.Controls.Add(this.buttonNewSupervisor);
            this.groupBox1.Controls.Add(this.buttonNewCompany);
            this.groupBox1.Controls.Add(this.buttonNewTeacher);
            this.groupBox1.Controls.Add(this.buttonTeacherChecked);
            this.groupBox1.Controls.Add(this.comboBoxViewSupervisor);
            this.groupBox1.Controls.Add(this.comboBoxViewCompany);
            this.groupBox1.Controls.Add(this.comboBoxViewTeacher);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Controls.Add(this.label_divader);
            this.groupBox1.Controls.Add(this.label_FathersName);
            this.groupBox1.Controls.Add(this.label_FirstName);
            this.groupBox1.Controls.Add(this.label_LastName);
            this.groupBox1.Controls.Add(this.label_Duration);
            this.groupBox1.Controls.Add(this.label_Supervisor);
            this.groupBox1.Controls.Add(this.label_Company);
            this.groupBox1.Controls.Add(this.label_Teacher);
            this.groupBox1.Controls.Add(this.label_Afm);
            this.groupBox1.Controls.Add(this.label_AEM);
            this.groupBox1.Controls.Add(this.textBoxViewSingleSupervisor);
            this.groupBox1.Controls.Add(this.textBoxViewSingleCompany);
            this.groupBox1.Controls.Add(this.textBoxViewSingleTeacher);
            this.groupBox1.Controls.Add(this.textBoxViewSingleStudentAEM);
            this.groupBox1.Controls.Add(this.textBoxViewSingleFathersName);
            this.groupBox1.Controls.Add(this.textBoxViewSingleStudentFirstName);
            this.groupBox1.Controls.Add(this.textBoxViewSingleStudentLastName);
            this.groupBox1.Controls.Add(this.buttonTeacherNonChecked);
            this.groupBox1.Controls.Add(this.buttonEditTeacher);
            this.groupBox1.Controls.Add(this.buttonCompanyNonChecked);
            this.groupBox1.Controls.Add(this.buttonEditCompany);
            this.groupBox1.Controls.Add(this.buttonSupervisorNonChecked);
            this.groupBox1.Controls.Add(this.pictureBoxWrong);
            this.groupBox1.Controls.Add(this.pictureBoxCorrect);
            this.groupBox1.Controls.Add(this.textBoxViewSingleStudentAFM);
            this.groupBox1.Controls.Add(this.pictureBoxErrorDuration);
            this.groupBox1.Controls.Add(this.pictureBoxErrorSupervisor);
            this.groupBox1.Controls.Add(this.pictureBoxErrorCompany);
            this.groupBox1.Controls.Add(this.pictureBoxErrorTeacher);
            this.groupBox1.Controls.Add(this.pictureBoxErrorAEM);
            this.groupBox1.Controls.Add(this.pictureBoxErrotFatherName);
            this.groupBox1.Controls.Add(this.pictureBoxErrotFirstName);
            this.groupBox1.Controls.Add(this.pictureBoxErrotLastName);
            this.groupBox1.Controls.Add(this.pictureBoxErrorAFM);
            this.groupBox1.Controls.Add(this.buttonEditSupervisor);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(200, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 255);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // buttonEditTeacher
            // 
            this.buttonEditTeacher.BackgroundImage = global::Intership.Properties.Resources.edit_button_image_68871;
            this.buttonEditTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditTeacher.Enabled = false;
            this.buttonEditTeacher.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTeacher.Location = new System.Drawing.Point(359, 142);
            this.buttonEditTeacher.Name = "buttonEditTeacher";
            this.buttonEditTeacher.Size = new System.Drawing.Size(20, 21);
            this.buttonEditTeacher.TabIndex = 18;
            this.buttonEditTeacher.UseVisualStyleBackColor = true;
            this.buttonEditTeacher.Click += new System.EventHandler(this.buttonEditTeacher_Click);
            // 
            // buttonEditCompany
            // 
            this.buttonEditCompany.BackgroundImage = global::Intership.Properties.Resources.edit_button_image_68871;
            this.buttonEditCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditCompany.Enabled = false;
            this.buttonEditCompany.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCompany.Location = new System.Drawing.Point(359, 168);
            this.buttonEditCompany.Name = "buttonEditCompany";
            this.buttonEditCompany.Size = new System.Drawing.Size(20, 21);
            this.buttonEditCompany.TabIndex = 18;
            this.buttonEditCompany.UseVisualStyleBackColor = true;
            this.buttonEditCompany.Click += new System.EventHandler(this.buttonEditCompany_Click);
            // 
            // pictureBoxWrong
            // 
            this.pictureBoxWrong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWrong.BackgroundImage")));
            this.pictureBoxWrong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxWrong.Location = new System.Drawing.Point(360, 117);
            this.pictureBoxWrong.Name = "pictureBoxWrong";
            this.pictureBoxWrong.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxWrong.TabIndex = 29;
            this.pictureBoxWrong.TabStop = false;
            this.pictureBoxWrong.Visible = false;
            // 
            // pictureBoxCorrect
            // 
            this.pictureBoxCorrect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCorrect.BackgroundImage")));
            this.pictureBoxCorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCorrect.Location = new System.Drawing.Point(360, 117);
            this.pictureBoxCorrect.Name = "pictureBoxCorrect";
            this.pictureBoxCorrect.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxCorrect.TabIndex = 28;
            this.pictureBoxCorrect.TabStop = false;
            this.pictureBoxCorrect.Visible = false;
            // 
            // pictureBoxErrorDuration
            // 
            this.pictureBoxErrorDuration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxErrorDuration.BackgroundImage")));
            this.pictureBoxErrorDuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorDuration.Location = new System.Drawing.Point(132, 223);
            this.pictureBoxErrorDuration.Name = "pictureBoxErrorDuration";
            this.pictureBoxErrorDuration.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorDuration.TabIndex = 27;
            this.pictureBoxErrorDuration.TabStop = false;
            // 
            // pictureBoxErrorSupervisor
            // 
            this.pictureBoxErrorSupervisor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxErrorSupervisor.BackgroundImage")));
            this.pictureBoxErrorSupervisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorSupervisor.Location = new System.Drawing.Point(132, 196);
            this.pictureBoxErrorSupervisor.Name = "pictureBoxErrorSupervisor";
            this.pictureBoxErrorSupervisor.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorSupervisor.TabIndex = 27;
            this.pictureBoxErrorSupervisor.TabStop = false;
            // 
            // pictureBoxErrorCompany
            // 
            this.pictureBoxErrorCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxErrorCompany.BackgroundImage")));
            this.pictureBoxErrorCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorCompany.Location = new System.Drawing.Point(132, 170);
            this.pictureBoxErrorCompany.Name = "pictureBoxErrorCompany";
            this.pictureBoxErrorCompany.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorCompany.TabIndex = 27;
            this.pictureBoxErrorCompany.TabStop = false;
            // 
            // pictureBoxErrorTeacher
            // 
            this.pictureBoxErrorTeacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxErrorTeacher.BackgroundImage")));
            this.pictureBoxErrorTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorTeacher.Location = new System.Drawing.Point(132, 144);
            this.pictureBoxErrorTeacher.Name = "pictureBoxErrorTeacher";
            this.pictureBoxErrorTeacher.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorTeacher.TabIndex = 27;
            this.pictureBoxErrorTeacher.TabStop = false;
            // 
            // pictureBoxErrorAEM
            // 
            this.pictureBoxErrorAEM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxErrorAEM.BackgroundImage")));
            this.pictureBoxErrorAEM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorAEM.Location = new System.Drawing.Point(132, 93);
            this.pictureBoxErrorAEM.Name = "pictureBoxErrorAEM";
            this.pictureBoxErrorAEM.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorAEM.TabIndex = 27;
            this.pictureBoxErrorAEM.TabStop = false;
            // 
            // pictureBoxErrotFatherName
            // 
            this.pictureBoxErrotFatherName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxErrotFatherName.BackgroundImage")));
            this.pictureBoxErrotFatherName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrotFatherName.Location = new System.Drawing.Point(132, 66);
            this.pictureBoxErrotFatherName.Name = "pictureBoxErrotFatherName";
            this.pictureBoxErrotFatherName.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrotFatherName.TabIndex = 27;
            this.pictureBoxErrotFatherName.TabStop = false;
            // 
            // pictureBoxErrotFirstName
            // 
            this.pictureBoxErrotFirstName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxErrotFirstName.BackgroundImage")));
            this.pictureBoxErrotFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrotFirstName.Location = new System.Drawing.Point(132, 40);
            this.pictureBoxErrotFirstName.Name = "pictureBoxErrotFirstName";
            this.pictureBoxErrotFirstName.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrotFirstName.TabIndex = 27;
            this.pictureBoxErrotFirstName.TabStop = false;
            // 
            // pictureBoxErrotLastName
            // 
            this.pictureBoxErrotLastName.BackgroundImage = global::Intership.Properties.Resources.attention;
            this.pictureBoxErrotLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrotLastName.Location = new System.Drawing.Point(132, 14);
            this.pictureBoxErrotLastName.Name = "pictureBoxErrotLastName";
            this.pictureBoxErrotLastName.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrotLastName.TabIndex = 27;
            this.pictureBoxErrotLastName.TabStop = false;
            // 
            // pictureBoxErrorAFM
            // 
            this.pictureBoxErrorAFM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxErrorAFM.BackgroundImage")));
            this.pictureBoxErrorAFM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorAFM.Location = new System.Drawing.Point(132, 119);
            this.pictureBoxErrorAFM.Name = "pictureBoxErrorAFM";
            this.pictureBoxErrorAFM.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorAFM.TabIndex = 27;
            this.pictureBoxErrorAFM.TabStop = false;
            // 
            // buttonEditSupervisor
            // 
            this.buttonEditSupervisor.BackgroundImage = global::Intership.Properties.Resources.edit_button_image_68871;
            this.buttonEditSupervisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditSupervisor.Enabled = false;
            this.buttonEditSupervisor.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSupervisor.Location = new System.Drawing.Point(359, 194);
            this.buttonEditSupervisor.Name = "buttonEditSupervisor";
            this.buttonEditSupervisor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonEditSupervisor.Size = new System.Drawing.Size(20, 21);
            this.buttonEditSupervisor.TabIndex = 18;
            this.buttonEditSupervisor.UseVisualStyleBackColor = true;
            this.buttonEditSupervisor.Click += new System.EventHandler(this.buttonEditSupervisor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 171);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(8, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 150);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(593, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(17, 274);
            this.panel6.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 25);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(11, 274);
            this.panel8.TabIndex = 34;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.groupBox2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(11, 25);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(189, 274);
            this.panel9.TabIndex = 35;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(200, 280);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(393, 19);
            this.panel11.TabIndex = 37;
            // 
            // FormViewSingleStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(610, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.tabControlInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormViewSingleStudent";
            this.ShowIcon = false;
            this.Text = "Προβολή Φοιτητή";
            this.Load += new System.EventHandler(this.FormViewSingleStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).EndInit();
            this.groupBoxContactEdit.ResumeLayout(false);
            this.groupBoxContactEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorContact)).EndInit();
            this.tabControlInfo.ResumeLayout(false);
            this.tabPageAddress.ResumeLayout(false);
            this.panelAddress.ResumeLayout(false);
            this.panelAddress.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.groupBoxAddressEdit.ResumeLayout(false);
            this.groupBoxAddressEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorCity)).EndInit();
            this.tabPageContacts.ResumeLayout(false);
            this.panelContacts.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.tabPageNotes.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorSupervisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorAEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrotFatherName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrotFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrotLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorAFM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AEM;
        private System.Windows.Forms.Label label_Afm;
        private System.Windows.Forms.Label label_Teacher;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.Label label_Supervisor;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private intershipDataSet intershipDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private intershipDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private intershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label_divader;
        public System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboBoxViewTeacher;
        private System.Windows.Forms.ComboBox comboBoxViewCompany;
        private System.Windows.Forms.ComboBox comboBoxViewSupervisor;
        private System.Windows.Forms.Button buttonEditTeacher;
        private System.Windows.Forms.Button buttonTeacherChecked;
        private System.Windows.Forms.Button buttonTeacherNonChecked;
        private System.Windows.Forms.Button buttonEditCompany;
        private System.Windows.Forms.Button buttonEditSupervisor;
        private System.Windows.Forms.Button buttonCompanyChecked;
        private System.Windows.Forms.Button buttonCompanyNonChecked;
        private System.Windows.Forms.Button buttonSupervisorChecked;
        private System.Windows.Forms.Button buttonSupervisorNonChecked;
        private System.Windows.Forms.DataGridView dataGridViewContact;
        private System.Windows.Forms.Label label_Contacts;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripCreate;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_FathersName;
        private System.Windows.Forms.DataGridView dataGridViewAddress;
        private System.Windows.Forms.Button buttonContactDelete;
        private System.Windows.Forms.Button buttonEditContact;
        private System.Windows.Forms.ComboBox comboBoxContactType;
        private System.Windows.Forms.Label label_ContactDetail;
        private System.Windows.Forms.Label label_ContactType;
        private System.Windows.Forms.GroupBox groupBoxContactEdit;
        private System.Windows.Forms.Button buttonContactCancel;
        private System.Windows.Forms.Button buttonContactSave;
        private System.Windows.Forms.TextBox textBoxContactDetail;
        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPageContacts;
        private System.Windows.Forms.TabPage tabPageAddress;
        private System.Windows.Forms.Button buttonContactNew;
        private System.Windows.Forms.Button buttonCancelContactEdit;
        private System.Windows.Forms.Button buttonAddressNew;
        private System.Windows.Forms.Button buttonAddressDelete;
        private System.Windows.Forms.Button buttonCancelAddressEdit;
        private System.Windows.Forms.Button buttonEditAddress;
        private System.Windows.Forms.GroupBox groupBoxAddressEdit;
        private System.Windows.Forms.TextBox textBoxStreetNumber;
        private System.Windows.Forms.TextBox textBoxStreetName;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label label_ZipCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label_StreetNumber;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_StreetName;
        private System.Windows.Forms.Button buttonAddressCancel;
        private System.Windows.Forms.Button buttonAddressSave;
        private System.Windows.Forms.TabPage tabPageNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.TextBox textBoxViewSingleStudentAEM;
        private System.Windows.Forms.TextBox textBoxViewSingleStudentAFM;
        private System.Windows.Forms.TextBox textBoxViewSingleStudentLastName;
        private System.Windows.Forms.TextBox textBoxViewSingleStudentFirstName;
        private System.Windows.Forms.TextBox textBoxViewSingleTeacher;
        private System.Windows.Forms.TextBox textBoxViewSingleCompany;
        private System.Windows.Forms.TextBox textBoxViewSingleSupervisor;
        private System.Windows.Forms.TextBox textBoxViewSingleFathersName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.Panel panelContacts;
        private System.Windows.Forms.Button buttonNewTeacher;
        private System.Windows.Forms.Button buttonNewCompany;
        private System.Windows.Forms.Button buttonNewSupervisor;
        private System.Windows.Forms.Button buttonDetailsCancel;
        private System.Windows.Forms.Button buttonDetailsSave;
        private System.Windows.Forms.Button buttonDetailsEdit;
        private System.Windows.Forms.PictureBox pictureBoxErrotLastName;
        private System.Windows.Forms.PictureBox pictureBoxErrorContact;
        private System.Windows.Forms.PictureBox pictureBoxErrorAddress;
        private System.Windows.Forms.PictureBox pictureBoxErrorCity;
        private System.Windows.Forms.PictureBox pictureBoxErrotFirstName;
        private System.Windows.Forms.PictureBox pictureBoxErrotFatherName;
        private System.Windows.Forms.PictureBox pictureBoxErrorAEM;
        private System.Windows.Forms.PictureBox pictureBoxErrorAFM;
        private System.Windows.Forms.PictureBox pictureBoxErrorTeacher;
        private System.Windows.Forms.PictureBox pictureBoxErrorCompany;
        private System.Windows.Forms.PictureBox pictureBoxErrorSupervisor;
        private System.Windows.Forms.PictureBox pictureBoxErrorDuration;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxCorrect;
        private System.Windows.Forms.PictureBox pictureBoxWrong;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
    }
}