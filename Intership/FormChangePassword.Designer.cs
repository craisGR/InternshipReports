namespace Intership
{
    partial class FormChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePassword));
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxCurrentPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRepeatNewPwd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.myButtonCancel = new Intership.MyButton();
            this.myButtonOK = new Intership.MyButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelNewPassword.ForeColor = System.Drawing.Color.White;
            this.labelNewPassword.Location = new System.Drawing.Point(6, 16);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(136, 13);
            this.labelNewPassword.TabIndex = 1;
            this.labelNewPassword.Text = "Τρέχον συνθηματικό: ";
            // 
            // textBoxCurrentPwd
            // 
            this.textBoxCurrentPwd.Location = new System.Drawing.Point(6, 32);
            this.textBoxCurrentPwd.Name = "textBoxCurrentPwd";
            this.textBoxCurrentPwd.Size = new System.Drawing.Size(248, 20);
            this.textBoxCurrentPwd.TabIndex = 1;
            this.textBoxCurrentPwd.UseSystemPasswordChar = true;
            this.textBoxCurrentPwd.TextChanged += new System.EventHandler(this.textBoxCurrentPwd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Νέο συνθηματικό:";
            // 
            // textBoxNewPwd
            // 
            this.textBoxNewPwd.Enabled = false;
            this.textBoxNewPwd.Location = new System.Drawing.Point(6, 32);
            this.textBoxNewPwd.Name = "textBoxNewPwd";
            this.textBoxNewPwd.Size = new System.Drawing.Size(248, 20);
            this.textBoxNewPwd.TabIndex = 2;
            this.textBoxNewPwd.UseSystemPasswordChar = true;
            this.textBoxNewPwd.TextChanged += new System.EventHandler(this.textBoxNewPwd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Επιβεβαίωση νέου συνθηματικού:";
            // 
            // textBoxRepeatNewPwd
            // 
            this.textBoxRepeatNewPwd.Enabled = false;
            this.textBoxRepeatNewPwd.Location = new System.Drawing.Point(6, 80);
            this.textBoxRepeatNewPwd.Name = "textBoxRepeatNewPwd";
            this.textBoxRepeatNewPwd.Size = new System.Drawing.Size(248, 20);
            this.textBoxRepeatNewPwd.TabIndex = 3;
            this.textBoxRepeatNewPwd.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNewPassword);
            this.groupBox1.Controls.Add(this.textBoxCurrentPwd);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRepeatNewPwd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxNewPwd);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
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
            this.myButtonCancel.Location = new System.Drawing.Point(170, 211);
            this.myButtonCancel.Name = "myButtonCancel";
            this.myButtonCancel.Size = new System.Drawing.Size(72, 30);
            this.myButtonCancel.TabIndex = 5;
            this.myButtonCancel.Text = "Ακύρωση";
            this.myButtonCancel.UseVisualStyleBackColor = true;
            this.myButtonCancel.Click += new System.EventHandler(this.myButtonCancel_Click);
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
            this.myButtonOK.Location = new System.Drawing.Point(43, 211);
            this.myButtonOK.Name = "myButtonOK";
            this.myButtonOK.Size = new System.Drawing.Size(72, 30);
            this.myButtonOK.TabIndex = 4;
            this.myButtonOK.Text = "Αλλαγή";
            this.myButtonOK.UseVisualStyleBackColor = true;
            this.myButtonOK.Click += new System.EventHandler(this.myButtonOK_Click);
            // 
            // FormChangePassword
            // 
            this.AcceptButton = this.myButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.myButtonCancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.myButtonCancel);
            this.Controls.Add(this.myButtonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Αλλαγή Συνθηματικού Χρήστη";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxCurrentPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRepeatNewPwd;
        private MyButton myButtonOK;
        private MyButton myButtonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}