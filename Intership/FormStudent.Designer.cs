namespace Intership
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAFM = new System.Windows.Forms.TextBox();
            this.label_AEM = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.comboBox_Teacher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEndUntil = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartUntil = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.label_Company = new System.Windows.Forms.Label();
            this.label_Teacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.label_AFM = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.textBoxAEM = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intershipDataSet = new Intership.intershipDataSet();
            this.companyTableAdapter = new Intership.intershipDataSetTableAdapters.CompanyTableAdapter();
            this.studentTableAdapter = new Intership.intershipDataSetTableAdapters.StudentTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonView = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paneLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.paneldatagrid = new System.Windows.Forms.Panel();
            this.dataGridViewsStudentForm = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel21.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.paneLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel13.SuspendLayout();
            this.paneldatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsStudentForm)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLastName.Location = new System.Drawing.Point(80, 52);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(114, 20);
            this.textBoxLastName.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxFirstName.Location = new System.Drawing.Point(80, 83);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(114, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxAFM
            // 
            this.textBoxAFM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAFM.Location = new System.Drawing.Point(80, 119);
            this.textBoxAFM.Name = "textBoxAFM";
            this.textBoxAFM.Size = new System.Drawing.Size(114, 20);
            this.textBoxAFM.TabIndex = 0;
            // 
            // label_AEM
            // 
            this.label_AEM.AutoSize = true;
            this.label_AEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_AEM.ForeColor = System.Drawing.Color.White;
            this.label_AEM.Location = new System.Drawing.Point(9, 24);
            this.label_AEM.Name = "label_AEM";
            this.label_AEM.Size = new System.Drawing.Size(35, 13);
            this.label_AEM.TabIndex = 1;
            this.label_AEM.Text = "ΑΕΜ:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(9, 86);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(50, 13);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Όνομα:";
            // 
            // comboBox_Teacher
            // 
            this.comboBox_Teacher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.comboBox_Teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Teacher.FormattingEnabled = true;
            this.comboBox_Teacher.Location = new System.Drawing.Point(12, 168);
            this.comboBox_Teacher.Name = "comboBox_Teacher";
            this.comboBox_Teacher.Size = new System.Drawing.Size(182, 21);
            this.comboBox_Teacher.TabIndex = 2;
            this.comboBox_Teacher.SelectedIndexChanged += new System.EventHandler(this.comboBox_Teacher_SelectedIndexChanged);
            this.comboBox_Teacher.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBox_Teacher_DragDrop);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // dateTimePickerEndUntil
            // 
            this.dateTimePickerEndUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndUntil.Location = new System.Drawing.Point(114, 317);
            this.dateTimePickerEndUntil.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEndUntil.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndUntil.Name = "dateTimePickerEndUntil";
            this.dateTimePickerEndUntil.Size = new System.Drawing.Size(80, 20);
            this.dateTimePickerEndUntil.TabIndex = 4;
            this.dateTimePickerEndUntil.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEndUntil.ValueChanged += new System.EventHandler(this.dateTimePickerEndUntil_ValueChanged);
            this.dateTimePickerEndUntil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerEndUntil_MouseDown);
            // 
            // dateTimePickerEndFrom
            // 
            this.dateTimePickerEndFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndFrom.Location = new System.Drawing.Point(10, 317);
            this.dateTimePickerEndFrom.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEndFrom.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndFrom.Name = "dateTimePickerEndFrom";
            this.dateTimePickerEndFrom.Size = new System.Drawing.Size(80, 20);
            this.dateTimePickerEndFrom.TabIndex = 4;
            this.dateTimePickerEndFrom.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndFrom.ValueChanged += new System.EventHandler(this.dateTimePickerEndFrom_ValueChanged);
            this.dateTimePickerEndFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerEndFrom_MouseDown);
            // 
            // dateTimePickerStartUntil
            // 
            this.dateTimePickerStartUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartUntil.Location = new System.Drawing.Point(114, 268);
            this.dateTimePickerStartUntil.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartUntil.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartUntil.Name = "dateTimePickerStartUntil";
            this.dateTimePickerStartUntil.Size = new System.Drawing.Size(80, 20);
            this.dateTimePickerStartUntil.TabIndex = 4;
            this.dateTimePickerStartUntil.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartUntil.ValueChanged += new System.EventHandler(this.dateTimePickerStartUntil_ValueChanged);
            this.dateTimePickerStartUntil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerStartUntil_MouseDown);
            // 
            // dateTimePickerStartFrom
            // 
            this.dateTimePickerStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartFrom.Location = new System.Drawing.Point(10, 268);
            this.dateTimePickerStartFrom.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartFrom.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartFrom.Name = "dateTimePickerStartFrom";
            this.dateTimePickerStartFrom.Size = new System.Drawing.Size(80, 20);
            this.dateTimePickerStartFrom.TabIndex = 4;
            this.dateTimePickerStartFrom.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartFrom.ValueChanged += new System.EventHandler(this.dateTimePickerStartFrom_ValueChanged);
            this.dateTimePickerStartFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerStartFrom_MouseDown);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(107, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(84, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Επαναφορά";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(9, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(83, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Αναζήτηση";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.comboBox_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(12, 218);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(182, 21);
            this.comboBox_Company.TabIndex = 2;
            this.comboBox_Company.SelectedIndexChanged += new System.EventHandler(this.comboBox_Company_SelectedIndexChanged);
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Company.ForeColor = System.Drawing.Color.White;
            this.label_Company.Location = new System.Drawing.Point(9, 201);
            this.label_Company.Name = "label_Company";
            this.label_Company.Size = new System.Drawing.Size(56, 13);
            this.label_Company.TabIndex = 1;
            this.label_Company.Text = "Εταιρία:";
            // 
            // label_Teacher
            // 
            this.label_Teacher.AutoSize = true;
            this.label_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Teacher.ForeColor = System.Drawing.Color.White;
            this.label_Teacher.Location = new System.Drawing.Point(9, 151);
            this.label_Teacher.Name = "label_Teacher";
            this.label_Teacher.Size = new System.Drawing.Size(140, 13);
            this.label_Teacher.TabIndex = 1;
            this.label_Teacher.Text = "Επιβλέπων Καθηγητής:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ημ. Λήξης:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelStartDate.ForeColor = System.Drawing.Color.White;
            this.labelStartDate.Location = new System.Drawing.Point(9, 251);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(85, 13);
            this.labelStartDate.TabIndex = 1;
            this.labelStartDate.Text = "Ημ. Έναρξης:";
            // 
            // label_AFM
            // 
            this.label_AFM.AutoSize = true;
            this.label_AFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_AFM.ForeColor = System.Drawing.Color.White;
            this.label_AFM.Location = new System.Drawing.Point(9, 122);
            this.label_AFM.Name = "label_AFM";
            this.label_AFM.Size = new System.Drawing.Size(39, 13);
            this.label_AFM.TabIndex = 1;
            this.label_AFM.Text = "ΑΦΜ:";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Surname.ForeColor = System.Drawing.Color.White;
            this.label_Surname.Location = new System.Drawing.Point(9, 55);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(57, 13);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.Text = "Επίθετο:";
            // 
            // textBoxAEM
            // 
            this.textBoxAEM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAEM.Location = new System.Drawing.Point(80, 21);
            this.textBoxAEM.Name = "textBoxAEM";
            this.textBoxAEM.Size = new System.Drawing.Size(114, 20);
            this.textBoxAEM.TabIndex = 0;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.intershipDataSet;
            // 
            // intershipDataSet
            // 
            this.intershipDataSet.DataSetName = "intershipDataSet";
            this.intershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.toolStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInsert,
            this.toolStripSeparator2,
            this.toolStripButtonDelete,
            this.toolStripSeparator1,
            this.toolStripButtonView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInsert
            // 
            this.toolStripButtonInsert.BackColor = System.Drawing.Color.Silver;
            this.toolStripButtonInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsert.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.toolStripButtonInsert.Name = "toolStripButtonInsert";
            this.toolStripButtonInsert.Size = new System.Drawing.Size(94, 21);
            this.toolStripButtonInsert.Text = "+ Νέα Εγγραφή";
            this.toolStripButtonInsert.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.BackColor = System.Drawing.Color.Silver;
            this.toolStripButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(73, 21);
            this.toolStripButtonDelete.Text = "- Διαγραφή";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.BackColor = System.Drawing.Color.Silver;
            this.toolStripButtonView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonView.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(61, 21);
            this.toolStripButtonView.Text = "Προβολή";
            this.toolStripButtonView.Click += new System.EventHandler(this.dataGridViewsStudentForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAEM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.dateTimePickerEndUntil);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.dateTimePickerEndFrom);
            this.groupBox1.Controls.Add(this.textBoxAFM);
            this.groupBox1.Controls.Add(this.dateTimePickerStartUntil);
            this.groupBox1.Controls.Add(this.label_AEM);
            this.groupBox1.Controls.Add(this.dateTimePickerStartFrom);
            this.groupBox1.Controls.Add(this.label_Surname);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Controls.Add(this.label_AFM);
            this.groupBox1.Controls.Add(this.comboBox_Company);
            this.groupBox1.Controls.Add(this.labelStartDate);
            this.groupBox1.Controls.Add(this.comboBox_Teacher);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_Company);
            this.groupBox1.Controls.Add(this.label_Teacher);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 376);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 32);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 500);
            this.panel2.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel21);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(10, 10);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(206, 104);
            this.panel14.TabIndex = 6;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.groupBox2);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(206, 170);
            this.panel21.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paneLogo);
            this.groupBox2.Location = new System.Drawing.Point(58, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // paneLogo
            // 
            this.paneLogo.Controls.Add(this.pictureBox1);
            this.paneLogo.Location = new System.Drawing.Point(5, 11);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(88, 88);
            this.paneLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Intership.Properties.Resources.student;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 480);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(216, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 480);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 10);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 10);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(767, 476);
            this.panel7.TabIndex = 9;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.paneldatagrid);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(767, 476);
            this.panel13.TabIndex = 1;
            // 
            // paneldatagrid
            // 
            this.paneldatagrid.Controls.Add(this.dataGridViewsStudentForm);
            this.paneldatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldatagrid.Location = new System.Drawing.Point(0, 0);
            this.paneldatagrid.Name = "paneldatagrid";
            this.paneldatagrid.Size = new System.Drawing.Size(767, 476);
            this.paneldatagrid.TabIndex = 1;
            // 
            // dataGridViewsStudentForm
            // 
            this.dataGridViewsStudentForm.AllowUserToAddRows = false;
            this.dataGridViewsStudentForm.AllowUserToDeleteRows = false;
            this.dataGridViewsStudentForm.AllowUserToResizeRows = false;
            this.dataGridViewsStudentForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewsStudentForm.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewsStudentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewsStudentForm.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewsStudentForm.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewsStudentForm.MultiSelect = false;
            this.dataGridViewsStudentForm.Name = "dataGridViewsStudentForm";
            this.dataGridViewsStudentForm.ReadOnly = true;
            this.dataGridViewsStudentForm.RowHeadersVisible = false;
            this.dataGridViewsStudentForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewsStudentForm.ShowCellErrors = false;
            this.dataGridViewsStudentForm.ShowEditingIcon = false;
            this.dataGridViewsStudentForm.Size = new System.Drawing.Size(767, 476);
            this.dataGridViewsStudentForm.TabIndex = 0;
            this.dataGridViewsStudentForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsStudentForm_CellClick);
            this.dataGridViewsStudentForm.DoubleClick += new System.EventHandler(this.dataGridViewsStudentForm_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(226, 25);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(787, 500);
            this.panel8.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(10, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(767, 14);
            this.panel9.TabIndex = 10;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(10, 490);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(767, 10);
            this.panel10.TabIndex = 11;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 500);
            this.panel11.TabIndex = 12;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(777, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 500);
            this.panel12.TabIndex = 13;
            // 
            // FormStudent
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1013, 525);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStudent";
            this.ShowIcon = false;
            this.Text = "Φοιτητής";
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.paneLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.paneldatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsStudentForm)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private intershipDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxAFM;
        private System.Windows.Forms.Label label_AEM;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.ComboBox comboBox_Teacher;
        private System.Windows.Forms.Label label_Teacher;
        private System.Windows.Forms.Label label_AFM;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.TextBox textBoxAEM;
        private intershipDataSet intershipDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private intershipDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartUntil;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndUntil;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsert;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox comboBox_Company;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridViewsStudentForm;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel paneldatagrid;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel paneLogo;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}