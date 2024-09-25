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
    public partial class FormDashboard : Form
    {
        
        private FormService formService = new FormService();
        private FormLaundries formLaundries = new FormLaundries();
        private FormCustomers formCustomers = new FormCustomers();
        private FormStaffs formStaffs = new FormStaffs();

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            formStaffs.ShowDialog();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            formCustomers.ShowDialog();
        }

        private void BtnLaundry_Click(object sender, EventArgs e)
        {
            formLaundries.ShowDialog();
        }

        private void BtnService_Click(object sender, EventArgs e)
        {
            formService.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
