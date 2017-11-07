using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace DBUtilities
{
    class MySQLDBUtilities
    {
        private MySqlCommand command;
        private MySqlConnection connection;
        private MySqlDataAdapter myAdapter;

        public MySQLDBUtilities()
        {
            //connection = new MySqlConnection();
            command = new MySqlCommand();
        }
        public DataTable GetResult(string sourceQuery)
        {
            DataTable d = new DataTable();
            try
            {
                myAdapter = new MySqlDataAdapter(sourceQuery, OpenConnection());
                myAdapter.Fill(d);
                myAdapter.Dispose();
                CloseConnection();
                return d;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public MySqlDataReader ExecuteQuery(string sourceQuery)
        {
            command.CommandText = sourceQuery;
            try
            {
                command.Connection = OpenConnection();
                MySqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public void CloseConnection()
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }   
        }

        private MySqlConnection OpenConnection()
        {
            try
            {
                connection = new MySqlConnection(ReadFromIniFile());
                //connection.ConnectionString = ReadFromIniFile();
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open) 
                        connection.Close();
                }
                return connection;
            } 
        }
        private string ReadFromIniFile()
        {
            string query = "";
            if (File.Exists(Application.StartupPath + "\\settings.ini"))
            {
                string[] datas = File.ReadAllLines(Application.StartupPath + "\\settings.ini");
                for (int i = 1; i < datas.Length; i++)
                {
                    query += datas[i];
                }
            }
            return query;
        }
        public void UpdateQuery(string query)
        {
            command.CommandText = query;
            try
            {
                command.Connection = OpenConnection();
                int result = command.ExecuteNonQuery();
                if (result > -1)
                    MessageBox.Show("Successfully updated!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("There is a problem updating.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void InsertQuery(string query)
        {
            command.CommandText = query;
            try
            {
                command.Connection = OpenConnection();
                int result = command.ExecuteNonQuery();
                if (result > -1)
                    MessageBox.Show("Successfully added!", "Add!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("There is a problem adding.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void InsertQueryNoPrompt(string query)
        {
            command.CommandText = query;
            try
            {
                command.Connection = OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void TextHandle(ref object sender, ref KeyPressEventArgs e, string format)
        {
            if (format.Equals("Letter"))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            }
            else if (format.Equals("Decimal"))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    e.Handled = true;
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                    e.Handled = true;
            }
            else if(format.Equals("Number"))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        public void SetAlltextToDefault(Control sourceForm)
        {
            foreach (Control c in sourceForm.Controls)
            {
                if (c.GetType().Name.Equals("TextBox"))
                    c.Text = "";
            }
        }
        public long GetCustomerID(string query)
        {
            MySqlDataReader r = ExecuteQuery(query);
            long id = 0;
            if (r.HasRows)
            {
                r.Read();
                id = Convert.ToInt64(r["customer_id"].ToString());
            }
            r.Close();
            CloseConnection();
            return id;
        }
        public bool IsSettingsValid()
        {
            MySqlConnection conn = new MySqlConnection(ReadFromIniFile());
            try
            {
                conn.Open();
                conn.Close();
                return false;
            }
            catch (Exception e)
            {
                return true;
            }
        }
    }
}
