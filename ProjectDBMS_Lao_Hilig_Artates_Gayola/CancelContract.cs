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

namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    public partial class frmCancelContract : Form
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        DataTable dt;
        MySqlDataReader r;
        private long id;

        public frmCancelContract()
        {
            InitializeComponent();
        }

        private void frmCancelContract_Load(object sender, EventArgs e)
        {
            PopulateList();
        }
        private void PopulateList()
        {
            lstRecords.Items.Clear();
            string query = "SELECT co.loan_id,cu.customer_id,cu.asFullName, co.date_start,co.date_end,co.loan_amount," +
                "co.interest_rate,co.payment_gives,co.payment_type,co.penalty_interest,co.penalty_mode," +
                "co.loan_total,cu.balance FROM tblcustomer cu INNER JOIN tblcontracts co " +
                "ON cu.customer_id = co.customer_id WHERE co.loan_status = 'Active' AND cu.customer_status = 'Active'";
            dt = db.GetResult(query);
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    ListViewItem itm = new ListViewItem(r["customer_id"].ToString());
                    itm.SubItems.Add(r["loan_id"].ToString());
                    itm.SubItems.Add(r["asFullName"].ToString());
                    itm.SubItems.Add(Convert.ToDateTime(r["date_start"].ToString()).ToString("MM/dd/yyyy"));
                    itm.SubItems.Add(Convert.ToDateTime(r["date_end"].ToString()).ToString("MM/dd/yyyy"));
                    itm.SubItems.Add(String.Format("{0:0.00}", Convert.ToDouble(r["loan_amount"].ToString())));
                    itm.SubItems.Add(r["interest_rate"].ToString());
                    itm.SubItems.Add(r["payment_gives"].ToString());
                    itm.SubItems.Add(r["payment_type"].ToString());
                    if (r["penalty_interest"].ToString().Equals("0"))
                        itm.SubItems.Add("None");
                    else
                        itm.SubItems.Add(r["penalty_interest"].ToString() + "% " + r["penalty_mode"].ToString());
                    itm.SubItems.Add(String.Format("{0:0.00}",Convert.ToDouble(r["loan_total"].ToString())));
                    itm.SubItems.Add(String.Format("{0:0.00}",Convert.ToDouble(r["balance"].ToString())));
                    lstRecords.Items.Add(itm);
                }
            }
        }

        private void btnVoidContract_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to void the selected contract?", "Void Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (IsContractNoRecord())
                {
                    frmAuthentication aut = new frmAuthentication();
                    aut.ShowDialog();
                    if (frmAuthentication.authentic)
                    {
                        CancelAllTransactionalRecord();
                        PopulateList();
                        frmAuthentication.authentic = false;
                        btnVoidContract.Enabled = false;
                    }
                }
            }
        }
        private bool IsContractNoRecord()
        {
            DataTable dt = db.GetResult("SELECT IsExtendedContract FROM tblcontracts WHERE loan_id = " + lstRecords.SelectedItems[0].SubItems[1].Text);
            DataRow r = dt.Rows[0];
            string isExtended = r["IsExtendedContract"].ToString();
            if (isExtended.Equals("Yes"))
            {
                MessageBox.Show("The selected customer's contract is an Extended Contract.", "Contract Extended Encountered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (lstRecords.SelectedItems[0].SubItems[10].Text == lstRecords.SelectedItems[0].SubItems[11].Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Contract cannot be cancelled. It must not have records of payment or other transaction.", "Unable to Void Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DialogResult.Yes == MessageBox.Show("Dou you want to deactivate the selected customer instead?", "Blacklist", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    frmAuthentication aut = new frmAuthentication();
                    aut.ShowDialog();
                    if (frmAuthentication.authentic)
                    {
                        db.UpdateQuery("UPDATE tblcustomer SET customer_status = 'Inactive' WHERE customer_id = " + lstRecords.SelectedItems[0].Text); frmAuthentication.authentic = false;
                        PopulateList();
                    }
                }
                return false;
            }

        }
        private void CancelAllTransactionalRecord()
        {
            id = Convert.ToInt64(lstRecords.SelectedItems[0].Text);
            List<long> sched_ids = new List<long>();
            long loan_id = Convert.ToInt64(lstRecords.SelectedItems[0].SubItems[1].Text);
            string query = "SELECT * FROM tblschedules WHERE loan_id = " + loan_id + " AND schedule_status = 'Pending'";
            r = db.ExecuteQuery(query);
            while (r.Read())
            {
                sched_ids.Add(Convert.ToInt64(r["sched_id"].ToString()));
            }
            r.Close();
            db.CloseConnection();
            for (int i = 0; i < sched_ids.Count; i++)
            {
                string update = "UPDATE tblschedules SET schedule_status = 'Canceled' WHERE sched_id = " + sched_ids[i];
                db.InsertQueryNoPrompt(update);
            }
            string cancelContract = "UPDATE tblcontracts SET loan_status = 'Canceled' WHERE loan_id = " + loan_id;
            db.InsertQueryNoPrompt(cancelContract);
            cancelContract = "UPDATE tblcustomer SET balance = 0 WHERE customer_id = " + id;
            db.UpdateQuery(cancelContract);
            db.InsertQueryNoPrompt("UPDATE tbluser SET capital = capital + " + Convert.ToDouble(lstRecords.SelectedItems[0].SubItems[5].Text) + " WHERE user_id = 1");
        }

        private void lstRecords_Click(object sender, EventArgs e)
        {
            btnVoidContract.Enabled = true;
        }
    }
}