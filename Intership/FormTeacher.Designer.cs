namespace Intership
{
    partial class FormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.supervisorTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intershipDataSet = new Intership.intershipDataSet();
            this.panel23 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paneLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControlTeacherDetails = new System.Windows.Forms.TabControl();
            this.tabPageTeacher = new System.Windows.Forms.TabPage();
            this.groupBoxTeacherDetails = new System.Windows.Forms.GroupBox();
            this.richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.groupBoxTeacher = new System.Windows.Forms.GroupBox();
            this.pictureBoxErrorName = new System.Windows.Forms.PictureBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tabPageStudentList = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewsStudentForm = new System.Windows.Forms.DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.studentSupervisorTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supervisorTeacherTableAdapter = new Intership.intershipDataSetTableAdapters.SupervisorTeacherTableAdapter();
            this.studentTableAdapter = new Intership.intershipDataSetTableAdapters.StudentTableAdapter();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRestore = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableAdapterManager = new Intership.intershipDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supervisorTeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).BeginInit();
            this.panel23.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.paneLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlTeacherDetails.SuspendLayout();
            this.tabPageTeacher.SuspendLayout();
            this.groupBoxTeacherDetails.SuspendLayout();
            this.groupBoxTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorName)).BeginInit();
            this.tabPageStudentList.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsStudentForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSupervisorTeacherBindingSource)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxTeachers);
            this.panel1.Controls.Add(this.panel23);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 475);
            this.panel1.TabIndex = 3;
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supervisorTeacherBindingSource, "TID", true));
            this.listBoxTeachers.DataSource = this.supervisorTeacherBindingSource;
            this.listBoxTeachers.DisplayMember = "Name";
            this.listBoxTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.Location = new System.Drawing.Point(0, 173);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.ScrollAlwaysVisible = true;
            this.listBoxTeachers.Size = new System.Drawing.Size(200, 292);
            this.listBoxTeachers.TabIndex = 5;
            this.listBoxTeachers.ValueMember = "TID";
            this.listBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.listBoxTeachers_SelectedIndexChanged);
            // 
            // supervisorTeacherBindingSource
            // 
            this.supervisorTeacherBindingSource.DataMember = "SupervisorTeacher";
            this.supervisorTeacherBindingSource.DataSource = this.intershipDataSet;
            // 
            // intershipDataSet
            // 
            this.intershipDataSet.DataSetName = "intershipDataSet";
            this.intershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.groupBox1);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(200, 173);
            this.panel23.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paneLogo);
            this.groupBox1.Location = new System.Drawing.Point(20, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // paneLogo
            // 
            this.paneLogo.Controls.Add(this.pictureBox1);
            this.paneLogo.Location = new System.Drawing.Point(6, 10);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(150, 150);
            this.paneLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Intership.Properties.Resources.proffessor;
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
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 465);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 10);
            this.panel6.TabIndex = 1;
            // 
            // tabControlTeacherDetails
            // 
            this.tabControlTeacherDetails.Controls.Add(this.tabPageTeacher);
            this.tabControlTeacherDetails.Controls.Add(this.tabPageStudentList);
            this.tabControlTeacherDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTeacherDetails.Location = new System.Drawing.Point(227, 35);
            this.tabControlTeacherDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlTeacherDetails.Name = "tabControlTeacherDetails";
            this.tabControlTeacherDetails.SelectedIndex = 0;
            this.tabControlTeacherDetails.Size = new System.Drawing.Size(471, 465);
            this.tabControlTeacherDetails.TabIndex = 0;
            // 
            // tabPageTeacher
            // 
            this.tabPageTeacher.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPageTeacher.Controls.Add(this.groupBoxTeacherDetails);
            this.tabPageTeacher.Controls.Add(this.panel18);
            this.tabPageTeacher.Controls.Add(this.groupBoxTeacher);
            this.tabPageTeacher.Controls.Add(this.panel17);
            this.tabPageTeacher.Controls.Add(this.panel16);
            this.tabPageTeacher.Controls.Add(this.panel15);
            this.tabPageTeacher.Controls.Add(this.panel14);
            this.tabPageTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeacher.Name = "tabPageTeacher";
            this.tabPageTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeacher.Size = new System.Drawing.Size(463, 439);
            this.tabPageTeacher.TabIndex = 0;
            this.tabPageTeacher.Text = "Πληροφορίες Καθηγητή";
            // 
            // groupBoxTeacherDetails
            // 
            this.groupBoxTeacherDetails.Controls.Add(this.richTextBoxDetails);
            this.groupBoxTeacherDetails.Controls.Add(this.panel22);
            this.groupBoxTeacherDetails.Controls.Add(this.panel21);
            this.groupBoxTeacherDetails.Controls.Add(this.panel20);
            this.groupBoxTeacherDetails.Controls.Add(this.panel19);
            this.groupBoxTeacherDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTeacherDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBoxTeacherDetails.ForeColor = System.Drawing.Color.White;
            this.groupBoxTeacherDetails.Location = new System.Drawing.Point(17, 197);
            this.groupBoxTeacherDetails.Name = "groupBoxTeacherDetails";
            this.groupBoxTeacherDetails.Size = new System.Drawing.Size(429, 228);
            this.groupBoxTeacherDetails.TabIndex = 10;
            this.groupBoxTeacherDetails.TabStop = false;
            this.groupBoxTeacherDetails.Text = "Λεπτομέριες";
            // 
            // richTextBoxDetails
            // 
            this.richTextBoxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBoxDetails.Location = new System.Drawing.Point(13, 27);
            this.richTextBoxDetails.Name = "richTextBoxDetails";
            this.richTextBoxDetails.Size = new System.Drawing.Size(403, 188);
            this.richTextBoxDetails.TabIndex = 0;
            this.richTextBoxDetails.Text = "";
            // 
            // panel22
            // 
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(13, 16);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(403, 11);
            this.panel22.TabIndex = 4;
            // 
            // panel21
            // 
            this.panel21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel21.Location = new System.Drawing.Point(13, 215);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(403, 10);
            this.panel21.TabIndex = 3;
            // 
            // panel20
            // 
            this.panel20.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel20.Location = new System.Drawing.Point(416, 16);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(10, 209);
            this.panel20.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(3, 16);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(10, 209);
            this.panel19.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(17, 176);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(429, 21);
            this.panel18.TabIndex = 15;
            // 
            // groupBoxTeacher
            // 
            this.groupBoxTeacher.Controls.Add(this.pictureBoxErrorName);
            this.groupBoxTeacher.Controls.Add(this.labelPhone);
            this.groupBoxTeacher.Controls.Add(this.labelMobile);
            this.groupBoxTeacher.Controls.Add(this.textBoxName);
            this.groupBoxTeacher.Controls.Add(this.textBoxEmail);
            this.groupBoxTeacher.Controls.Add(this.labelEmail);
            this.groupBoxTeacher.Controls.Add(this.textBoxPhone);
            this.groupBoxTeacher.Controls.Add(this.labelName);
            this.groupBoxTeacher.Controls.Add(this.textBoxMobile);
            this.groupBoxTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBoxTeacher.ForeColor = System.Drawing.Color.White;
            this.groupBoxTeacher.Location = new System.Drawing.Point(17, 14);
            this.groupBoxTeacher.Name = "groupBoxTeacher";
            this.groupBoxTeacher.Size = new System.Drawing.Size(429, 162);
            this.groupBoxTeacher.TabIndex = 10;
            this.groupBoxTeacher.TabStop = false;
            this.groupBoxTeacher.Text = "Στοιχεία Καθηγητή";
            // 
            // pictureBoxErrorName
            // 
            this.pictureBoxErrorName.BackgroundImage = global::Intership.Properties.Resources.attention;
            this.pictureBoxErrorName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorName.Location = new System.Drawing.Point(149, 21);
            this.pictureBoxErrorName.Name = "pictureBoxErrorName";
            this.pictureBoxErrorName.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorName.TabIndex = 28;
            this.pictureBoxErrorName.TabStop = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.Location = new System.Drawing.Point(6, 84);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(108, 13);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Σταθ. Τηλέφωνο:";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelMobile.ForeColor = System.Drawing.Color.White;
            this.labelMobile.Location = new System.Drawing.Point(6, 120);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(96, 13);
            this.labelMobile.TabIndex = 6;
            this.labelMobile.Text = "Κιν. Τηλέφωνο:";
            // 
            // textBoxName
            // 
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxName.Location = new System.Drawing.Point(166, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxEmail.Location = new System.Drawing.Point(166, 50);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(6, 53);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxPhone.Location = new System.Drawing.Point(166, 81);
            this.textBoxPhone.MaxLength = 10;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(250, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(6, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(106, 13);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Ονοματεπώνυμο:";
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxMobile.Location = new System.Drawing.Point(166, 117);
            this.textBoxMobile.MaxLength = 10;
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(250, 20);
            this.textBoxMobile.TabIndex = 2;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(17, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(429, 11);
            this.panel17.TabIndex = 14;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(17, 425);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(429, 11);
            this.panel16.TabIndex = 13;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(3, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(14, 433);
            this.panel15.TabIndex = 12;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(446, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(14, 433);
            this.panel14.TabIndex = 11;
            // 
            // tabPageStudentList
            // 
            this.tabPageStudentList.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPageStudentList.Controls.Add(this.panel12);
            this.tabPageStudentList.Controls.Add(this.panel3);
            this.tabPageStudentList.Controls.Add(this.panel2);
            this.tabPageStudentList.Controls.Add(this.panel10);
            this.tabPageStudentList.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudentList.Name = "tabPageStudentList";
            this.tabPageStudentList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentList.Size = new System.Drawing.Size(463, 439);
            this.tabPageStudentList.TabIndex = 1;
            this.tabPageStudentList.Text = "Λίστα Φοιτητών";
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(17, 425);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(429, 11);
            this.panel12.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewsStudentForm);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(17, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 433);
            this.panel3.TabIndex = 0;
            // 
            // dataGridViewsStudentForm
            // 
            this.dataGridViewsStudentForm.AllowUserToAddRows = false;
            this.dataGridViewsStudentForm.AllowUserToDeleteRows = false;
            this.dataGridViewsStudentForm.AllowUserToOrderColumns = true;
            this.dataGridViewsStudentForm.AllowUserToResizeRows = false;
            this.dataGridViewsStudentForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewsStudentForm.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewsStudentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewsStudentForm.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewsStudentForm.Location = new System.Drawing.Point(0, 11);
            this.dataGridViewsStudentForm.MultiSelect = false;
            this.dataGridViewsStudentForm.Name = "dataGridViewsStudentForm";
            this.dataGridViewsStudentForm.ReadOnly = true;
            this.dataGridViewsStudentForm.RowHeadersVisible = false;
            this.dataGridViewsStudentForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewsStudentForm.ShowCellErrors = false;
            this.dataGridViewsStudentForm.ShowEditingIcon = false;
            this.dataGridViewsStudentForm.Size = new System.Drawing.Size(429, 411);
            this.dataGridViewsStudentForm.TabIndex = 7;
            this.dataGridViewsStudentForm.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsStudentForm_CellContentClick);
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(429, 11);
            this.panel13.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 422);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(429, 11);
            this.panel11.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 433);
            this.panel2.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(446, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(14, 433);
            this.panel10.TabIndex = 2;
            // 
            // studentSupervisorTeacherBindingSource
            // 
            this.studentSupervisorTeacherBindingSource.DataMember = "Student_SupervisorTeacher";
            this.studentSupervisorTeacherBindingSource.DataSource = this.supervisorTeacherBindingSource;
            // 
            // supervisorTeacherTableAdapter
            // 
            this.supervisorTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCreate,
            this.toolStripSeparator2,
            this.toolStripButtonDelete,
            this.toolStripSeparator3,
            this.toolStripButtonEdit,
            this.toolStripSeparator5,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonRestore});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(711, 25);
            this.toolStripMenu.TabIndex = 21;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.toolStripButtonDelete.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(73, 21);
            this.toolStripButtonDelete.Text = "- Διαγραφή";
            this.toolStripButtonDelete.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(711, 10);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 475);
            this.panel5.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(210, 35);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(17, 475);
            this.panel7.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(227, 500);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(484, 10);
            this.panel8.TabIndex = 25;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(698, 35);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(13, 465);
            this.panel9.TabIndex = 26;
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
            this.tableAdapterManager.SupervisorTeacherTableAdapter = this.supervisorTeacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = Intership.intershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(711, 510);
            this.Controls.Add(this.tabControlTeacherDetails);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.toolStripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTeacher";
            this.ShowIcon = false;
            this.Text = "Προβολή Καθηγητή";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supervisorTeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).EndInit();
            this.panel23.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.paneLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlTeacherDetails.ResumeLayout(false);
            this.tabPageTeacher.ResumeLayout(false);
            this.groupBoxTeacherDetails.ResumeLayout(false);
            this.groupBoxTeacher.ResumeLayout(false);
            this.groupBoxTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorName)).EndInit();
            this.tabPageStudentList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsStudentForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSupervisorTeacherBindingSource)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlTeacherDetails;
        private System.Windows.Forms.TabPage tabPageTeacher;
        private System.Windows.Forms.TabPage tabPageStudentList;
        private System.Windows.Forms.ListBox listBoxTeachers;
        private intershipDataSet intershipDataSet;
        private System.Windows.Forms.BindingSource supervisorTeacherBindingSource;
        private intershipDataSetTableAdapters.SupervisorTeacherTableAdapter supervisorTeacherTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxTeacherDetails;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
        private System.Windows.Forms.GroupBox groupBoxTeacher;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource studentSupervisorTeacherBindingSource;
        private intershipDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripCreate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRestore;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private intershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBoxErrorName;
        private System.Windows.Forms.DataGridView dataGridViewsStudentForm;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel paneLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}