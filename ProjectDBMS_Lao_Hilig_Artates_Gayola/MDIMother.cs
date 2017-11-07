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

namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    public partial class frmMDIMother : Form
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        public DateTime currentDate;
        public static bool IsClosed;
        private bool mustPrompt = true;
        private int formWidth;

        public frmMDIMother()
        {
            InitializeComponent();
            //MessageBox.Show(DateTime.Now.ToLongTimeString());
            //MessageBox.Show(Environment.MachineName);
            currentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }
        private void MDIMother_Load(object sender, EventArgs e)
        {
            formWidth = this.Size.Width;
            ResizeListView();
            LoadStartForm();
            SetPenalties();
        }
        private void LoadStartForm()
        {
            IsClosed = false;
            frmlogin login = new frmlogin();
            login.MdiParent = this;
            login.Show();
        }
        private void MDIMother_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && mustPrompt)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    Environment.Exit(1);
                else
                    e.Cancel = true;
            }
        }
        private void addCustomerMenu_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.btnCommand.Text = "Save";
            IsClosed = false;
            customer.gpbSecondary.Height = 233;
            customer.btnStatus.Visible = false;
            customer.Height = 464;
            customer.btnCancelUpdate.Visible = false;
            customer.MdiParent = this;
            customer.Show();
        }
        private void tmIsClosed_Tick(object sender, EventArgs e)
        {
            msMenu.Enabled = IsClosed;
            
        }
        private void editCustomerMenu_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.btnCommand.Text = "Update";
            IsClosed = false;
            customer.btnStatus.Visible = false;
            customer.Height = 464;
            customer.btnCancelUpdate.Visible = true;
            customer.btnCancelUpdate.Enabled = false;
            customer.btnCommand.Enabled = false;
            customer.gpbMain.Enabled = false;
            customer.MdiParent = this;
            customer.Show();
        }
        private void deactivateCustomerMenu_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.btnStatus.Text = "Deactivate";
            IsClosed = false;
            customer.gpbMain.Visible = false;
            customer.gpbSecondary.Location = new Point(3, -2);
            customer.Height = 315;
            customer.btnCancelUpdate.Visible = false;
            customer.btnStatus.Enabled = false;
            customer.btnCommand.Visible = false;
            customer.gpbMain.Enabled = false;
            customer.MdiParent = this;
            customer.Show();
        }
        private void addNewContractMenu_Click(object sender, EventArgs e)
        {
            frmContracts contract = new frmContracts();
            contract.MdiParent = this;
            IsClosed = false;
            contract.Show();
        }
        private void addCapitalMenu_Click(object sender, EventArgs e)
        {
            frmAddCapital add = new frmAddCapital();
            add.MdiParent = this;
            add.Show();
        }
        private void changePasswordMenu_Click(object sender, EventArgs e)
        {
            frmChangeAccount change = new frmChangeAccount();
            change.MdiParent = this;
            change.Show();
        }
        private void cancelContractMenu_Click(object sender, EventArgs e)
        {
            frmCancelContract cancel = new frmCancelContract();
            cancel.MdiParent = this;
            cancel.Show();
        }
        private void addPaymentMenu_Click(object sender, EventArgs e)
        {
            frmScheduleCustomerCheck scheds = new frmScheduleCustomerCheck();
            scheds.MdiParent = this;
            IsClosed = false;
            scheds.Show();
        }
        private void tmPenaltySet_Tick(object sender, EventArgs e)
        {
            if (currentDate < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
            {
                currentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                SetPenalties();
            }
        }
        private void SetPenalties()
        {
            DataTable dt = db.GetResult("SELECT cu.customer_id FROM (tblcontracts co INNER JOIN tblcustomer cu ON co.customer_id = cu.customer_id) INNER JOIN tblschedules sc ON co.loan_id = sc.loan_id WHERE loan_status = 'Active'");
            double penaltyInterest;
            string penaltyMode;
            double amountPaid;
            double schedAmount;

            List<long> cust_id = new List<long>();
            foreach (DataRow row in dt.Rows)
            {
                if (!cust_id.Contains(Convert.ToInt64(row["customer_id"].ToString())))
                {
                    cust_id.Add(Convert.ToInt64(row["customer_id"]));
                    db.InsertQueryNoPrompt("UPDATE tblcustomer SET balance = 0 WHERE customer_id = " + Convert.ToInt64(row["customer_id"].ToString()));
                }
            }
            for (int i = 0; i < cust_id.Count; i++)
            {
                dt = db.GetResult("SELECT cu.customer_id, co.loan_id, co.penalty_interest, co.penalty_mode,sc.sched_id, sc.schedule_date, sc.scheduled_amount,sc.amount_penaltied,sc.amount_paid,sc.fully_paid FROM (tblcontracts co INNER JOIN tblcustomer cu ON co.customer_id = cu.customer_id) INNER JOIN tblschedules sc ON co.loan_id = sc.loan_id WHERE loan_status = 'Active' AND cu.customer_id = " + cust_id[i]);
                foreach (DataRow row in dt.Rows)
                {
                    string update;
                    penaltyInterest = Convert.ToDouble(row["penalty_interest"].ToString());
                    penaltyMode = row["penalty_mode"].ToString();
                    amountPaid = Math.Round(Convert.ToDouble(row["amount_paid"].ToString()), 2);
                    schedAmount = Math.Round(Convert.ToDouble(row["scheduled_amount"].ToString()), 2);

                    long sched_id = Convert.ToInt64(row["sched_id"].ToString());
                    if (row["fully_paid"].ToString().Equals("No") && Convert.ToDateTime(DateTime.Now.ToShortDateString()) > Convert.ToDateTime(row["schedule_date"].ToString()))
                    {
                        int dateDifference = (DateTime.Now - Convert.ToDateTime(row["schedule_date"].ToString())).Days;
                        double amount_penaltied = ((schedAmount * penaltyInterest) * (penaltyMode.Equals("Daily") ? dateDifference : (Convert.ToDateTime(DateTime.Now.ToShortDateString()) > Convert.ToDateTime(row["schedule_date"].ToString()) ? 1 : 0)));
                        update = "UPDATE tblschedules SET amount_penaltied = " + Math.Round(amount_penaltied, 2) + " WHERE sched_id = " + sched_id;
                        db.InsertQueryNoPrompt(update);
                        db.InsertQueryNoPrompt("UPDATE tblcustomer SET balance = balance + " + ((schedAmount + amount_penaltied) - amountPaid) + " WHERE customer_id = " + cust_id[i]);
                    }
                    else if (row["fully_paid"].ToString().Equals("Yes"))
                        ;//do nothing
                    else
                    {
                        db.InsertQueryNoPrompt("UPDATE tblschedules SET amount_penaltied = 0 WHERE sched_id = " + sched_id);
                        db.InsertQueryNoPrompt("UPDATE tblcustomer SET balance = balance + " + (schedAmount - amountPaid) + " WHERE customer_id = " + cust_id[i]);
                    }
                }
            }
        }
        private void ResizeListView()
        {
            int sizeAllowance = formWidth - 820;
            int sizePerColAdd = (sizeAllowance / 7) - 3;
            int[] colWidth = { clName.Width, clContactNo.Width, clAddress.Width, clSchedDate.Width, clSchedAmount.Width, clAmountPaid.Width,clBalance.Width };
            clName.Width = colWidth[0] + sizePerColAdd;
            clContactNo.Width = colWidth[1] + sizePerColAdd;
            clAddress.Width = colWidth[2] + sizePerColAdd;
            clSchedDate.Width = colWidth[3] + sizePerColAdd;
            clSchedAmount.Width = colWidth[4] + sizePerColAdd;
            clAmountPaid.Width = colWidth[5] + sizePerColAdd;
            clBalance.Width = colWidth[6] + sizePerColAdd;
        }
        private void logoutMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void schedulesMenu_Click(object sender, EventArgs e)
        {
            if (lstAllSched.Visible == false)
            {
                lstAllSched.Visible = true;
                SetAllActiveSchedules();
            }
            else
                lstAllSched.Visible = false;
        }
        private void SetAllActiveSchedules()
        {
            lstAllSched.Items.Clear();
            string query = "SELECT cu.asFullName,cu.Contact,cu.Address,sc.schedule_date,sc.scheduled_amount,sc.amount_penaltied,sc.amount_paid FROM (tblcontracts co INNER JOIN tblcustomer cu ON co.customer_id = cu.customer_id) INNER JOIN tblschedules sc ON co.loan_id = sc.loan_id WHERE co.loan_status = 'Active' AND sc.fully_paid = 'No' AND cu.customer_status = 'Active' ORDER BY sc.schedule_date ASC";
            DataTable dt = db.GetResult(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem itm = new ListViewItem(row["asFullName"].ToString());
                    itm.SubItems.Add(row["Contact"].ToString());
                    itm.SubItems.Add(row["Address"].ToString());
                    itm.SubItems.Add(Convert.ToDateTime(row["schedule_date"].ToString()).ToString("MM/dd/yyyy"));
                    double schedAmount = Convert.ToDouble(row["scheduled_amount"].ToString());
                    double penaltyAmount = Convert.ToDouble(row["amount_penaltied"].ToString());
                    double amountPaid = Convert.ToDouble(row["amount_paid"].ToString());
                    itm.SubItems.Add(String.Format("{0:0.00}", (schedAmount + penaltyAmount)));
                    itm.SubItems.Add(String.Format("{0:0.00}", amountPaid));
                    itm.SubItems.Add(String.Format("{0:0.00}", ((schedAmount + penaltyAmount) - amountPaid)));
                    lstAllSched.Items.Add(itm);
                }
                for (int i = 0; i < lstAllSched.Items.Count; i++)
                {
                    ListViewItem itm = lstAllSched.Items[i];
                    itm.UseItemStyleForSubItems = false;
                    if (Convert.ToDateTime(itm.SubItems[3].Text) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                        itm.SubItems[3].BackColor = Color.Red;
                    else if (Convert.ToDateTime(itm.SubItems[3].Text) > Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                        itm.SubItems[3].BackColor = Color.Lime;
                    else
                        itm.SubItems[3].BackColor = Color.Yellow;
                }
            }
        }

        private void checkIncomeMenu_Click(object sender, EventArgs e)
        {
            frmIncome income = new frmIncome();
            income.MdiParent = this;
            income.Show();
        }

        private void checkPaymentMenu_Click(object sender, EventArgs e)
        {
            frmPaymentAndBalance payment = new frmPaymentAndBalance();
            payment.MdiParent = this;
            IsClosed = false;
            payment.clBalance.Width = 0;
            payment.Text = "Payment Record";
            payment.Show();
        }

        private void checkCBalanceMenu_Click(object sender, EventArgs e)
        {
            frmPaymentAndBalance balance = new frmPaymentAndBalance();
            balance.MdiParent = this;
            IsClosed = false;
            balance.clAddress.Width = 0;
            balance.lblNote.Visible = true;
            balance.btnSelect.Visible = false;
            balance.Size = new Size(603, 295);
            balance.Text = "Customer Balance";
            balance.gpbPayRecord.Visible = false;
            balance.Show();
        }
    }
}
