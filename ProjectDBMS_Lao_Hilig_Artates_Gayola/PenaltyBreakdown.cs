using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUtilities;

namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    public partial class frmPenaltyBreakdown : Form
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        public long sched_id;

        public frmPenaltyBreakdown()
        {
            InitializeComponent();
        }

        private void frmPenaltyBreakdown_Load(object sender, EventArgs e)
        {
            LoadBreakdown();
        }
        private void LoadBreakdown()
        {
            string query = "SELECT c.penalty_mode, c.penalty_interest, sc.schedule_date, sc.scheduled_amount" + 
                " FROM tblcontracts c INNER JOIN tblschedules sc ON c.loan_id = sc.loan_id " + 
                "WHERE sched_id = " + sched_id;
            DataTable dt = db.GetResult(query);
            foreach (DataRow r in dt.Rows)
            {
                double interest = Convert.ToDouble(r["penalty_interest"].ToString());
                double amount = Convert.ToDouble(r["scheduled_amount"].ToString());
                DateTime schedDate = Convert.ToDateTime(r["schedule_date"].ToString());
                lblMode.Text = (interest * 100).ToString() + "% " + r["penalty_mode"].ToString();
                if (r["penalty_mode"].ToString().Equals("Daily"))
                {
                    int dateDiff = (DateTime.Now - schedDate).Days;
                    for (int i = 0; i < dateDiff; i++)
                    {
                        ListViewItem itm = new ListViewItem(schedDate.AddDays(i + 1).ToString("MM/dd/yyyy"));
                        itm.SubItems.Add(String.Format("{0:0.00}",(interest * amount)));
                        lstBreakdown.Items.Add(itm);
                    }
                }
                else
                {
                    ListViewItem itm = new ListViewItem(schedDate.AddDays(1).ToString("MM/dd/yyyy"));
                    itm.SubItems.Add(String.Format("{0:0.00}",(interest * amount)));
                    lstBreakdown.Items.Add(itm);
                }
            }
        }
    }
}
