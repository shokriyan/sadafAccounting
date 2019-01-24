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
    public partial class frmAcc : Form
    {
        string sConnection = ConfigurationManager.ConnectionStrings["Sadaf"].ConnectionString;
        SqlConnection conSadaf;
        public frmAcc()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            if (keyData == Keys.Enter)
                saveAcc();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void accList()
        {
            SqlDataAdapter daList = new SqlDataAdapter();
            SqlCommand cmdList = new SqlCommand("select * from accounts", conSadaf);
            daList.SelectCommand = cmdList;
            DataTable dtList = new DataTable();
            daList.Fill(dtList);
            dataGridViewAccounts.AutoGenerateColumns = false;
            dataGridViewAccounts.DataSource = dtList; 
        }

        private void accounts_Load(object sender, EventArgs e)
        {
            conSadaf = new SqlConnection(sConnection);
            accList(); 
        }
        public void saveAcc()
        {
            if (txtAccID.Text == string.Empty)
                MessageBox.Show("خطا شماره 9100019 \n خطا در وارد کردن اطلاعات دوباره چک کنید");
            else if (txtAccName.Text == string.Empty)
                MessageBox.Show("خطا شماره 9100019 \n خطا در وارد کردن اطلاعات دوباره چک کنید");
            else
            {
                string accID = txtAccID.Text;
                string accName = txtAccName.Text;

                SqlCommand cmdSave = new SqlCommand();
                cmdSave.Connection = conSadaf;
                cmdSave.CommandText = "insert accounts values (@accID,@accName) ";
                cmdSave.Parameters.AddWithValue("@accID", accID);
                cmdSave.Parameters.AddWithValue("@accName", accName);
                if (conSadaf.State != ConnectionState.Open)
                    conSadaf.Open();
                cmdSave.ExecuteNonQuery();

                txtAccID.Clear();
                txtAccName.Clear();

                accList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveAcc();
        }

    }
}
