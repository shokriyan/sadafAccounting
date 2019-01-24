namespace sadafAccounting
{
    partial class frmStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.GroupBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.persianDateHire = new PersianDateLibrary.PersianDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSClose = new System.Windows.Forms.Button();
            this.staffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofhire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Controls.Add(this.comboBoxStatus);
            this.btnSave.Controls.Add(this.label7);
            this.btnSave.Controls.Add(this.comboBoxCurrency);
            this.btnSave.Controls.Add(this.label6);
            this.btnSave.Controls.Add(this.textBoxSalary);
            this.btnSave.Controls.Add(this.label5);
            this.btnSave.Controls.Add(this.persianDateHire);
            this.btnSave.Controls.Add(this.label4);
            this.btnSave.Controls.Add(this.textBoxPosition);
            this.btnSave.Controls.Add(this.label3);
            this.btnSave.Controls.Add(this.textBoxName);
            this.btnSave.Controls.Add(this.label2);
            this.btnSave.Controls.Add(this.textBoxCode);
            this.btnSave.Controls.Add(this.label1);
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(306, 421);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "مشخصات";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "فعال",
            "غیرفعال"});
            this.comboBoxStatus.Location = new System.Drawing.Point(130, 368);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(89, 24);
            this.comboBoxStatus.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "وضعیت";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "افغانی",
            "دلار",
            "یورو",
            "تومان"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(130, 310);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(89, 24);
            this.comboBoxCurrency.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ارز";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(21, 246);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(170, 23);
            this.textBoxSalary.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "معاش پایه";
            // 
            // persianDateHire
            // 
            this.persianDateHire.BackColor = System.Drawing.SystemColors.Control;
            this.persianDateHire.Font = new System.Drawing.Font("B Homa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDateHire.Format = PersianDateLibrary.PersianDateTimePicker.DateFormat.Long;
            this.persianDateHire.GregorianDate = new System.DateTime(2013, 5, 24, 0, 0, 0, 0);
            this.persianDateHire.Location = new System.Drawing.Point(21, 188);
            this.persianDateHire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.persianDateHire.MaxDate = "1500/4/23";
            this.persianDateHire.MinDate = "1200/2/15";
            this.persianDateHire.Name = "persianDateHire";
            this.persianDateHire.Size = new System.Drawing.Size(170, 23);
            this.persianDateHire.TabIndex = 4;
            this.persianDateHire.Value = "1392/03/03";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاریخ استخدام";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(21, 133);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(198, 23);
            this.textBoxPosition.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "وظیفه";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام کامل";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(130, 30);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(89, 23);
            this.textBoxCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد کارمند";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewList);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 421);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست کارمندان";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            this.dataGridViewList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffID,
            this.fullName,
            this.position,
            this.dateofhire,
            this.baseSalary,
            this.currency,
            this.status});
            this.dataGridViewList.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewList.Name = "dataGridViewList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewList.Size = new System.Drawing.Size(731, 393);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "ثبت و جدید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSClose
            // 
            this.btnSClose.Location = new System.Drawing.Point(127, 439);
            this.btnSClose.Name = "btnSClose";
            this.btnSClose.Size = new System.Drawing.Size(101, 31);
            this.btnSClose.TabIndex = 15;
            this.btnSClose.TabStop = false;
            this.btnSClose.Text = "ثبت و خروج";
            this.btnSClose.UseVisualStyleBackColor = true;
            this.btnSClose.Click += new System.EventHandler(this.btnSClose_Click);
            // 
            // staffID
            // 
            this.staffID.DataPropertyName = "staffID";
            this.staffID.HeaderText = "کد کارمند";
            this.staffID.Name = "staffID";
            this.staffID.Width = 85;
            // 
            // fullName
            // 
            this.fullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "نام کامل";
            this.fullName.Name = "fullName";
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "وظیفه";
            this.position.Name = "position";
            // 
            // dateofhire
            // 
            this.dateofhire.DataPropertyName = "dateofhire";
            this.dateofhire.HeaderText = "تاریخ";
            this.dateofhire.Name = "dateofhire";
            // 
            // baseSalary
            // 
            this.baseSalary.DataPropertyName = "baseSalary";
            this.baseSalary.HeaderText = "معاش";
            this.baseSalary.Name = "baseSalary";
            this.baseSalary.Width = 70;
            // 
            // currency
            // 
            this.currency.DataPropertyName = "currency";
            this.currency.HeaderText = " ارز";
            this.currency.Name = "currency";
            this.currency.Width = 70;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "وضعیت";
            this.status.Name = "status";
            this.status.Width = 80;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 482);
            this.Controls.Add(this.btnSClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStaff";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست کارمندان";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.btnSave.ResumeLayout(false);
            this.btnSave.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label5;
        private PersianDateLibrary.PersianDateTimePicker persianDateHire;
        private System.Windows.Forms.Button btnSClose;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofhire;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}