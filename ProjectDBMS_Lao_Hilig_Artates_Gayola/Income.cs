using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using DBUtilities;

namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    public partial class frmIncome : Form
    {
        MySQLDBUtilities db = new MySQLDBUtilities();

        public frmIncome()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            double loanAmount = 0;
            double paymentAmount = 0;
            double earnings = 0;
            DataTable dtLoan = db.GetResult("SELECT cu.asFullName, co.date_start, co.loan_amount" +
                " FROM tblcustomer cu INNER JOIN tblcontracts co ON cu.customer_id = co.customer_id " +
                "WHERE co.date_start BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "'");
            DataTable dtPayment = db.GetResult("SELECT cu.asFullName, p.payment_date,p.payment_amount,co.payment_due,co.interest_rate,co.payment_gives,co.loan_amount FROM" +
                " (tblpayments p INNER JOIN tblcontracts co ON p.loan_id = co.loan_id) INNER JOIN" +
                " tblcustomer cu ON cu.customer_id = co.customer_id WHERE p.payment_date BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") +
                "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "'");
            if (dtLoan != null)
            {
                foreach (DataRow r in dtLoan.Rows)
                {
                    loanAmount += Convert.ToDouble(r["loan_amount"].ToString());
                    ListViewItem itm = new ListViewItem(r["asFullName"].ToString());
                    itm.SubItems.Add(Convert.ToDateTime(r["date_start"].ToString()).ToString("MM/dd/yyyy"));
                    itm.SubItems.Add(String.Format("{0:0.00}", Convert.ToDouble(r["loan_amount"].ToString())));
                    lstLoan.Items.Add(itm);
                }
            }
            if (dtPayment != null)
            {
                foreach (DataRow r in dtPayment.Rows)
                {
                    paymentAmount += Convert.ToDouble(r["payment_amount"].ToString());
                    ListViewItem itm = new ListViewItem(r["asFullName"].ToString());
                    itm.SubItems.Add(Convert.ToDateTime(r["payment_date"].ToString()).ToString("MM/dd/yyyy"));
                    itm.SubItems.Add(String.Format("{0:0.00}", Convert.ToDouble(r["payment_amount"].ToString())));
                    lstPayment.Items.Add(itm);
                    double percentOfPayed = Convert.ToDouble(r["payment_amount"].ToString()) / Convert.ToDouble(r["payment_due"].ToString());
                    double interest = Convert.ToDouble(r["interest_rate"].ToString()) / Convert.ToInt32(r["payment_gives"].ToString());
                    interest = interest * Convert.ToDouble(r["loan_amount"].ToString());
                    double total = percentOfPayed * interest;
                    earnings += Math.Round(total, 2);
                }
            }
            txtLoanReleased.Text = String.Format("{0:0.00}",loanAmount);
            txtPaymentReceived.Text = String.Format("{0:0.00}",paymentAmount);
            lblStatistic.Text = String.Format("{0:0.00}", (paymentAmount - loanAmount)) + ((paymentAmount - loanAmount) < 0? " LOSS" : " GAIN");
            txtEarnings.Text = String.Format("{0:0.00}", earnings);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
            dtpFrom.MaxDate = dtpTo.Value;
        }

        private void frmIncome_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMDIMother.IsClosed = true;
        }
    }
}
