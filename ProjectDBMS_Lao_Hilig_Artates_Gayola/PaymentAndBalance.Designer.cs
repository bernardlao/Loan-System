namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    partial class frmPaymentAndBalance
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
            this.gpbCustomer = new System.Windows.Forms.GroupBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbPhoto = new System.Windows.Forms.GroupBox();
            this.lblNP = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lstExistingCustomer = new System.Windows.Forms.ListView();
            this.clCID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gpbPayRecord = new System.Windows.Forms.GroupBox();
            this.chkActiveOnly = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPayRecord = new System.Windows.Forms.ListView();
            this.clPaymentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPaymentAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbCustomer.SuspendLayout();
            this.gpbPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.gpbPayRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCustomer
            // 
            this.gpbCustomer.Controls.Add(this.lblNote);
            this.gpbCustomer.Controls.Add(this.label2);
            this.gpbCustomer.Controls.Add(this.gpbPhoto);
            this.gpbCustomer.Controls.Add(this.lstExistingCustomer);
            this.gpbCustomer.Controls.Add(this.btnSelect);
            this.gpbCustomer.Controls.Add(this.txtSearchKey);
            this.gpbCustomer.Controls.Add(this.btnSearch);
            this.gpbCustomer.Location = new System.Drawing.Point(1, 1);
            this.gpbCustomer.Name = "gpbCustomer";
            this.gpbCustomer.Size = new System.Drawing.Size(663, 251);
            this.gpbCustomer.TabIndex = 1;
            this.gpbCustomer.TabStop = false;
            this.gpbCustomer.Text = "Customer Selection";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(11, 235);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(176, 13);
            this.lblNote.TabIndex = 65;
            this.lblNote.Text = "Note: Click to see Customer\'s Photo";
            this.lblNote.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Name";
            // 
            // gpbPhoto
            // 
            this.gpbPhoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpbPhoto.Controls.Add(this.lblNP);
            this.gpbPhoto.Controls.Add(this.picPhoto);
            this.gpbPhoto.Location = new System.Drawing.Point(448, 64);
            this.gpbPhoto.Name = "gpbPhoto";
            this.gpbPhoto.Size = new System.Drawing.Size(133, 128);
            this.gpbPhoto.TabIndex = 63;
            this.gpbPhoto.TabStop = false;
            this.gpbPhoto.Text = "Photo";
            // 
            // lblNP
            // 
            this.lblNP.AutoSize = true;
            this.lblNP.Enabled = false;
            this.lblNP.Location = new System.Drawing.Point(40, 61);
            this.lblNP.Name = "lblNP";
            this.lblNP.Size = new System.Drawing.Size(52, 13);
            this.lblNP.TabIndex = 1;
            this.lblNP.Text = "No Photo";
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(6, 13);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(120, 109);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // lstExistingCustomer
            // 
            this.lstExistingCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clCID,
            this.clCustomerName,
            this.clContact,
            this.clBalance,
            this.clAddress});
            this.lstExistingCustomer.FullRowSelect = true;
            this.lstExistingCustomer.GridLines = true;
            this.lstExistingCustomer.Location = new System.Drawing.Point(11, 47);
            this.lstExistingCustomer.Name = "lstExistingCustomer";
            this.lstExistingCustomer.Size = new System.Drawing.Size(430, 177);
            this.lstExistingCustomer.TabIndex = 62;
            this.lstExistingCustomer.UseCompatibleStateImageBehavior = false;
            this.lstExistingCustomer.View = System.Windows.Forms.View.Details;
            this.lstExistingCustomer.Click += new System.EventHandler(this.lstExistingCustomer_Click_1);
            // 
            // clCID
            // 
            this.clCID.Text = "";
            this.clCID.Width = 0;
            // 
            // clCustomerName
            // 
            this.clCustomerName.Text = "Customer\'s Name";
            this.clCustomerName.Width = 180;
            // 
            // clContact
            // 
            this.clContact.Text = "Contact";
            this.clContact.Width = 100;
            // 
            // clBalance
            // 
            this.clBalance.Text = "Balance";
            this.clBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clBalance.Width = 140;
            // 
            // clAddress
            // 
            this.clAddress.Text = "Address";
            this.clAddress.Width = 140;
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(586, 113);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(72, 29);
            this.btnSelect.TabIndex = 61;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(256, 20);
            this.txtSearchKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(116, 20);
            this.txtSearchKey.TabIndex = 57;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(375, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 24);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gpbPayRecord
            // 
            this.gpbPayRecord.Controls.Add(this.chkActiveOnly);
            this.gpbPayRecord.Controls.Add(this.lblName);
            this.gpbPayRecord.Controls.Add(this.label1);
            this.gpbPayRecord.Controls.Add(this.lstPayRecord);
            this.gpbPayRecord.Location = new System.Drawing.Point(1, 258);
            this.gpbPayRecord.Name = "gpbPayRecord";
            this.gpbPayRecord.Size = new System.Drawing.Size(663, 246);
            this.gpbPayRecord.TabIndex = 3;
            this.gpbPayRecord.TabStop = false;
            this.gpbPayRecord.Text = "Payment Record";
            // 
            // chkActiveOnly
            // 
            this.chkActiveOnly.AutoSize = true;
            this.chkActiveOnly.Location = new System.Drawing.Point(526, 15);
            this.chkActiveOnly.Name = "chkActiveOnly";
            this.chkActiveOnly.Size = new System.Drawing.Size(126, 17);
            this.chkActiveOnly.TabIndex = 3;
            this.chkActiveOnly.Text = "for Current Loan Only";
            this.chkActiveOnly.UseVisualStyleBackColor = true;
            this.chkActiveOnly.CheckedChanged += new System.EventHandler(this.chkActiveOnly_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(125, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer\'s Name:";
            // 
            // lstPayRecord
            // 
            this.lstPayRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clPaymentDate,
            this.clPaymentAmount,
            this.clRemarks});
            this.lstPayRecord.GridLines = true;
            this.lstPayRecord.Location = new System.Drawing.Point(6, 38);
            this.lstPayRecord.Name = "lstPayRecord";
            this.lstPayRecord.Size = new System.Drawing.Size(646, 198);
            this.lstPayRecord.TabIndex = 0;
            this.lstPayRecord.UseCompatibleStateImageBehavior = false;
            this.lstPayRecord.View = System.Windows.Forms.View.Details;
            // 
            // clPaymentDate
            // 
            this.clPaymentDate.Text = "Payment Date";
            this.clPaymentDate.Width = 150;
            // 
            // clPaymentAmount
            // 
            this.clPaymentAmount.Text = "Payment Amount";
            this.clPaymentAmount.Width = 180;
            // 
            // clRemarks
            // 
            this.clRemarks.Text = "Remarks";
            this.clRemarks.Width = 295;
            // 
            // frmPaymentAndBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 506);
            this.Controls.Add(this.gpbPayRecord);
            this.Controls.Add(this.gpbCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentAndBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPaymentAndBalance_FormClosing);
            this.Load += new System.EventHandler(this.frmPaymentAndBalance_Load);
            this.gpbCustomer.ResumeLayout(false);
            this.gpbCustomer.PerformLayout();
            this.gpbPhoto.ResumeLayout(false);
            this.gpbPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.gpbPayRecord.ResumeLayout(false);
            this.gpbPayRecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCustomer;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstPayRecord;
        private System.Windows.Forms.ColumnHeader clPaymentDate;
        private System.Windows.Forms.ColumnHeader clPaymentAmount;
        private System.Windows.Forms.ColumnHeader clRemarks;
        public System.Windows.Forms.GroupBox gpbPayRecord;
        private System.Windows.Forms.CheckBox chkActiveOnly;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbPhoto;
        private System.Windows.Forms.ColumnHeader clCID;
        private System.Windows.Forms.ColumnHeader clCustomerName;
        private System.Windows.Forms.PictureBox picPhoto;
        public System.Windows.Forms.ListView lstExistingCustomer;
        public System.Windows.Forms.ColumnHeader clBalance;
        public System.Windows.Forms.ColumnHeader clAddress;
        private System.Windows.Forms.ColumnHeader clContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNP;
        public System.Windows.Forms.Label lblNote;
        public System.Windows.Forms.Button btnSelect;
    }
}