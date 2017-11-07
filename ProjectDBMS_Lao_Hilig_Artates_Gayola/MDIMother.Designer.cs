namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    partial class frmMDIMother
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIMother));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.manageCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateCustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLoansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewContractMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelContractMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkIncomeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPaymentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.checkCBalanceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCapitalMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tmIsClosed = new System.Windows.Forms.Timer(this.components);
            this.tmPenaltySet = new System.Windows.Forms.Timer(this.components);
            this.lstAllSched = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clContactNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSchedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSchedAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmountPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.msMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.msMenu.Enabled = false;
            this.msMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCustomersToolStripMenuItem,
            this.manageLoansToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.logoutMenu,
            this.myAccountToolStripMenuItem,
            this.schedulesMenu});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(632, 29);
            this.msMenu.TabIndex = 4;
            this.msMenu.Text = "menuStrip1";
            // 
            // manageCustomersToolStripMenuItem
            // 
            this.manageCustomersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerMenu,
            this.editCustomerMenu,
            this.deactivateCustomerMenu});
            this.manageCustomersToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.manageCustomersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageCustomersToolStripMenuItem.Image")));
            this.manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            this.manageCustomersToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.manageCustomersToolStripMenuItem.Text = "Manage &Customers";
            // 
            // addCustomerMenu
            // 
            this.addCustomerMenu.Image = ((System.Drawing.Image)(resources.GetObject("addCustomerMenu.Image")));
            this.addCustomerMenu.Name = "addCustomerMenu";
            this.addCustomerMenu.Size = new System.Drawing.Size(285, 26);
            this.addCustomerMenu.Text = "Add Customer";
            this.addCustomerMenu.Click += new System.EventHandler(this.addCustomerMenu_Click);
            // 
            // editCustomerMenu
            // 
            this.editCustomerMenu.Image = ((System.Drawing.Image)(resources.GetObject("editCustomerMenu.Image")));
            this.editCustomerMenu.Name = "editCustomerMenu";
            this.editCustomerMenu.Size = new System.Drawing.Size(232, 22);
            this.editCustomerMenu.Text = "Edit Customer";
            this.editCustomerMenu.Click += new System.EventHandler(this.editCustomerMenu_Click);
            // 
            // deactivateCustomerMenu
            // 
            this.deactivateCustomerMenu.Image = ((System.Drawing.Image)(resources.GetObject("deactivateCustomerMenu.Image")));
            this.deactivateCustomerMenu.Name = "deactivateCustomerMenu";
            this.deactivateCustomerMenu.Size = new System.Drawing.Size(232, 22);
            this.deactivateCustomerMenu.Text = "Activate/Deactivate Customer";
            this.deactivateCustomerMenu.Click += new System.EventHandler(this.deactivateCustomerMenu_Click);
            // 
            // manageLoansToolStripMenuItem
            // 
            this.manageLoansToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manageLoansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewContractMenu,
            this.cancelContractMenu,
            this.addPaymentMenu});
            this.manageLoansToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.manageLoansToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageLoansToolStripMenuItem.Image")));
            this.manageLoansToolStripMenuItem.Name = "manageLoansToolStripMenuItem";
            this.manageLoansToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.manageLoansToolStripMenuItem.Text = "Manage &Loans";
            // 
            // addNewContractMenu
            // 
            this.addNewContractMenu.Image = ((System.Drawing.Image)(resources.GetObject("addNewContractMenu.Image")));
            this.addNewContractMenu.Name = "addNewContractMenu";
            this.addNewContractMenu.Size = new System.Drawing.Size(172, 22);
            this.addNewContractMenu.Text = "Add New Contract";
            this.addNewContractMenu.Click += new System.EventHandler(this.addNewContractMenu_Click);
            // 
            // cancelContractMenu
            // 
            this.cancelContractMenu.Image = ((System.Drawing.Image)(resources.GetObject("cancelContractMenu.Image")));
            this.cancelContractMenu.Name = "cancelContractMenu";
            this.cancelContractMenu.Size = new System.Drawing.Size(172, 22);
            this.cancelContractMenu.Text = "Cancel Contract";
            this.cancelContractMenu.Click += new System.EventHandler(this.cancelContractMenu_Click);
            // 
            // addPaymentMenu
            // 
            this.addPaymentMenu.Image = ((System.Drawing.Image)(resources.GetObject("addPaymentMenu.Image")));
            this.addPaymentMenu.Name = "addPaymentMenu";
            this.addPaymentMenu.Size = new System.Drawing.Size(172, 22);
            this.addPaymentMenu.Text = "Add Payment";
            this.addPaymentMenu.Click += new System.EventHandler(this.addPaymentMenu_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkIncomeMenu,
            this.checkPaymentMenu,
            this.checkCBalanceMenu});
            this.recordsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.recordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recordsToolStripMenuItem.Image")));
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.recordsToolStripMenuItem.Text = "&Records";
            // 
            // checkIncomeMenu
            // 
            this.checkIncomeMenu.Image = ((System.Drawing.Image)(resources.GetObject("checkIncomeMenu.Image")));
            this.checkIncomeMenu.Name = "checkIncomeMenu";
            this.checkIncomeMenu.Size = new System.Drawing.Size(251, 26);
            this.checkIncomeMenu.Text = "Check Income";
            this.checkIncomeMenu.Click += new System.EventHandler(this.checkIncomeMenu_Click);
            // 
            // checkPaymentMenu
            // 
            this.checkPaymentMenu.Image = ((System.Drawing.Image)(resources.GetObject("checkPaymentMenu.Image")));
            this.checkPaymentMenu.Name = "checkPaymentMenu";
            this.checkPaymentMenu.Size = new System.Drawing.Size(251, 26);
            this.checkPaymentMenu.Text = "Check Payment";
            this.checkPaymentMenu.Click += new System.EventHandler(this.checkPaymentMenu_Click);
            // 
            // checkCBalanceMenu
            // 
            this.checkCBalanceMenu.Image = ((System.Drawing.Image)(resources.GetObject("checkCBalanceMenu.Image")));
            this.checkCBalanceMenu.Name = "checkCBalanceMenu";
            this.checkCBalanceMenu.Size = new System.Drawing.Size(251, 26);
            this.checkCBalanceMenu.Text = "Check Customer Balance";
            this.checkCBalanceMenu.Click += new System.EventHandler(this.checkCBalanceMenu_Click);
            // 
            // logoutMenu
            // 
            this.logoutMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutMenu.ForeColor = System.Drawing.Color.Black;
            this.logoutMenu.Image = ((System.Drawing.Image)(resources.GetObject("logoutMenu.Image")));
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(53, 20);
            this.logoutMenu.Text = "&Exit";
            this.logoutMenu.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.myAccountToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCapitalMenu,
            this.changePasswordMenu});
            this.myAccountToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.myAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("myAccountToolStripMenuItem.Image")));
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.myAccountToolStripMenuItem.Text = "&My Account";
            // 
            // addCapitalMenu
            // 
            this.addCapitalMenu.Image = ((System.Drawing.Image)(resources.GetObject("addCapitalMenu.Image")));
            this.addCapitalMenu.Name = "addCapitalMenu";
            this.addCapitalMenu.Size = new System.Drawing.Size(204, 26);
            this.addCapitalMenu.Text = "Add Capital";
            this.addCapitalMenu.Click += new System.EventHandler(this.addCapitalMenu_Click);
            // 
            // changePasswordMenu
            // 
            this.changePasswordMenu.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordMenu.Image")));
            this.changePasswordMenu.Name = "changePasswordMenu";
            this.changePasswordMenu.Size = new System.Drawing.Size(204, 26);
            this.changePasswordMenu.Text = "Change Password";
            this.changePasswordMenu.Click += new System.EventHandler(this.changePasswordMenu_Click);
            // 
            // schedulesMenu
            // 
            this.schedulesMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.schedulesMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.schedulesMenu.ForeColor = System.Drawing.Color.Black;
            this.schedulesMenu.Image = ((System.Drawing.Image)(resources.GetObject("schedulesMenu.Image")));
            this.schedulesMenu.ImageTransparentColor = System.Drawing.Color.Black;
            this.schedulesMenu.Name = "schedulesMenu";
            this.schedulesMenu.Size = new System.Drawing.Size(88, 20);
            this.schedulesMenu.Text = "&Schedules";
            this.schedulesMenu.Click += new System.EventHandler(this.schedulesMenu_Click);
            // 
            // tmIsClosed
            // 
            this.tmIsClosed.Enabled = true;
            this.tmIsClosed.Interval = 500;
            this.tmIsClosed.Tick += new System.EventHandler(this.tmIsClosed_Tick);
            // 
            // tmPenaltySet
            // 
            this.tmPenaltySet.Enabled = true;
            this.tmPenaltySet.Interval = 1000;
            this.tmPenaltySet.Tick += new System.EventHandler(this.tmPenaltySet_Tick);
            // 
            // lstAllSched
            // 
            this.lstAllSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAllSched.BackColor = System.Drawing.SystemColors.Window;
            this.lstAllSched.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clContactNo,
            this.clAddress,
            this.clSchedDate,
            this.clSchedAmount,
            this.clAmountPaid,
            this.clBalance});
            this.lstAllSched.FullRowSelect = true;
            this.lstAllSched.GridLines = true;
            this.lstAllSched.Location = new System.Drawing.Point(0, 209);
            this.lstAllSched.Name = "lstAllSched";
            this.lstAllSched.Size = new System.Drawing.Size(632, 219);
            this.lstAllSched.TabIndex = 6;
            this.lstAllSched.UseCompatibleStateImageBehavior = false;
            this.lstAllSched.View = System.Windows.Forms.View.Details;
            this.lstAllSched.Visible = false;
            // 
            // clName
            // 
            this.clName.Text = "Full Name";
            this.clName.Width = 160;
            // 
            // clContactNo
            // 
            this.clContactNo.Text = "Contact No";
            this.clContactNo.Width = 100;
            // 
            // clAddress
            // 
            this.clAddress.Text = "Address";
            this.clAddress.Width = 160;
            // 
            // clSchedDate
            // 
            this.clSchedDate.Text = "Schedule Date";
            this.clSchedDate.Width = 100;
            // 
            // clSchedAmount
            // 
            this.clSchedAmount.Text = "Amount in Schedule";
            this.clSchedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clSchedAmount.Width = 100;
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
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // frmMDIMother
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.lstAllSched);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.msMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMDIMother";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loan Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIMother_FormClosing);
            this.Load += new System.EventHandler(this.MDIMother_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem manageCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerMenu;
        private System.Windows.Forms.ToolStripMenuItem editCustomerMenu;
        private System.Windows.Forms.ToolStripMenuItem deactivateCustomerMenu;
        public System.Windows.Forms.MenuStrip msMenu;
        public System.Windows.Forms.Timer tmIsClosed;
        private System.Windows.Forms.ToolStripMenuItem manageLoansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewContractMenu;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCapitalMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenu;
        private System.Windows.Forms.ToolStripMenuItem checkIncomeMenu;
        private System.Windows.Forms.ToolStripMenuItem checkPaymentMenu;
        private System.Windows.Forms.ToolStripMenuItem cancelContractMenu;
        private System.Windows.Forms.ToolStripMenuItem addPaymentMenu;
        private System.Windows.Forms.Timer tmPenaltySet;
        private System.Windows.Forms.ToolStripMenuItem checkCBalanceMenu;
        private System.Windows.Forms.ToolStripMenuItem schedulesMenu;
        private System.Windows.Forms.ListView lstAllSched;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clContactNo;
        private System.Windows.Forms.ColumnHeader clAddress;
        private System.Windows.Forms.ColumnHeader clSchedDate;
        private System.Windows.Forms.ColumnHeader clSchedAmount;
        private System.Windows.Forms.ColumnHeader clAmountPaid;
        private System.Windows.Forms.ToolStripMenuItem logoutMenu;
        private System.Windows.Forms.ColumnHeader clBalance;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}



