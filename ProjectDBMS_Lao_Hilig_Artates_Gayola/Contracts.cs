using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using DBUtilities;
using MyExcelClass;

namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    public partial class frmContracts : Form
    {
        MyExcel excel = new MyExcel();
        MySqlDataReader r;
        MySQLDBUtilities db = new MySQLDBUtilities();

        private string searchBy = "asFullname LIKE '%";
        private string status = "";
        private long id;

        public frmContracts()
        {
            InitializeComponent();
        }

        private void frmContracts_Load(object sender, EventArgs e)
        {
            LoadCapital();
            dtpPaymentStart.MinDate = DateTime.Now;
            cmbMode.SelectedItem = cmbMode.Items[0];
            cmbPenalty.SelectedItem = cmbPenalty.Items[0];
            cmbSearchBy.SelectedItem = cmbSearchBy.Items[0];
            PopulateList("", "");
            gpbInfo.Enabled = false;
            gpbContract.Enabled = false;
            gpbContractDetails.Enabled = false;
        }
        private void LoadCapital()
        {
            DataTable dt = db.GetResult("SELECT capital FROM tbluser WHERE user_id = 1");
            DataRow r = dt.Rows[0];
            lblCapital.Text = "Capital: " + String.Format("{0:0.00}", Convert.ToDouble(r["capital"].ToString()));
        }
        public void PopulateList(string filter, string state)
        {
            lstExistingCustomer.Items.Clear();
            string sql = "SELECT * FROM tblcustomer WHERE " + searchBy + filter + "%' " + state + "ORDER BY asFullName ASC";
            r = db.ExecuteQuery(sql);
            while (r.Read())
            {
                ListViewItem itm = new ListViewItem(r["customer_id"].ToString());
                itm.SubItems.Add(r["asFullName"].ToString());
                itm.SubItems.Add(r["Address"].ToString());
                itm.SubItems.Add(r["Contact"].ToString());
                itm.SubItems.Add(r["customer_status"].ToString());
                lstExistingCustomer.Items.Add(itm);
            }
            r.Close();
            db.CloseConnection();
            for (int i = 0; i < lstExistingCustomer.Items.Count; i++)
            {
                ListViewItem itm = lstExistingCustomer.Items[i];
                itm.UseItemStyleForSubItems = false;
                if (itm.SubItems[4].Text.Equals("Active"))
                    itm.SubItems[4].ForeColor = Color.Green;
                else
                    itm.SubItems[4].ForeColor = Color.Red;
            }
        }
        private void frmContracts_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMDIMother.IsClosed = true;
        }
        private void cmbSearchBy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedItem == cmbSearchBy.Items[0])
                searchBy = "asFullname LIKE '%";
            else
                searchBy = "Contact LIKE '%";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateList(txtSearchKey.Text, status);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Proceed with this customer?", "Set Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                btnSelect.Enabled = false;
                ListViewItem itm = lstExistingCustomer.SelectedItems[0];
                if (itm.SubItems[4].Text.Equals("Active"))
                {
                    id = Convert.ToInt64(lstExistingCustomer.SelectedItems[0].Text);
                    SetInfo(id);
                    gpbCustomer.Enabled = false;
                    gpbInfo.Enabled = true;
                }
                else
                    MessageBox.Show("Customer must be active to continue.", "Customer Inactive!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        private void SetInfo(long cust_id)
        {
            string sql = "SELECT * FROM tblcustomer WHERE customer_id = " + cust_id;
            r = db.ExecuteQuery(sql);
            if (r.HasRows)
            {
                r.Read();
                if (!r["Mname"].ToString().Equals(""))
                    txtFullname.Text = r["Fname"].ToString() + " " + r["Mname"].ToString() + " " + r["Lname"].ToString();
                else
                    txtFullname.Text = r["Fname"].ToString() + " " + r["Lname"].ToString();
                txtContact.Text = r["Contact"].ToString();
                txtBalance.Text = String.Format("{0:0.00}",Convert.ToDouble(r["balance"].ToString()));
                if (!r["CustomerPic"].ToString().Equals(""))
                {
                    lblPhoto.Visible = false;
                    Image img = GetCopyImage(Application.StartupPath + "\\CustomerImages\\" + r["CustomerPic"].ToString());
                    picPhoto.Image = img;
                }
                else
                {
                    picPhoto.Image = null;
                    lblPhoto.Visible = true;
                }
            }
            r.Close();
            db.CloseConnection();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            gpbContractDetails.Enabled = false;
            gpbCustomer.Enabled = true;
            gpbInfo.Enabled = false;
            picPhoto.Image = null;
            db.SetAlltextToDefault(gpbContractDetails);
            db.SetAlltextToDefault(gpbInfo);
        }

        private void chkCondition_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCondition.Checked == true)
                gpbAgreement.Enabled = true;
            else
                gpbAgreement.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to proceed with this customer?", "Proceed", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (HasContract(id))
                {
                    if (DialogResult.Yes == MessageBox.Show("The selected account has already have a contract. Create another contract?", "Extend Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        btnGotoInfo.Enabled = true;
                        btnSave.Enabled = true;
                        gpbInfo.Enabled = false;
                        gpbContract.Enabled = true;
                        gpbContractDetails.Enabled = true;
                        btnLast.Visible = true;
                    }
                }
                else
                {
                    btnGotoInfo.Enabled = true;
                    btnSave.Enabled = true;
                    gpbContract.Enabled = true;
                    gpbInfo.Enabled = false;
                }
            }

        }
        
        private bool HasContract(long idToCheck)
        {
            string query = "SELECT * FROM tblcontracts WHERE customer_id = " + idToCheck + " AND loan_status = 'Active'";
            r = db.ExecuteQuery(query);
            if (r.HasRows)
            {
                r.Close();
                db.CloseConnection();
                return true;
            }
            else
            {
                r.Close();
                db.CloseConnection();
                return false;
            }
        }
        private void SetContractDetails(long idToCheck)
        {
            string query = "SELECT * FROM tblcontracts WHERE customer_id = " + idToCheck + " AND loan_status = 'Active'";
            r = db.ExecuteQuery(query);
            if (r.HasRows)
            {
                r.Read();
                txtTotalAmount.Text = String.Format("{0:0.00}",Convert.ToDouble(r["loan_total"].ToString()));
                txtDateStart.Text = Convert.ToDateTime(r["payment_start"].ToString()).ToString("MM/dd/yyyy");
                txtDateEnd.Text = Convert.ToDateTime(r["date_end"].ToString()).ToString("MM/dd/yyyy");
                txtPaymentDue.Text = String.Format("{0:0.00}",Convert.ToDouble(r["payment_due"].ToString()));
                txtAgreementInterest.Text = (Convert.ToDouble(r["penalty_interest"].ToString()) * 100).ToString();
                txtAgreementMode.Text = r["penalty_mode"].ToString();
            }
            r.Close();
            db.CloseConnection();
        }

        private void txtPenalty_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextHandle(ref sender, ref e, "Decimal");
        }

        private void txtGives_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextHandle(ref sender, ref e, "Number");
        }
        private bool IsInformationComplete()
        {
            if (txtLoanAmount.Text == "" || txtInterest.Text == "" || txtGives.Text == "")
                return false;
            if (chkCondition.Checked == true)
            {
                if (txtPenalty.Text == "")
                    return false;
            }
            return true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (IsInformationComplete())
            {
                gpbContractDetails.Enabled = true;
                SetCheckDetails();
            }
            else
                MessageBox.Show("Please fill up all fields");
        }
        private void SetCheckDetails()              
        {
            try
            {
                double interest = Math.Round((Convert.ToDouble(txtInterest.Text) / 100),2);
                double loanAmount = Math.Round(Convert.ToDouble(txtLoanAmount.Text), 2);
                int gives = Convert.ToInt32(txtGives.Text);
                txtTotalAmount.Text = String.Format("{0:0.00}",Math.Round(((loanAmount * interest) + loanAmount), 2));
                txtPaymentDue.Text = String.Format("{0:0.00}",Math.Round((Convert.ToDouble(txtTotalAmount.Text) / gives), 2));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            txtDateStart.Text = dtpPaymentStart.Value.ToString("MM/dd/yyyy");
            DateTime endDate = dtpPaymentStart.Value;
            if (cmbMode.SelectedItem == cmbMode.Items[0])
            {
                double valueToAdd = (Convert.ToDouble(txtGives.Text) - 1) * 7;
                endDate = endDate.AddDays(valueToAdd);
                txtDateEnd.Text = endDate.ToString("MM/dd/yyyy");
            }
            else
            {
                int valueToAdd = Convert.ToInt32(txtGives.Text) - 1;
                endDate = endDate.AddMonths(valueToAdd);
                txtDateEnd.Text = endDate.ToString("MM/dd/yyyy");
            }
            if (chkCondition.Checked == true)
            {
                txtAgreementInterest.Text = txtPenalty.Text;
                txtAgreementMode.Text = cmbPenalty.SelectedItem.ToString();
            }
            else
            {
                txtAgreementInterest.Text = "0";
                txtAgreementMode.Text = cmbPenalty.SelectedItem.ToString();
            }
        }

        private void btnGotoInfo_Click(object sender, EventArgs e)
        {
            btnGotoInfo.Enabled = false;
            btnSave.Enabled = false;
            gpbContractDetails.Enabled = false;
            gpbContract.Enabled = false;
            gpbInfo.Enabled = true;
            db.SetAlltextToDefault(gpbContractDetails);
            db.SetAlltextToDefault(gpbContract);
            db.SetAlltextToDefault(gpbAgreement);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Save contract?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (IsInformationComplete())
                {
                    if (GetBalance() < Math.Round(Convert.ToDouble(txtLoanAmount.Text),2))
                    {
                        if (IsCapitalEnough())
                        {
                            SetCheckDetails();
                            ExecuteSavingContract();
                            db.SetAlltextToDefault(gpbContractDetails);
                            db.SetAlltextToDefault(gpbContract);
                            db.SetAlltextToDefault(gpbAgreement);
                            gpbContract.Enabled = false;
                            gpbContractDetails.Enabled = false;
                            gpbInfo.Enabled = true;
                            btnLast.Visible = false;
                            SetInfo(id);
                            btnSave.Enabled = false;
                            btnGotoInfo.Enabled = false;
                            LoadCapital();
                        }
                    }
                    else
                        MessageBox.Show("Loan amount must be greater than the outstanding balance!");
                }
                else
                    MessageBox.Show("Please fill up all fields");
            }
        }
        private bool IsCapitalEnough()
        {
            string query = "SELECT * FROM tbluser";
            r = db.ExecuteQuery(query);
            r.Read();
            double capital = Convert.ToDouble(r["capital"].ToString());
            double loanAmount = Math.Round(Convert.ToDouble(txtLoanAmount.Text),2) - Math.Round(Convert.ToDouble(txtBalance.Text),2);
            if (capital >= loanAmount)
            {
                r.Close();
                db.CloseConnection();
                return true;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("You do not have enough capital. Do you want to add now?", "Problem Encountered", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    frmAddCapital add = new frmAddCapital();
                    add.ShowDialog();
                }
                r.Close();
                db.CloseConnection();
                return false;
            }
        }
        private double GetBalance()
        {
            double bal = 0;
            r = db.ExecuteQuery("SELECT balance FROM tblcustomer WHERE customer_id = " + id);
            if (r.HasRows)
            {
                r.Read();
                bal = Convert.ToDouble(r["balance"].ToString());
            }
            r.Close();
            db.CloseConnection();
            return bal;
        }
        private void ExecuteSavingContract()
        {
            long customer_id = id;
            string date_start = DateTime.Now.ToString("yyyy-MM-dd");
            string date_end = Convert.ToDateTime(txtDateEnd.Text).ToString("yyyy-MM-dd");
            double interest_rate = Convert.ToDouble(txtInterest.Text) / 100;
            double loan_amount = Math.Round(Convert.ToDouble(txtLoanAmount.Text), 2);
            double payment_due = Math.Round(Convert.ToDouble(txtPaymentDue.Text), 2);
            string payment_start = Convert.ToDateTime(txtDateStart.Text).ToString("yyyy-MM-dd");
            int payment_gives = Convert.ToInt32(txtGives.Text);
            string payment_type = cmbMode.SelectedItem.ToString();
            double penalty_interest = 0;
            string penalty_mode = cmbPenalty.Items[0].ToString();
            if (chkCondition.Checked == true)
            {
                penalty_interest = Convert.ToDouble(txtAgreementInterest.Text) / 100;
                penalty_mode = cmbPenalty.SelectedItem.ToString();
            }
            double loan_total = Math.Round(Convert.ToDouble(txtTotalAmount.Text), 2);
            string loan_status = "Active";
            string isExtended = (btnLast.Visible == true ? "Yes" : "No");

            UpdateCustomerBalance(loan_amount,loan_total);
            if (HasContract(customer_id))
                ReleasePastContract();

            string insert = "INSERT INTO tblcontracts (customer_id,date_start,date_end,interest_rate,loan_amount,payment_due,payment_start,payment_gives,payment_type,penalty_interest,penalty_mode,loan_total,loan_status,IsExtendedContract) " +
                "VALUES(" + customer_id + ",'" + date_start + "','" + date_end + "'," + interest_rate + "," +
                loan_amount + "," + payment_due + ",'" + payment_start + "'," + payment_gives + ",'" + payment_type + "'," +
                penalty_interest + ",'" + penalty_mode + "'," + loan_total + ",'" + loan_status + "','" + isExtended + "')";
            db.InsertQuery(insert);
            string otherCondition = (penalty_interest ==0? "None":"The borrower agreed to the additional rate of " + (penalty_interest * 100) + "% " + penalty_mode + " upon inability to pay the scheduled date.");
            excel.PrintReportToExcelContract(String.Format("{0:0.00}", loan_amount) + " pesos", payment_gives.ToString() + " " + (payment_type == "Weekly"? "Week/s" : "Month/s"), (interest_rate * 100).ToString() + "%",otherCondition);
            SetSchedule();
        }
        private void ReleasePastContract()
        {
            List<long> sched_ids = new List<long>();
            long loan_id = GetLoanID();
            double amount = 0;
            List<double> penaltied = new List<double>();
            string query = "SELECT * FROM tblschedules WHERE loan_id = " + loan_id + " AND schedule_status = 'Pending'";
            r = db.ExecuteQuery(query);
            while (r.Read())
            {
                sched_ids.Add(Convert.ToInt64(r["sched_id"].ToString()));
                penaltied.Add(Convert.ToDouble(r["amount_penaltied"].ToString()));
                amount = Convert.ToDouble(r["scheduled_amount"].ToString());
            }
            r.Close();
            db.CloseConnection();
            for (int i = 0; i < sched_ids.Count; i++)
            {
                string insert;
                if (penaltied[i] == 0)
                {
                    insert = "INSERT INTO tblpayments(loan_id, sched_id, payment_date, payment_amount, remarks) " +
                        "VALUES(" + loan_id + "," + sched_ids[i] + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + amount + "," + "'Advanced payment due to new contract signing')";
                }
                else
                {
                    insert = "INSERT INTO tblpayments(loan_id, sched_id, payment_date, payment_amount, remarks) " +
                       "VALUES(" + loan_id + "," + sched_ids[i] + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + penaltied[i] + "," + "'Advanced payment due to new contract signing')";
                }
                db.InsertQueryNoPrompt(insert);
            }
            for (int i = 0; i < sched_ids.Count; i++)
            {
                string update;
                if(penaltied[i] == 0)
                    update = "UPDATE tblschedules SET amount_paid = " + amount + ", fully_paid = 'Yes', schedule_status = 'Done' WHERE sched_id = " + sched_ids[i];
                else
                    update = "UPDATE tblschedules SET amount_paid = " + penaltied[i] + ", fully_paid = 'Yes', schedule_status = 'Done' WHERE sched_id = " + sched_ids[i];
                db.InsertQueryNoPrompt(update);
            }
            string setContractStatus = "UPDATE tblcontracts SET loan_status = 'Finished' WHERE loan_id = " + loan_id;
            db.InsertQueryNoPrompt(setContractStatus);
        }
        private long GetLoanID()
        {
            string query = "SELECT loan_id FROM tblcontracts WHERE customer_id = " + id + " AND loan_status = 'Active'";
            r = db.ExecuteQuery(query);
            r.Read();
            long loan_id = Convert.ToInt64(r["loan_id"].ToString());
            r.Close();
            db.CloseConnection();
            return loan_id;
        }
        private void SetSchedule()
        {
            string query = "SELECT loan_id,payment_start,payment_gives,payment_due,payment_type FROM tblcontracts " +
                "WHERE customer_id = " + id + " AND loan_status = 'Active'";
            r = db.ExecuteQuery(query);
            if (r.HasRows)
            {
                r.Read();
                long loan_id = Convert.ToInt64(r["loan_id"].ToString());
                DateTime payment_start = Convert.ToDateTime(r["payment_start"].ToString());
                int payment_gives = Convert.ToInt32(r["payment_gives"].ToString());
                double payment_due = Convert.ToDouble(r["payment_due"].ToString());
                string payment_type = r["payment_type"].ToString();
                if (payment_type.Equals("Weekly"))
                {
                    for (int i = 0; i < payment_gives; i++)
                    {
                        payment_start = (i == 0 ? payment_start : payment_start.AddDays(7));
                        string insert = "INSERT INTO tblschedules(loan_id,schedule_date,scheduled_amount,amount_penaltied,amount_paid,fully_paid,schedule_status) " +
                               "VALUES(" + loan_id + ",'" + payment_start.ToString("yyyy-MM-dd") + "'," + payment_due + ",0,0,'No','Pending')";
                        db.InsertQueryNoPrompt(insert);
                    }
                }
                else
                {
                    for (int i = 0; i < payment_gives; i++)
                    {
                        payment_start = (i == 0 ? payment_start : payment_start.AddMonths(1));
                        string insert = "INSERT INTO tblschedules(loan_id,schedule_date,scheduled_amount,amount_penaltied,amount_paid,fully_paid,schedule_status) " +
                               "VALUES(" + loan_id + ",'" + payment_start.ToString("yyyy-MM-dd") + "'," + payment_due + ",0,0,'No','Pending')";
                        db.InsertQueryNoPrompt(insert);
                    }
                }
            }
            r.Close();
            db.CloseConnection();
        }
        private void UpdateCustomerBalance(double newAmount,double total)
        {
            double balance = GetBalance();
            double release = newAmount - balance;
            balance = total;
            MessageBox.Show("Release amount: " + release, "Amount to Release",MessageBoxButtons.OK,MessageBoxIcon.Information);
            string update = "UPDATE tblcustomer SET balance = " + balance + " WHERE customer_id = " + id;
            db.InsertQueryNoPrompt(update);
            update = "UPDATE tbluser SET capital = capital - " + release + " WHERE user_id = 1";
            db.InsertQueryNoPrompt(update);
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            SetContractDetails(id);
        }

        private void lstExistingCustomer_Click(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
        }

        private void lstExistingCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Proceed with this customer?", "Set Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                btnSelect.Enabled = false;
                ListViewItem itm = lstExistingCustomer.SelectedItems[0];
                if (itm.SubItems[4].Text.Equals("Active"))
                {
                    id = Convert.ToInt64(lstExistingCustomer.SelectedItems[0].Text);
                    SetInfo(id);
                    gpbCustomer.Enabled = false;
                    gpbInfo.Enabled = true;
                }
                else
                    MessageBox.Show("Customer must be active to continue.", "Customer Inactive!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
