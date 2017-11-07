namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    partial class frmScheduleCustomerCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleCustomerCheck));
            this.gpbCustomerList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstExistingCustomer = new System.Windows.Forms.ListView();
            this.clCustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLoanID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbCustomerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCustomerList
            // 
            this.gpbCustomerList.Controls.Add(this.label1);
            this.gpbCustomerList.Controls.Add(this.txtKey);
            this.gpbCustomerList.Controls.Add(this.btnSearch);
            this.gpbCustomerList.Controls.Add(this.lstExistingCustomer);
            this.gpbCustomerList.Location = new System.Drawing.Point(4, 2);
            this.gpbCustomerList.Name = "gpbCustomerList";
            this.gpbCustomerList.Size = new System.Drawing.Size(257, 367);
            this.gpbCustomerList.TabIndex = 0;
            this.gpbCustomerList.TabStop = false;
            this.gpbCustomerList.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note: Double-click to proceed";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(22, 28);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(147, 20);
            this.txtKey.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(175, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstExistingCustomer
            // 
            this.lstExistingCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clCustomerID,
            this.clLoanID,
            this.clName});
            this.lstExistingCustomer.FullRowSelect = true;
            this.lstExistingCustomer.GridLines = true;
            this.lstExistingCustomer.Location = new System.Drawing.Point(22, 72);
            this.lstExistingCustomer.Name = "lstExistingCustomer";
            this.lstExistingCustomer.Size = new System.Drawing.Size(210, 271);
            this.lstExistingCustomer.TabIndex = 0;
            this.lstExistingCustomer.UseCompatibleStateImageBehavior = false;
            this.lstExistingCustomer.View = System.Windows.Forms.View.Details;
            this.lstExistingCustomer.DoubleClick += new System.EventHandler(this.lstExistingCustomer_DoubleClick);
            // 
            // clCustomerID
            // 
            this.clCustomerID.Text = "";
            this.clCustomerID.Width = 0;
            // 
            // clLoanID
            // 
            this.clLoanID.Text = "";
            this.clLoanID.Width = 0;
            // 
            // clName
            // 
            this.clName.Text = "Customer\'s Name";
            this.clName.Width = 200;
            // 
            // frmScheduleCustomerCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 374);
            this.Controls.Add(this.gpbCustomerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduleCustomerCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Selection Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScheduleCustomerCheck_FormClosing);
            this.Load += new System.EventHandler(this.frmScheduleCustomerCheck_Load);
            this.gpbCustomerList.ResumeLayout(false);
            this.gpbCustomerList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCustomerList;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstExistingCustomer;
        private System.Windows.Forms.ColumnHeader clCustomerID;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader clLoanID;
    }
}