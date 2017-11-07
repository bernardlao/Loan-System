namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    partial class frmSchedulePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedulePayment));
            this.gpbSchedule = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lstSchedules = new System.Windows.Forms.ListView();
            this.clStat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSchedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSchedAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmountPenaltied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmountPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFullyPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttpPop = new System.Windows.Forms.ToolTip(this.components);
            this.cmsOne = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCheckPenaltyBreakdown = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbSchedule.SuspendLayout();
            this.cmsOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSchedule
            // 
            this.gpbSchedule.Controls.Add(this.lblTotal);
            this.gpbSchedule.Controls.Add(this.label9);
            this.gpbSchedule.Controls.Add(this.lblBalance);
            this.gpbSchedule.Controls.Add(this.label8);
            this.gpbSchedule.Controls.Add(this.lblName);
            this.gpbSchedule.Controls.Add(this.label7);
            this.gpbSchedule.Controls.Add(this.label5);
            this.gpbSchedule.Controls.Add(this.label6);
            this.gpbSchedule.Controls.Add(this.label3);
            this.gpbSchedule.Controls.Add(this.label4);
            this.gpbSchedule.Controls.Add(this.label2);
            this.gpbSchedule.Controls.Add(this.label1);
            this.gpbSchedule.Controls.Add(this.btnPay);
            this.gpbSchedule.Controls.Add(this.lstSchedules);
            this.gpbSchedule.Location = new System.Drawing.Point(3, 3);
            this.gpbSchedule.Name = "gpbSchedule";
            this.gpbSchedule.Size = new System.Drawing.Size(744, 377);
            this.gpbSchedule.TabIndex = 2;
            this.gpbSchedule.TabStop = false;
            this.gpbSchedule.Text = "Schedules";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(533, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 13);
            this.lblTotal.TabIndex = 75;
            this.lblTotal.Text = "Balance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Total && Interest :";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(102, 357);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 73;
            this.lblBalance.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Total Balance:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(131, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.TabIndex = 71;
            this.lblName.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 70;
            this.label7.Text = "Customer Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Past Schedules";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(277, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Present Schedule";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(146, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "On-going Schedules";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(9, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "   ";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(581, 341);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(148, 29);
            this.btnPay.TabIndex = 62;
            this.btnPay.Text = "Proceed Paying";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lstSchedules
            // 
            this.lstSchedules.CheckBoxes = true;
            this.lstSchedules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clStat,
            this.clSchedDate,
            this.clSchedAmount,
            this.clAmountPenaltied,
            this.clTotalAmount,
            this.clAmountPaid,
            this.clBalance,
            this.clFullyPaid});
            this.lstSchedules.FullRowSelect = true;
            this.lstSchedules.GridLines = true;
            this.lstSchedules.Location = new System.Drawing.Point(10, 45);
            this.lstSchedules.Name = "lstSchedules";
            this.lstSchedules.Size = new System.Drawing.Size(719, 291);
            this.lstSchedules.TabIndex = 0;
            this.lstSchedules.UseCompatibleStateImageBehavior = false;
            this.lstSchedules.View = System.Windows.Forms.View.Details;
            this.lstSchedules.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSchedules_ItemCheck);
            this.lstSchedules.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSchedules_MouseClick);
            // 
            // clStat
            // 
            this.clStat.Text = "+";
            this.clStat.Width = 40;
            // 
            // clSchedDate
            // 
            this.clSchedDate.Text = "Schedule Date";
            this.clSchedDate.Width = 100;
            // 
            // clSchedAmount
            // 
            this.clSchedAmount.Text = "Scheduled Amount";
            this.clSchedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clSchedAmount.Width = 110;
            // 
            // clAmountPenaltied
            // 
            this.clAmountPenaltied.Text = "Amount Penaltied";
            this.clAmountPenaltied.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clAmountPenaltied.Width = 100;
            // 
            // clTotalAmount
            // 
            this.clTotalAmount.Text = "Total Amount";
            this.clTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clTotalAmount.Width = 100;
            // 
            // clAmountPaid
            // 
            this.clAmountPaid.Text = "Amount Paid";
            this.clAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clAmountPaid.Width = 100;
            // 
            // clBalance
            // 
            this.clBalance.Text = "Balance";
            this.clBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clBalance.Width = 100;
            // 
            // clFullyPaid
            // 
            this.clFullyPaid.Text = "Fully Paid";
            // 
            // cmsOne
            // 
            this.cmsOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCheckPenaltyBreakdown});
            this.cmsOne.Name = "cmsOne";
            this.cmsOne.ShowImageMargin = false;
            this.cmsOne.Size = new System.Drawing.Size(187, 26);
            this.cmsOne.Text = "Check penalty breakdown";
            // 
            // tsmCheckPenaltyBreakdown
            // 
            this.tsmCheckPenaltyBreakdown.Name = "tsmCheckPenaltyBreakdown";
            this.tsmCheckPenaltyBreakdown.Size = new System.Drawing.Size(186, 22);
            this.tsmCheckPenaltyBreakdown.Text = "Check penalty breakdown";
            this.tsmCheckPenaltyBreakdown.Click += new System.EventHandler(this.tsmCheckPenaltyBreakdown_Click);
            // 
            // frmSchedulePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 384);
            this.Controls.Add(this.gpbSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSchedulePayment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedules per Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSchedulePayment_FormClosing);
            this.Load += new System.EventHandler(this.frmSchedulePayment_Load);
            this.gpbSchedule.ResumeLayout(false);
            this.gpbSchedule.PerformLayout();
            this.cmsOne.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSchedule;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListView lstSchedules;
        private System.Windows.Forms.ColumnHeader clStat;
        private System.Windows.Forms.ColumnHeader clSchedDate;
        private System.Windows.Forms.ColumnHeader clSchedAmount;
        private System.Windows.Forms.ColumnHeader clAmountPaid;
        private System.Windows.Forms.ColumnHeader clFullyPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader clAmountPenaltied;
        private System.Windows.Forms.ColumnHeader clTotalAmount;
        private System.Windows.Forms.ColumnHeader clBalance;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolTip ttpPop;
        private System.Windows.Forms.ContextMenuStrip cmsOne;
        private System.Windows.Forms.ToolStripMenuItem tsmCheckPenaltyBreakdown;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label8;
    }
}