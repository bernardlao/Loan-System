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
    public partial class frmScheduleCustomerCheck : Form
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        DataTable dt;

        public frmScheduleCustomerCheck()
        {
            InitializeComponent();
        }

        private void frmScheduleCustomerCheck_Load(object sender, EventArgs e)
        {
            LoadCustomer("");
        }
        private void LoadCustomer(string filter)
        {
            lstExistingCustomer.Items.Clear();
            string query = "SELECT cu.customer_id,co.loan_id,cu.asFullName FROM tblcustomer cu " +
                "INNER JOIN tblcontracts co ON cu.customer_id = co.customer_id" +
                " WHERE loan_status = 'Active' AND cu.customer_status = 'Active' " + filter;
            dt = db.GetResult(query);
            foreach (DataRow r in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(r["customer_id"].ToString());
                itm.SubItems.Add(r["loan_id"].ToString());
                itm.SubItems.Add(r["asFullName"].ToString());
                lstExistingCustomer.Items.Add(itm);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomer("AND asFullName LIKE '%" + txtKey.Text + "%'");
        }

        private void lstExistingCustomer_DoubleClick(object sender, EventArgs e)
        {
            frmSchedulePayment scheduled = new frmSchedulePayment();
            scheduled.customer_id = Convert.ToInt64(lstExistingCustomer.SelectedItems[0].Text);
            scheduled.loan_id = Convert.ToInt64(lstExistingCustomer.SelectedItems[0].SubItems[1].Text);
            scheduled.lblName.Text = lstExistingCustomer.SelectedItems[0].SubItems[2].Text;
            scheduled.ShowDialog();
            LoadCustomer("");
        }

        private void frmScheduleCustomerCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMDIMother.IsClosed = true;
        }
    }
}
