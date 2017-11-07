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
    public partial class frmAddCapital : Form
    {
        MySqlDataReader r;
        MySQLDBUtilities db = new MySQLDBUtilities();
        private double capital;

        public frmAddCapital()
        {
            InitializeComponent();
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
        }

        private void frmAddCapital_Load(object sender, EventArgs e)
        {
            GetCapital();
        }
        private void GetCapital()
        {
            string query = "SELECT * FROM tbluser WHERE user_id = 1";
            r = db.ExecuteQuery(query);
            if (r.HasRows)
            {
                r.Read();
                lblCapital.Text = String.Format("{0:0.00}", Convert.ToDouble(r["capital"].ToString()));
            }
            r.Close();
            db.CloseConnection();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextHandle(ref sender, ref e, "Decimal");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfim_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Confirm Amount?", "Adding Capital", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (txtAmount.Text != "")
                {
                    frmAuthentication aut = new frmAuthentication();
                    aut.ShowDialog();
                    if (frmAuthentication.authentic)
                    {
                        capital = Convert.ToDouble(lblCapital.Text);
                        capital += Math.Round(Convert.ToDouble(txtAmount.Text), 2);
                        string update = "UPDATE tbluser SET capital = " + capital + " WHERE user_id = 1";
                        db.InsertQuery(update);
                        GetCapital();
                        frmAuthentication.authentic = false;
                    }
                }
                else
                    MessageBox.Show("Invalid input", "Error");
            }
        }
    }
}
