namespace Intership
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.label_username = new System.Windows.Forms.Label();
            this.txtBox_usrname = new System.Windows.Forms.TextBox();
            this.intershipDataSet = new Intership.intershipDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myButton_login = new Intership.MyButton();
            this.myButton_Logout = new Intership.MyButton();
            this.myCheckBox_pswRev = new Intership.MyCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_username.Location = new System.Drawing.Point(150, 228);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(91, 23);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // txtBox_usrname
            // 
            this.txtBox_usrname.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtBox_usrname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_usrname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBox_usrname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBox_usrname.Location = new System.Drawing.Point(49, 251);
            this.txtBox_usrname.Margin = new System.Windows.Forms.Padding(0);
            this.txtBox_usrname.Name = "txtBox_usrname";
            this.txtBox_usrname.Size = new System.Drawing.Size(188, 20);
            this.txtBox_usrname.TabIndex = 1;
            // 
            // intershipDataSet
            // 
            this.intershipDataSet.DataSetName = "intershipDataSet";
            this.intershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(49, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 3);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(155, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox_password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_password.Location = new System.Drawing.Point(48, 322);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(173, 20);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.txtbox_password_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(48, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 3);
            this.panel2.TabIndex = 6;
            // 
            // myButton_login
            // 
            this.myButton_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myButton_login.FlatAppearance.BorderSize = 2;
            this.myButton_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myButton_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myButton_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton_login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myButton_login.Location = new System.Drawing.Point(89, 392);
            this.myButton_login.Name = "myButton_login";
            this.myButton_login.Size = new System.Drawing.Size(105, 38);
            this.myButton_login.TabIndex = 0;
            this.myButton_login.TabStop = false;
            this.myButton_login.Text = "Είσοδος";
            this.myButton_login.UseVisualStyleBackColor = true;
            this.myButton_login.Click += new System.EventHandler(this.myButton_login_Click);
            // 
            // myButton_Logout
            // 
            this.myButton_Logout.BackColor = System.Drawing.Color.White;
            this.myButton_Logout.BackgroundImage = global::Intership.Properties.Resources.logout;
            this.myButton_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton_Logout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.myButton_Logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myButton_Logout.FlatAppearance.BorderSize = 0;
            this.myButton_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myButton_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myButton_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton_Logout.ForeColor = System.Drawing.Color.White;
            this.myButton_Logout.Location = new System.Drawing.Point(236, 12);
            this.myButton_Logout.Name = "myButton_Logout";
            this.myButton_Logout.Size = new System.Drawing.Size(25, 25);
            this.myButton_Logout.TabIndex = 0;
            this.myButton_Logout.TabStop = false;
            this.myButton_Logout.UseVisualStyleBackColor = false;
            this.myButton_Logout.Click += new System.EventHandler(this.myButton_Logout_Click);
            // 
            // myCheckBox_pswRev
            // 
            this.myCheckBox_pswRev.Appearance = System.Windows.Forms.Appearance.Button;
            this.myCheckBox_pswRev.AutoSize = true;
            this.myCheckBox_pswRev.BackColor = System.Drawing.Color.White;
            this.myCheckBox_pswRev.BackgroundImage = global::Intership.Properties.Resources.psw_rev;
            this.myCheckBox_pswRev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.myCheckBox_pswRev.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myCheckBox_pswRev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myCheckBox_pswRev.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.myCheckBox_pswRev.FlatAppearance.BorderSize = 0;
            this.myCheckBox_pswRev.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.myCheckBox_pswRev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.myCheckBox_pswRev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.myCheckBox_pswRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCheckBox_pswRev.Location = new System.Drawing.Point(220, 322);
            this.myCheckBox_pswRev.MaximumSize = new System.Drawing.Size(25, 25);
            this.myCheckBox_pswRev.MinimumSize = new System.Drawing.Size(18, 18);
            this.myCheckBox_pswRev.Name = "myCheckBox_pswRev";
            this.myCheckBox_pswRev.Size = new System.Drawing.Size(18, 18);
            this.myCheckBox_pswRev.TabIndex = 0;
            this.myCheckBox_pswRev.TabStop = false;
            this.myCheckBox_pswRev.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.myCheckBox_pswRev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.myCheckBox_pswRev.UseMnemonic = false;
            this.myCheckBox_pswRev.UseVisualStyleBackColor = false;
            this.myCheckBox_pswRev.CheckedChanged += new System.EventHandler(this.myCheckBox_pswRev_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_login
            // 
            this.AcceptButton = this.myButton_login;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.myButton_Logout;
            this.ClientSize = new System.Drawing.Size(265, 447);
            this.ControlBox = false;
            this.Controls.Add(this.myButton_login);
            this.Controls.Add(this.myCheckBox_pswRev);
            this.Controls.Add(this.myButton_Logout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.txtBox_usrname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_username);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.intershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private intershipDataSet intershipDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox_usrname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyCheckBox myCheckBox_pswRev;
        private MyButton myButton_Logout;
        private MyButton myButton_login;
    }
}

