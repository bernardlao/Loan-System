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
    public partial class frmCustomer : Form
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        MySqlDataReader r;

        private string oldlocation;
        private string location;
        private string searchBy = "asFullname LIKE '%";
        private string status = "";
        private long update_id;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            SetDefaults();
            PopulateList("","");
        }
        public void PopulateList(string filter,string status)
        {
            lstExistingCustomer.Items.Clear();
            string sql = "SELECT * FROM tblcustomer WHERE " + searchBy + filter + "%' " + status + "ORDER BY asFullName ASC";
            r = db.ExecuteQuery(sql);
            while (r.Read())
            {
                ListViewItem itm = new ListViewItem(r["asFullName"].ToString());
                itm.SubItems.Add(r["Address"].ToString());
                itm.SubItems.Add(r["Gender"].ToString());
                itm.SubItems.Add(Convert.ToDateTime(r["birthdate"].ToString()).ToString("MM/dd/yyyy"));
                itm.SubItems.Add(r["Contact"].ToString());
                itm.SubItems.Add(r["customer_status"].ToString());
                lstExistingCustomer.Items.Add(itm);
            }
            r.Close();
            for (int i = 0; i < lstExistingCustomer.Items.Count;i++ )
            {
                ListViewItem itm = lstExistingCustomer.Items[i];
                itm.UseItemStyleForSubItems = false;
                if (itm.SubItems[5].Text.Equals("Active"))
                    itm.SubItems[5].ForeColor = Color.Green;
                else
                    itm.SubItems[5].ForeColor = Color.Red;
            }
        }
        private void SetDefaults()
        {
            txtAddress.Text = "";
            dtpBday.Value = DateTime.Now;
            txtContact.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtMname.Text = "";
            txtSearchKey.Text = "";
            cmbGender.SelectedItem = cmbGender.Items[0];
            cmbSearchBy.SelectedItem = cmbSearchBy.Items[0];
            cmbStatus.SelectedItem = cmbStatus.Items[0];
            picPhoto.Image = null;
        }
        private long GetLastID()
        {
            string sql = "SELECT * FROM tblcustomer ORDER BY customer_id DESC";
            r = db.ExecuteQuery(sql);
            long Cid = 0;
            if (r.HasRows)
            {
                r.Read();
                Cid = Convert.ToInt64(r["customer_id"].ToString());
            }
            r.Close();
            return Cid;
        }
        public Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
        private void TextHandler(ref object sender,ref KeyPressEventArgs e,string s)
        {
            if (s.Equals("Age"))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            if (s.Equals("Contacts"))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ')' && e.KeyChar != '(')
                    e.Handled = true;
            }
            if (s.Equals("Text"))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            if (btnCommand.Text.Equals("Save"))
            {
                if (IsAllInputValid())
                {
                    if (DialogResult.Yes == MessageBox.Show("Save Customer?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        ExecuteAdding();
                        SetDefaults();
                        PopulateList("","");
                    }
                }
                else
                    MessageBox.Show("There are some missing information that must be filled up.", "Unsufficient Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (btnCommand.Text.Equals("Update"))
            {
                if (IsAllInputValid())
                {
                    if (DialogResult.Yes == MessageBox.Show("Update informations?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        ExecuteUpdate();
                        SetDefaults();
                        PopulateList("", "");
                        gpbMain.Enabled = false;
                        gpbSecondary.Enabled = true;
                        btnCancelUpdate.Enabled = false;
                        btnCommand.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("There are some missing information that must be filled up.", "Unsufficient Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextHandler(ref sender, ref e, "Text");
        }
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextHandler(ref sender, ref e, "Contacts");
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMDIMother.IsClosed = true;
        }

        private string AutoCorrectCasing(string s)
        {
            string retval = "";
            if (s.Contains(" "))
            {
                string[] text = s.Split(' ');
                for (int i = 0; i < text.Length; i++)
                {
                    if (!text[i].Equals(""))
                    {
                        retval += text[i].Substring(0, 1).ToString().ToUpper() + text[i].Substring(1).ToString().ToLower() + " ";
                    }
                }
                retval = retval.Remove(retval.Length - 1);
            }
            else
            {
                retval = s.Substring(0, 1).ToString().ToUpper() + s.Substring(1).ToString().ToLower();
            }
            return retval;
        }
        private bool IsAllInputValid()
        {
            if (txtAddress.Text == "" || txtFname.Text == "" || txtLname.Text == "" || txtContact.Text == "")
                return false;
            return true;
        }
        private string SetFullName(string f, string m, string l)
        {
            if (m == null)
                return f + " " + l;
            else
                return f + " " + m + " " + l;
        }
        private void SetPhoto(string fileName)
        {
            try
            {
                File.Copy(@location, Application.StartupPath + "\\CustomerImages\\" + fileName + ".png",true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Image Files(.jpg,.png,.jpeg)|*.jpg;*.png;*.jpeg";
            if (DialogResult.Cancel != openfile.ShowDialog())
            {
                location = openfile.FileName;
                Image img = GetCopyImage(location);
                picPhoto.Image = img;
                lblPhoto.Visible = false;
            }
        }

        private void cmbSearchBy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedItem == cmbSearchBy.Items[0])
                searchBy = "asFullname LIKE '%";
            else
                searchBy = "Contact LIKE '%";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateList(txtSearchKey.Text,status);
        }

        private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem == cmbStatus.Items[0])
            {
                status = "";
                PopulateList(txtSearchKey.Text, status);
            }
            if (cmbStatus.SelectedItem == cmbStatus.Items[1])
            {
                status = "AND customer_status = 'Active' ";
                PopulateList(txtSearchKey.Text, status);
            }
            if (cmbStatus.SelectedItem == cmbStatus.Items[2])
            {
                status = "AND customer_status = 'Inactive' ";
                PopulateList(txtSearchKey.Text, status);
            }
        }

        private void lstExistingCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (btnCommand.Text.Equals("Update"))
            {
                gpbMain.Enabled = true;
                btnCancelUpdate.Enabled = true;
                btnCommand.Enabled = true;
                gpbSecondary.Enabled = false;
                long id = GetID();
                update_id = id;
                DisplayInfo(id);
            }
        }
        public long GetID()
        {
            ListViewItem itm = lstExistingCustomer.SelectedItems[0];
            string sql = "SELECT * FROM tblcustomer WHERE asFullName = '" + itm.Text +"' AND Address = '" +
                itm.SubItems[1].Text + "' AND birthdate = '" + Convert.ToDateTime(itm.SubItems[3].Text).ToString("yyyy-MM-dd") + "'";
            r = db.ExecuteQuery(sql);
            long temp = 0;
            if (r.HasRows)
            {
                r.Read();
                temp = Convert.ToInt64(r["customer_id"].ToString());
                r.Close();
            }
            return temp;

        }
        private void DisplayInfo(long id)
        {
            string sql = "SELECT * FROM tblcustomer WHERE customer_id = " + id;
            r = db.ExecuteQuery(sql);
            r.Read();
            txtAddress.Text = r["Address"].ToString();
            dtpBday.Value = Convert.ToDateTime(r["birthdate"].ToString());
            txtFname.Text = r["Fname"].ToString();
            txtLname.Text = r["Lname"].ToString();
            txtMname.Text = r["Mname"].ToString();
            txtContact.Text = r["Contact"].ToString();
            cmbGender.Text = r["Gender"].ToString();
            string fileName = r["CustomerPic"].ToString();
            r.Close();

            if (!fileName.Equals(""))
            {
                oldlocation = Application.StartupPath + "\\CustomerImages\\" + fileName;
                File.Copy(@oldlocation, Application.StartupPath + "\\temporary.png",true);
                location = Application.StartupPath + "\\temporary.png";
                Image img = GetCopyImage(location);
                picPhoto.Image = img;
                lblPhoto.Visible = false;
            }
            else
            {
                location = "";
                picPhoto.Image = null;
            }
        }
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            gpbMain.Enabled = false;
            gpbSecondary.Enabled = true;
            SetDefaults();
            btnCancelUpdate.Enabled = false;
            btnCommand.Enabled = false;
        }
        private void ExecuteAdding()
        {
            string fname = AutoCorrectCasing(txtFname.Text);
            string lname = AutoCorrectCasing(txtLname.Text);
            string mname = "";
            if (txtMname.Text == "")
                mname = "";
            else
                mname = AutoCorrectCasing(txtMname.Text);
            string address = AutoCorrectCasing(txtAddress.Text);
            string gender = cmbGender.SelectedItem.ToString();
            string bdate = dtpBday.Value.ToString("yyyy-MM-dd");
            string contact = txtContact.Text;

            string fullName = SetFullName(fname, mname, lname);
            string photo = "";
            if (picPhoto.Image == null)
                photo = "''";
            else
            {
                SetPhoto((GetLastID() + 1).ToString());
                photo = "'" + (GetLastID() + 1).ToString() + ".png'";
            }

            string insert = "INSERT INTO tblcustomer(Fname,Lname,Mname,Address,Gender,birthdate,Contact,CustomerPic,asFullName,customer_status,balance) " +
                "VALUES('" + fname + "','" + lname + "','" + mname + "','" + address + "','" + gender + "','" + bdate + "','" + contact + "'," + photo + ",'" + fullName + "','Active',0)";
            db.InsertQuery(insert);
        }
        private void ExecuteUpdate()
        {
            string fname = AutoCorrectCasing(txtFname.Text);
            string lname = AutoCorrectCasing(txtLname.Text);
            string mname = "";
            if (txtMname.Text == "")
                mname = "";
            else
                mname = AutoCorrectCasing(txtMname.Text);
            string address = AutoCorrectCasing(txtAddress.Text);
            string gender = cmbGender.SelectedItem.ToString();
            string bdate = dtpBday.Value.ToString("yyyy-MM-dd");
            string contact = txtContact.Text;
            string fullName = SetFullName(fname, mname, lname);
            string photo = "";
            if (location.Equals(""))
                photo = "''";
            else if (location.Equals(Application.StartupPath + "\\temporary.png"))
            {
                photo = "'" + update_id.ToString() + ".png'";
            }
            else
            {
                SetPhoto(update_id.ToString());
                photo = "'" + update_id.ToString() + ".png'";
            }
            
            string update = "UPDATE tblcustomer SET Fname ='" + fname + "', Lname = '" + lname +
                   "', Mname = '" + mname + "', Address = '" + address + "', Gender = '" + gender +
                   "', birthdate = '" + bdate + "', Contact = '" + contact + "', asFullName = '" + fullName +
                   "', CustomerPic = " + photo + " WHERE customer_id = " + update_id;
            db.UpdateQuery(update);
        }
        private void ExecuteDeactivate(long deactID)
        {
            string sql = "";
            if (btnStatus.Text.Equals("Activate"))
                sql = "UPDATE tblcustomer SET customer_status = 'Active' WHERE customer_id = " + deactID;
            else
                sql = "UPDATE tblcustomer SET customer_status = 'Inactive' WHERE customer_id = " + deactID;
            db.UpdateQuery(sql);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picPhoto.Image == null)
            {
                if (lblPhoto.Visible == false)
                    lblPhoto.Visible = true;
            }
        }

        private void lstExistingCustomer_Click(object sender, EventArgs e)
        {
            btnStatus.Enabled = true;
            ListViewItem itm = lstExistingCustomer.SelectedItems[0];
            if (itm.SubItems[5].Text.Equals("Active"))
                btnStatus.Text = "Deactivate";
            if (itm.SubItems[5].Text.Equals("Inactive"))
                btnStatus.Text = "Activate";
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deactivate selected account?", "Account Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmAuthentication aut = new frmAuthentication();
                aut.ShowDialog();
                if (frmAuthentication.authentic)
                {
                    ExecuteDeactivate(GetID());
                    btnStatus.Enabled = false;
                    PopulateList("", "");
                    frmAuthentication.authentic = false;
                }
            }
        }
    }
}
