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
    public partial class frmSchedulePayment : Form
    {
        MySqlDataReader r;
        MySQLDBUtilities db = new MySQLDBUtilities();
        List<long> sched_ids = new List<long>();

        public long loan_id;
        public long customer_id;

        public frmSchedulePayment()
        {
            InitializeComponent();
        }
        private void frmSchedulePayment_Load(object sender, EventArgs e)
        {
            SetSchedulesInList();
        }
        private void frmSchedulePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMDIMother.IsClosed = true;
        }
        private void SetSchedulesInList()
        {
            lstSchedules.Items.Clear();
            string query = "SELECT   sched_id, schedule_date, scheduled_amount, amount_penaltied, amount_paid, fully_paid, co.loan_total, co.interest_rate  FROM" + 
                " (tblcustomer cu INNER JOIN tblcontracts co ON cu.customer_id = co.customer_id)" +
                " INNER JOIN tblschedules s ON co.loan_id = s.loan_id WHERE cu.customer_id = " + customer_id +
                " AND loan_status = 'Active' AND schedule_status = 'Pending'";
            r = db.ExecuteQuery(query);
            sched_ids.Clear();
            double totalBalance = 0;
            if (r.HasRows)
            {
                while (r.Read())
                {

                    sched_ids.Add(Convert.ToInt64(r["sched_id"].ToString()));
                    ListViewItem itm = new ListViewItem("");
                    itm.SubItems.Add(Convert.ToDateTime(r["schedule_date"].ToString()).ToString("MM/dd/yyyy"));
                    double schedAmount = Convert.ToDouble(r["scheduled_amount"].ToString());
                    double amountPenaltied = Convert.ToDouble(r["amount_penaltied"].ToString());
                    double amountPaid = Convert.ToDouble(r["amount_paid"].ToString());
                    double balance = (schedAmount + amountPenaltied) - amountPaid;
                    itm.SubItems.Add(String.Format("{0:0.00}",schedAmount));
                    itm.SubItems.Add(String.Format("{0:0.00}",amountPenaltied));
                    itm.SubItems.Add(String.Format("{0:0.00}",(schedAmount + amountPenaltied)));
                    itm.SubItems.Add(String.Format("{0:0.00}",amountPaid));
                    itm.SubItems.Add(String.Format("{0:0.00}",balance));
                    itm.SubItems.Add(r["fully_paid"].ToString());
                    lstSchedules.Items.Add(itm);
                    totalBalance += balance;
                    lblTotal.Text = r["loan_total"].ToString() + " with " + (Convert.ToDouble(r["interest_rate"].ToString()) * 100) + "% of interest";
                }
            }
            lblBalance.Text = String.Format("{0:0.00}", totalBalance);

            r.Close();
            db.CloseConnection();
            for (int i = 0; i < lstSchedules.Items.Count; i++)
            {
                ListViewItem itm = lstSchedules.Items[i];
                itm.UseItemStyleForSubItems = false;
                if (Convert.ToDateTime(itm.SubItems[1].Text) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    itm.BackColor = Color.Red;
                else if (Convert.ToDateTime(itm.SubItems[1].Text) > Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    itm.BackColor = Color.Lime;
                else
                    itm.BackColor = Color.Yellow;
            }
        }
        private void lstSchedules_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lstSchedules.Items[e.Index].SubItems[7].Text.Equals("Yes"))
                e.NewValue = CheckState.Unchecked;
            if (e.NewValue == CheckState.Checked)
            {
                if (e.Index > 0)
                {
                    for (int i = 0; i < e.Index; i++)
                    {
                        if (lstSchedules.Items[i].SubItems[7].Text.Equals("No"))
                            lstSchedules.Items[i].Checked = true;
                        else
                            lstSchedules.Items[i].Checked = false;
                    }
                }
            }
            else
            {
                for (int i = e.Index + 1; i < lstSchedules.Items.Count; i++)
                    lstSchedules.Items[i].Checked = false;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Compute selected schedules amount?", "Proceed", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                    frmPayment pay = new frmPayment();
                    GetAmountTotal();
                    pay.ShowDialog();
                    SetSchedulesInList();
            }
        }
        private void GetAmountTotal()
        {
            double retVal = 0;
            List<int> indexes = new List<int>();
            for (int i = 0; i < lstSchedules.Items.Count; i++)
            {
                if (lstSchedules.Items[i].Checked == true)
                    indexes.Add(i);
            }
            for (int i = 0; i < indexes.Count; i++)
            {
                ListViewItem itm = lstSchedules.Items[indexes[i]];
                retVal += Convert.ToDouble(itm.SubItems[6].Text);
            }
            frmPayment.sched_ids = this.sched_ids;
            frmPayment.indexes = indexes;
            frmPayment.totalAmountToPay = retVal;
        }

        private void lstSchedules_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && !lstSchedules.SelectedItems[0].SubItems[3].Text.Equals("0"))
            {
                cmsOne.Show(Cursor.Position);
            }
        }

        private void tsmCheckPenaltyBreakdown_Click(object sender, EventArgs e)
        {
            frmPenaltyBreakdown breakdown = new frmPenaltyBreakdown();
            breakdown.sched_id = sched_ids[lstSchedules.SelectedIndices[0]];
            breakdown.ShowDialog();
        }

    }
}