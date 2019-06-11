namespace Intership
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxVerifyPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelVerifyPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.myButtonOK = new Intership.MyButton();
            this.myButtonCancel = new Intership.MyButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEditUsers = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intershipDataSet = new Intership.intershipDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.myButtonNewUser = new Intership.MyButton();
            this.myButtonCancel2 = new Intership.MyButton();
            this.myButtonDelete = new Intership.MyButton();
            this.tabPageNewUser = new System.Windows.Forms.TabPage();
            this.usersTableAdapter = new Intership.intershipDataSetTableAdapters.UsersTableAdapter();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageEditUsers.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageNewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxVerifyPassword);
            this.groupBox2.Controls.Add(this.labelUsername);
            this.groupBox2.Controls.Add(this.labelPassword);
            this.groupBox2.Controls.Add(this.labelVerifyPassword);
            this.groupBox2.Controls.Add(this.textBoxUsername);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Location = new System.Drawing.Point(17, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 161);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // textBoxVerifyPassword
            // 
            this.textBoxVerifyPassword.Enabled = false;
            this.textBoxVerifyPassword.Location = new System.Drawing.Point(6, 133);
            this.textBoxVerifyPassword.Name = "textBoxVerifyPassword";
            this.textBoxVerifyPassword.Size = new System.Drawing.Size(248, 20);
            this.textBoxVerifyPassword.TabIndex = 3;
            this.textBoxVerifyPassword.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(6, 16);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(99, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "\'Ονομα Χρήστη:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(6, 69);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(86, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Συνθηματικό:";
            // 
            // labelVerifyPassword
            // 
            this.labelVerifyPassword.AutoSize = true;
            this.labelVerifyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelVerifyPassword.ForeColor = System.Drawing.Color.White;
            this.labelVerifyPassword.Location = new System.Drawing.Point(6, 117);
            this.labelVerifyPassword.Name = "labelVerifyPassword";
            this.labelVerifyPassword.Size = new System.Drawing.Size(172, 13);
            this.labelVerifyPassword.TabIndex = 1;
            this.labelVerifyPassword.Text = "Επιβεβαίωση συνθηματικού:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(6, 32);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(248, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 85);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(248, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // myButtonOK
            // 
            this.myButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myButtonOK.FlatAppearance.BorderSize = 2;
            this.myButtonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myButtonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButtonOK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myButtonOK.ForeColor = System.Drawing.Color.White;
            this.myButtonOK.Location = new System.Drawing.Point(23, 197);
            this.myButtonOK.Name = "myButtonOK";
            this.myButtonOK.Size = new System.Drawing.Size(93, 30);
            this.myButtonOK.TabIndex = 7;
            this.myButtonOK.TabStop = false;
            this.myButtonOK.Text = "Δημιουργία";
            this.myButtonOK.UseVisualStyleBackColor = true;
            this.myButtonOK.Click += new System.EventHandler(this.myButtonOK_Click);
            // 
            // myButtonCancel
            // 
            this.myButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.myButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myButtonCancel.FlatAppearance.BorderSize = 2;
            this.myButtonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myButtonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButtonCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myButtonCancel.ForeColor = System.Drawing.Color.White;
            this.myButtonCancel.Location = new System.Drawing.Point(178, 197);
            this.myButtonCancel.Name = "myButtonCancel";
            this.myButtonCancel.Size = new System.Drawing.Size(93, 30);
            this.myButtonCancel.TabIndex = 8;
            this.myButtonCancel.TabStop = false;
            this.myButtonCancel.Text = "Ακύρωση";
            this.myButtonCancel.UseVisualStyleBackColor = true;
            this.myButtonCancel.Click += new System.EventHandler(this.myButtonCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEditUsers);
            this.tabControl1.Controls.Add(this.tabPageNewUser);
            this.tabControl1.Location = new System.Drawing.Point(-4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(297, 274);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageEditUsers
            // 
            this.tabPageEditUsers.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPageEditUsers.Controls.Add(this.groupBox3);
            this.tabPageEditUsers.Controls.Add(this.groupBox1);
            this.tabPageEditUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditUsers.Name = "tabPageEditUsers";
            this.tabPageEditUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditUsers.Size = new System.Drawing.Size(289, 248);
            this.tabPageEditUsers.TabIndex = 1;
            this.tabPageEditUsers.Text = "Χρήστες";
            this.tabPageEditUsers.ToolTipText = "Επεξεργασία Χρηστών";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxUsers);
            this.groupBox3.Location = new System.Drawing.Point(12, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 224);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.DataSource = this.usersBindingSource;
            this.listBoxUsers.DisplayMember = "username";
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(6, 16);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(102, 199);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.ValueMember = "username";
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.intershipDataSet;
            // 
            // intershipDataSet
            // 
            this.intershipDataSet.DataSetName = "intershipDataSet";
            this.intershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.myButtonNewUser);
            this.groupBox1.Controls.Add(this.myButtonCancel2);
            this.groupBox1.Controls.Add(this.myButtonDelete);
            this.groupBox1.Location = new System.Drawing.Point(134, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 224);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // myButtonNewUser
            // 
            this.myButtonNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButtonNewUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myButtonNewUser.FlatAppearance.BorderSize = 2;
            this.myButtonNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myButtonNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myButtonNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButtonNewUser.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myButtonNewUser.ForeColor = System.Drawing.Color.White;
            this.myButtonNewUser.Location = new System.Drawing.Point(5, 16);
            this.myButtonNewUser.Name = "myButtonNewUser";
            this.myButtonNewUser.Size = new System.Drawing.Size(133, 30);
            this.myButtonNewUser.TabIndex = 8;
            this.myButtonNewUser.TabStop = false;
            this.myButtonNewUser.Text = "Δημιουργία Χρήστη";
            this.myButtonNewUser.UseVisualStyleBackColor = true;
            this.myButtonNewUser.Click += new System.EventHandler(this.myButtonNewUser_Click);
            // 
            // myButtonCancel2
            // 
            this.myButtonCancel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButtonCancel2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myButtonCancel2.FlatAppearance.BorderSize = 2;
            this.myButtonCancel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myButtonCancel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myButtonCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButtonCancel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myButtonCancel2.ForeColor = System.Drawing.Color.White;
            this.myButtonCancel2.Location = new System.Drawing.Point(5, 185);
            this.myButtonCancel2.Name = "myButtonCancel2";
            this.myButtonCancel2.Size = new System.Drawing.Size(133, 30);
            this.myButtonCancel2.TabIndex = 8;
            this.myButtonCancel2.TabStop = false;
            this.myButtonCancel2.Text = "Ακύρωση";
            this.myButtonCancel2.UseVisualStyleBackColor = true;
            this.myButtonCancel2.Click += new System.EventHandler(this.myButtonCancel_Click);
            // 
            // myButtonDelete
            // 
            this.myButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myButtonDelete.FlatAppearance.BorderSize = 2;
            this.myButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButtonDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myButtonDelete.ForeColor = System.Drawing.Color.White;
            this.myButtonDelete.Location = new System.Drawing.Point(5, 52);
            this.myButtonDelete.Name = "myButtonDelete";
            this.myButtonDelete.Size = new System.Drawing.Size(133, 30);
            this.myButtonDelete.TabIndex = 8;
            this.myButtonDelete.TabStop = false;
            this.myButtonDelete.Text = "Διαχραφή Χρήστη";
            this.myButtonDelete.UseVisualStyleBackColor = true;
            this.myButtonDelete.Click += new System.EventHandler(this.myButtonDeleteUser_Click);
            // 
            // tabPageNewUser
            // 
            this.tabPageNewUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPageNewUser.Controls.Add(this.groupBox2);
            this.tabPageNewUser.Controls.Add(this.myButtonCancel);
            this.tabPageNewUser.Controls.Add(this.myButtonOK);
            this.tabPageNewUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewUser.Name = "tabPageNewUser";
            this.tabPageNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewUser.Size = new System.Drawing.Size(289, 248);
            this.tabPageNewUser.TabIndex = 0;
            this.tabPageNewUser.Text = "Νέος Χρήστης";
            this.tabPageNewUser.ToolTipText = "Δημιουργία Νέου Χρήστη";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // FormUsers
            // 
            this.AcceptButton = this.myButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.myButtonCancel;
            this.ClientSize = new System.Drawing.Size(288, 279);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Διαχείριση Χρηστών";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageEditUsers.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPageNewUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxVerifyPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelVerifyPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private MyButton myButtonOK;
        private MyButton myButtonCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNewUser;
        private System.Windows.Forms.TabPage tabPageEditUsers;
        private MyButton myButtonCancel2;
        private MyButton myButtonDelete;
        private MyButton myButtonNewUser;
        private System.Windows.Forms.ListBox listBoxUsers;
        private intershipDataSet intershipDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private intershipDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}