using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration; 

namespace sadafAccounting
{
    public partial class frmCustomer : Form
    {
        string sConnection = ConfigurationManager.ConnectionStrings["sadaf"].ConnectionString;
        SqlConnection conSadaf; 
        public frmCustomer()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsCustomers.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dtsCustomers.customer);

            conSadaf = new SqlConnection(sConnection);
            auto();
            btnSChange.Enabled = false;
        }

        private void auto()
        {
            SqlCommand cmdID = new SqlCommand("select Max(customerID) from customer", conSadaf); 
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open();
            string prvID;
            int tempID = 0;
            prvID = cmdID.ExecuteScalar().ToString();
            conSadaf.Close();
            if (prvID == string.Empty)
                tempID = 0;
            else
                tempID = int.Parse(prvID);
            int customerID = tempID + 1;
            textBoxID.Text = customerID.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ID = textBoxID.Text;
            string fullName = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string province = textBoxProvince.Text;

            if (fullName == string.Empty)
            {
                MessageBox.Show("اشتباه در وارد نمودن اطلاعات, دوباره چک کنید");
                return;
            }

            SqlCommand cmdSave = new SqlCommand();
            cmdSave.CommandText = "insert customer values (@customerID, @fullName, @phone, @province)";
            cmdSave.Connection = conSadaf; 
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open();
            cmdSave.Parameters.AddWithValue("@customerID", ID);
            cmdSave.Parameters.AddWithValue("fullName", fullName);
            cmdSave.Parameters.AddWithValue("@phone", phone);
            cmdSave.Parameters.AddWithValue("@province", province);
            cmdSave.ExecuteNonQuery();
            conSadaf.Close();

            auto();
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxProvince.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyWord= textBoxSearch.Text;
            SqlDataAdapter daSrc = new SqlDataAdapter(); 
            SqlCommand cmdSrc = new SqlCommand();
            cmdSrc.CommandText = string.Format(@"select customer.customerID, customer.fullName,customer.phone,customer.province
from customer where fullName Like N'%{0}%'", keyWord);
            cmdSrc.Connection = conSadaf;
            daSrc.SelectCommand = cmdSrc;
            DataTable dtSrc = new DataTable();
            daSrc.Fill(dtSrc);
            dataGridViewCustomer.AutoGenerateColumns = false;
            dataGridViewCustomer.DataSource = dtSrc; 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = this.dtsCustomers.customer; 
            textBoxSearch.Clear();
        }

        private void btnSChange_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridViewCustomer.Rows)
            {
                string id = dr.Cells[0].Value.ToString();
                string fullName = dr.Cells[1].Value.ToString();
                string phone = dr.Cells[2].Value.ToString();
                string province = dr.Cells[3].Value.ToString();

                SqlCommand cmdSave = new SqlCommand();
                cmdSave.CommandText = "update customer set fullName = @fullName, phone = @phone, province = @province where customerID = @id";
                cmdSave.Parameters.AddWithValue("@fullName", fullName);
                cmdSave.Parameters.AddWithValue("@phone", phone);
                cmdSave.Parameters.AddWithValue("@province", province);
                cmdSave.Parameters.AddWithValue("@id", id);
                cmdSave.Connection = conSadaf;
                if (conSadaf.State != ConnectionState.Open)
                    conSadaf.Open();
                cmdSave.ExecuteNonQuery();
                conSadaf.Close();
            }
            btnSChange.Enabled = false; 
        }

        private void dataGridViewCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSChange.Enabled = true; 
        }
    }
}
