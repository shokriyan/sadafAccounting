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
    public partial class frmSale : Form
    {
        string sConnection = ConfigurationManager.ConnectionStrings["sadaf"].ConnectionString;
        SqlConnection conSadaf;
        public frmSale()
        {
            InitializeComponent();
        }

        public void invNumber()
        {
            int invNumber;

            SqlCommand cmdNumber = new SqlCommand("select MAX(invNo) from invoice", conSadaf);
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open();
            string number = cmdNumber.ExecuteScalar().ToString();
            if (number != null)
                invNumber = 0;
            else
                invNumber = int.Parse(number.ToString());

            int numberNew = invNumber + 1;
            txtInvoiceNo.Text = numberNew.ToString();

        }
        string currency; 
        public void currencySelect()
        {
            SqlCommand cmdList = new SqlCommand("select currency from company", conSadaf);
            if (conSadaf.State != ConnectionState.Open)
                conSadaf.Open(); 
            currency = cmdList.ExecuteScalar().ToString();
            conSadaf.Close(); 
        }
        private void frmSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsCustomer1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dtsCustomer1.customer);
            // TODO: This line of code loads data into the 'dtsItemColumn.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dtsItemColumn.product);
            // TODO: This line of code loads data into the 'dtsCustomer.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dtsCustomer.customer);
            // TODO: This line of code loads data into the 'dtsCustomer.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dtsCustomer.customer);
            conSadaf = new SqlConnection(sConnection);
            invNumber();
            currencySelect();
        }


        private void dgvInvDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInvDetail.Rows.Count >= 1)
            {
                double totalAmount = 0;
                foreach (DataGridViewRow dr in dgvInvDetail.Rows)
                {
                    if (dr.Cells[2].Value != null)
                    {
                        int prdtID = int.Parse(dr.Cells[2].Value.ToString());

                        SqlDataAdapter daDgv = new SqlDataAdapter();
                        SqlCommand cmdDGV = new SqlCommand("select description, measureUnit from product where productID=@prdtID", conSadaf);
                        cmdDGV.Parameters.AddWithValue("@prdtID", prdtID);
                        daDgv.SelectCommand = cmdDGV;
                        if (conSadaf.State != ConnectionState.Open)
                            conSadaf.Open();
                        DataTable dtDgv = new DataTable();
                        daDgv.Fill(dtDgv);

                        dr.Cells[3].Value = dtDgv.Rows[0][0].ToString();
                        dr.Cells[1].Value = dtDgv.Rows[0][1].ToString();

                        if (dr.Cells[0].Value != null && dr.Cells[4].Value != null)
                        {
                            double quantity = double.Parse(dr.Cells[0].Value.ToString());
                            double unitPrice = double.Parse(dr.Cells[4].Value.ToString());

                            double lineTotal = Math.Round(quantity * unitPrice, 2); 
                            dr.Cells[5].Value = lineTotal.ToString();
                        }

                        if (dr.Cells[0].Value != null && dr.Cells[4].Value != null)
                        {
                            double unitpirce = double.Parse(dr.Cells[4].Value.ToString());
                            double qty = double.Parse(dr.Cells[0].Value.ToString());
                            double lineTotal = unitpirce * qty;
                            totalAmount += Math.Round(lineTotal, 2);
                        }

                        labelTotal.Text = totalAmount.ToString() + " " + currency;
                    }
                }
            }
        }

        private void cmbCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue != null)
            {
                string shipTo = cmbCustomer.Text.ToString();
                txtShipTo.Text = shipTo.ToString();
            }
        }


    }
}
