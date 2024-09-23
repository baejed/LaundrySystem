using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LaundrySystem
{
    public partial class FormStaffs : Form
    {

        GlobalProcedure globalProcedure = new GlobalProcedure();

        HashAlgorithm sha = SHA256.Create();

        private string v_fullName = "";
        private DateTime v_bdate = DateTime.Now;
        private string v_gender = "";
        private string v_address = "";
        private string v_contactNumber = "";
        private string v_emailadd = "";
        private string v_username = "";
        private string v_passHash = "";

        public FormStaffs()
        {
            InitializeComponent();
            if (!this.globalProcedure.fncConnectToDatabase())
                MessageBox.Show("Not Connected");
        }

        private void TbCustomerName_TextChanged(object sender, EventArgs e)
        {
            this.v_fullName = this.TbCustomerName.Text;
        }

        private void DtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            this.v_bdate = this.DtpBirthdate.Value;
        }

        private void TbAddress_TextChanged(object sender, EventArgs e)
        {
            this.v_address = this.TbAddress.Text;
        }

        private void TbContactNum_TextChanged(object sender, EventArgs e)
        {
            this.v_contactNumber = this.TbContactNum.Text;
        }

        private void TbEmailAdd_TextChanged(object sender, EventArgs e)
        {
            this.v_emailadd = this.TbEmailAdd.Text;
        }

        private void TbUser_TextChanged(object sender, EventArgs e)
        {
            this.v_username = this.TbUser.Text;
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            this.v_passHash = this.TbPassword.Text;
        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            MySqlCommand gProcCmd = this.globalProcedure.sqlCommand;

            try
            {
                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procAddStaff";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_fullname", v_fullName);
                gProcCmd.Parameters.AddWithValue("@p_birthdate", v_bdate);
                gProcCmd.Parameters.AddWithValue("@p_gender", v_gender);
                gProcCmd.Parameters.AddWithValue("@p_address", v_address);
                gProcCmd.Parameters.AddWithValue("@p_contactno", v_contactNumber);
                gProcCmd.Parameters.AddWithValue("@p_emailadd", v_emailadd);
                gProcCmd.Parameters.AddWithValue("@p_username", v_username);
                gProcCmd.Parameters.AddWithValue("@p_password", v_passHash);
                gProcCmd.ExecuteNonQuery();
                MessageBox.Show("Staff saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed");
            }
        }
    }
}
