using LaundrySystem.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem
{
    public partial class Customers : Form
    {

        Color disabledColor = Color.FromArgb(135, 190, 245);

        GlobalProcedure globalProcedure = new GlobalProcedure();

        bool editing = false;

        int v_selectedId = -1;

        string v_fullName = "";
        DateTime v_bdate = DateTime.Now;
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
            this.Editing = false;

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
            MySqlCommand gProcCmd = this.globalProcedure.sqlCommand;

            try
            {
                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procAddCustomer";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_fullname", v_fullName);
                gProcCmd.Parameters.AddWithValue("@p_birthdate", v_bdate);
                gProcCmd.Parameters.AddWithValue("@p_gender", v_gender);
                gProcCmd.Parameters.AddWithValue("@p_address", v_address);
                gProcCmd.Parameters.AddWithValue("@p_contactno", v_contactNumber);
                gProcCmd.Parameters.AddWithValue("@p_emailadd", v_emailadd);
                gProcCmd.Parameters.AddWithValue("@p_cust_photo", v_customerPhoto);
                gProcCmd.ExecuteNonQuery();
                MessageBox.Show("Customer saved successfully");
                SearchAndDisplayAllCustomer(v_fullnameSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed");
            }

            ClearCustomerDetails();

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
                    this.LblTotalRecs.Text = "Total Records: " + totalRecords.ToString();
                    this.GridCustomers.RowCount = totalRecords;

                    while(!(totalRecords-1 < row))
                    {
                        this.GridCustomers.Rows[row].Cells[0].Value = dataTable.Rows[row]["id"].ToString();
                        this.GridCustomers.Rows[row].Cells[1].Value = dataTable.Rows[row]["fullname"].ToString();
                        this.GridCustomers.Rows[row].Cells[2].Value = DateTime.Parse(dataTable.Rows[row]["birthdate"].ToString()).Date;
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
                    this.LblTotalRecs.Text = "Total Records: " + totalRecords.ToString();
                    this.GridCustomers.RowCount = totalRecords;

                    while (!(totalRecords - 1 < row))
                    {
                        this.GridCustomers.Rows[row].Cells[0].Value = dataTable.Rows[row]["id"].ToString();
                        this.GridCustomers.Rows[row].Cells[1].Value = dataTable.Rows[row]["fullname"].ToString();
                        this.GridCustomers.Rows[row].Cells[2].Value = DateTime.Parse(dataTable.Rows[row]["birthdate"].ToString()).Date;
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

        private void GridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIdx = e.RowIndex;

            if (selectedIdx < 0) return;

            string customerId = this.GridCustomers.Rows[selectedIdx].Cells[0].Value.ToString();
            DisplayCustomerDetails(selectedIdx);

            this.v_selectedId = int.Parse(customerId);

            this.LblCustomerInfo.Text = "Customer Info (" + "Cusomter ID: " + customerId + ")";

            this.Editing = true;
        }

        private void DisplayCustomerDetails(int index)
        {
            DataGridViewCellCollection details =  this.GridCustomers.Rows[index].Cells;

            this.TbCustomerName.Text = details[1].Value.ToString();
            this.DtpBirthdate.Value = DateTime.Parse(details[2].Value.ToString());
            this.CmbCustGender.Text = details[3].Value.ToString();
            this.TbAddress.Text = details[4].Value.ToString();
            this.TbContactNum.Text = details[5].Value.ToString();
            this.TbEmailAdd.Text = details[6].Value.ToString();
            this.v_customerPhoto = details[7].Value.ToString();

            try
            {
                this.PicCustomer.Image = new Bitmap(this.v_customerPhoto);

            }catch(Exception ex)
            {
                this.ClearCustomerPic();
            }
        }

        private void ClearCustomerDetails()
        {
            //DataGridViewCellCollection details = this.GridCustomers.Rows[index].Cells;

            this.TbCustomerName.Text = "";
            this.DtpBirthdate.Value = DateTime.Now;
            this.CmbCustGender.Text = "";
            this.TbAddress.Text = "";
            this.TbContactNum.Text = "";
            this.TbEmailAdd.Text = "";
            this.ClearCustomerPic();
            this.LblCustomerInfo.Text = "Customer Info (New Customer)";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procDeleteCustomerById";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_id", v_selectedId);
                gProcCmd.ExecuteNonQuery();

                MessageBox.Show("User ID: " + this.v_selectedId + " deleted");
                this.v_selectedId = -1;
            }catch (Exception ex)
            {
                MessageBox.Show("Delete failedd");
            }

            SearchAndDisplayAllCustomer(v_fullnameSearch);
            ClearCustomerDetails();

        }

        bool Editing { set { 
                this.editing = value;
                this.BtnUpdate.Enabled = value;
                this.BtnDelete.Enabled = value;
                this.BtnCancel.Enabled = value;
                this.BtnAddCustomer.Enabled = !value;

                this.BtnUpdate.BackgroundColor = value ? Color.Black : disabledColor;
                this.BtnDelete.BackgroundColor = value ? Color.Black : disabledColor;
                this.BtnCancel.BackgroundColor = value ? Color.Black : disabledColor;
                this.BtnAddCustomer.BackgroundColor = value ? disabledColor : Color.Black;

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Editing = false;
            ClearCustomerDetails();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MySqlCommand gProcCmd = this.globalProcedure.sqlCommand;

            try
            {
                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procUpdateCustomerById";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_id", v_selectedId);
                gProcCmd.Parameters.AddWithValue("@p_fullname", v_fullName);
                gProcCmd.Parameters.AddWithValue("@p_birthdate", v_bdate);
                gProcCmd.Parameters.AddWithValue("@p_gender", v_gender);
                gProcCmd.Parameters.AddWithValue("@p_address", v_address);
                gProcCmd.Parameters.AddWithValue("@p_contactno", v_contactNumber);
                gProcCmd.Parameters.AddWithValue("@p_emailadd", v_emailadd);
                gProcCmd.Parameters.AddWithValue("@p_cust_photo", v_customerPhoto);
                gProcCmd.ExecuteNonQuery();

                MessageBox.Show("Customer updated successfully");
                SearchAndDisplayAllCustomer(v_fullnameSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearCustomerDetails();
            Editing = false;
        }
    }
}
