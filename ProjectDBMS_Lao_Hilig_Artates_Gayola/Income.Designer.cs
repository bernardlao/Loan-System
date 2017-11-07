namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    partial class frmIncome
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.lstPayment = new System.Windows.Forms.ListView();
            this.clFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDateOfPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstLoan = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clContractDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtEarnings = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaymentReceived = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoanReleased = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(119, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(97, 20);
            this.dtpFrom.TabIndex = 8;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(264, 14);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(97, 20);
            this.dtpTo.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(403, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.label7);
            this.gpbInfo.Controls.Add(this.lblStatistic);
            this.gpbInfo.Controls.Add(this.lstPayment);
            this.gpbInfo.Controls.Add(this.lstLoan);
            this.gpbInfo.Controls.Add(this.txtEarnings);
            this.gpbInfo.Controls.Add(this.label3);
            this.gpbInfo.Controls.Add(this.txtPaymentReceived);
            this.gpbInfo.Controls.Add(this.label2);
            this.gpbInfo.Controls.Add(this.txtLoanReleased);
            this.gpbInfo.Controls.Add(this.label1);
            this.gpbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfo.Location = new System.Drawing.Point(23, 56);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(494, 538);
            this.gpbInfo.TabIndex = 11;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Income Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Report (Released VS Received):";
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Location = new System.Drawing.Point(224, 513);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(92, 13);
            this.lblStatistic.TabIndex = 14;
            this.lblStatistic.Text = "Value - Loss/Gain";
            // 
            // lstPayment
            // 
            this.lstPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clFullName,
            this.clDateOfPayment,
            this.columnHeader3});
            this.lstPayment.FullRowSelect = true;
            this.lstPayment.GridLines = true;
            this.lstPayment.Location = new System.Drawing.Point(28, 276);
            this.lstPayment.Name = "lstPayment";
            this.lstPayment.Size = new System.Drawing.Size(436, 190);
            this.lstPayment.TabIndex = 13;
            this.lstPayment.UseCompatibleStateImageBehavior = false;
            this.lstPayment.View = System.Windows.Forms.View.Details;
            // 
            // clFullName
            // 
            this.clFullName.Text = "Customer\'s Name";
            this.clFullName.Width = 200;
            // 
            // clDateOfPayment
            // 
            this.clDateOfPayment.Text = "Payment Date";
            this.clDateOfPayment.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 120;
            // 
            // lstLoan
            // 
            this.lstLoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clContractDate,
            this.clAmount});
            this.lstLoan.FullRowSelect = true;
            this.lstLoan.GridLines = true;
            this.lstLoan.Location = new System.Drawing.Point(28, 54);
            this.lstLoan.Name = "lstLoan";
            this.lstLoan.Size = new System.Drawing.Size(436, 190);
            this.lstLoan.TabIndex = 12;
            this.lstLoan.UseCompatibleStateImageBehavior = false;
            this.lstLoan.View = System.Windows.Forms.View.Details;
            // 
            // clName
            // 
            this.clName.Text = "Customer\'s Name";
            this.clName.Width = 200;
            // 
            // clContractDate
            // 
            this.clContractDate.Text = "Contract Date";
            this.clContractDate.Width = 100;
            // 
            // clAmount
            // 
            this.clAmount.Text = "Amount";
            this.clAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clAmount.Width = 120;
            // 
            // txtEarnings
            // 
            this.txtEarnings.Location = new System.Drawing.Point(135, 484);
            this.txtEarnings.Name = "txtEarnings";
            this.txtEarnings.ReadOnly = true;
            this.txtEarnings.Size = new System.Drawing.Size(329, 20);
            this.txtEarnings.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Earnings";
            // 
            // txtPaymentReceived
            // 
            this.txtPaymentReceived.Location = new System.Drawing.Point(134, 250);
            this.txtPaymentReceived.Name = "txtPaymentReceived";
            this.txtPaymentReceived.ReadOnly = true;
            this.txtPaymentReceived.Size = new System.Drawing.Size(330, 20);
            this.txtPaymentReceived.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payment Total";
            // 
            // txtLoanReleased
            // 
            this.txtLoanReleased.Location = new System.Drawing.Point(167, 28);
            this.txtLoanReleased.Name = "txtLoanReleased";
            this.txtLoanReleased.ReadOnly = true;
            this.txtLoanReleased.Size = new System.Drawing.Size(297, 20);
            this.txtLoanReleased.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loan Released Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 606);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Check";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIncome_FormClosing);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtEarnings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lstPayment;
        private System.Windows.Forms.ColumnHeader clFullName;
        private System.Windows.Forms.ColumnHeader clDateOfPayment;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstLoan;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clContractDate;
        private System.Windows.Forms.ColumnHeader clAmount;
        private System.Windows.Forms.TextBox txtPaymentReceived;
        private System.Windows.Forms.TextBox txtLoanReleased;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatistic;

    }
}