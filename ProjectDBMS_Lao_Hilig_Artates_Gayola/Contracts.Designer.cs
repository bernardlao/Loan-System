namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    partial class frmContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContracts));
            this.gpbCustomer = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstExistingCustomer = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbContract = new System.Windows.Forms.GroupBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpPaymentStart = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.chkCondition = new System.Windows.Forms.CheckBox();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.gpbAgreement = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.cmbPenalty = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGives = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGotoInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gpbContractDetails = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtAgreementMode = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAgreementInterest = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDateStart = new System.Windows.Forms.TextBox();
            this.txtPaymentDue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateEnd = new System.Windows.Forms.TextBox();
            this.gpbCustomer.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.gpbContract.SuspendLayout();
            this.gpbAgreement.SuspendLayout();
            this.gpbContractDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCustomer
            // 
            this.gpbCustomer.Controls.Add(this.btnSelect);
            this.gpbCustomer.Controls.Add(this.label8);
            this.gpbCustomer.Controls.Add(this.cmbSearchBy);
            this.gpbCustomer.Controls.Add(this.txtSearchKey);
            this.gpbCustomer.Controls.Add(this.btnSearch);
            this.gpbCustomer.Controls.Add(this.lstExistingCustomer);
            this.gpbCustomer.Location = new System.Drawing.Point(2, 1);
            this.gpbCustomer.Name = "gpbCustomer";
            this.gpbCustomer.Size = new System.Drawing.Size(466, 544);
            this.gpbCustomer.TabIndex = 0;
            this.gpbCustomer.TabStop = false;
            this.gpbCustomer.Text = "Customer Selection";
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(382, 510);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(72, 29);
            this.btnSelect.TabIndex = 61;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Search by";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Name",
            "Contact"});
            this.cmbSearchBy.Location = new System.Drawing.Point(150, 33);
            this.cmbSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(99, 21);
            this.cmbSearchBy.TabIndex = 58;
            this.cmbSearchBy.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchBy_SelectionChangeCommitted);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(269, 32);
            this.txtSearchKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(116, 20);
            this.txtSearchKey.TabIndex = 57;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(388, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 24);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstExistingCustomer
            // 
            this.lstExistingCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.FullName,
            this.Address,
            this.Contact,
            this.clStatus});
            this.lstExistingCustomer.FullRowSelect = true;
            this.lstExistingCustomer.GridLines = true;
            this.lstExistingCustomer.Location = new System.Drawing.Point(10, 75);
            this.lstExistingCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.lstExistingCustomer.MultiSelect = false;
            this.lstExistingCustomer.Name = "lstExistingCustomer";
            this.lstExistingCustomer.Size = new System.Drawing.Size(444, 430);
            this.lstExistingCustomer.TabIndex = 55;
            this.lstExistingCustomer.UseCompatibleStateImageBehavior = false;
            this.lstExistingCustomer.View = System.Windows.Forms.View.Details;
            this.lstExistingCustomer.Click += new System.EventHandler(this.lstExistingCustomer_Click);
            this.lstExistingCustomer.DoubleClick += new System.EventHandler(this.lstExistingCustomer_DoubleClick);
            // 
            // clID
            // 
            this.clID.Text = "";
            this.clID.Width = 0;
            // 
            // FullName
            // 
            this.FullName.Text = "Name";
            this.FullName.Width = 147;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 138;
            // 
            // Contact
            // 
            this.Contact.Text = "Contact";
            this.Contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Contact.Width = 90;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.btnConfirm);
            this.gpbInfo.Controls.Add(this.btnGoBack);
            this.gpbInfo.Controls.Add(this.txtBalance);
            this.gpbInfo.Controls.Add(this.txtContact);
            this.gpbInfo.Controls.Add(this.txtFullname);
            this.gpbInfo.Controls.Add(this.label4);
            this.gpbInfo.Controls.Add(this.groupBox1);
            this.gpbInfo.Controls.Add(this.label3);
            this.gpbInfo.Controls.Add(this.label1);
            this.gpbInfo.Location = new System.Drawing.Point(474, 3);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(249, 542);
            this.gpbInfo.TabIndex = 1;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Customer Info";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(134, 425);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(72, 29);
            this.btnConfirm.TabIndex = 63;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(58, 425);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(72, 29);
            this.btnGoBack.TabIndex = 62;
            this.btnGoBack.Text = "<<Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(22, 357);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(214, 20);
            this.txtBalance.TabIndex = 8;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(22, 307);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(214, 20);
            this.txtContact.TabIndex = 7;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(22, 256);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(214, 20);
            this.txtFullname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Outstanding Balance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPhoto);
            this.groupBox1.Controls.Add(this.picPhoto);
            this.groupBox1.Location = new System.Drawing.Point(47, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 151);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(52, 72);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(52, 13);
            this.lblPhoto.TabIndex = 17;
            this.lblPhoto.Text = "No Photo";
            this.lblPhoto.Visible = false;
            // 
            // picPhoto
            // 
            this.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPhoto.Location = new System.Drawing.Point(15, 18);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(128, 120);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 16;
            this.picPhoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // gpbContract
            // 
            this.gpbContract.Controls.Add(this.lblCapital);
            this.gpbContract.Controls.Add(this.label17);
            this.gpbContract.Controls.Add(this.dtpPaymentStart);
            this.gpbContract.Controls.Add(this.btnCheck);
            this.gpbContract.Controls.Add(this.label16);
            this.gpbContract.Controls.Add(this.chkCondition);
            this.gpbContract.Controls.Add(this.cmbMode);
            this.gpbContract.Controls.Add(this.label14);
            this.gpbContract.Controls.Add(this.txtInterest);
            this.gpbContract.Controls.Add(this.gpbAgreement);
            this.gpbContract.Controls.Add(this.txtGives);
            this.gpbContract.Controls.Add(this.label6);
            this.gpbContract.Controls.Add(this.label5);
            this.gpbContract.Controls.Add(this.txtLoanAmount);
            this.gpbContract.Controls.Add(this.label2);
            this.gpbContract.Location = new System.Drawing.Point(729, 3);
            this.gpbContract.Name = "gpbContract";
            this.gpbContract.Size = new System.Drawing.Size(297, 317);
            this.gpbContract.TabIndex = 2;
            this.gpbContract.TabStop = false;
            this.gpbContract.Text = "Loan Contract";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapital.Location = new System.Drawing.Point(19, 283);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(48, 13);
            this.lblCapital.TabIndex = 59;
            this.lblCapital.Text = "label20";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 91);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "Start of Payment";
            // 
            // dtpPaymentStart
            // 
            this.dtpPaymentStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentStart.Location = new System.Drawing.Point(130, 85);
            this.dtpPaymentStart.MinDate = new System.DateTime(2016, 2, 24, 0, 0, 0, 0);
            this.dtpPaymentStart.Name = "dtpPaymentStart";
            this.dtpPaymentStart.Size = new System.Drawing.Size(100, 20);
            this.dtpPaymentStart.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(212, 275);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 29);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(232, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "%";
            // 
            // chkCondition
            // 
            this.chkCondition.AutoSize = true;
            this.chkCondition.Location = new System.Drawing.Point(170, 186);
            this.chkCondition.Name = "chkCondition";
            this.chkCondition.Size = new System.Drawing.Size(99, 17);
            this.chkCondition.TabIndex = 6;
            this.chkCondition.Text = "Add Agreement";
            this.chkCondition.UseVisualStyleBackColor = true;
            this.chkCondition.CheckedChanged += new System.EventHandler(this.chkCondition_CheckedChanged);
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.cmbMode.Location = new System.Drawing.Point(130, 53);
            this.cmbMode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(99, 21);
            this.cmbMode.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Payment Mode";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(79, 119);
            this.txtInterest.MaxLength = 3;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(150, 20);
            this.txtInterest.TabIndex = 4;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenalty_KeyPress);
            // 
            // gpbAgreement
            // 
            this.gpbAgreement.Controls.Add(this.label15);
            this.gpbAgreement.Controls.Add(this.label13);
            this.gpbAgreement.Controls.Add(this.txtPenalty);
            this.gpbAgreement.Controls.Add(this.cmbPenalty);
            this.gpbAgreement.Controls.Add(this.label9);
            this.gpbAgreement.Enabled = false;
            this.gpbAgreement.Location = new System.Drawing.Point(22, 190);
            this.gpbAgreement.Name = "gpbAgreement";
            this.gpbAgreement.Size = new System.Drawing.Size(247, 79);
            this.gpbAgreement.TabIndex = 49;
            this.gpbAgreement.TabStop = false;
            this.gpbAgreement.Text = "Agreement";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(210, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Interest";
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(57, 19);
            this.txtPenalty.MaxLength = 3;
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(150, 20);
            this.txtPenalty.TabIndex = 7;
            this.txtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPenalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenalty_KeyPress);
            // 
            // cmbPenalty
            // 
            this.cmbPenalty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenalty.FormattingEnabled = true;
            this.cmbPenalty.Items.AddRange(new object[] {
            "Daily",
            "Per Duedate"});
            this.cmbPenalty.Location = new System.Drawing.Point(108, 47);
            this.cmbPenalty.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPenalty.Name = "cmbPenalty";
            this.cmbPenalty.Size = new System.Drawing.Size(99, 21);
            this.cmbPenalty.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Penalty Condition";
            // 
            // txtGives
            // 
            this.txtGives.Location = new System.Drawing.Point(77, 150);
            this.txtGives.MaxLength = 4;
            this.txtGives.Name = "txtGives";
            this.txtGives.Size = new System.Drawing.Size(150, 20);
            this.txtGives.TabIndex = 5;
            this.txtGives.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGives.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGives_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gives";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Interest";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(114, 25);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(115, 20);
            this.txtLoanAmount.TabIndex = 1;
            this.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenalty_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loan Amount";
            // 
            // btnGotoInfo
            // 
            this.btnGotoInfo.Enabled = false;
            this.btnGotoInfo.Location = new System.Drawing.Point(853, 555);
            this.btnGotoInfo.Name = "btnGotoInfo";
            this.btnGotoInfo.Size = new System.Drawing.Size(75, 29);
            this.btnGotoInfo.TabIndex = 9;
            this.btnGotoInfo.Text = "<<Back";
            this.btnGotoInfo.UseVisualStyleBackColor = true;
            this.btnGotoInfo.Click += new System.EventHandler(this.btnGotoInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(941, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gpbContractDetails
            // 
            this.gpbContractDetails.Controls.Add(this.label21);
            this.gpbContractDetails.Controls.Add(this.btnLast);
            this.gpbContractDetails.Controls.Add(this.txtAgreementMode);
            this.gpbContractDetails.Controls.Add(this.label19);
            this.gpbContractDetails.Controls.Add(this.txtAgreementInterest);
            this.gpbContractDetails.Controls.Add(this.label18);
            this.gpbContractDetails.Controls.Add(this.label10);
            this.gpbContractDetails.Controls.Add(this.txtDateStart);
            this.gpbContractDetails.Controls.Add(this.txtPaymentDue);
            this.gpbContractDetails.Controls.Add(this.label11);
            this.gpbContractDetails.Controls.Add(this.txtTotalAmount);
            this.gpbContractDetails.Controls.Add(this.label12);
            this.gpbContractDetails.Controls.Add(this.label7);
            this.gpbContractDetails.Controls.Add(this.txtDateEnd);
            this.gpbContractDetails.Enabled = false;
            this.gpbContractDetails.Location = new System.Drawing.Point(729, 326);
            this.gpbContractDetails.Name = "gpbContractDetails";
            this.gpbContractDetails.Size = new System.Drawing.Size(297, 223);
            this.gpbContractDetails.TabIndex = 3;
            this.gpbContractDetails.TabStop = false;
            this.gpbContractDetails.Text = "Contract Details";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 148);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 63;
            this.label21.Text = "Condition";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(144, 190);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(143, 29);
            this.btnLast.TabIndex = 62;
            this.btnLast.Text = "Check Last Contract";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Visible = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtAgreementMode
            // 
            this.txtAgreementMode.Location = new System.Drawing.Point(176, 164);
            this.txtAgreementMode.Name = "txtAgreementMode";
            this.txtAgreementMode.ReadOnly = true;
            this.txtAgreementMode.Size = new System.Drawing.Size(108, 20);
            this.txtAgreementMode.TabIndex = 61;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(128, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 13);
            this.label19.TabIndex = 59;
            this.label19.Text = "%";
            // 
            // txtAgreementInterest
            // 
            this.txtAgreementInterest.Location = new System.Drawing.Point(61, 164);
            this.txtAgreementInterest.Name = "txtAgreementInterest";
            this.txtAgreementInterest.ReadOnly = true;
            this.txtAgreementInterest.Size = new System.Drawing.Size(65, 20);
            this.txtAgreementInterest.TabIndex = 58;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Interest";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Start of Payment";
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(143, 56);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.ReadOnly = true;
            this.txtDateStart.Size = new System.Drawing.Size(140, 20);
            this.txtDateStart.TabIndex = 52;
            // 
            // txtPaymentDue
            // 
            this.txtPaymentDue.Location = new System.Drawing.Point(143, 113);
            this.txtPaymentDue.Name = "txtPaymentDue";
            this.txtPaymentDue.ReadOnly = true;
            this.txtPaymentDue.Size = new System.Drawing.Size(140, 20);
            this.txtPaymentDue.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "End of Contract Date";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(143, 25);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(140, 20);
            this.txtTotalAmount.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Payment Due";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Total Loan Amount";
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(143, 82);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.ReadOnly = true;
            this.txtDateEnd.Size = new System.Drawing.Size(140, 20);
            this.txtDateEnd.TabIndex = 54;
            // 
            // frmContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 592);
            this.Controls.Add(this.btnGotoInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gpbContractDetails);
            this.Controls.Add(this.gpbContract);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.gpbCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contracts Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContracts_FormClosing);
            this.Load += new System.EventHandler(this.frmContracts_Load);
            this.gpbCustomer.ResumeLayout(false);
            this.gpbCustomer.PerformLayout();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.gpbContract.ResumeLayout(false);
            this.gpbContract.PerformLayout();
            this.gpbAgreement.ResumeLayout(false);
            this.gpbAgreement.PerformLayout();
            this.gpbContractDetails.ResumeLayout(false);
            this.gpbContractDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCustomer;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ListView lstExistingCustomer;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.GroupBox gpbContract;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPenalty;
        private System.Windows.Forms.TextBox txtGives;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbAgreement;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkCondition;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpPaymentStart;
        private System.Windows.Forms.GroupBox gpbContractDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDateStart;
        private System.Windows.Forms.TextBox txtPaymentDue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDateEnd;
        private System.Windows.Forms.TextBox txtAgreementMode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAgreementInterest;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGotoInfo;
        private System.Windows.Forms.Button btnLast;
        public System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.Label lblCapital;
    }
}