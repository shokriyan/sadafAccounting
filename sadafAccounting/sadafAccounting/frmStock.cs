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
    public partial class frmStock : Form
    {
        string sConnection = ConfigurationManager.ConnectionStrings["sadaf"].ConnectionString;
        SqlConnection conSadaf;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            if (keyData == Keys.Enter)
                searchResult(); 
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public frmStock()
        {
            InitializeComponent();
        }
        
        public void stockList()
        {
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand();
            cmdList.CommandText = @"select stock.productID, category.category, stock.productName, stock.description, stock.unit, stock.stockQty
from stock
inner join category on stock.category = category.categoryID";
            cmdList.Connection = conSadaf; 
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);

            dataGridViewStock.AutoGenerateColumns = false;
            dataGridViewStock.DataSource = dtList; 
        }
        private void frmStock_Load(object sender, EventArgs e)
        {
            conSadaf = new SqlConnection(sConnection);
            this.WindowState = FormWindowState.Maximized;
            fillComboCat();
            stockList();
            dataGridViewStock.ContextMenuStrip = contextMenuStripRhtClick; 
        }

        public void fillComboCat()
        {
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand("select * from category", conSadaf);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);
            dtList.Rows.Add("-1", "همه موارد"); 
            comboBoxCategory.ValueMember = "categoryID";
            comboBoxCategory.DisplayMember = "category";
            comboBoxCategory.DataSource = dtList;
            comboBoxCategory.SelectedValue = "-1";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBoxCategory.SelectedValue = "-1";
            textBoxProduct.Clear();
            stockList();
        }
        public void searchResult()
        {
            int category = int.Parse(comboBoxCategory.SelectedValue.ToString());
            string prdName = textBoxProduct.Text;
            string query = "";

            if (category == -1 & prdName == string.Empty)
            {
                stockList();
            }
            else if (category == -1 & prdName != string.Empty)
            {
                query = string.Format(@"select stock.productID, category.category, stock.productName, stock.description, stock.unit, stock.stockQty
from stock
inner join category on stock.category = category.categoryID
where stock.productName like N'%{0}%'", prdName);
                SqlDataAdapter daResult = new SqlDataAdapter();
                SqlCommand cmdResult = new SqlCommand(query, conSadaf);
                daResult.SelectCommand = cmdResult;
                DataTable dtResult = new DataTable();
                daResult.Fill(dtResult);
                dataGridViewStock.AutoGenerateColumns = false;
                dataGridViewStock.DataSource = dtResult;
            }
            else
            {
                query = string.Format(@"select stock.productID, category.category, stock.productName, stock.description, stock.unit, stock.stockQty
from stock
inner join category on stock.category = category.categoryID
where stock.productName like N'%{0}%' and category.categoryID=@catID", prdName);
                SqlDataAdapter daResult = new SqlDataAdapter();
                SqlCommand cmdResult = new SqlCommand(query, conSadaf);
                cmdResult.Parameters.AddWithValue("@catID", category);
                daResult.SelectCommand = cmdResult;
                DataTable dtResult = new DataTable();
                daResult.Fill(dtResult);
                dataGridViewStock.AutoGenerateColumns = false;
                dataGridViewStock.DataSource = dtResult; 
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchResult();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewStock.SelectedCells.Count > 0)
            {
                int selectedCell = dataGridViewStock.SelectedCells[0].RowIndex;
                string productID = dataGridViewStock[0, selectedCell].Value.ToString();
                frmHistory fHistory = new frmHistory();
                fHistory.prdID = productID;
                fHistory.ShowDialog();
                stockList(); 
            }
        }
    }
}
