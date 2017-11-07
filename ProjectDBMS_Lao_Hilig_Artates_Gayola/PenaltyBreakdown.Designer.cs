namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    partial class frmPenaltyBreakdown
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
            this.lstBreakdown = new System.Windows.Forms.ListView();
            this.clDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAmountAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBreakdown
            // 
            this.lstBreakdown.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clDate,
            this.clAmountAdded});
            this.lstBreakdown.FullRowSelect = true;
            this.lstBreakdown.GridLines = true;
            this.lstBreakdown.Location = new System.Drawing.Point(12, 35);
            this.lstBreakdown.Name = "lstBreakdown";
            this.lstBreakdown.Size = new System.Drawing.Size(272, 331);
            this.lstBreakdown.TabIndex = 0;
            this.lstBreakdown.UseCompatibleStateImageBehavior = false;
            this.lstBreakdown.View = System.Windows.Forms.View.Details;
            // 
            // clDate
            // 
            this.clDate.Text = "Date";
            this.clDate.Width = 100;
            // 
            // clAmountAdded
            // 
            this.clAmountAdded.Text = "Amount Added";
            this.clAmountAdded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clAmountAdded.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agreement:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(89, 13);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(105, 13);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "interest per mode";
            // 
            // frmPenaltyBreakdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 378);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBreakdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPenaltyBreakdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakdown";
            this.Load += new System.EventHandler(this.frmPenaltyBreakdown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstBreakdown;
        private System.Windows.Forms.ColumnHeader clDate;
        private System.Windows.Forms.ColumnHeader clAmountAdded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMode;
    }
}