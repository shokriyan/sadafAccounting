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
    public partial class frmHistory : Form
    {
        string sConnection = ConfigurationManager.ConnectionStrings["sadaf"].ConnectionString;
        SqlConnection conSadaf; 
        public frmHistory()
        {
            InitializeComponent();
        }

        public string prdID { set; get; }

        public void historylist()
        {
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand();
            cmdList.CommandText = @"select import.importID, product.productName, import.date,staffs.fullName, import.quantity
from import 
inner join product on import.productID = product.productID
inner join staffs on import.staff = staffs.staffID 
where import.productID = @prdID";
            cmdList.Connection = conSadaf;
            cmdList.Parameters.AddWithValue("@prdID", prdID);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);
            dataGridViewHistory.AutoGenerateColumns = false;
            dataGridViewHistory.DataSource = dtList; 
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            conSadaf = new SqlConnection(sConnection);
            historylist();
            StaffList();
            comboBoxStaff.SelectedValue = "-1";
            textBoxCount.Enabled = false;
            calculateQty();
        }
        public void StaffList()
        {
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand("select staffID, fullName from staffs", conSadaf);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);
            dtList.Rows.Add("-1", "تمام کارمندان");
            comboBoxStaff.ValueMember = "staffID";
            comboBoxStaff.DisplayMember = "fullName";
            comboBoxStaff.DataSource = dtList; 
        }

        public void search()
        {
            int staffID = int.Parse(comboBoxStaff.SelectedValue.ToString());
            string sDate = persianDateTimeStart.Value;
            string fDate = persianDateTimeFinish.Value;
            string query = "";
            if (staffID == -1)
            {
                query = @"select import.importID, product.productName, import.date,staffs.fullName, import.quantity
from import 
inner join product on import.productID = product.productID
inner join staffs on import.staff = staffs.staffID 
where import.productID = @prdID and import.date > @sDate and import.date < @fDate";
                SqlDataAdapter daResult = new SqlDataAdapter();
                SqlCommand cmdResult = new SqlCommand(query, conSadaf);
                cmdResult.Parameters.AddWithValue("@prdID", prdID);
                cmdResult.Parameters.AddWithValue("@sDate", sDate);
                cmdResult.Parameters.AddWithValue("@fDate", fDate);
                daResult.SelectCommand = cmdResult;
                DataTable dtResult = new DataTable();
                daResult.Fill(dtResult);
                dataGridViewHistory.AutoGenerateColumns = false;
                dataGridViewHistory.DataSource = dtResult;
            }
            else
            {
                query = @"select import.importID, product.productName, import.date,staffs.fullName, import.quantity
from import 
inner join product on import.productID = product.productID
inner join staffs on import.staff = staffs.staffID 
where import.productID = @prdID and import.staff = @staff and import.date > @sDate and import.date < @fDate";
                SqlDataAdapter daResult = new SqlDataAdapter();
                SqlCommand cmdResult = new SqlCommand(query, conSadaf);
                cmdResult.Parameters.AddWithValue("@prdID", prdID);
                cmdResult.Parameters.AddWithValue("@staff", staffID);
                cmdResult.Parameters.AddWithValue("@sDate", sDate);
                cmdResult.Parameters.AddWithValue("@fDate", fDate);
                daResult.SelectCommand = cmdResult;
                DataTable dtResult = new DataTable();
                daResult.Fill(dtResult);
                dataGridViewHistory.AutoGenerateColumns = false;
                dataGridViewHistory.DataSource = dtResult;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
            calculateQty();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            historylist();
            calculateQty();
        }
        public void calculateQty()
        {
            float result = 0;
            foreach (DataGridViewRow dr in dataGridViewHistory.Rows)
            {
                float lineQty = float.Parse(dr.Cells[4].Value.ToString());
                result += lineQty; 
            }
            textBoxCount.Text = result.ToString();
        }

        private void btnSChange_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridViewHistory.Rows)
            {
                int impID = int.Parse(dr.Cells[0].Value.ToString());
                float impQty = float.Parse(dr.Cells[4].Value.ToString());

                SqlCommand cmdUpdate = new SqlCommand("update import set quantity = @qty where importID = @impID", conSadaf);
                cmdUpdate.Parameters.AddWithValue("@qty", impQty);
                cmdUpdate.Parameters.AddWithValue("@impID", impID);

                if (conSadaf.State != ConnectionState.Open)
                    conSadaf.Open();
                cmdUpdate.ExecuteNonQuery();

                SqlCommand cmdSumQty = new SqlCommand("select sum(quantity) from import where productID = @productID", conSadaf);
                cmdSumQty.Parameters.AddWithValue("@productID", prdID);
                float stockQty = float.Parse(cmdSumQty.ExecuteScalar().ToString());

                SqlCommand cmdSUpdate = new SqlCommand("update stock set stockQty = @stockQty where productID = @productID", conSadaf);
                cmdSUpdate.Parameters.AddWithValue("@stockQty", stockQty);
                cmdSUpdate.Parameters.AddWithValue("@productID", prdID);

                cmdSUpdate.ExecuteNonQuery();
                calculateQty(); 
            }
        }
    }
}
