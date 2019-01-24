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
    public partial class frmProducts : Form
    {
        string sConnection = ConfigurationManager.ConnectionStrings["sadaf"].ConnectionString;
        SqlConnection conSadaf;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            conSadaf = new SqlConnection(sConnection);
            btnAddCat.Enabled = false;
            btnSchange.Enabled = false; 
            prdList();
            comboCategory();
            autoID();
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            btnAddCat.Enabled = true; 
        }
        public void comboCategory()
        {
            SqlDataAdapter daCombo = new SqlDataAdapter();
            SqlCommand cmdCombo = new SqlCommand("Select * from category", conSadaf);
            daCombo.SelectCommand = cmdCombo;
            DataTable dtCombo = new DataTable();
            daCombo.Fill(dtCombo);

            btnDelete.DataSource = dtCombo;
            btnDelete.ValueMember = "categoryID";
            btnDelete.DisplayMember = "category"; 
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            string category = textBoxCategory.Text;

            SqlCommand cmdSave = new SqlCommand();
            cmdSave.CommandText = "insert category values (@category)";
            cmdSave.Connection = conSadaf; 
            cmdSave.Parameters.AddWithValue("@category", category);
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open();
            cmdSave.ExecuteNonQuery();
            conSadaf.Close();
            comboCategory();
            textBoxCategory.Clear();
        }

        public void autoID()
        {
            SqlCommand cmdID = new SqlCommand("select MAX(productID) from product", conSadaf);
            cmdID.Connection = conSadaf;
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
            int productID = tempID + 1;
            textBoxCode.Text = productID.ToString();
        }
        public void saveProduct()
        {
            bool inventoryPart = false;
            if (checkBoxInventory.Checked == true)
                inventoryPart = true;
            else
                inventoryPart = false;
            int productID = int.Parse(textBoxCode.Text.ToString());
            int category = int.Parse(btnDelete.SelectedValue.ToString());
            string product = textBoxProduct.Text;
            string desc = textBoxDesc.Text;
            string mu = textBoxMU.Text;
            if (product == string.Empty)
            {
                MessageBox.Show("اشتباه در وارد کردن اطلاعات دوباره چک نمایید");
                return;
            }
            else
            {
                SqlCommand cmdSave = new SqlCommand();
                cmdSave.Connection = conSadaf;
                cmdSave.CommandText = "insert product values (@productID,@category,@product,@description,@mUnit,@inventory)";
                cmdSave.Parameters.AddWithValue("@productID", productID);
                cmdSave.Parameters.AddWithValue("@category", category);
                cmdSave.Parameters.AddWithValue("@product", product);
                cmdSave.Parameters.AddWithValue("@description", desc);
                cmdSave.Parameters.AddWithValue("@mUnit", mu);
                cmdSave.Parameters.AddWithValue("@inventory", inventoryPart);
                if (conSadaf.State != ConnectionState.Open)
                    conSadaf.Open();
                cmdSave.ExecuteNonQuery();

                if (inventoryPart == true)
                {
                    SqlCommand cmdStock = new SqlCommand();
                    cmdStock.Connection = conSadaf;
                    cmdStock.CommandText = "insert stock values (@prID, @cat, @product, @desc, @mu, @stockQty)";
                    cmdStock.Parameters.AddWithValue("@prID", productID);
                    cmdStock.Parameters.AddWithValue("@cat", category);
                    cmdStock.Parameters.AddWithValue("@product", product);
                    cmdStock.Parameters.AddWithValue("@desc", desc);
                    cmdStock.Parameters.AddWithValue("@mu", mu);
                    cmdStock.Parameters.AddWithValue("@stockQty", 0);
                    cmdStock.ExecuteNonQuery();
                }

                conSadaf.Close();

                textBoxProduct.Clear();
                textBoxDesc.Clear();
                textBoxMU.Clear();
                autoID();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveProduct();
        }

        private void btnSclose_Click(object sender, EventArgs e)
        {
            saveProduct();
            this.Close();
        }

        private void comboBoxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = btnDelete.Text;

            if (type == "خدمات")
                checkBoxInventory.Checked = false;
            else
                checkBoxInventory.Checked = true; 
        }
        public void prdList()
        {
            string query = @"select product.productID, category.category, product.productName, product.description, product.measureUnit, inventory = case
when product.inventoryPart = 0 then N'خیر'
when product.inventoryPart = 1 then N'بلی'
end
from product
inner join category on product.category = category.categoryID";
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand(query, conSadaf);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);
            dataGridViewPrdList.AutoGenerateColumns = false;
            dataGridViewPrdList.DataSource = dtList;
        }

        private void dataGridViewPrdList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSchange.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyWord = textBoxSearch.Text;
            string query = string.Format(@"select product.productID, category.category, product.productName, product.description, product.measureUnit, inventory = case
when product.inventoryPart = 0 then N'خیر'
when product.inventoryPart = 1 then N'بلی'
end
from product
inner join category on product.category = category.categoryID
where product.productName Like N'%{0}%'",keyWord);
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand(query, conSadaf);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);
            dataGridViewPrdList.AutoGenerateColumns = false;
            dataGridViewPrdList.DataSource = dtList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            prdList();
            comboCategory();
        }

        private void btnSchange_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridViewPrdList.Rows)
            {
                int prdCode = int.Parse(dr.Cells[0].Value.ToString()); 
                string productName = dr.Cells[2].Value.ToString();
                string description = dr.Cells[3].Value.ToString();
                string mUnit = dr.Cells[4].Value.ToString();
                bool inventory = false;

                string invItem = dr.Cells[5].Value.ToString();
                if (invItem == "خیر")
                    inventory = false;
                else
                    inventory = true;
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.CommandText = "update product set productName = @prdname , description = @description, measureUnit = @mUnit , inventoryPart = @inventory where productID = @prdCode";
                cmdUpdate.Connection = conSadaf;
                cmdUpdate.Parameters.AddWithValue("@prdname", productName);
                cmdUpdate.Parameters.AddWithValue("@description", description);
                cmdUpdate.Parameters.AddWithValue("@mUnit", mUnit);
                cmdUpdate.Parameters.AddWithValue("@inventory", inventory);
                cmdUpdate.Parameters.AddWithValue("@prdCode", prdCode);
                if (conSadaf.State != ConnectionState.Open)
                    conSadaf.Open();
                cmdUpdate.ExecuteNonQuery();
                conSadaf.Close();
                SqlCommand cmdUStock = new SqlCommand();
                cmdUStock.CommandText = "update stock set productName = @prdname , description = @description, unit = @mUnit where productID = @prdCode";
                cmdUStock.Connection = conSadaf;
                cmdUStock.Parameters.AddWithValue("@prdname", productName);
                cmdUStock.Parameters.AddWithValue("@description", description);
                cmdUStock.Parameters.AddWithValue("@mUnit", mUnit);
                cmdUStock.Parameters.AddWithValue("@inventory", inventory);
                cmdUStock.Parameters.AddWithValue("@prdCode", prdCode);
                if (conSadaf.State != ConnectionState.Open)
                    conSadaf.Open(); 
                cmdUStock.ExecuteNonQuery();
                conSadaf.Close();
            }
        }
    }
}
