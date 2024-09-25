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

        Color disabledColor = Color.FromArgb(135, 190, 245);
        bool editing = false;

        private string[] passwords;

        private string v_fullName = "";
        private DateTime v_bdate = DateTime.Now;
        private string v_gender = "";
        private string v_address = "";
        private string v_contactNumber = "";
        private string v_emailadd = "";
        private string v_username = "";
        private string v_password = "";
        private string v_confirmPassword = "";

        int v_selectedId = -1;


        public FormStaffs()
        {
            InitializeComponent();
            if (!this.globalProcedure.fncConnectToDatabase())
                MessageBox.Show("Not Connected");
            DisplayAllStaff();
            Editing = false;
        }

        private void TbCustomerName_TextChanged(object sender, EventArgs e)
        {
            this.v_fullName = this.TbStaffName.Text;
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
            this.v_password = this.TbPassword.Text;
        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {

            if(v_password != v_confirmPassword)
            {
                MessageBox.Show("Password does not match");
                return;
            }

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
                gProcCmd.Parameters.AddWithValue("@p_password", v_password);
                gProcCmd.ExecuteNonQuery();
                MessageBox.Show("Staff saved successfully");
                DisplayAllStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayAllStaff()
        {

            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();
                this.globalProcedure.datLaundry = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procDisplayAllStaff";
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
                    this.GridStaffs.RowCount = totalRecords;
                    this.passwords = new string[totalRecords];

                    while (!(totalRecords - 1 < row))
                    {
                        this.GridStaffs.Rows[row].Cells[0].Value = dataTable.Rows[row]["id"].ToString();
                        this.GridStaffs.Rows[row].Cells[1].Value = dataTable.Rows[row]["fullname"].ToString();
                        this.GridStaffs.Rows[row].Cells[2].Value = DateTime.Parse(dataTable.Rows[row]["birthdate"].ToString()).Date;
                        this.GridStaffs.Rows[row].Cells[3].Value = dataTable.Rows[row]["gender"].ToString();
                        this.GridStaffs.Rows[row].Cells[4].Value = dataTable.Rows[row]["address"].ToString();
                        this.GridStaffs.Rows[row].Cells[5].Value = dataTable.Rows[row]["contactno"].ToString();
                        this.GridStaffs.Rows[row].Cells[6].Value = dataTable.Rows[row]["emailadd"].ToString();
                        this.GridStaffs.Rows[row].Cells[7].Value = dataTable.Rows[row]["username"].ToString();
                        this.passwords[row] = dataTable.Rows[row]["password"].ToString();
                        row++;
                    }

                }
                else
                {
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

        private void CmbStaffGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.v_gender = this.CmbStaffGender.SelectedItem.ToString();
        }

        private void TbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            this.v_confirmPassword = TbConfirmPassword.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        bool Editing
        {
            set
            {
                this.editing = value;
                this.BtnUpdate.Enabled = value;
                this.BtnDelete.Enabled = value;
                this.BtnCancel.Enabled = value;
                this.BtnClear.Enabled = !value;
                this.BtnAddStaff.Enabled = !value;

                this.BtnUpdate.BackgroundColor = value ? Color.Black : disabledColor;
                this.BtnDelete.BackgroundColor = value ? Color.Black : disabledColor;
                this.BtnCancel.BackgroundColor = value ? Color.Black : disabledColor;
                this.BtnClear.BackgroundColor = value ? disabledColor : Color.Black;
                this.BtnAddStaff.BackgroundColor = value ? disabledColor : Color.Black;

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridStaffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIdx = e.RowIndex;

            if (selectedIdx < 0) return;

            string staffId = this.GridStaffs.Rows[selectedIdx].Cells[0].Value.ToString();
            //DisplayCustomerDetails(selectedIdx);

            this.v_selectedId = int.Parse(staffId);

            this.LblStaffInfo.Text = "Staff Info (" + "Staff ID: " + staffId + ")";

            this.Editing = true;

            DisplayStaffDetails(selectedIdx);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procDeleteStaffById";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_id", v_selectedId);
                gProcCmd.ExecuteNonQuery();

                MessageBox.Show("Staff ID: " + this.v_selectedId + " deleted");
                this.v_selectedId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failedd");
            }

            //SearchAndDisplayAllCustomer(v_fullnameSearch);
            DisplayAllStaff();
            ClearFields();
        }

        private void ClearFields()
        {
            this.v_fullName = "";
            this.v_bdate = DateTime.Now;
            this.v_gender = "";
            this.v_address = "";
            this.v_contactNumber = "";
            this.v_emailadd = "";
            this.v_username = "";
            this.v_password = "";
            this.v_confirmPassword = "";

            this.TbStaffName.Text = "";
            this.DtpBirthdate.Value = DateTime.Now;
            this.CmbStaffGender.Text = "";
            this.TbAddress.Text = "";
            this.TbContactNum.Text = "";
            this.TbEmailAdd.Text = "";
            this.TbUser.Text = "";
            this.TbPassword.Text = "";
            this.TbConfirmPassword.Text = "";

            this.LblStaffInfo.Text = "Staff Info (New Staff)";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            Editing = false;
        }

        private void DisplayStaffDetails(int index)
        {
            DataGridViewCellCollection details = this.GridStaffs.Rows[index].Cells;

            this.TbStaffName.Text = details[1].Value.ToString();
            this.DtpBirthdate.Value = DateTime.Parse(details[2].Value.ToString());
            this.CmbStaffGender.Text = details[3].Value.ToString();
            this.TbAddress.Text = details[4].Value.ToString();
            this.TbContactNum.Text = details[5].Value.ToString();
            this.TbEmailAdd.Text = details[6].Value.ToString();
            this.TbUser.Text = details[7].Value.ToString();
            this.TbPassword.Text = passwords[index];
            this.TbConfirmPassword.Text = passwords[index];

            //this.v_fullName = details[1].Value.ToString();
            //this.v_bdate = DateTime.Parse(details[2].Value.ToString());
            //this.v_gender = details[3].Value.ToString();
            //this.v_address = details[4].Value.ToString();
            //this.v_contactNumber = details[5].Value.ToString();
            //this.v_emailadd = details[6].Value.ToString();
            //this.v_username = details[7].Value.ToString();
            //this.v_password = passwords[index];
            //this.v_confirmPassword = passwords[index];
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (v_password != v_confirmPassword)
            {
                MessageBox.Show("Password does not match");
                return;
            }

            MySqlCommand gProcCmd = this.globalProcedure.sqlCommand;

            try
            {
                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procUpdateStaffById";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_id", v_selectedId);
                gProcCmd.Parameters.AddWithValue("@p_fullname", v_fullName);
                gProcCmd.Parameters.AddWithValue("@p_birthdate", v_bdate);
                gProcCmd.Parameters.AddWithValue("@p_gender", v_gender);
                gProcCmd.Parameters.AddWithValue("@p_address", v_address);
                gProcCmd.Parameters.AddWithValue("@p_contactno", v_contactNumber);
                gProcCmd.Parameters.AddWithValue("@p_emailadd", v_emailadd);
                gProcCmd.Parameters.AddWithValue("@p_username", v_username);
                gProcCmd.Parameters.AddWithValue("@p_password", v_password);
                gProcCmd.ExecuteNonQuery();

                MessageBox.Show("Customer updated successfully");
                DisplayAllStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearFields();
            Editing = false;
        }
    }
}
