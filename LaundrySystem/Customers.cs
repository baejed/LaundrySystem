using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem
{
    public partial class Customers : Form
    {

        GlobalProcedure globalProcedure = new GlobalProcedure();

        string v_fullName = "";
        DateTime v_bdate;
        string v_gender = "";
        string v_address = "";
        string v_contactNumber = "";
        string v_emailadd = "";
        string v_customerPhoto = "";

        public Customers()
        {
            InitializeComponent();
            if(!this.globalProcedure.fncConnectToDatabase())
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

        private void CmbCustGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.v_gender = this.CmbCustGender.Text;
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

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procAddCustomer";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_fullname", v_fullName);
                sqlCmd.Parameters.AddWithValue("@p_birthdate", v_bdate);
                sqlCmd.Parameters.AddWithValue("@p_gender", v_gender);
                sqlCmd.Parameters.AddWithValue("@p_address", v_address);
                sqlCmd.Parameters.AddWithValue("@p_contactno", v_contactNumber);
                sqlCmd.Parameters.AddWithValue("@p_emailadd", v_emailadd);
                sqlCmd.Parameters.AddWithValue("@p_cust_photo", v_customerPhoto);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Customer saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed");
            }

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPic = new OpenFileDialog();
            ofdPic.Filter = "Images files (*.jpg;*.gif;*.bmp)|*.jpg;*.gif;*.bmp";
            if(ofdPic.ShowDialog() == DialogResult.OK)
            {
                this.PicCustomer.Image = new Bitmap(ofdPic.FileName);
                this.v_customerPhoto = ofdPic.FileName;
            }
        }
    }
}
