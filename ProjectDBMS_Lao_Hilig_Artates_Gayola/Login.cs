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
    public partial class frmlogin : Form
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        MySqlDataReader r;
        string user = "";
        string password = "";
        private bool mustPrompt = true;

        public frmlogin()
        {
            InitializeComponent();
            if (db.IsSettingsValid() && File.Exists(Application.StartupPath + "\\settings.ini"))
            {
                frmConnect connect = new frmConnect();
                connect.ShowDialog();
            }
            if (!File.Exists(Application.StartupPath + "\\settings.ini"))
            {
                frmConnect connectDb = new frmConnect();
                connectDb.ShowDialog();
            }
        }
        public static string GetConnectQuery()
        {
            string query = "";
            string[] datas = File.ReadAllLines(Application.StartupPath + "\\settings.ini");
            for (int i = 1; i < datas.Length; i++)
            {
                query += datas[i];
            }
            return query;
        }
        private void GetUserAndPass()
        {
            string sql = "SELECT * FROM tbluser";
            r = db.ExecuteQuery(sql);
            r.Read();
            user = r["user_name"].ToString();
            password = r["user_password"].ToString();
            r.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetUserAndPass();
            if (txtUser.Text.Equals(user) && txtPass.Text.Equals(password))
            {
                mustPrompt = false;
                MessageBox.Show("Welcome " + user);
                frmMDIMother.IsClosed = true;
                this.Close();
            }
            else if (txtUser.Text.Equals(user) && !txtPass.Text.Equals(password))
            {
                MessageBox.Show("Invalid password.", "Wrong password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Invalid account.", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CheckInput(ref object sender,ref KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(ref sender, ref e);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(ref sender, ref e);
        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && mustPrompt)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    Environment.Exit(1);
                else
                    e.Cancel = true;
            }
        }
    }
}
