namespace sadafAccounting
{
    partial class frmHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.importID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSChange = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.persianDateTimeFinish = new PersianDateLibrary.PersianDateTimePicker();
            this.persianDateTimeStart = new PersianDateLibrary.PersianDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCount);
            this.groupBox1.Controls.Add(this.dataGridViewHistory);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش تمام ورودی ها ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "مجموع تعداد ورودی";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(6, 312);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(150, 22);
            this.textBoxCount.TabIndex = 1;
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.importID,
            this.productName,
            this.date,
            this.staff,
            this.quantity});
            this.dataGridViewHistory.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.Size = new System.Drawing.Size(983, 287);
            this.dataGridViewHistory.TabIndex = 0;
            // 
            // importID
            // 
            this.importID.DataPropertyName = "importID";
            this.importID.HeaderText = "کد ورودی";
            this.importID.Name = "importID";
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "محصول";
            this.productName.Name = "productName";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            this.date.Width = 150;
            // 
            // staff
            // 
            this.staff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staff.DataPropertyName = "fullName";
            this.staff.HeaderText = "فرستنده";
            this.staff.Name = "staff";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "تعداد ورودی";
            this.quantity.Name = "quantity";
            this.quantity.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSChange);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.comboBoxStaff);
            this.groupBox2.Controls.Add(this.persianDateTimeFinish);
            this.groupBox2.Controls.Add(this.persianDateTimeStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // btnSChange
            // 
            this.btnSChange.Location = new System.Drawing.Point(6, 73);
            this.btnSChange.Name = "btnSChange";
            this.btnSChange.Size = new System.Drawing.Size(113, 23);
            this.btnSChange.TabIndex = 8;
            this.btnSChange.Text = "ثبت تغییرات";
            this.btnSChange.UseVisualStyleBackColor = true;
            this.btnSChange.Click += new System.EventHandler(this.btnSChange_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "بارگذاری مجدد";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(184, 36);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(188, 22);
            this.comboBoxStaff.TabIndex = 5;
            // 
            // persianDateTimeFinish
            // 
            this.persianDateTimeFinish.BackColor = System.Drawing.SystemColors.Control;
            this.persianDateTimeFinish.Font = new System.Drawing.Font("B Homa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDateTimeFinish.Format = PersianDateLibrary.PersianDateTimePicker.DateFormat.Long;
            this.persianDateTimeFinish.GregorianDate = new System.DateTime(2015, 3, 19, 0, 0, 0, 0);
            this.persianDateTimeFinish.Location = new System.Drawing.Point(474, 36);
            this.persianDateTimeFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.persianDateTimeFinish.MaxDate = "1500/4/23";
            this.persianDateTimeFinish.MinDate = "1200/2/15";
            this.persianDateTimeFinish.Name = "persianDateTimeFinish";
            this.persianDateTimeFinish.Size = new System.Drawing.Size(176, 22);
            this.persianDateTimeFinish.TabIndex = 4;
            this.persianDateTimeFinish.Value = "1393/12/28";
            // 
            // persianDateTimeStart
            // 
            this.persianDateTimeStart.BackColor = System.Drawing.SystemColors.Control;
            this.persianDateTimeStart.Font = new System.Drawing.Font("B Homa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDateTimeStart.Format = PersianDateLibrary.PersianDateTimePicker.DateFormat.Long;
            this.persianDateTimeStart.GregorianDate = new System.DateTime(2013, 3, 21, 0, 0, 0, 0);
            this.persianDateTimeStart.Location = new System.Drawing.Point(734, 37);
            this.persianDateTimeStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.persianDateTimeStart.MaxDate = "1500/4/23";
            this.persianDateTimeStart.MinDate = "1200/2/15";
            this.persianDateTimeStart.Name = "persianDateTimeStart";
            this.persianDateTimeStart.Size = new System.Drawing.Size(177, 22);
            this.persianDateTimeStart.TabIndex = 3;
            this.persianDateTimeStart.Value = "1392/1/1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "فرستنده";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاریخ پایان";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(918, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاریخ شروع";
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش ورودی";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn importID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private PersianDateLibrary.PersianDateTimePicker persianDateTimeFinish;
        private PersianDateLibrary.PersianDateTimePicker persianDateTimeStart;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.BindingSource sadafDataSetBindingSource;
        private System.Windows.Forms.Button btnSChange;

    }
}