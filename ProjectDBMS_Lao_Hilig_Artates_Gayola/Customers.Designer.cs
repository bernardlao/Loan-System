namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    partial class frmCustomer
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
            System.Windows.Forms.Timer timer1;
            this.btnCommand = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.gpbMain = new System.Windows.Forms.GroupBox();
            this.dtpBday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.gpbSecondary = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstExistingCustomer = new System.Windows.Forms.ListView();
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStatus = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpbMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.gpbSecondary.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(542, 160);
            this.btnCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(94, 31);
            this.btnCommand.TabIndex = 37;
            this.btnCommand.Text = "Command";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(444, 160);
            this.btnCancelUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnCancelUpdate.TabIndex = 47;
            this.btnCancelUpdate.Text = "Cancel Update";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // gpbMain
            // 
            this.gpbMain.Controls.Add(this.dtpBday);
            this.gpbMain.Controls.Add(this.label7);
            this.gpbMain.Controls.Add(this.txtContact);
            this.gpbMain.Controls.Add(this.groupBox2);
            this.gpbMain.Controls.Add(this.label6);
            this.gpbMain.Controls.Add(this.cmbGender);
            this.gpbMain.Controls.Add(this.label5);
            this.gpbMain.Controls.Add(this.label4);
            this.gpbMain.Controls.Add(this.txtAddress);
            this.gpbMain.Controls.Add(this.label3);
            this.gpbMain.Controls.Add(this.label2);
            this.gpbMain.Controls.Add(this.label1);
            this.gpbMain.Controls.Add(this.txtMname);
            this.gpbMain.Controls.Add(this.txtLname);
            this.gpbMain.Controls.Add(this.txtFname);
            this.gpbMain.Location = new System.Drawing.Point(3, -2);
            this.gpbMain.Name = "gpbMain";
            this.gpbMain.Size = new System.Drawing.Size(656, 157);
            this.gpbMain.TabIndex = 49;
            this.gpbMain.TabStop = false;
            // 
            // dtpBday
            // 
            this.dtpBday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBday.Location = new System.Drawing.Point(327, 67);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(110, 20);
            this.dtpBday.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Contact ";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(321, 95);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(118, 20);
            this.txtContact.TabIndex = 57;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPhoto);
            this.groupBox2.Controls.Add(this.picPhoto);
            this.groupBox2.Location = new System.Drawing.Point(493, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(149, 150);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer\'s Image";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(45, 73);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(56, 13);
            this.lblPhoto.TabIndex = 16;
            this.lblPhoto.Text = "Click Here";
            // 
            // picPhoto
            // 
            this.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPhoto.Location = new System.Drawing.Point(12, 20);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(128, 120);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 15;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.picPhoto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Birthdate";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(321, 36);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(118, 21);
            this.cmbGender.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(79, 129);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 20);
            this.txtAddress.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "First Name";
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(89, 94);
            this.txtMname.Margin = new System.Windows.Forms.Padding(2);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(131, 20);
            this.txtMname.TabIndex = 44;
            this.txtMname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(89, 64);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(131, 20);
            this.txtLname.TabIndex = 43;
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(87, 35);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(131, 20);
            this.txtFname.TabIndex = 42;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // gpbSecondary
            // 
            this.gpbSecondary.Controls.Add(this.btnStatus);
            this.gpbSecondary.Controls.Add(this.cmbStatus);
            this.gpbSecondary.Controls.Add(this.label8);
            this.gpbSecondary.Controls.Add(this.cmbSearchBy);
            this.gpbSecondary.Controls.Add(this.txtSearchKey);
            this.gpbSecondary.Controls.Add(this.btnSearch);
            this.gpbSecondary.Controls.Add(this.lstExistingCustomer);
            this.gpbSecondary.Location = new System.Drawing.Point(3, 196);
            this.gpbSecondary.Name = "gpbSecondary";
            this.gpbSecondary.Size = new System.Drawing.Size(656, 272);
            this.gpbSecondary.TabIndex = 50;
            this.gpbSecondary.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(14, 12);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(99, 21);
            this.cmbStatus.TabIndex = 54;
            this.cmbStatus.SelectionChangeCommitted += new System.EventHandler(this.cmbStatus_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Search by";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Name",
            "Contact"});
            this.cmbSearchBy.Location = new System.Drawing.Point(338, 14);
            this.cmbSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(99, 21);
            this.cmbSearchBy.TabIndex = 52;
            this.cmbSearchBy.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchBy_SelectionChangeCommitted);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(457, 13);
            this.txtSearchKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(116, 20);
            this.txtSearchKey.TabIndex = 51;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(576, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 24);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstExistingCustomer
            // 
            this.lstExistingCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FullName,
            this.Address,
            this.Gender,
            this.bday,
            this.Contact,
            this.clStatus});
            this.lstExistingCustomer.FullRowSelect = true;
            this.lstExistingCustomer.GridLines = true;
            this.lstExistingCustomer.Location = new System.Drawing.Point(14, 39);
            this.lstExistingCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.lstExistingCustomer.MultiSelect = false;
            this.lstExistingCustomer.Name = "lstExistingCustomer";
            this.lstExistingCustomer.Size = new System.Drawing.Size(628, 181);
            this.lstExistingCustomer.TabIndex = 49;
            this.lstExistingCustomer.UseCompatibleStateImageBehavior = false;
            this.lstExistingCustomer.View = System.Windows.Forms.View.Details;
            this.lstExistingCustomer.Click += new System.EventHandler(this.lstExistingCustomer_Click);
            this.lstExistingCustomer.DoubleClick += new System.EventHandler(this.lstExistingCustomer_DoubleClick);
            // 
            // FullName
            // 
            this.FullName.Text = "Name";
            this.FullName.Width = 175;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 160;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 49;
            // 
            // bday
            // 
            this.bday.Text = "Birthdate";
            this.bday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bday.Width = 80;
            // 
            // Contact
            // 
            this.Contact.Text = "Contact";
            this.Contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Contact.Width = 95;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(548, 230);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(94, 31);
            this.btnStatus.TabIndex = 55;
            this.btnStatus.Text = "Command";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 474);
            this.Controls.Add(this.gpbSecondary);
            this.Controls.Add(this.gpbMain);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.btnCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.gpbMain.ResumeLayout(false);
            this.gpbMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.gpbSecondary.ResumeLayout(false);
            this.gpbSecondary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnCommand;
        public System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        public System.Windows.Forms.GroupBox gpbMain;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader bday;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.Label lblPhoto;
        public System.Windows.Forms.ListView lstExistingCustomer;
        private System.Windows.Forms.DateTimePicker dtpBday;
        public System.Windows.Forms.Button btnStatus;
        public System.Windows.Forms.GroupBox gpbSecondary;
    }
}