using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LaundrySystem
{
    public partial class FormService : Form
    {

        GlobalProcedure globalProcedure = new GlobalProcedure();
        object[] customerDetails;
        HashSet<string> customerFullnames;

        string v_customerName = "";
        string v_serviceType;
        string v_garmentType;
        double v_weight = -1;
        int v_quantity = -1;
        double v_amount = -1;

        double v_price = -1;

        public FormService()
        {
            InitializeComponent();
            globalProcedure.fncConnectToDatabase();
            PrepareCustomerAutocomplete();
            InitializeCmbServiceType();
            InitializeCmbGamentType();

            this.CmbServiceType.SelectedIndex = 0;
            this.CmbGarmentType.SelectedIndex = 4;

            this.v_serviceType = CmbServiceType.Text;
            this.v_garmentType = CmbGarmentType.Text;
        }

        private void FormService_Load(object sender, EventArgs e)
        {

        }

        private void PrepareCustomerAutocomplete()
        {

            string[] customerFullnames = null;

            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();
                this.globalProcedure.datLaundry = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procSelectAllCustomerName";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                this.globalProcedure.sqlLaundryAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datLaundry.Clear();
                this.globalProcedure.sqlLaundryAdapter.Fill(this.globalProcedure.datLaundry);

                int totalRecords = globalProcedure.datLaundry.Rows.Count;

                customerFullnames = new string[totalRecords];
                this.customerFullnames = new HashSet<string>();

                if (globalProcedure.datLaundry.Rows.Count > 0)
                {
                    DataTable dataTable = globalProcedure.datLaundry;
                    int row = 0;



                    while (!(totalRecords - 1 < row))
                    {
                        //this.GridStaffs.Rows[row].Cells[0].Value = dataTable.Rows[row]["id"].ToString();
                        customerFullnames[row] = dataTable.Rows[row]["fullname"].ToString();
                        this.customerFullnames.Add(dataTable.Rows[row]["fullname"].ToString());
                        row++;
                    }

                }
                else
                {
                    //MessageBox.Show("Record not found!");
                }

                this.TbCustomerName.AutoCompleteCustomSource.Clear();
                this.TbCustomerName.AutoCompleteCustomSource.AddRange(customerFullnames);
                this.globalProcedure.sqlLaundryAdapter.Dispose();
                this.globalProcedure.datLaundry.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TbCustomerName_TextChanged(object sender, EventArgs e)
        {

            this.v_customerName = TbCustomerName.Text;
            DisplayCustomerDetails(v_customerName);
            DisplayAmount();
        }

        public void DisplayCustomerDetails(string fullname)
        {
            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();
                this.globalProcedure.datLaundry = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procSelectCustomerByFullname";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_fullname", fullname);
                this.globalProcedure.sqlLaundryAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datLaundry.Clear();
                this.globalProcedure.sqlLaundryAdapter.Fill(this.globalProcedure.datLaundry);

                int totalRecords = globalProcedure.datLaundry.Rows.Count;
                DataTable dataTable = globalProcedure.datLaundry;

                if (globalProcedure.datLaundry.Rows.Count > 0)
                {
                    int row = 0;
                    string picLoc;

                    while (!(totalRecords - 1 < row))
                    {
                        //this.GridStaffs.Rows[row].Cells[0].Value = dataTable.Rows[row]["id"].ToString();
                        //customerFullnames[row] = dataTable.Rows[row]["fullname"].ToString();
                        this.TbBirthdate.Text = dataTable.Rows[row]["birthdate"].ToString();
                        this.TbGender.Text = dataTable.Rows[row]["gender"].ToString();
                        this.TbAddress.Text = dataTable.Rows[row]["address"].ToString();
                        this.TbEmail.Text = dataTable.Rows[row]["emailadd"].ToString();

                        picLoc = dataTable.Rows[row]["cust_photo"].ToString();

                        try
                        {
                            this.PicCustomer.Image = new Bitmap(picLoc);

                        }
                        catch (Exception ex)
                        {
                            ClearCustomerPhoto();
                        }

                        row++;
                    }

                }
                else
                {
                    this.TbBirthdate.Text = String.Empty;
                    this.TbGender.Text = String.Empty;
                    this.TbAddress.Text = String.Empty;
                    this.TbEmail.Text = String.Empty;
                    ClearCustomerPhoto();
                }

                this.globalProcedure.sqlLaundryAdapter.Dispose();
                this.globalProcedure.datLaundry.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeCmbServiceType()
        {

            string[] serviceTypes;

            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();
                this.globalProcedure.datLaundry = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procGetServiceTypes";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                this.globalProcedure.sqlLaundryAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datLaundry.Clear();
                this.globalProcedure.sqlLaundryAdapter.Fill(this.globalProcedure.datLaundry);

                int totalRecords = globalProcedure.datLaundry.Rows.Count;
                DataTable dataTable = globalProcedure.datLaundry;

                serviceTypes = new string[totalRecords];


                if (globalProcedure.datLaundry.Rows.Count > 0)
                {
                    int row = 0;

                    while (!(totalRecords - 1 < row))
                    {

                        //this.TbBirthdate.Text = dataTable.Rows[row]["birthdate"].ToString();
                        serviceTypes[row] = dataTable.Rows[row]["service_type"].ToString();

                        row++;
                    }

                }

                this.globalProcedure.sqlLaundryAdapter.Dispose();
                this.globalProcedure.datLaundry.Dispose();
                this.CmbServiceType.DataSource = serviceTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ang cmbservices sa form service");
            }

        }

        public void InitializeCmbGamentType()
        {

            string[] garmentTypes;

            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();
                this.globalProcedure.datLaundry = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procGetGarmentTypes";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                this.globalProcedure.sqlLaundryAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datLaundry.Clear();
                this.globalProcedure.sqlLaundryAdapter.Fill(this.globalProcedure.datLaundry);

                int totalRecords = globalProcedure.datLaundry.Rows.Count;
                DataTable dataTable = globalProcedure.datLaundry;

                garmentTypes = new string[totalRecords];


                if (globalProcedure.datLaundry.Rows.Count > 0)
                {
                    int row = 0;

                    while (!(totalRecords - 1 < row))
                    {

                        //this.TbBirthdate.Text = dataTable.Rows[row]["birthdate"].ToString();
                        garmentTypes[row] = dataTable.Rows[row]["garment_type"].ToString();

                        row++;
                    }

                }

                this.globalProcedure.sqlLaundryAdapter.Dispose();
                this.globalProcedure.datLaundry.Dispose();
                this.CmbGarmentType.DataSource = garmentTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ang cmbgarments sa form service");
                MessageBox.Show(ex.Message);
            }

        }

        private void TbWeight_TextChanged(object sender, EventArgs e)
        {
            this.v_weight = double.Parse(TbWeight.Text);
            DisplayAmount();
        }

        private void TbQty_TextChanged(object sender, EventArgs e)
        {
            this.v_quantity = int.Parse(TbQty.Text);
            DisplayAmount();
        }

        private double GetServicePrice(string service)
        {

            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlLaundryAdapter = new MySqlDataAdapter();
                this.globalProcedure.datLaundry = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procGetServicePrice";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_service_type", service);
                this.globalProcedure.sqlLaundryAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datLaundry.Clear();
                this.globalProcedure.sqlLaundryAdapter.Fill(this.globalProcedure.datLaundry);

                int totalRecords = globalProcedure.datLaundry.Rows.Count;
                DataTable dataTable = globalProcedure.datLaundry;


                if (globalProcedure.datLaundry.Rows.Count > 0)
                {
                    int row = 0;

                    return double.Parse(dataTable.Rows[row]["price"].ToString());

                }

                this.globalProcedure.sqlLaundryAdapter.Dispose();
                this.globalProcedure.datLaundry.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ang getserviceprice sa form service");
                MessageBox.Show(ex.Message);
            }

            return -1;
        }

        private void DisplayAmount()
        {
            if (v_price <= 0 || v_weight <= 0) return;

            this.v_amount = v_price * v_weight;

            this.TbAmount.Text = v_amount.ToString();
        }

        private void CmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.v_serviceType = CmbServiceType.Text;

            this.v_price = GetServicePrice(v_serviceType);
            DisplayAmount();
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
