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
using System.IO;
using DBUtilities;

namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    public partial class frmChangeAccount : Form
    {
        frmlogin log = new frmlogin();
        MySqlDataReader r;
        MySQLDBUtilities db = new MySQLDBUtilities();

        string user = "";
        string password = "";
        public frmChangeAccount()
        {
            InitializeComponent();
            if (!File.Exists(Application.StartupPath + "\\settings.ini"))
            {
                frmConnect connectDb = new frmConnect();
                connectDb.ShowDialog();
            }
        }

        public void GetUserAndPass()
        {
            string sql = "SELECT * FROM tbluser";
            r = db.ExecuteQuery(sql);
            r.Read();
            user = r["user_name"].ToString();
            password = r["user_password"].ToString();
            r.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }

        private void txtOldUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            log.CheckInput(ref sender, ref e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetUserAndPass();
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Save information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (IsAllInfoComplete())
                {
                    ChangeUser();
                    this.Close();
                }
            }
        }
        private bool IsAllInfoComplete()
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtRetypePass.Text == "")
            {
                MessageBox.Show("There are some invalid inputs.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!txtOldPass.Text.Equals(password))
            {
                MessageBox.Show("Old password Invalid", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!txtNewPass.Text.Equals(txtRetypePass.Text))
            {
                MessageBox.Show("Password must be valid. Please re-type your password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ChangeUser()
        {
            string update = "UPDATE tbluser SET user_password = '" + txtNewPass.Text + "' " +
                            "WHERE user_name = '" + user + "'";
            db.UpdateQuery(update);
        }
    }
}
