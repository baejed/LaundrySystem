namespace LaundrySystem
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.LblBirthdate = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblCustomerInfo = new System.Windows.Forms.Label();
            this.DtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.TbContactNumber = new System.Windows.Forms.TextBox();
            this.LblContactNum = new System.Windows.Forms.Label();
            this.TbEmailAdd = new System.Windows.Forms.TextBox();
            this.LblEmailAdd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblServiceType = new System.Windows.Forms.Label();
            this.LblLaundryDate = new System.Windows.Forms.Label();
            this.LblGarmentType = new System.Windows.Forms.Label();
            this.TbWeight = new System.Windows.Forms.TextBox();
            this.LblWeight = new System.Windows.Forms.Label();
            this.TbQty = new System.Windows.Forms.TextBox();
            this.LblQty = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpLaundryDate = new System.Windows.Forms.DateTimePicker();
            this.CmbGarmentType = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GarmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbServiceType = new System.Windows.Forms.ComboBox();
            this.BtnFinalizeOrder = new System.Windows.Forms.Button();
            this.PnlService = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PnlService.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbCustomerName.Location = new System.Drawing.Point(19, 248);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.Size = new System.Drawing.Size(225, 23);
            this.TbCustomerName.TabIndex = 0;
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.Location = new System.Drawing.Point(16, 229);
            this.LblCustomerName.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(68, 16);
            this.LblCustomerName.TabIndex = 1;
            this.LblCustomerName.Text = "Full Name";
            // 
            // LblBirthdate
            // 
            this.LblBirthdate.AutoSize = true;
            this.LblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBirthdate.Location = new System.Drawing.Point(16, 284);
            this.LblBirthdate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblBirthdate.Name = "LblBirthdate";
            this.LblBirthdate.Size = new System.Drawing.Size(60, 16);
            this.LblBirthdate.TabIndex = 1;
            this.LblBirthdate.Text = "Birthdate";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.Location = new System.Drawing.Point(16, 339);
            this.LblGender.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(52, 16);
            this.LblGender.TabIndex = 1;
            this.LblGender.Text = "Gender";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(19, 413);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 23);
            this.textBox4.TabIndex = 0;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(16, 394);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(58, 16);
            this.LblAddress.TabIndex = 1;
            this.LblAddress.Text = "Address";
            // 
            // LblCustomerInfo
            // 
            this.LblCustomerInfo.AutoSize = true;
            this.LblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerInfo.Location = new System.Drawing.Point(13, 25);
            this.LblCustomerInfo.Name = "LblCustomerInfo";
            this.LblCustomerInfo.Size = new System.Drawing.Size(185, 31);
            this.LblCustomerInfo.TabIndex = 2;
            this.LblCustomerInfo.Text = "Customer Info";
            // 
            // DtpBirthdate
            // 
            this.DtpBirthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DtpBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DtpBirthdate.Location = new System.Drawing.Point(19, 303);
            this.DtpBirthdate.Name = "DtpBirthdate";
            this.DtpBirthdate.Size = new System.Drawing.Size(225, 23);
            this.DtpBirthdate.TabIndex = 3;
            // 
            // CmbGender
            // 
            this.CmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CmbGender.Location = new System.Drawing.Point(19, 358);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(225, 24);
            this.CmbGender.TabIndex = 4;
            // 
            // TbContactNumber
            // 
            this.TbContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbContactNumber.Location = new System.Drawing.Point(19, 468);
            this.TbContactNumber.MaxLength = 11;
            this.TbContactNumber.Name = "TbContactNumber";
            this.TbContactNumber.Size = new System.Drawing.Size(225, 23);
            this.TbContactNumber.TabIndex = 0;
            // 
            // LblContactNum
            // 
            this.LblContactNum.AutoSize = true;
            this.LblContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactNum.Location = new System.Drawing.Point(16, 449);
            this.LblContactNum.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblContactNum.Name = "LblContactNum";
            this.LblContactNum.Size = new System.Drawing.Size(103, 16);
            this.LblContactNum.TabIndex = 1;
            this.LblContactNum.Text = "Contact Number";
            // 
            // TbEmailAdd
            // 
            this.TbEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbEmailAdd.Location = new System.Drawing.Point(19, 523);
            this.TbEmailAdd.Name = "TbEmailAdd";
            this.TbEmailAdd.Size = new System.Drawing.Size(225, 23);
            this.TbEmailAdd.TabIndex = 0;
            // 
            // LblEmailAdd
            // 
            this.LblEmailAdd.AutoSize = true;
            this.LblEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailAdd.Location = new System.Drawing.Point(16, 504);
            this.LblEmailAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblEmailAdd.Name = "LblEmailAdd";
            this.LblEmailAdd.Size = new System.Drawing.Size(95, 16);
            this.LblEmailAdd.TabIndex = 1;
            this.LblEmailAdd.Text = "Email Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LblServiceType
            // 
            this.LblServiceType.AutoSize = true;
            this.LblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceType.Location = new System.Drawing.Point(281, 64);
            this.LblServiceType.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblServiceType.Name = "LblServiceType";
            this.LblServiceType.Size = new System.Drawing.Size(88, 16);
            this.LblServiceType.TabIndex = 1;
            this.LblServiceType.Text = "Service Type";
            // 
            // LblLaundryDate
            // 
            this.LblLaundryDate.AutoSize = true;
            this.LblLaundryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLaundryDate.Location = new System.Drawing.Point(281, 119);
            this.LblLaundryDate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblLaundryDate.Name = "LblLaundryDate";
            this.LblLaundryDate.Size = new System.Drawing.Size(36, 16);
            this.LblLaundryDate.TabIndex = 1;
            this.LblLaundryDate.Text = "Date";
            // 
            // LblGarmentType
            // 
            this.LblGarmentType.AutoSize = true;
            this.LblGarmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGarmentType.Location = new System.Drawing.Point(281, 174);
            this.LblGarmentType.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblGarmentType.Name = "LblGarmentType";
            this.LblGarmentType.Size = new System.Drawing.Size(93, 16);
            this.LblGarmentType.TabIndex = 1;
            this.LblGarmentType.Text = "Garment Type";
            // 
            // TbWeight
            // 
            this.TbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbWeight.Location = new System.Drawing.Point(284, 248);
            this.TbWeight.Name = "TbWeight";
            this.TbWeight.Size = new System.Drawing.Size(225, 23);
            this.TbWeight.TabIndex = 0;
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeight.Location = new System.Drawing.Point(281, 229);
            this.LblWeight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(49, 16);
            this.LblWeight.TabIndex = 1;
            this.LblWeight.Text = "Weight";
            // 
            // TbQty
            // 
            this.TbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbQty.Location = new System.Drawing.Point(284, 303);
            this.TbQty.Name = "TbQty";
            this.TbQty.Size = new System.Drawing.Size(225, 23);
            this.TbQty.TabIndex = 0;
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.Location = new System.Drawing.Point(281, 284);
            this.LblQty.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(55, 16);
            this.LblQty.TabIndex = 1;
            this.LblQty.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Laundry Info";
            // 
            // DtpLaundryDate
            // 
            this.DtpLaundryDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DtpLaundryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DtpLaundryDate.Location = new System.Drawing.Point(284, 138);
            this.DtpLaundryDate.Name = "DtpLaundryDate";
            this.DtpLaundryDate.Size = new System.Drawing.Size(225, 23);
            this.DtpLaundryDate.TabIndex = 3;
            // 
            // CmbGarmentType
            // 
            this.CmbGarmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbGarmentType.FormattingEnabled = true;
            this.CmbGarmentType.Location = new System.Drawing.Point(284, 194);
            this.CmbGarmentType.Name = "CmbGarmentType";
            this.CmbGarmentType.Size = new System.Drawing.Size(225, 24);
            this.CmbGarmentType.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(284, 358);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 23);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.Location = new System.Drawing.Point(284, 393);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(225, 42);
            this.BtnAddOrder.TabIndex = 7;
            this.BtnAddOrder.Text = "Add Order";
            this.BtnAddOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceType,
            this.Date,
            this.GarmentType,
            this.Weight,
            this.Quantity,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(538, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(604, 435);
            this.dataGridView1.TabIndex = 8;
            // 
            // ServiceType
            // 
            this.ServiceType.HeaderText = "Service Type";
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // GarmentType
            // 
            this.GarmentType.HeaderText = "Garment Type";
            this.GarmentType.Name = "GarmentType";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // CmbServiceType
            // 
            this.CmbServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbServiceType.FormattingEnabled = true;
            this.CmbServiceType.Location = new System.Drawing.Point(284, 83);
            this.CmbServiceType.Name = "CmbServiceType";
            this.CmbServiceType.Size = new System.Drawing.Size(225, 24);
            this.CmbServiceType.TabIndex = 4;
            // 
            // BtnFinalizeOrder
            // 
            this.BtnFinalizeOrder.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizeOrder.Location = new System.Drawing.Point(538, 479);
            this.BtnFinalizeOrder.Name = "BtnFinalizeOrder";
            this.BtnFinalizeOrder.Size = new System.Drawing.Size(604, 82);
            this.BtnFinalizeOrder.TabIndex = 9;
            this.BtnFinalizeOrder.Text = "Finalize Laundry";
            this.BtnFinalizeOrder.UseVisualStyleBackColor = true;
            // 
            // PnlService
            // 
            this.PnlService.Controls.Add(this.BtnFinalizeOrder);
            this.PnlService.Controls.Add(this.pictureBox1);
            this.PnlService.Controls.Add(this.dataGridView1);
            this.PnlService.Controls.Add(this.TbCustomerName);
            this.PnlService.Controls.Add(this.BtnAddOrder);
            this.PnlService.Controls.Add(this.LblCustomerName);
            this.PnlService.Controls.Add(this.CmbGarmentType);
            this.PnlService.Controls.Add(this.LblBirthdate);
            this.PnlService.Controls.Add(this.CmbServiceType);
            this.PnlService.Controls.Add(this.LblGender);
            this.PnlService.Controls.Add(this.DtpLaundryDate);
            this.PnlService.Controls.Add(this.textBox4);
            this.PnlService.Controls.Add(this.label7);
            this.PnlService.Controls.Add(this.label1);
            this.PnlService.Controls.Add(this.CmbGender);
            this.PnlService.Controls.Add(this.LblQty);
            this.PnlService.Controls.Add(this.LblAddress);
            this.PnlService.Controls.Add(this.textBox2);
            this.PnlService.Controls.Add(this.TbContactNumber);
            this.PnlService.Controls.Add(this.TbQty);
            this.PnlService.Controls.Add(this.DtpBirthdate);
            this.PnlService.Controls.Add(this.LblWeight);
            this.PnlService.Controls.Add(this.LblContactNum);
            this.PnlService.Controls.Add(this.TbWeight);
            this.PnlService.Controls.Add(this.TbEmailAdd);
            this.PnlService.Controls.Add(this.LblGarmentType);
            this.PnlService.Controls.Add(this.LblEmailAdd);
            this.PnlService.Controls.Add(this.LblLaundryDate);
            this.PnlService.Controls.Add(this.LblCustomerInfo);
            this.PnlService.Controls.Add(this.LblServiceType);
            this.PnlService.Location = new System.Drawing.Point(66, 0);
            this.PnlService.Margin = new System.Windows.Forms.Padding(0);
            this.PnlService.Name = "PnlService";
            this.PnlService.Size = new System.Drawing.Size(1158, 576);
            this.PnlService.TabIndex = 10;
            this.PnlService.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 576);
            this.panel1.TabIndex = 11;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlService);
            this.Name = "ServiceForm";
            this.Text = "Laundry System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PnlService.ResumeLayout(false);
            this.PnlService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label LblBirthdate;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblCustomerInfo;
        private System.Windows.Forms.DateTimePicker DtpBirthdate;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.TextBox TbContactNumber;
        private System.Windows.Forms.Label LblContactNum;
        private System.Windows.Forms.TextBox TbEmailAdd;
        private System.Windows.Forms.Label LblEmailAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblServiceType;
        private System.Windows.Forms.Label LblLaundryDate;
        private System.Windows.Forms.Label LblGarmentType;
        private System.Windows.Forms.TextBox TbWeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.TextBox TbQty;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpLaundryDate;
        private System.Windows.Forms.ComboBox CmbGarmentType;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn GarmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.ComboBox CmbServiceType;
        private System.Windows.Forms.Button BtnFinalizeOrder;
        private System.Windows.Forms.Panel PnlService;
        private System.Windows.Forms.Panel panel1;
    }
}