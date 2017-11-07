using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using DBUtilities;
using System.IO;

namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    public partial class frmPaymentAndBalance : Form
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        private long id;

        public frmPaymentAndBalance()
        {
            InitializeComponent();
        }
        private void frmPaymentAndBalance_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMDIMother.IsClosed = true;
        }
        private void frmPaymentAndBalance_Load(object sender, EventArgs e)
        {
            PopulateList("");
        }
        public void PopulateList(string filter)
        {
            lstExistingCustomer.Items.Clear();
            string query = "SELECT * FROM tblcustomer " + filter;
            DataTable dt = db.GetResult(query);
            foreach (DataRow r in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(r["customer_id"].ToString());
                itm.SubItems.Add(r["asFullName"].ToString());
                itm.SubItems.Add(r["Contact"].ToString());
                itm.SubItems.Add(String.Format("{0:0.00}",Convert.ToDouble(r["balance"].ToString())));
                itm.SubItems.Add(r["Address"].ToString());
                lstExistingCustomer.Items.Add(itm);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = "WHERE asFullName = '" + txtSearchKey.Text + "'";
            PopulateList(filter);
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Proceed with this customer?", "Set Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                chkActiveOnly.Checked = false;
                id = Convert.ToInt64(lstExistingCustomer.SelectedItems[0].Text);
                btnSelect.Enabled = false;
                SetInitialRecord();
                lblName.Text = lstExistingCustomer.SelectedItems[0].SubItems[1].Text;
            }
        }
        private void SetInitialRecord()
        {
            string query = "SELECT loan_id FROM tblcustomer cu INNER JOIN tblcontracts co ON cu.customer_id = co.customer_id WHERE cu.customer_id = " + id;
            DataTable dt = db.GetResult(query);
            if (dt.Rows.Count != 0)
            {
                SetPayRecord(dt);
            }
            else
                MessageBox.Show("There are no records found for the specified customer.");
        }
        private void SetPayRecord(DataTable data)
        {
            lstPayRecord.Items.Clear();
            string loan_ids = "";
            foreach (DataRow row in data.Rows)
            {
                loan_ids += row["loan_id"].ToString() + ",";
            }
            loan_ids = loan_ids.Remove(loan_ids.Length - 1);
            string query = "SELECT p.payment_date,p.payment_amount,p.remarks FROM tblpayments p WHERE loan_id IN (" + loan_ids + ") ORDER BY p.payment_date DESC";
            data = db.GetResult(query);
            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem itm = new ListViewItem(Convert.ToDateTime(row["payment_date"].ToString()).ToString("MM/dd/yyyy"));
                    itm.SubItems.Add(String.Format("{0:0.00}",Convert.ToDouble(row["payment_amount"].ToString())));
                    itm.SubItems.Add(row["remarks"].ToString());
                    lstPayRecord.Items.Add(itm);
                }
            }
            else
                MessageBox.Show("There is no payment received from the specified customer");
        }
        public Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        private void lstExistingCustomer_Click_1(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
            id = Convert.ToInt64(lstExistingCustomer.SelectedItems[0].Text);
            string location = Application.StartupPath + "\\CustomerImages\\" + id + ".png";
            if (File.Exists(location))
            {
                Image img = GetCopyImage(location);
                picPhoto.Image = img;
                lblNP.Visible = false;
            }
            else
            {
                picPhoto.Image = null;
                lblNP.Visible = true;
            }
        }

        private void chkActiveOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActiveOnly.Checked == false)
            {
                SetInitialRecord();
            }
            else
            {
                string query = "SELECT loan_id FROM tblcustomer cu INNER JOIN tblcontracts co ON cu.customer_id = co.customer_id WHERE co.loan_status = 'Active' AND cu.customer_id = " + id;
                DataTable dt = db.GetResult(query);
                if (dt != null)
                {
                    SetPayRecord(dt);
                }
                else
                    MessageBox.Show("There are no current Loan recorded for the specified customer.");
            }
        }
    }
}
