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
    public partial class frmImport : Form
    {
        string sConnection = ConfigurationManager.ConnectionStrings["sadaf"].ConnectionString;
        SqlConnection conSadaf;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public frmImport()
        {
            InitializeComponent();
        }

        public void productList()
        {
            int catID = int.Parse(comboBoxCat.SelectedValue.ToString()); 
            SqlDataAdapter daList = new SqlDataAdapter(); 
            SqlCommand cmdList = new SqlCommand(); 
            cmdList.Connection = conSadaf;
            if (catID == -1)
            {
                cmdList.CommandText = "select productID, productName + ' - ' + measureUnit as product from product where inventoryPart = 1";
            }
            else
            {
                cmdList.CommandText = "select productID, productName + ' - ' + measureUnit as product from product  where category = @catID and inventoryPart = 1";
                cmdList.Parameters.AddWithValue("@catID", catID);
            }
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);

            comboBoxProduct.DataSource = dtList;
            comboBoxProduct.ValueMember = "productID";
            comboBoxProduct.DisplayMember = "product";

        }

        public void catList()
        {
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand("select * from category", conSadaf);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);
            dtList.Rows.Add("-1", "همه موارد");
            comboBoxCat.ValueMember = "categoryID";
            comboBoxCat.DisplayMember = "category";
            comboBoxCat.DataSource = dtList;
            comboBoxCat.SelectedValue = "-1";
        }
        private void frmImport_Load(object sender, EventArgs e)
        {
            conSadaf = new SqlConnection(sConnection);
            catList();
            autoID();
            staffList();
        }

        public void autoID()
        {
            SqlCommand cmdID = new SqlCommand("select MAX(importID) from Import", conSadaf);
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open();
            string prvID;
            int tempIP;
            prvID = cmdID.ExecuteScalar().ToString();
            if (prvID == string.Empty)
                tempIP = 0;
            else
                tempIP = int.Parse(prvID.ToString());
            int result = tempIP + 1;
            textBoxCode.Text = result.ToString(); 
        }
        private void comboBoxCat_SelectedValueChanged(object sender, EventArgs e)
        {
            productList();
        }
        public void staffList()
        {
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand("select staffID, fullName from staffs", conSadaf);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);

            comboBoxStaff.DataSource = dtList;
            comboBoxStaff.ValueMember = "staffID";
            comboBoxStaff.DisplayMember = "fullName"; 
        }

        public void dgvAdd()
        {
            int importID = int.Parse(textBoxCode.Text.ToString());
            int productID = int.Parse(comboBoxProduct.SelectedValue.ToString());
            string product = comboBoxProduct.Text;
            string date = persianDateTimePickerImport.Value.ToString();
            int staffID = int.Parse(comboBoxStaff.SelectedValue.ToString());
            string staff = comboBoxStaff.Text;
            if (textBoxQty.Text == string.Empty)
                return;
            else
            {
                float importQty = float.Parse(textBoxQty.Text.ToString());
                foreach (DataGridViewRow dr in dataGridViewList.Rows)
                {
                    int checkPID = int.Parse(dr.Cells[1].Value.ToString());

                    if (checkPID == productID)
                    {
                        MessageBox.Show("آیتم وارد شده تکراری می باشد");
                        return;
                    }
                }

                dataGridViewList.Rows.Add(importID, productID, product, date, staffID, staff, importQty);
                textBoxQty.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvAdd();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridViewList.Rows)
            {
                int importID = int.Parse(dr.Cells[0].Value.ToString());
                int productID = int.Parse(dr.Cells[1].Value.ToString());
                string date = dr.Cells[3].Value.ToString();
                int staffID = int.Parse(dr.Cells[4].Value.ToString());
                float importQty = float.Parse(dr.Cells[6].Value.ToString());
                SqlCommand cmdsave = new SqlCommand();
                cmdsave.Connection = conSadaf;
                cmdsave.CommandText = "insert import values (@importID, @productID, @date, @staffID, @impQty)";
                cmdsave.Parameters.AddWithValue("@importID", importID);
                cmdsave.Parameters.AddWithValue("@productID", productID);
                cmdsave.Parameters.AddWithValue("@date", date);
                cmdsave.Parameters.AddWithValue("@staffID", staffID);
                cmdsave.Parameters.AddWithValue("@impQty", importQty);

                if (conSadaf.State != ConnectionState.Open)
                    conSadaf.Open();
                cmdsave.ExecuteNonQuery();

                SqlCommand cmdSumQty = new SqlCommand("select sum(quantity) from import where productID = @productID", conSadaf);
                cmdSumQty.Parameters.AddWithValue("@productID", productID); 
                float stockQty = float.Parse(cmdSumQty.ExecuteScalar().ToString());

                SqlCommand cmdUpdate = new SqlCommand("update stock set stockQty = @stockQty where productID = @productID", conSadaf);
                cmdUpdate.Parameters.AddWithValue("@stockQty", stockQty);
                cmdUpdate.Parameters.AddWithValue("@productID", productID);

                cmdUpdate.ExecuteNonQuery();

                conSadaf.Close();
            }

            dataGridViewList.Rows.Clear();
            autoID(); 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            catList();
            staffList();
            productList();
        }
    }
}
