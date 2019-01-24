namespace sadafAccounting
{
    partial class frmSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCustomer1 = new sadafAccounting.dtsCustomer();
            this.label1 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCustomer = new sadafAccounting.dtsCustomer();
            this.customerTableAdapter = new sadafAccounting.dtsCustomerTableAdapters.customerTableAdapter();
            this.persianDateTimePicker1 = new PersianDateLibrary.PersianDateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtShipTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInvDetail = new System.Windows.Forms.DataGridView();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsItemColumn = new sadafAccounting.dtsItemColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtsItemColumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new sadafAccounting.dtsItemColumnTableAdapters.productTableAdapter();
            this.labelGrand = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCustomer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsItemColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsItemColumnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 59);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(22, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "فاکتور فروش";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.DataSource = this.customerBindingSource1;
            this.cmbCustomer.DisplayMember = "fullName";
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(710, 26);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(255, 24);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.ValueMember = "customerID";
            this.cmbCustomer.SelectedValueChanged += new System.EventHandler(this.cmbCustomer_SelectedValueChanged);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.dtsCustomer1;
            // 
            // dtsCustomer1
            // 
            this.dtsCustomer1.DataSetName = "dtsCustomer";
            this.dtsCustomer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(840, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام مشتری یا شرکت";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.dtsCustomer;
            // 
            // dtsCustomer
            // 
            this.dtsCustomer.DataSetName = "dtsCustomer";
            this.dtsCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // persianDateTimePicker1
            // 
            this.persianDateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.persianDateTimePicker1.BackColor = System.Drawing.SystemColors.Control;
            this.persianDateTimePicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.persianDateTimePicker1.Font = new System.Drawing.Font("B Homa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDateTimePicker1.Format = PersianDateLibrary.PersianDateTimePicker.DateFormat.Long;
            this.persianDateTimePicker1.GregorianDate = new System.DateTime(2015, 1, 21, 0, 0, 0, 0);
            this.persianDateTimePicker1.Location = new System.Drawing.Point(4, 34);
            this.persianDateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.persianDateTimePicker1.MaxDate = "1500/4/23";
            this.persianDateTimePicker1.MinDate = "1200/2/15";
            this.persianDateTimePicker1.Name = "persianDateTimePicker1";
            this.persianDateTimePicker1.Size = new System.Drawing.Size(185, 28);
            this.persianDateTimePicker1.TabIndex = 1;
            this.persianDateTimePicker1.Value = "1393/11/01";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtInvoiceNo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.persianDateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(15, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 129);
            this.panel2.TabIndex = 2;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Location = new System.Drawing.Point(3, 90);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(185, 23);
            this.txtInvoiceNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "شماره فاکتور";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاریخ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtShipTo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(726, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 57);
            this.panel3.TabIndex = 4;
            // 
            // txtShipTo
            // 
            this.txtShipTo.Location = new System.Drawing.Point(-1, 26);
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.Size = new System.Drawing.Size(251, 23);
            this.txtShipTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "فاکتور به نام";
            // 
            // dgvInvDetail
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvInvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantity,
            this.um,
            this.items,
            this.description,
            this.unitPrice,
            this.lineTotal});
            this.dgvInvDetail.Location = new System.Drawing.Point(3, 264);
            this.dgvInvDetail.Name = "dgvInvDetail";
            this.dgvInvDetail.Size = new System.Drawing.Size(978, 281);
            this.dgvInvDetail.TabIndex = 0;
            this.dgvInvDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvDetail_CellValueChanged);
            // 
            // quantity
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.NullValue = null;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.quantity.HeaderText = "تعداد";
            this.quantity.Name = "quantity";
            // 
            // um
            // 
            this.um.HeaderText = "واحد";
            this.um.Name = "um";
            // 
            // items
            // 
            this.items.DataSource = this.productBindingSource;
            this.items.DisplayMember = "itemName";
            this.items.FillWeight = 200F;
            this.items.HeaderText = "جنس";
            this.items.Name = "items";
            this.items.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.items.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.items.ValueMember = "productID";
            this.items.Width = 200;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.dtsItemColumn;
            // 
            // dtsItemColumn
            // 
            this.dtsItemColumn.DataSetName = "dtsItemColumn";
            this.dtsItemColumn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.description.DefaultCellStyle = dataGridViewCellStyle8;
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            // 
            // unitPrice
            // 
            dataGridViewCellStyle9.NullValue = "0";
            this.unitPrice.DefaultCellStyle = dataGridViewCellStyle9;
            this.unitPrice.HeaderText = "فی قیمت";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Width = 150;
            // 
            // lineTotal
            // 
            dataGridViewCellStyle10.Format = "0,0.00";
            dataGridViewCellStyle10.NullValue = "0";
            this.lineTotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.lineTotal.HeaderText = "مجموع";
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.Width = 150;
            // 
            // dtsItemColumnBindingSource
            // 
            this.dtsItemColumnBindingSource.DataSource = this.dtsItemColumn;
            this.dtsItemColumnBindingSource.Position = 0;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // labelGrand
            // 
            this.labelGrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGrand.AutoSize = true;
            this.labelGrand.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelGrand.Location = new System.Drawing.Point(692, 557);
            this.labelGrand.Name = "labelGrand";
            this.labelGrand.Size = new System.Drawing.Size(82, 16);
            this.labelGrand.TabIndex = 5;
            this.labelGrand.Text = "مجموع کل: ";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelTotal.Location = new System.Drawing.Point(811, 557);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 16);
            this.labelTotal.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(15, 585);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelGrand);
            this.Controls.Add(this.dgvInvDetail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmSale";
            this.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "فاکتور فروش";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCustomer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCustomer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsItemColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsItemColumnBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label1;
        private dtsCustomer dtsCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private dtsCustomerTableAdapters.customerTableAdapter customerTableAdapter;
        private PersianDateLibrary.PersianDateTimePicker persianDateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvInvDetail;
        private dtsItemColumn dtsItemColumn;
        private System.Windows.Forms.BindingSource dtsItemColumnBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private dtsItemColumnTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox txtShipTo;
        private System.Windows.Forms.Label labelGrand;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn um;
        private System.Windows.Forms.DataGridViewComboBoxColumn items;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotal;
        private dtsCustomer dtsCustomer1;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.Button btnSave;
    }
}