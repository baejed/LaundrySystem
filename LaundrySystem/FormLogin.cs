using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem
{
    public partial class FormLogin : Form
    {

        GlobalProcedure globalProcedure = new GlobalProcedure();

        string v_username = "";
        string v_password = "";


        public FormLogin()
        {
            InitializeComponent();
            globalProcedure.fncConnectToDatabase();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void TbUsername_TextChanged(object sender, EventArgs e)
        {
            this.v_username = this.TbUsername.Text;
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            this.v_password = this.TbPassword.Text;
        }

        private void Login()
        {
            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();
                this.globalProcedure.datLaundry = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procValidateCreds";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_username", v_username);
                gProcCmd.Parameters.AddWithValue("@p_password", v_password);
                this.globalProcedure.sqlLaundryAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datLaundry.Clear();
                this.globalProcedure.sqlLaundryAdapter.Fill(this.globalProcedure.datLaundry);

                DataTable dataTable = globalProcedure.datLaundry;
                if (int.Parse(dataTable.Rows[0]["validaccounts"].ToString()) > 0)
                {
                    this.globalProcedure.sqlLaundryAdapter.Dispose();
                    this.globalProcedure.datLaundry.Dispose();
                    this.Hide();
                    ClearFields();
                    new FormDashboard().ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or passowrd");
                }


                //try
                //{
                //    DataTable dataTable = globalProcedure.datLaundry;
                //    ifdataTable.Rows[0]["id"].ToString();
                //}

                //if (globalProcedure.datLaundry.Rows.Count > 0)
                //{
                //    DataTable dataTable = globalProcedure.datLaundry;
                //        this.GridCustomers.Rows[row].Cells[0].Value = dataTable.Rows[row]["id"].ToString();


                //}
                //else
                //{
                //    //MessageBox.Show("Record not found!");
                //}

                this.globalProcedure.sqlLaundryAdapter.Dispose();
                this.globalProcedure.datLaundry.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void ClearFields()
        {
            this.TbPassword.Text = string.Empty;
            this.TbUsername.Text = string.Empty;
            this.v_username = "";
            this.v_password = "";
        }
    }
}
