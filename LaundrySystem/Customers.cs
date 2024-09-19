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

        string v_fullnameSearch = "";

        public Customers()
        {
            InitializeComponent();
            if(!this.globalProcedure.fncConnectToDatabase())
                MessageBox.Show("Not Connected");

            DisplayAllCustomer();

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
                DisplayAllCustomer();
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

        public void DisplayAllCustomer()
        {
            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();
                this.globalProcedure.datLaundry = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procDisplayAllCustomer";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                this.globalProcedure.sqlLaundryAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datLaundry.Clear();
                this.globalProcedure.sqlLaundryAdapter.Fill(this.globalProcedure.datLaundry);

                if (globalProcedure.datLaundry.Rows.Count > 0)
                {
                    DataTable dataTable = globalProcedure.datLaundry;
                    int row = 0;
                    int totalRecords = globalProcedure.datLaundry.Rows.Count;
                    this.LblTotalRecs.Text = totalRecords.ToString();
                    this.GridCustomers.RowCount = totalRecords;

                    while(!(totalRecords-1 < row))
                    {
                        this.GridCustomers.Rows[row].Cells[0].Value = dataTable.Rows[row]["id"].ToString();
                        this.GridCustomers.Rows[row].Cells[1].Value = dataTable.Rows[row]["fullname"].ToString();
                        this.GridCustomers.Rows[row].Cells[2].Value = dataTable.Rows[row]["birthdate"].ToString();
                        this.GridCustomers.Rows[row].Cells[3].Value = dataTable.Rows[row]["gender"].ToString();
                        this.GridCustomers.Rows[row].Cells[4].Value = dataTable.Rows[row]["address"].ToString();
                        this.GridCustomers.Rows[row].Cells[5].Value = dataTable.Rows[row]["contactno"].ToString();
                        this.GridCustomers.Rows[row].Cells[6].Value = dataTable.Rows[row]["emailadd"].ToString();
                        this.GridCustomers.Rows[row].Cells[7].Value = dataTable.Rows[row]["cust_photo"].ToString();
                        row++;
                    }

                }
                else
                {
                    MessageBox.Show("Record not found!");
                }

                this.globalProcedure.sqlLaundryAdapter.Dispose();
                this.globalProcedure.datLaundry.Dispose();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SearchAndDisplayAllCustomer(string p_fullname)
        {
            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();
                this.globalProcedure.datLaundry = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procSearchCustomerByFullname";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_fullname", p_fullname);
                this.globalProcedure.sqlLaundryAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datLaundry.Clear();
                this.globalProcedure.sqlLaundryAdapter.Fill(this.globalProcedure.datLaundry);

                if (globalProcedure.datLaundry.Rows.Count > 0)
                {
                    DataTable dataTable = globalProcedure.datLaundry;
                    int row = 0;
                    int totalRecords = globalProcedure.datLaundry.Rows.Count;
                    this.LblTotalRecs.Text = totalRecords.ToString();
                    this.GridCustomers.RowCount = totalRecords;

                    while (!(totalRecords - 1 < row))
                    {
                        this.GridCustomers.Rows[row].Cells[0].Value = dataTable.Rows[row]["id"].ToString();
                        this.GridCustomers.Rows[row].Cells[1].Value = dataTable.Rows[row]["fullname"].ToString();
                        this.GridCustomers.Rows[row].Cells[2].Value = dataTable.Rows[row]["birthdate"].ToString();
                        this.GridCustomers.Rows[row].Cells[3].Value = dataTable.Rows[row]["gender"].ToString();
                        this.GridCustomers.Rows[row].Cells[4].Value = dataTable.Rows[row]["address"].ToString();
                        this.GridCustomers.Rows[row].Cells[5].Value = dataTable.Rows[row]["contactno"].ToString();
                        this.GridCustomers.Rows[row].Cells[6].Value = dataTable.Rows[row]["emailadd"].ToString();
                        this.GridCustomers.Rows[row].Cells[7].Value = dataTable.Rows[row]["cust_photo"].ToString();
                        row++;
                    }

                }
                else
                {
                    this.GridCustomers.Rows.Clear();
                    //MessageBox.Show("Record not found!");
                }

                this.globalProcedure.sqlLaundryAdapter.Dispose();
                this.globalProcedure.datLaundry.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TbFullnameSearch_TextChanged(object sender, EventArgs e)
        {
            this.v_fullnameSearch = this.TbFullnameSearch.Text;

            if (this.v_fullnameSearch == String.Empty)
                DisplayAllCustomer();
            else
                SearchAndDisplayAllCustomer(this.v_fullnameSearch);
        }
    }
}
