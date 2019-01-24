using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace sadafAccounting
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D; 
        }

        private void companyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany fCompany = new frmCompany();
            fCompany.ShowDialog();
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff fStaff = new frmStaff();
            fStaff.ShowDialog(); 
        }

        private void انبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock fStock = SingletonProvider<frmStock>.Instance;
            fStock.MdiParent = this;
            fStock.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts fProducts = SingletonProvider<frmProducts>.Instance;
            fProducts.MdiParent = this;
            fProducts.WindowState = FormWindowState.Maximized; 
            fProducts.Show();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImport fImport = SingletonProvider<frmImport>.Instance;
            fImport.MdiParent = this;
            fImport.WindowState = FormWindowState.Maximized; 
            fImport.Show();
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSale fSales = SingletonProvider<frmSale>.Instance;
            fSales.MdiParent = this;
            fSales.WindowState = FormWindowState.Maximized;
            fSales.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer fCustomer = SingletonProvider<frmCustomer>.Instance;
            fCustomer.ShowDialog(); 
        }
        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcc fAcc = SingletonProvider<frmAcc>.Instance;
            fAcc.MdiParent = this;
            fAcc.WindowState = FormWindowState.Normal;
            fAcc.Show(); 
        }

    }
    public class SingletonProvider<T> where T : new()
    {
        public static T Instance
        {
            get
            {
                return SingletonCreator.Instance;
            }
        }
        class SingletonCreator
        {
            private static T objInstance;
            public static T Instance
            {
                get
                {
                    Form objForm = objInstance as Form;
                    if (objInstance == null || objForm.IsDisposed == true)
                        objInstance = new T();
                    return objInstance;
                }
            }
        }
    }
}
