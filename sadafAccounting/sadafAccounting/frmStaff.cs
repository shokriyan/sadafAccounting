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
    public partial class frmStaff : Form
    {
        string sConnection = ConfigurationManager.ConnectionStrings["sadaf"].ConnectionString;
        SqlConnection conSadaf; 
        public frmStaff()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void autoID()
        {
            SqlCommand cmdAuto = new SqlCommand("select Max(staffID) from staffs", conSadaf);
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open();
            string prevID;
            int tempID = 0 ; 
            prevID = cmdAuto.ExecuteScalar().ToString();
            if (prevID == string.Empty)
                tempID = 0;
            else
                tempID = int.Parse(prevID);
            int staffID = tempID + 1; 
            textBoxCode.Text = staffID.ToString();

        }
        public void staffSave()
        {
            string staffID = textBoxCode.Text;
            string fullName = textBoxName.Text;
            string position = textBoxPosition.Text;
            string hDate = persianDateHire.Value.ToString();
            string bSalary = textBoxSalary.Text;
            string currency = comboBoxCurrency.Text;
            string status = comboBoxStatus.Text;

            SqlCommand cmdSave = new SqlCommand();
            cmdSave.Connection = conSadaf;
            cmdSave.CommandText = "insert staffs values (@staffID, @fullName, @position, @hDate, @bSalary, @currency, @status)";
            cmdSave.Parameters.AddWithValue("@staffID", staffID);
            cmdSave.Parameters.AddWithValue("@fullName", fullName);
            cmdSave.Parameters.AddWithValue("@position", position);
            cmdSave.Parameters.AddWithValue("@hDate", hDate);
            cmdSave.Parameters.AddWithValue("@bSalary", bSalary);
            cmdSave.Parameters.AddWithValue("@currency", currency);
            cmdSave.Parameters.AddWithValue("@status", status);
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open();
            cmdSave.ExecuteNonQuery();

            textBoxCode.Clear();
            textBoxName.Clear();
            textBoxPosition.Clear();
            textBoxSalary.Clear();

            autoID(); 
        }

        public void staffList()
        {
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand("select * from staffs", conSadaf);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);
            dataGridViewList.AutoGenerateColumns = false;
            dataGridViewList.DataSource = dtList;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            conSadaf = new SqlConnection(sConnection);
            autoID();
            staffList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staffSave();
            staffList();
        }

        private void btnSClose_Click(object sender, EventArgs e)
        {
            staffSave();
            this.Close();
        }
    }
}
