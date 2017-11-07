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

namespace ProjectDBMS_Lao_Hilig_Artates_Gayola
{
    public partial class frmConnect : Form
    {
        MySqlConnection conn;
        private bool mustPrompt = true;
        public frmConnect()
        {
            InitializeComponent();
        }
        private void EraseWhiteSpaces(ref object sender, ref KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || e.KeyChar == '=')
                e.Handled = true;
        }

        private void frmConnect_KeyPress(object sender, KeyPressEventArgs e)
        {
            EraseWhiteSpaces(ref sender, ref e);
        }
        private bool CheckInputs()
        {
            if (txtDatabase.Text == "" || txtPassword.Text == "" || txtPort.Text == "" || txtServer.Text == "" || txtUID.Text == "")
            {
                MessageBox.Show("Details must be complete..", "Unsufficient Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void SaveDatas()
        {
            File.WriteAllText(Application.StartupPath + "\\settings.ini", "[Loan Database Properties]" + Environment.NewLine);
            string[] datas = new string[5];
            datas[0] = "SERVER=" + txtServer.Text + ";";
            datas[1] = "PORT=" + txtPort.Text + ";";
            datas[2] = "DATABASE=" + txtDatabase.Text + ";";
            datas[3] = "UID=" + txtUID.Text + ";";
            datas[4] = "PASSWORD=" + txtPassword.Text + ";";
            File.AppendAllLines(Application.StartupPath + "\\settings.ini", datas);
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Save Connection Datas", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (CheckInputs())
                {
                    if (TestConnection(false))
                    {
                        SaveDatas();
                        MessageBox.Show("You have successfully set a connection to your system.");
                        mustPrompt = false;
                        this.Close();
                    }
                }
            }
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            bool test;
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Test Connection Datas", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                test = TestConnection(true);
        }
        private bool TestConnection(bool isTestOnly)
        {
            string query = "SERVER=" + txtServer.Text + ";" + "PORT=" + txtPort.Text + ";" +
                "DATABASE=" + txtDatabase.Text + ";" + "UID=" + txtUID.Text + ";" + "PASSWORD=" + txtPassword.Text + ";";
            try
            {
                conn = new MySqlConnection(query);
                conn.Open();
                if(isTestOnly)
                    MessageBox.Show("You have a valid connection.");
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void frmConnect_FormClosing(object sender, FormClosingEventArgs e)
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
