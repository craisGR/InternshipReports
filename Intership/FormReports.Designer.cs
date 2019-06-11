namespace Intership
{
    partial class FormReports
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Προβολή Φοιτητή");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Αναλυτική Προβολή Φοιτητή");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Λίστα Φοιτητών");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Λίστα Φοιτητών (ανά εταιρία)");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Λίστα Φοιτητών (ανά καθηγητή)");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Φοιτητές", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Προβολή Καθηγητή");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Λίστα Καθηγητών");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Επιβλέπωντες Καθηγητές", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Προβολή Εταιρίας");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Αναλυτική Προβολή Εταιρίας");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Λίστα Εταιριών");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Λίστα Εταιριών (ανά Είδος)");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Λίστα Εταιριών (ανά νομική μορφή)");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Λίστα Εταιριών (ανά πόλη)");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Εταιρίες", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewReports = new System.Windows.Forms.TreeView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paneLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelReport = new System.Windows.Forms.Panel();
            this.myButtonClear = new Intership.MyButton();
            this.myButtonReport = new Intership.MyButton();
            this.panelTeacher2 = new System.Windows.Forms.Panel();
            this.buttonTeachersNone = new System.Windows.Forms.Button();
            this.buttonTeachersAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxTeachers = new System.Windows.Forms.CheckedListBox();
            this.panelCompanies2 = new System.Windows.Forms.Panel();
            this.buttonCompanyNone = new System.Windows.Forms.Button();
            this.buttonCompanyAll = new System.Windows.Forms.Button();
            this.labelCompanies = new System.Windows.Forms.Label();
            this.checkedListBoxCompanies = new System.Windows.Forms.CheckedListBox();
            this.panelStudent1 = new System.Windows.Forms.Panel();
            this.comboBoxSelectStudent = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intershipDataSet = new Intership.intershipDataSet();
            this.labelFindStudent = new System.Windows.Forms.Label();
            this.textBoxAEM = new System.Windows.Forms.TextBox();
            this.label_AEM = new System.Windows.Forms.Label();
            this.panelStudent2 = new System.Windows.Forms.Panel();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonCnone = new System.Windows.Forms.Button();
            this.buttonTall = new System.Windows.Forms.Button();
            this.buttonTnone = new System.Windows.Forms.Button();
            this.checkedListBoxCompanyStRpt = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxTeacherStRpt = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEndUntil = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndFrom = new System.Windows.Forms.DateTimePicker();
            this.label_Teacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Company = new System.Windows.Forms.Label();
            this.dateTimePickerStartUntil = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartFrom = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.panelTeacher1 = new System.Windows.Forms.Panel();
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.panelCompanies1 = new System.Windows.Forms.Panel();
            this.ComboboxCompany = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.studentTableAdapter = new Intership.intershipDataSetTableAdapters.StudentTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel21.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.paneLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelReport.SuspendLayout();
            this.panelTeacher2.SuspendLayout();
            this.panelCompanies2.SuspendLayout();
            this.panelStudent1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).BeginInit();
            this.panelStudent2.SuspendLayout();
            this.panelTeacher1.SuspendLayout();
            this.panelCompanies1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 584);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewReports);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(8, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 459);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // treeViewReports
            // 
            this.treeViewReports.BackColor = System.Drawing.Color.DodgerBlue;
            this.treeViewReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.treeViewReports.ForeColor = System.Drawing.Color.White;
            this.treeViewReports.LineColor = System.Drawing.Color.LightGray;
            this.treeViewReports.Location = new System.Drawing.Point(3, 16);
            this.treeViewReports.Name = "treeViewReports";
            treeNode17.Name = "NodeStudentSingle";
            treeNode17.Text = "Προβολή Φοιτητή";
            treeNode18.Name = "NodeStudenetSingleFull";
            treeNode18.Text = "Αναλυτική Προβολή Φοιτητή";
            treeNode19.Name = "NodeStudentList";
            treeNode19.Text = "Λίστα Φοιτητών";
            treeNode20.Name = "NodeStudentListCompany";
            treeNode20.Text = "Λίστα Φοιτητών (ανά εταιρία)";
            treeNode21.Name = "NodeStudentListTeacher";
            treeNode21.Text = "Λίστα Φοιτητών (ανά καθηγητή)";
            treeNode22.Name = "NodeStudents";
            treeNode22.Text = "Φοιτητές";
            treeNode22.ToolTipText = "Εκτυώσεις Φοιτητών";
            treeNode23.Name = "NodeTeachersSingle";
            treeNode23.Text = "Προβολή Καθηγητή";
            treeNode24.Name = "NodeTeachersList";
            treeNode24.Text = "Λίστα Καθηγητών";
            treeNode25.Name = "NodeTeachers";
            treeNode25.Text = "Επιβλέπωντες Καθηγητές";
            treeNode26.Name = "NodeCompaniesSingle";
            treeNode26.Text = "Προβολή Εταιρίας";
            treeNode27.Name = "NodeCompaniesSingleFull";
            treeNode27.Text = "Αναλυτική Προβολή Εταιρίας";
            treeNode28.Name = "NodeCopaniesList";
            treeNode28.Text = "Λίστα Εταιριών";
            treeNode29.Name = "NodeCopaniesListType";
            treeNode29.Text = "Λίστα Εταιριών (ανά Είδος)";
            treeNode30.Name = "NodeCopaniesListLF";
            treeNode30.Text = "Λίστα Εταιριών (ανά νομική μορφή)";
            treeNode31.Name = "NodeCopaniesListCity";
            treeNode31.Text = "Λίστα Εταιριών (ανά πόλη)";
            treeNode32.Name = "NodeCompanies";
            treeNode32.Text = "Εταιρίες";
            this.treeViewReports.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode25,
            treeNode32});
            this.treeViewReports.ShowNodeToolTips = true;
            this.treeViewReports.Size = new System.Drawing.Size(227, 440);
            this.treeViewReports.TabIndex = 0;
            this.treeViewReports.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewReports_AfterSelect);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(241, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 459);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(8, 574);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 10);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 469);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 115);
            this.panel3.TabIndex = 1;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.groupBox2);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(249, 115);
            this.panel21.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paneLogo);
            this.groupBox2.Location = new System.Drawing.Point(77, 0);
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
            this.pictureBox1.BackgroundImage = global::Intership.Properties.Resources.print;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(249, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 114);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelReport);
            this.groupBox3.Controls.Add(this.panelTeacher2);
            this.groupBox3.Controls.Add(this.panelCompanies2);
            this.groupBox3.Controls.Add(this.panelStudent1);
            this.groupBox3.Controls.Add(this.panelStudent2);
            this.groupBox3.Controls.Add(this.panelTeacher1);
            this.groupBox3.Controls.Add(this.panelCompanies1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(866, 104);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.myButtonClear);
            this.panelReport.Controls.Add(this.myButtonReport);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelReport.Location = new System.Drawing.Point(745, 16);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(118, 85);
            this.panelReport.TabIndex = 1;
            // 
            // myButtonClear
            // 
            this.myButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myButtonClear.FlatAppearance.BorderSize = 2;
            this.myButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButtonClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myButtonClear.ForeColor = System.Drawing.Color.White;
            this.myButtonClear.Location = new System.Drawing.Point(7, 47);
            this.myButtonClear.Name = "myButtonClear";
            this.myButtonClear.Size = new System.Drawing.Size(105, 29);
            this.myButtonClear.TabIndex = 1;
            this.myButtonClear.TabStop = false;
            this.myButtonClear.Text = "Καθαρισμός";
            this.myButtonClear.UseVisualStyleBackColor = true;
            this.myButtonClear.Click += new System.EventHandler(this.myButtonClear_Click);
            // 
            // myButtonReport
            // 
            this.myButtonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButtonReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myButtonReport.FlatAppearance.BorderSize = 2;
            this.myButtonReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myButtonReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myButtonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButtonReport.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myButtonReport.ForeColor = System.Drawing.Color.White;
            this.myButtonReport.Location = new System.Drawing.Point(7, 4);
            this.myButtonReport.Name = "myButtonReport";
            this.myButtonReport.Size = new System.Drawing.Size(105, 29);
            this.myButtonReport.TabIndex = 1;
            this.myButtonReport.TabStop = false;
            this.myButtonReport.Text = "Εκτέλεση";
            this.myButtonReport.UseVisualStyleBackColor = true;
            this.myButtonReport.Click += new System.EventHandler(this.myButtonReport_Click);
            // 
            // panelTeacher2
            // 
            this.panelTeacher2.AutoScroll = true;
            this.panelTeacher2.Controls.Add(this.buttonTeachersNone);
            this.panelTeacher2.Controls.Add(this.buttonTeachersAll);
            this.panelTeacher2.Controls.Add(this.label4);
            this.panelTeacher2.Controls.Add(this.checkedListBoxTeachers);
            this.panelTeacher2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTeacher2.Location = new System.Drawing.Point(3, 16);
            this.panelTeacher2.Name = "panelTeacher2";
            this.panelTeacher2.Size = new System.Drawing.Size(860, 85);
            this.panelTeacher2.TabIndex = 4;
            this.panelTeacher2.Visible = false;
            // 
            // buttonTeachersNone
            // 
            this.buttonTeachersNone.Location = new System.Drawing.Point(470, 32);
            this.buttonTeachersNone.Name = "buttonTeachersNone";
            this.buttonTeachersNone.Size = new System.Drawing.Size(49, 23);
            this.buttonTeachersNone.TabIndex = 7;
            this.buttonTeachersNone.Text = "None";
            this.buttonTeachersNone.UseVisualStyleBackColor = true;
            this.buttonTeachersNone.Click += new System.EventHandler(this.buttonUnchecked_Click);
            // 
            // buttonTeachersAll
            // 
            this.buttonTeachersAll.Location = new System.Drawing.Point(470, 3);
            this.buttonTeachersAll.Name = "buttonTeachersAll";
            this.buttonTeachersAll.Size = new System.Drawing.Size(49, 23);
            this.buttonTeachersAll.TabIndex = 7;
            this.buttonTeachersAll.Text = "All";
            this.buttonTeachersAll.UseVisualStyleBackColor = true;
            this.buttonTeachersAll.Click += new System.EventHandler(this.buttonChecked_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Αναζήτηση Καθηγητή:";
            // 
            // checkedListBoxTeachers
            // 
            this.checkedListBoxTeachers.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkedListBoxTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxTeachers.CheckOnClick = true;
            this.checkedListBoxTeachers.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxTeachers.FormattingEnabled = true;
            this.checkedListBoxTeachers.Location = new System.Drawing.Point(151, 3);
            this.checkedListBoxTeachers.Name = "checkedListBoxTeachers";
            this.checkedListBoxTeachers.Size = new System.Drawing.Size(253, 75);
            this.checkedListBoxTeachers.TabIndex = 6;
            // 
            // panelCompanies2
            // 
            this.panelCompanies2.AutoScroll = true;
            this.panelCompanies2.Controls.Add(this.buttonCompanyNone);
            this.panelCompanies2.Controls.Add(this.buttonCompanyAll);
            this.panelCompanies2.Controls.Add(this.labelCompanies);
            this.panelCompanies2.Controls.Add(this.checkedListBoxCompanies);
            this.panelCompanies2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCompanies2.Location = new System.Drawing.Point(3, 16);
            this.panelCompanies2.Name = "panelCompanies2";
            this.panelCompanies2.Size = new System.Drawing.Size(860, 85);
            this.panelCompanies2.TabIndex = 17;
            this.panelCompanies2.Visible = false;
            // 
            // buttonCompanyNone
            // 
            this.buttonCompanyNone.Location = new System.Drawing.Point(470, 32);
            this.buttonCompanyNone.Name = "buttonCompanyNone";
            this.buttonCompanyNone.Size = new System.Drawing.Size(49, 23);
            this.buttonCompanyNone.TabIndex = 7;
            this.buttonCompanyNone.Text = "None";
            this.buttonCompanyNone.UseVisualStyleBackColor = true;
            this.buttonCompanyNone.Click += new System.EventHandler(this.buttonCompanyNone_Click);
            // 
            // buttonCompanyAll
            // 
            this.buttonCompanyAll.Location = new System.Drawing.Point(470, 3);
            this.buttonCompanyAll.Name = "buttonCompanyAll";
            this.buttonCompanyAll.Size = new System.Drawing.Size(49, 23);
            this.buttonCompanyAll.TabIndex = 7;
            this.buttonCompanyAll.Text = "All";
            this.buttonCompanyAll.UseVisualStyleBackColor = true;
            this.buttonCompanyAll.Click += new System.EventHandler(this.buttonCompanyAll_Click);
            // 
            // labelCompanies
            // 
            this.labelCompanies.AutoSize = true;
            this.labelCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCompanies.ForeColor = System.Drawing.Color.White;
            this.labelCompanies.Location = new System.Drawing.Point(8, 3);
            this.labelCompanies.Name = "labelCompanies";
            this.labelCompanies.Size = new System.Drawing.Size(132, 13);
            this.labelCompanies.TabIndex = 5;
            this.labelCompanies.Text = "Αναζήτηση Εταιρίας:";
            // 
            // checkedListBoxCompanies
            // 
            this.checkedListBoxCompanies.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkedListBoxCompanies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxCompanies.CheckOnClick = true;
            this.checkedListBoxCompanies.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxCompanies.FormattingEnabled = true;
            this.checkedListBoxCompanies.Location = new System.Drawing.Point(151, 3);
            this.checkedListBoxCompanies.Name = "checkedListBoxCompanies";
            this.checkedListBoxCompanies.Size = new System.Drawing.Size(253, 75);
            this.checkedListBoxCompanies.TabIndex = 6;
            // 
            // panelStudent1
            // 
            this.panelStudent1.Controls.Add(this.comboBoxSelectStudent);
            this.panelStudent1.Controls.Add(this.labelFindStudent);
            this.panelStudent1.Controls.Add(this.textBoxAEM);
            this.panelStudent1.Controls.Add(this.label_AEM);
            this.panelStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudent1.Location = new System.Drawing.Point(3, 16);
            this.panelStudent1.Name = "panelStudent1";
            this.panelStudent1.Size = new System.Drawing.Size(860, 85);
            this.panelStudent1.TabIndex = 0;
            this.panelStudent1.Visible = false;
            // 
            // comboBoxSelectStudent
            // 
            this.comboBoxSelectStudent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "aem", true));
            this.comboBoxSelectStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectStudent.FormattingEnabled = true;
            this.comboBoxSelectStudent.Location = new System.Drawing.Point(149, 52);
            this.comboBoxSelectStudent.Name = "comboBoxSelectStudent";
            this.comboBoxSelectStudent.Size = new System.Drawing.Size(288, 21);
            this.comboBoxSelectStudent.TabIndex = 5;
            this.comboBoxSelectStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectStudent_SelectedIndexChanged);
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
            // labelFindStudent
            // 
            this.labelFindStudent.AutoSize = true;
            this.labelFindStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelFindStudent.ForeColor = System.Drawing.Color.White;
            this.labelFindStudent.Location = new System.Drawing.Point(13, 55);
            this.labelFindStudent.Name = "labelFindStudent";
            this.labelFindStudent.Size = new System.Drawing.Size(130, 13);
            this.labelFindStudent.TabIndex = 4;
            this.labelFindStudent.Text = "Αναζήτηση Φοιτητή:";
            // 
            // textBoxAEM
            // 
            this.textBoxAEM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAEM.Location = new System.Drawing.Point(149, 14);
            this.textBoxAEM.Name = "textBoxAEM";
            this.textBoxAEM.Size = new System.Drawing.Size(114, 20);
            this.textBoxAEM.TabIndex = 2;
            // 
            // label_AEM
            // 
            this.label_AEM.AutoSize = true;
            this.label_AEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_AEM.ForeColor = System.Drawing.Color.White;
            this.label_AEM.Location = new System.Drawing.Point(106, 17);
            this.label_AEM.Name = "label_AEM";
            this.label_AEM.Size = new System.Drawing.Size(35, 13);
            this.label_AEM.TabIndex = 3;
            this.label_AEM.Text = "ΑΕΜ:";
            // 
            // panelStudent2
            // 
            this.panelStudent2.Controls.Add(this.buttonCall);
            this.panelStudent2.Controls.Add(this.buttonCnone);
            this.panelStudent2.Controls.Add(this.buttonTall);
            this.panelStudent2.Controls.Add(this.buttonTnone);
            this.panelStudent2.Controls.Add(this.checkedListBoxCompanyStRpt);
            this.panelStudent2.Controls.Add(this.checkedListBoxTeacherStRpt);
            this.panelStudent2.Controls.Add(this.label3);
            this.panelStudent2.Controls.Add(this.label2);
            this.panelStudent2.Controls.Add(this.dateTimePickerEndUntil);
            this.panelStudent2.Controls.Add(this.dateTimePickerEndFrom);
            this.panelStudent2.Controls.Add(this.label_Teacher);
            this.panelStudent2.Controls.Add(this.label1);
            this.panelStudent2.Controls.Add(this.label_Company);
            this.panelStudent2.Controls.Add(this.dateTimePickerStartUntil);
            this.panelStudent2.Controls.Add(this.dateTimePickerStartFrom);
            this.panelStudent2.Controls.Add(this.labelStartDate);
            this.panelStudent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudent2.ForeColor = System.Drawing.Color.White;
            this.panelStudent2.Location = new System.Drawing.Point(3, 16);
            this.panelStudent2.Name = "panelStudent2";
            this.panelStudent2.Size = new System.Drawing.Size(860, 85);
            this.panelStudent2.TabIndex = 6;
            this.panelStudent2.Visible = false;
            // 
            // buttonCall
            // 
            this.buttonCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonCall.ForeColor = System.Drawing.Color.Black;
            this.buttonCall.Location = new System.Drawing.Point(610, -3);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(35, 19);
            this.buttonCall.TabIndex = 18;
            this.buttonCall.Text = "All";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // buttonCnone
            // 
            this.buttonCnone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonCnone.ForeColor = System.Drawing.Color.Black;
            this.buttonCnone.Location = new System.Drawing.Point(651, -3);
            this.buttonCnone.Name = "buttonCnone";
            this.buttonCnone.Size = new System.Drawing.Size(35, 20);
            this.buttonCnone.TabIndex = 18;
            this.buttonCnone.Text = "None";
            this.buttonCnone.UseVisualStyleBackColor = true;
            this.buttonCnone.Click += new System.EventHandler(this.buttonCnone_Click);
            // 
            // buttonTall
            // 
            this.buttonTall.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonTall.ForeColor = System.Drawing.Color.Black;
            this.buttonTall.Location = new System.Drawing.Point(324, -2);
            this.buttonTall.Name = "buttonTall";
            this.buttonTall.Size = new System.Drawing.Size(35, 19);
            this.buttonTall.TabIndex = 18;
            this.buttonTall.Text = "All";
            this.buttonTall.UseVisualStyleBackColor = true;
            this.buttonTall.Click += new System.EventHandler(this.buttonTall_Click);
            // 
            // buttonTnone
            // 
            this.buttonTnone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonTnone.ForeColor = System.Drawing.Color.Black;
            this.buttonTnone.Location = new System.Drawing.Point(365, -3);
            this.buttonTnone.Name = "buttonTnone";
            this.buttonTnone.Size = new System.Drawing.Size(35, 20);
            this.buttonTnone.TabIndex = 18;
            this.buttonTnone.Text = "None";
            this.buttonTnone.UseVisualStyleBackColor = true;
            this.buttonTnone.Click += new System.EventHandler(this.buttonTnone_Click);
            // 
            // checkedListBoxCompanyStRpt
            // 
            this.checkedListBoxCompanyStRpt.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkedListBoxCompanyStRpt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxCompanyStRpt.CheckOnClick = true;
            this.checkedListBoxCompanyStRpt.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxCompanyStRpt.FormattingEnabled = true;
            this.checkedListBoxCompanyStRpt.Location = new System.Drawing.Point(478, 17);
            this.checkedListBoxCompanyStRpt.Name = "checkedListBoxCompanyStRpt";
            this.checkedListBoxCompanyStRpt.Size = new System.Drawing.Size(244, 60);
            this.checkedListBoxCompanyStRpt.TabIndex = 17;
            // 
            // checkedListBoxTeacherStRpt
            // 
            this.checkedListBoxTeacherStRpt.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkedListBoxTeacherStRpt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxTeacherStRpt.CheckOnClick = true;
            this.checkedListBoxTeacherStRpt.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxTeacherStRpt.FormattingEnabled = true;
            this.checkedListBoxTeacherStRpt.Location = new System.Drawing.Point(195, 16);
            this.checkedListBoxTeacherStRpt.Name = "checkedListBoxTeacherStRpt";
            this.checkedListBoxTeacherStRpt.Size = new System.Drawing.Size(258, 60);
            this.checkedListBoxTeacherStRpt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // dateTimePickerEndUntil
            // 
            this.dateTimePickerEndUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndUntil.Location = new System.Drawing.Point(92, 65);
            this.dateTimePickerEndUntil.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEndUntil.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndUntil.Name = "dateTimePickerEndUntil";
            this.dateTimePickerEndUntil.Size = new System.Drawing.Size(80, 20);
            this.dateTimePickerEndUntil.TabIndex = 13;
            this.dateTimePickerEndUntil.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEndUntil.ValueChanged += new System.EventHandler(this.dateTimePickerEndUntil_ValueChanged);
            this.dateTimePickerEndUntil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerEndUntil_MouseDown);
            // 
            // dateTimePickerEndFrom
            // 
            this.dateTimePickerEndFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndFrom.Location = new System.Drawing.Point(1, 65);
            this.dateTimePickerEndFrom.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEndFrom.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndFrom.Name = "dateTimePickerEndFrom";
            this.dateTimePickerEndFrom.Size = new System.Drawing.Size(80, 20);
            this.dateTimePickerEndFrom.TabIndex = 14;
            this.dateTimePickerEndFrom.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndFrom.ValueChanged += new System.EventHandler(this.dateTimePickerEndFrom_ValueChanged);
            this.dateTimePickerEndFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerEndFrom_MouseDown);
            // 
            // label_Teacher
            // 
            this.label_Teacher.AutoSize = true;
            this.label_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Teacher.ForeColor = System.Drawing.Color.White;
            this.label_Teacher.Location = new System.Drawing.Point(192, -1);
            this.label_Teacher.Name = "label_Teacher";
            this.label_Teacher.Size = new System.Drawing.Size(97, 13);
            this.label_Teacher.TabIndex = 8;
            this.label_Teacher.Text = "Επ. Καθηγητής:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ημ. Λήξης:";
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Company.ForeColor = System.Drawing.Color.White;
            this.label_Company.Location = new System.Drawing.Point(475, 0);
            this.label_Company.Name = "label_Company";
            this.label_Company.Size = new System.Drawing.Size(56, 13);
            this.label_Company.TabIndex = 7;
            this.label_Company.Text = "Εταιρία:";
            // 
            // dateTimePickerStartUntil
            // 
            this.dateTimePickerStartUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartUntil.Location = new System.Drawing.Point(90, 19);
            this.dateTimePickerStartUntil.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartUntil.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartUntil.Name = "dateTimePickerStartUntil";
            this.dateTimePickerStartUntil.Size = new System.Drawing.Size(80, 20);
            this.dateTimePickerStartUntil.TabIndex = 15;
            this.dateTimePickerStartUntil.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartUntil.ValueChanged += new System.EventHandler(this.dateTimePickerStartUntil_ValueChanged);
            this.dateTimePickerStartUntil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerStartUntil_MouseDown);
            // 
            // dateTimePickerStartFrom
            // 
            this.dateTimePickerStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartFrom.Location = new System.Drawing.Point(-1, 19);
            this.dateTimePickerStartFrom.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStartFrom.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartFrom.Name = "dateTimePickerStartFrom";
            this.dateTimePickerStartFrom.Size = new System.Drawing.Size(80, 20);
            this.dateTimePickerStartFrom.TabIndex = 16;
            this.dateTimePickerStartFrom.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartFrom.ValueChanged += new System.EventHandler(this.dateTimePickerStartFrom_ValueChanged);
            this.dateTimePickerStartFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePickerStartFrom_MouseDown);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelStartDate.ForeColor = System.Drawing.Color.White;
            this.labelStartDate.Location = new System.Drawing.Point(-1, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(85, 13);
            this.labelStartDate.TabIndex = 5;
            this.labelStartDate.Text = "Ημ. Έναρξης:";
            // 
            // panelTeacher1
            // 
            this.panelTeacher1.Controls.Add(this.comboBoxTeachers);
            this.panelTeacher1.Controls.Add(this.labelTeacherName);
            this.panelTeacher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTeacher1.Location = new System.Drawing.Point(3, 16);
            this.panelTeacher1.Name = "panelTeacher1";
            this.panelTeacher1.Size = new System.Drawing.Size(860, 85);
            this.panelTeacher1.TabIndex = 7;
            this.panelTeacher1.Visible = false;
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "aem", true));
            this.comboBoxTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.Location = new System.Drawing.Point(149, 13);
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(288, 21);
            this.comboBoxTeachers.TabIndex = 5;
            this.comboBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeachers_SelectedIndexChanged);
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTeacherName.ForeColor = System.Drawing.Color.White;
            this.labelTeacherName.Location = new System.Drawing.Point(6, 16);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(137, 13);
            this.labelTeacherName.TabIndex = 4;
            this.labelTeacherName.Text = "Αναζήτηση Καθηγητή:";
            // 
            // panelCompanies1
            // 
            this.panelCompanies1.Controls.Add(this.ComboboxCompany);
            this.panelCompanies1.Controls.Add(this.label5);
            this.panelCompanies1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCompanies1.Location = new System.Drawing.Point(3, 16);
            this.panelCompanies1.Name = "panelCompanies1";
            this.panelCompanies1.Size = new System.Drawing.Size(860, 85);
            this.panelCompanies1.TabIndex = 4;
            this.panelCompanies1.Visible = false;
            // 
            // ComboboxCompany
            // 
            this.ComboboxCompany.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "aem", true));
            this.ComboboxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxCompany.FormattingEnabled = true;
            this.ComboboxCompany.Location = new System.Drawing.Point(169, 6);
            this.ComboboxCompany.Name = "ComboboxCompany";
            this.ComboboxCompany.Size = new System.Drawing.Size(288, 21);
            this.ComboboxCompany.TabIndex = 7;
            this.ComboboxCompany.SelectedIndexChanged += new System.EventHandler(this.ComboboxCompany_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Αναζήτηση Εταιρίας:";
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 104);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(866, 10);
            this.panel9.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(866, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 114);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1115, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 470);
            this.panel7.TabIndex = 2;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(249, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ShowCloseButton = false;
            this.crystalReportViewer.ShowLogo = false;
            this.crystalReportViewer.Size = new System.Drawing.Size(866, 470);
            this.crystalReportViewer.TabIndex = 3;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1123, 584);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReports";
            this.ShowIcon = false;
            this.Text = "Εκτυπώσεις";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.paneLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            this.panelTeacher2.ResumeLayout(false);
            this.panelTeacher2.PerformLayout();
            this.panelCompanies2.ResumeLayout(false);
            this.panelCompanies2.PerformLayout();
            this.panelStudent1.ResumeLayout(false);
            this.panelStudent1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).EndInit();
            this.panelStudent2.ResumeLayout(false);
            this.panelStudent2.PerformLayout();
            this.panelTeacher1.ResumeLayout(false);
            this.panelTeacher1.PerformLayout();
            this.panelCompanies1.ResumeLayout(false);
            this.panelCompanies1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeViewReports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel paneLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Panel panelStudent1;
        private MyButton myButtonReport;
        private System.Windows.Forms.ComboBox comboBoxSelectStudent;
        private System.Windows.Forms.Label labelFindStudent;
        private intershipDataSet intershipDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private intershipDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Panel panelStudent2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndUntil;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndFrom;
        private System.Windows.Forms.Label label_Teacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartUntil;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartFrom;
        private System.Windows.Forms.Label labelStartDate;
        private MyButton myButtonClear;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.TextBox textBoxAEM;
        private System.Windows.Forms.Label label_AEM;
        private System.Windows.Forms.Panel panelTeacher1;
        private System.Windows.Forms.Panel panelTeacher2;
        private System.Windows.Forms.CheckedListBox checkedListBoxTeachers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTeachersNone;
        private System.Windows.Forms.Button buttonTeachersAll;
        private System.Windows.Forms.Panel panelCompanies1;
        private System.Windows.Forms.ComboBox ComboboxCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelCompanies2;
        private System.Windows.Forms.Button buttonCompanyNone;
        private System.Windows.Forms.Button buttonCompanyAll;
        private System.Windows.Forms.Label labelCompanies;
        private System.Windows.Forms.CheckedListBox checkedListBoxCompanies;
        private System.Windows.Forms.CheckedListBox checkedListBoxTeacherStRpt;
        private System.Windows.Forms.CheckedListBox checkedListBoxCompanyStRpt;
        private System.Windows.Forms.Button buttonTall;
        private System.Windows.Forms.Button buttonTnone;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonCnone;

    }
}