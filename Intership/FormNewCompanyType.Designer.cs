namespace Intership
{
    partial class FormNewCompanyType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewCompanyType));
            this.dataGridViewType = new System.Windows.Forms.DataGridView();
            this.buttonTypeNew = new System.Windows.Forms.Button();
            this.buttonTypeDelete = new System.Windows.Forms.Button();
            this.buttonCancelTypeEdit = new System.Windows.Forms.Button();
            this.buttonEditType = new System.Windows.Forms.Button();
            this.pictureBoxErrorTypeName = new System.Windows.Forms.PictureBox();
            this.textBoxTypeName = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.buttonTypeSave = new System.Windows.Forms.Button();
            this.groupBoxEditType = new System.Windows.Forms.GroupBox();
            this.panelEditType = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorTypeName)).BeginInit();
            this.groupBoxEditType.SuspendLayout();
            this.panelEditType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewType
            // 
            this.dataGridViewType.AllowUserToAddRows = false;
            this.dataGridViewType.AllowUserToDeleteRows = false;
            this.dataGridViewType.AllowUserToOrderColumns = true;
            this.dataGridViewType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewType.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewType.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewType.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewType.MultiSelect = false;
            this.dataGridViewType.Name = "dataGridViewType";
            this.dataGridViewType.ReadOnly = true;
            this.dataGridViewType.RowHeadersVisible = false;
            this.dataGridViewType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewType.Size = new System.Drawing.Size(338, 152);
            this.dataGridViewType.TabIndex = 21;
            this.dataGridViewType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewType_CellClick);
            // 
            // buttonTypeNew
            // 
            this.buttonTypeNew.AccessibleDescription = "";
            this.buttonTypeNew.AccessibleName = "";
            this.buttonTypeNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonTypeNew.ForeColor = System.Drawing.Color.Green;
            this.buttonTypeNew.Location = new System.Drawing.Point(7, 19);
            this.buttonTypeNew.Name = "buttonTypeNew";
            this.buttonTypeNew.Size = new System.Drawing.Size(20, 21);
            this.buttonTypeNew.TabIndex = 24;
            this.buttonTypeNew.TabStop = false;
            this.buttonTypeNew.Text = "+";
            this.buttonTypeNew.UseVisualStyleBackColor = true;
            this.buttonTypeNew.Click += new System.EventHandler(this.buttonContactNew_Click);
            // 
            // buttonTypeDelete
            // 
            this.buttonTypeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonTypeDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonTypeDelete.Location = new System.Drawing.Point(59, 19);
            this.buttonTypeDelete.Name = "buttonTypeDelete";
            this.buttonTypeDelete.Size = new System.Drawing.Size(20, 21);
            this.buttonTypeDelete.TabIndex = 25;
            this.buttonTypeDelete.TabStop = false;
            this.buttonTypeDelete.Text = "-";
            this.buttonTypeDelete.UseVisualStyleBackColor = true;
            this.buttonTypeDelete.Click += new System.EventHandler(this.buttonTypeDelete_Click);
            // 
            // buttonCancelTypeEdit
            // 
            this.buttonCancelTypeEdit.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelTypeEdit.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelTypeEdit.Location = new System.Drawing.Point(302, 0);
            this.buttonCancelTypeEdit.Name = "buttonCancelTypeEdit";
            this.buttonCancelTypeEdit.Size = new System.Drawing.Size(20, 21);
            this.buttonCancelTypeEdit.TabIndex = 26;
            this.buttonCancelTypeEdit.TabStop = false;
            this.buttonCancelTypeEdit.Text = "X";
            this.buttonCancelTypeEdit.UseVisualStyleBackColor = true;
            this.buttonCancelTypeEdit.Click += new System.EventHandler(this.buttonCancelContactEdit_Click);
            // 
            // buttonEditType
            // 
            this.buttonEditType.BackgroundImage = global::Intership.Properties.Resources.edit_button_image_68871;
            this.buttonEditType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditType.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditType.Location = new System.Drawing.Point(33, 19);
            this.buttonEditType.Name = "buttonEditType";
            this.buttonEditType.Size = new System.Drawing.Size(20, 21);
            this.buttonEditType.TabIndex = 27;
            this.buttonEditType.TabStop = false;
            this.buttonEditType.UseVisualStyleBackColor = true;
            this.buttonEditType.Click += new System.EventHandler(this.buttonEditContact_Click);
            // 
            // pictureBoxErrorTypeName
            // 
            this.pictureBoxErrorTypeName.BackgroundImage = global::Intership.Properties.Resources.attention;
            this.pictureBoxErrorTypeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxErrorTypeName.Location = new System.Drawing.Point(96, 34);
            this.pictureBoxErrorTypeName.Name = "pictureBoxErrorTypeName";
            this.pictureBoxErrorTypeName.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxErrorTypeName.TabIndex = 32;
            this.pictureBoxErrorTypeName.TabStop = false;
            // 
            // textBoxTypeName
            // 
            this.textBoxTypeName.Location = new System.Drawing.Point(117, 33);
            this.textBoxTypeName.MaxLength = 100;
            this.textBoxTypeName.Name = "textBoxTypeName";
            this.textBoxTypeName.Size = new System.Drawing.Size(205, 20);
            this.textBoxTypeName.TabIndex = 30;
            this.textBoxTypeName.TextChanged += new System.EventHandler(this.textBoxTypeName_TextChanged);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_type.ForeColor = System.Drawing.Color.White;
            this.label_type.Location = new System.Drawing.Point(-3, 36);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(99, 13);
            this.label_type.TabIndex = 31;
            this.label_type.Text = "Είδος Εταιρίας:";
            // 
            // buttonTypeSave
            // 
            this.buttonTypeSave.Enabled = false;
            this.buttonTypeSave.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTypeSave.ForeColor = System.Drawing.Color.Green;
            this.buttonTypeSave.Location = new System.Drawing.Point(276, 0);
            this.buttonTypeSave.Name = "buttonTypeSave";
            this.buttonTypeSave.Size = new System.Drawing.Size(20, 21);
            this.buttonTypeSave.TabIndex = 33;
            this.buttonTypeSave.Text = "√";
            this.buttonTypeSave.UseVisualStyleBackColor = true;
            this.buttonTypeSave.Click += new System.EventHandler(this.buttonTypeSave_Click);
            // 
            // groupBoxEditType
            // 
            this.groupBoxEditType.Controls.Add(this.buttonEditType);
            this.groupBoxEditType.Controls.Add(this.buttonTypeDelete);
            this.groupBoxEditType.Controls.Add(this.buttonTypeNew);
            this.groupBoxEditType.Controls.Add(this.panelEditType);
            this.groupBoxEditType.ForeColor = System.Drawing.Color.White;
            this.groupBoxEditType.Location = new System.Drawing.Point(8, 166);
            this.groupBoxEditType.Name = "groupBoxEditType";
            this.groupBoxEditType.Size = new System.Drawing.Size(338, 106);
            this.groupBoxEditType.TabIndex = 34;
            this.groupBoxEditType.TabStop = false;
            // 
            // panelEditType
            // 
            this.panelEditType.Controls.Add(this.buttonTypeSave);
            this.panelEditType.Controls.Add(this.textBoxTypeName);
            this.panelEditType.Controls.Add(this.label_type);
            this.panelEditType.Controls.Add(this.pictureBoxErrorTypeName);
            this.panelEditType.Controls.Add(this.buttonCancelTypeEdit);
            this.panelEditType.Location = new System.Drawing.Point(7, 19);
            this.panelEditType.Name = "panelEditType";
            this.panelEditType.Size = new System.Drawing.Size(325, 77);
            this.panelEditType.TabIndex = 34;
            this.panelEditType.Visible = false;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.okButton.FlatAppearance.BorderSize = 2;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(132, 287);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(78, 26);
            this.okButton.TabIndex = 35;
            this.okButton.Text = "Έξοδος";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // FormNewCompanyType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(358, 325);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dataGridViewType);
            this.Controls.Add(this.groupBoxEditType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNewCompanyType";
            this.ShowIcon = false;
            this.Text = "Είδος Επιχείρησης";
            this.Load += new System.EventHandler(this.FormNewCompanyType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorTypeName)).EndInit();
            this.groupBoxEditType.ResumeLayout(false);
            this.panelEditType.ResumeLayout(false);
            this.panelEditType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewType;
        private System.Windows.Forms.Button buttonTypeNew;
        private System.Windows.Forms.Button buttonTypeDelete;
        private System.Windows.Forms.Button buttonCancelTypeEdit;
        private System.Windows.Forms.Button buttonEditType;
        private System.Windows.Forms.PictureBox pictureBoxErrorTypeName;
        private System.Windows.Forms.TextBox textBoxTypeName;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Button buttonTypeSave;
        private System.Windows.Forms.GroupBox groupBoxEditType;
        private System.Windows.Forms.Panel panelEditType;
        private System.Windows.Forms.Button okButton;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;

    }
}