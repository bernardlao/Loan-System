namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    partial class frmCancelContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelContract));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstRecords = new System.Windows.Forms.ListView();
            this.clCustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLoanId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSigningDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLoanAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clInterest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGives = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPaymentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPenaltyCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLoanTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVoidContract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(91, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(281, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lstRecords
            // 
            this.lstRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clCustomerId,
            this.clLoanId,
            this.clFullName,
            this.clSigningDate,
            this.clDateEnd,
            this.clLoanAmount,
            this.clInterest,
            this.clGives,
            this.clPaymentType,
            this.clPenaltyCondition,
            this.clLoanTotal,
            this.clBalance});
            this.lstRecords.FullRowSelect = true;
            this.lstRecords.GridLines = true;
            this.lstRecords.Location = new System.Drawing.Point(16, 46);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(918, 319);
            this.lstRecords.TabIndex = 3;
            this.lstRecords.UseCompatibleStateImageBehavior = false;
            this.lstRecords.View = System.Windows.Forms.View.Details;
            this.lstRecords.Click += new System.EventHandler(this.lstRecords_Click);
            // 
            // clCustomerId
            // 
            this.clCustomerId.Text = "";
            this.clCustomerId.Width = 0;
            // 
            // clLoanId
            // 
            this.clLoanId.Text = "";
            this.clLoanId.Width = 0;
            // 
            // clFullName
            // 
            this.clFullName.Text = "Customer\'s Name";
            this.clFullName.Width = 150;
            // 
            // clSigningDate
            // 
            this.clSigningDate.Text = "Signing Date";
            this.clSigningDate.Width = 80;
            // 
            // clDateEnd
            // 
            this.clDateEnd.Text = "Ending Date";
            this.clDateEnd.Width = 80;
            // 
            // clLoanAmount
            // 
            this.clLoanAmount.Text = "Loan Amount";
            this.clLoanAmount.Width = 100;
            // 
            // clInterest
            // 
            this.clInterest.Text = "Interest";
            // 
            // clGives
            // 
            this.clGives.Text = "Gives";
            this.clGives.Width = 40;
            // 
            // clPaymentType
            // 
            this.clPaymentType.Text = "Payment Type";
            this.clPaymentType.Width = 100;
            // 
            // clPenaltyCondition
            // 
            this.clPenaltyCondition.Text = "Penalty Condition";
            this.clPenaltyCondition.Width = 100;
            // 
            // clLoanTotal
            // 
            this.clLoanTotal.Text = "Loan Total";
            this.clLoanTotal.Width = 100;
            // 
            // clBalance
            // 
            this.clBalance.Text = "Balance";
            this.clBalance.Width = 100;
            // 
            // btnVoidContract
            // 
            this.btnVoidContract.Enabled = false;
            this.btnVoidContract.Location = new System.Drawing.Point(794, 371);
            this.btnVoidContract.Name = "btnVoidContract";
            this.btnVoidContract.Size = new System.Drawing.Size(140, 33);
            this.btnVoidContract.TabIndex = 4;
            this.btnVoidContract.Text = "Void Contract";
            this.btnVoidContract.UseVisualStyleBackColor = true;
            this.btnVoidContract.Click += new System.EventHandler(this.btnVoidContract_Click);
            // 
            // frmCancelContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 416);
            this.Controls.Add(this.btnVoidContract);
            this.Controls.Add(this.lstRecords);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCancelContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contract Cancellation";
            this.Load += new System.EventHandler(this.frmCancelContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstRecords;
        private System.Windows.Forms.ColumnHeader clCustomerId;
        private System.Windows.Forms.ColumnHeader clFullName;
        private System.Windows.Forms.ColumnHeader clSigningDate;
        private System.Windows.Forms.ColumnHeader clDateEnd;
        private System.Windows.Forms.ColumnHeader clLoanAmount;
        private System.Windows.Forms.ColumnHeader clInterest;
        private System.Windows.Forms.ColumnHeader clGives;
        private System.Windows.Forms.ColumnHeader clPaymentType;
        private System.Windows.Forms.ColumnHeader clPenaltyCondition;
        private System.Windows.Forms.ColumnHeader clLoanTotal;
        private System.Windows.Forms.ColumnHeader clBalance;
        private System.Windows.Forms.Button btnVoidContract;
        private System.Windows.Forms.ColumnHeader clLoanId;
    }
}