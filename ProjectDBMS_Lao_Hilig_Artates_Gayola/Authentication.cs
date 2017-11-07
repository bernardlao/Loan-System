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
    public partial class frmAuthentication : Form
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        DataTable dt;
        public static bool authentic = false;
        string pass;

        public frmAuthentication()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(pass))
            {
                authentic = true;
                MessageBox.Show("Authenticated");
                this.Close();
            }
            else
                MessageBox.Show("Incorrect Password");
        }

        private void frmAuthentication_Load(object sender, EventArgs e)
        {
            dt = db.GetResult("SELECT user_password FROM tbluser WHERE user_id = 1");
            foreach (DataRow r in dt.Rows)
            {
                pass = r["user_password"].ToString();
            }
        }
    }
}
