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
    public partial class frmPayment : Form
    {
        MySqlDataReader r;
        MySQLDBUtilities db = new MySQLDBUtilities();
        public static double totalAmountToPay;
        public static List<int> indexes;
        public static List<long> sched_ids;

        public frmPayment()
        {
            InitializeComponent();
        }
        private void txtPaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextHandle(ref sender, ref e, "Decimal");
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            txtAmountToPay.Text = String.Format("{0:0.00}",totalAmountToPay);
        }

        private void btnAddPay_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Add Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (Convert.ToDouble(txtAmountToPay.Text) >= Convert.ToDouble(txtPaymentAmount.Text) && !txtPaymentAmount.Text.Equals("0"))
                {
                    frmAuthentication aut = new frmAuthentication();
                    aut.ShowDialog();
                    if (frmAuthentication.authentic)
                    {
                        SetPayments();
                        UpdateLoanInformation();
                        MessageBox.Show("Payment already recorded!");
                        this.Close();
                        frmAuthentication.authentic = false;
                    }
                }
                else
                    MessageBox.Show("Payment Amount must be less than or equal to the Amount to Pay and must not be Zero.");
            }
        }
        private void SetPayments()
        {
            double payment_amount = Math.Round(Convert.ToDouble(txtPaymentAmount.Text), 2);
            string query;
            string update;
            string insert;
            long loan_id;
            double balanceFortheSched;
            for (int i = 0; i < indexes.Count; i++)
            {
                query = "SELECT scheduled_amount, amount_penaltied, amount_paid, loan_id FROM tblschedules WHERE sched_id = " + sched_ids[indexes[i]];
                r = db.ExecuteQuery(query);
                r.Read();
                loan_id = Convert.ToInt64(r["loan_id"].ToString());
                if (!r["amount_penaltied"].ToString().Equals("0"))
                    balanceFortheSched = (Convert.ToDouble(r["amount_penaltied"].ToString()) + Convert.ToDouble(r["scheduled_amount"].ToString())) - Convert.ToDouble(r["amount_paid"].ToString());
                else
                    balanceFortheSched = Convert.ToDouble(r["scheduled_amount"].ToString()) - Convert.ToDouble(r["amount_paid"].ToString());
                payment_amount = payment_amount - balanceFortheSched;
                if (payment_amount <= 0)
                {
                    r.Close();
                    db.CloseConnection();
                    update = "UPDATE tblschedules SET amount_paid = amount_paid + " + (payment_amount + balanceFortheSched) +  " WHERE sched_id = " + sched_ids[indexes[i]];
                    db.InsertQueryNoPrompt(update);
                    insert = "INSERT INTO tblpayments(loan_id, sched_id, payment_date, payment_amount, remarks) " +
                        "VALUES(" + loan_id + "," + sched_ids[indexes[i]] + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + (payment_amount + balanceFortheSched) + "," + "'Ordinary Payment'" + ")";
                    db.InsertQueryNoPrompt(insert);
                    UpdateCustomerBalance((payment_amount + balanceFortheSched), loan_id);
                    update = "UPDATE tbluser SET capital = capital + " + (payment_amount + balanceFortheSched) + " WHERE user_id = 1";
                    db.InsertQueryNoPrompt(update);
                    break;
                }
                else
                {
                    r.Close();
                    db.CloseConnection();
                    update = "UPDATE tblschedules SET amount_paid = amount_paid + " + balanceFortheSched + " WHERE sched_id = " + sched_ids[indexes[i]];
                    db.InsertQueryNoPrompt(update);
                    insert = "INSERT INTO tblpayments(loan_id, sched_id, payment_date, payment_amount, remarks) " +
                        "VALUES(" + loan_id + "," + sched_ids[indexes[i]] + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + balanceFortheSched + "," + "'Ordinary Payment'" + ")";
                    db.InsertQueryNoPrompt(insert);
                    UpdateCustomerBalance(balanceFortheSched, loan_id);
                    update = "UPDATE tbluser SET capital = capital + " + balanceFortheSched + " WHERE user_id = 1";
                    db.InsertQueryNoPrompt(update);
                }
            }
            for (int i = 0; i < indexes.Count; i++)
            {
                query = "SELECT scheduled_amount, amount_penaltied, amount_paid, loan_id FROM tblschedules WHERE sched_id = " + sched_ids[indexes[i]];
                r = db.ExecuteQuery(query);
                r.Read();
                string amountToCheck = (Convert.ToDouble(r["scheduled_amount"]) + Convert.ToDouble(r["amount_penaltied"].ToString())).ToString();

                if (amountToCheck.Equals(r["amount_paid"].ToString()))
                {
                    r.Close();
                    db.CloseConnection();
                    update = "UPDATE tblschedules SET fully_paid = 'Yes' WHERE sched_id = " + sched_ids[indexes[i]];
                    db.InsertQueryNoPrompt(update);
                }
            }
        }
        private void UpdateCustomerBalance(double amount, long loan_id)
        {
            string sql = "SELECT customer_id FROM tblcontracts WHERE loan_id = " + loan_id;
            r = db.ExecuteQuery(sql);
            r.Read();
            long customer_id = Convert.ToInt64(r["customer_id"].ToString());
            r.Close();
            db.CloseConnection();
            sql = "UPDATE tblcustomer SET balance = balance - " + amount + " WHERE customer_id = " + customer_id;
            db.InsertQueryNoPrompt(sql);
        }
        private void UpdateLoanInformation()
        {
            string query;
            long loan_id = 0;
            int count = 0;
            string ids = "";
            for (int i = 0; i < sched_ids.Count; i++)
                ids += sched_ids[i].ToString() + ",";
            ids = ids.Remove(ids.Length - 1);
            query = "SELECT scheduled_amount, amount_penaltied, amount_paid, loan_id, fully_paid FROM tblschedules WHERE sched_id IN (" + ids + ")";
            r = db.ExecuteQuery(query);
            while (r.Read())
            {
                loan_id = Convert.ToInt64(r["loan_id"].ToString());
                if (r["fully_paid"].ToString().Equals("Yes"))
                    count++;
            }
            r.Close();
            db.CloseConnection();
            if (count == sched_ids.Count)
            {
                query = "UPDATE tblcontracts SET loan_status = 'Finished' WHERE loan_id = " + loan_id;
                db.InsertQueryNoPrompt(query);
                for (int i = 0; i < sched_ids.Count; i++)
                {
                    query = "UPDATE tblschedules SET schedule_status = 'Done' WHERE sched_id = " + sched_ids[i];
                    db.InsertQueryNoPrompt(query);
                }
            }
        }

        private void txtPaymentAmount_Enter(object sender, EventArgs e)
        {
            if (txtPaymentAmount.Text.Equals("0"))
                txtPaymentAmount.Text = "";
        }

        private void txtPaymentAmount_Leave(object sender, EventArgs e)
        {
            if (txtPaymentAmount.Text.Equals(""))
                txtPaymentAmount.Text = "0";
        }
    }
}
