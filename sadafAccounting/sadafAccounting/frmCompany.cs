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
    public partial class frmCompany : Form
    {
        string sConnection = ConfigurationManager.ConnectionStrings["sadaf"].ConnectionString;
        SqlConnection conSadaf; 

        public frmCompany()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
           return base.ProcessCmdKey(ref msg, keyData);
        }

        public void loadCompany()
        {
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand("select * from company", conSadaf);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);
            if (dtList.Rows.Count > 0)
            {
                textBoxCompany.Text = dtList.Rows[0][1].ToString();
                textBoxType.Text = dtList.Rows[0][2].ToString();
                textBoxPhone.Text = dtList.Rows[0][3].ToString();
                textBoxMail.Text = dtList.Rows[0][4].ToString(); 
                textBoxAddress.Text = dtList.Rows[0][5].ToString();
                textBoxCity.Text = dtList.Rows[0][6].ToString();
                textBoxProvince.Text = dtList.Rows[0][7].ToString();
                cmbCurrency.SelectedItem= dtList.Rows[0][8].ToString();
                btnSave.Enabled = false;
                btnChanges.Enabled = true;
                textBoxCompany.Enabled = false;
            }
            else
                return; 
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            conSadaf = new SqlConnection(sConnection);
            btnChanges.Enabled = false;
            loadCompany();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string company = textBoxCompany.Text;
            string type = textBoxType.Text;
            string phone = textBoxPhone.Text;
            string mail = textBoxMail.Text; 
            string address = textBoxAddress.Text;
            string city = textBoxCity.Text;
            string province = textBoxProvince.Text;
            string currency = cmbCurrency.Text.ToString(); 

            SqlCommand cmdSave = new SqlCommand();
            cmdSave.Connection = conSadaf;
            cmdSave.CommandText = "insert company values (@company,@type,@phone,@mail,@address,@city,@province,@currency)";
            cmdSave.Parameters.AddWithValue("@company", company);
            cmdSave.Parameters.AddWithValue("@type", type);
            cmdSave.Parameters.AddWithValue("@phone", phone);
            cmdSave.Parameters.AddWithValue("@mail", mail);
            cmdSave.Parameters.AddWithValue("@address", address);
            cmdSave.Parameters.AddWithValue("@city", city);
            cmdSave.Parameters.AddWithValue("@province", province);
            cmdSave.Parameters.AddWithValue("@currency", currency); 
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open();
            cmdSave.ExecuteNonQuery();
            conSadaf.Close();
        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
            string company = textBoxCompany.Text;
            string type = textBoxType.Text;
            string phone = textBoxPhone.Text;
            string mail = textBoxMail.Text;
            string address = textBoxAddress.Text;
            string city = textBoxCity.Text;
            string province = textBoxProvince.Text;
            string currency = cmbCurrency.Text.ToString(); 

            SqlCommand cmdSave = new SqlCommand();
            cmdSave.Connection = conSadaf;
            cmdSave.CommandText = @"update company set companyType = @type, phone = @phone, email = @mail , address = @address, city = @city, province = @province, currency=@currency where companyName = @company";
            cmdSave.Parameters.AddWithValue("@type", type);
            cmdSave.Parameters.AddWithValue("@phone", phone);
            cmdSave.Parameters.AddWithValue("@mail", mail);
            cmdSave.Parameters.AddWithValue("@address", address);
            cmdSave.Parameters.AddWithValue("@city", city);
            cmdSave.Parameters.AddWithValue("@province", province);
            cmdSave.Parameters.AddWithValue("@currency", currency);
            cmdSave.Parameters.AddWithValue("@company", company);
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open();
            cmdSave.ExecuteNonQuery();
            conSadaf.Close();
        }
    }
}
