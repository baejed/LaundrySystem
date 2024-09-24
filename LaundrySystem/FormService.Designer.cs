namespace LaundrySystem
{
    partial class FormService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormService));
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.LblCustomerInfo = new System.Windows.Forms.Label();
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
            this.PnlService = new System.Windows.Forms.Panel();
            this.LblEmailAdOut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblBirthdateOut = new System.Windows.Forms.Label();
            this.LblEmailAd = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.BtnFinalizeOrder = new System.Windows.Forms.Button();
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
            this.TbCustomerName.Size = new System.Drawing.Size(179, 23);
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
            this.LblServiceType.Location = new System.Drawing.Point(16, 350);
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
            this.LblLaundryDate.Location = new System.Drawing.Point(16, 405);
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
            this.LblGarmentType.Location = new System.Drawing.Point(16, 460);
            this.LblGarmentType.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblGarmentType.Name = "LblGarmentType";
            this.LblGarmentType.Size = new System.Drawing.Size(93, 16);
            this.LblGarmentType.TabIndex = 1;
            this.LblGarmentType.Text = "Garment Type";
            // 
            // TbWeight
            // 
            this.TbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbWeight.Location = new System.Drawing.Point(284, 369);
            this.TbWeight.Name = "TbWeight";
            this.TbWeight.Size = new System.Drawing.Size(225, 23);
            this.TbWeight.TabIndex = 0;
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeight.Location = new System.Drawing.Point(281, 350);
            this.LblWeight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(49, 16);
            this.LblWeight.TabIndex = 1;
            this.LblWeight.Text = "Weight";
            // 
            // TbQty
            // 
            this.TbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbQty.Location = new System.Drawing.Point(284, 424);
            this.TbQty.Name = "TbQty";
            this.TbQty.Size = new System.Drawing.Size(225, 23);
            this.TbQty.TabIndex = 0;
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.Location = new System.Drawing.Point(281, 405);
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
            this.label7.Location = new System.Drawing.Point(13, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Laundry Info";
            // 
            // DtpLaundryDate
            // 
            this.DtpLaundryDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DtpLaundryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DtpLaundryDate.Location = new System.Drawing.Point(19, 424);
            this.DtpLaundryDate.Name = "DtpLaundryDate";
            this.DtpLaundryDate.Size = new System.Drawing.Size(225, 23);
            this.DtpLaundryDate.TabIndex = 3;
            // 
            // CmbGarmentType
            // 
            this.CmbGarmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbGarmentType.FormattingEnabled = true;
            this.CmbGarmentType.Location = new System.Drawing.Point(19, 480);
            this.CmbGarmentType.Name = "CmbGarmentType";
            this.CmbGarmentType.Size = new System.Drawing.Size(225, 24);
            this.CmbGarmentType.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(284, 479);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 23);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.Location = new System.Drawing.Point(19, 525);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(490, 42);
            this.BtnAddOrder.TabIndex = 7;
            this.BtnAddOrder.Text = "Add Order";
            this.BtnAddOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceType,
            this.Date,
            this.GarmentType,
            this.Weight,
            this.Quantity,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(641, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(557, 481);
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
            this.CmbServiceType.Location = new System.Drawing.Point(19, 369);
            this.CmbServiceType.Name = "CmbServiceType";
            this.CmbServiceType.Size = new System.Drawing.Size(225, 24);
            this.CmbServiceType.TabIndex = 4;
            // 
            // PnlService
            // 
            this.PnlService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlService.Controls.Add(this.LblEmailAdOut);
            this.PnlService.Controls.Add(this.label5);
            this.PnlService.Controls.Add(this.label3);
            this.PnlService.Controls.Add(this.LblBirthdateOut);
            this.PnlService.Controls.Add(this.LblEmailAd);
            this.PnlService.Controls.Add(this.LblAddress);
            this.PnlService.Controls.Add(this.LblGender);
            this.PnlService.Controls.Add(this.LblBirthDate);
            this.PnlService.Controls.Add(this.BtnFinalizeOrder);
            this.PnlService.Controls.Add(this.pictureBox1);
            this.PnlService.Controls.Add(this.dataGridView1);
            this.PnlService.Controls.Add(this.TbCustomerName);
            this.PnlService.Controls.Add(this.BtnAddOrder);
            this.PnlService.Controls.Add(this.LblCustomerName);
            this.PnlService.Controls.Add(this.CmbGarmentType);
            this.PnlService.Controls.Add(this.CmbServiceType);
            this.PnlService.Controls.Add(this.DtpLaundryDate);
            this.PnlService.Controls.Add(this.label7);
            this.PnlService.Controls.Add(this.label1);
            this.PnlService.Controls.Add(this.LblQty);
            this.PnlService.Controls.Add(this.textBox2);
            this.PnlService.Controls.Add(this.TbQty);
            this.PnlService.Controls.Add(this.LblWeight);
            this.PnlService.Controls.Add(this.TbWeight);
            this.PnlService.Controls.Add(this.LblGarmentType);
            this.PnlService.Controls.Add(this.LblLaundryDate);
            this.PnlService.Controls.Add(this.LblCustomerInfo);
            this.PnlService.Controls.Add(this.LblServiceType);
            this.PnlService.Location = new System.Drawing.Point(9, 0);
            this.PnlService.Margin = new System.Windows.Forms.Padding(0);
            this.PnlService.Name = "PnlService";
            this.PnlService.Size = new System.Drawing.Size(1211, 622);
            this.PnlService.TabIndex = 10;
            // 
            // LblEmailAdOut
            // 
            this.LblEmailAdOut.AutoSize = true;
            this.LblEmailAdOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailAdOut.Location = new System.Drawing.Point(346, 186);
            this.LblEmailAdOut.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.LblEmailAdOut.Name = "LblEmailAdOut";
            this.LblEmailAdOut.Size = new System.Drawing.Size(0, 25);
            this.LblEmailAdOut.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 10;
            // 
            // LblBirthdateOut
            // 
            this.LblBirthdateOut.AutoSize = true;
            this.LblBirthdateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBirthdateOut.Location = new System.Drawing.Point(346, 66);
            this.LblBirthdateOut.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.LblBirthdateOut.Name = "LblBirthdateOut";
            this.LblBirthdateOut.Size = new System.Drawing.Size(0, 25);
            this.LblBirthdateOut.TabIndex = 10;
            // 
            // LblEmailAd
            // 
            this.LblEmailAd.AutoSize = true;
            this.LblEmailAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailAd.Location = new System.Drawing.Point(222, 186);
            this.LblEmailAd.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.LblEmailAd.Name = "LblEmailAd";
            this.LblEmailAd.Size = new System.Drawing.Size(71, 25);
            this.LblEmailAd.TabIndex = 10;
            this.LblEmailAd.Text = "Email:";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(222, 146);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(97, 25);
            this.LblAddress.TabIndex = 10;
            this.LblAddress.Text = "Address:";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.Location = new System.Drawing.Point(222, 106);
            this.LblGender.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(89, 25);
            this.LblGender.TabIndex = 10;
            this.LblGender.Text = "Gender:";
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBirthDate.Location = new System.Drawing.Point(222, 66);
            this.LblBirthDate.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(104, 25);
            this.LblBirthDate.TabIndex = 10;
            this.LblBirthDate.Text = "Birthdate:";
            // 
            // BtnFinalizeOrder
            // 
            this.BtnFinalizeOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFinalizeOrder.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizeOrder.Location = new System.Drawing.Point(641, 525);
            this.BtnFinalizeOrder.Name = "BtnFinalizeOrder";
            this.BtnFinalizeOrder.Size = new System.Drawing.Size(557, 82);
            this.BtnFinalizeOrder.TabIndex = 9;
            this.BtnFinalizeOrder.Text = "Finalize Laundry";
            this.BtnFinalizeOrder.UseVisualStyleBackColor = true;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 619);
            this.Controls.Add(this.PnlService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label LblCustomerInfo;
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
        private System.Windows.Forms.Panel PnlService;
        private System.Windows.Forms.Button BtnFinalizeOrder;
        private System.Windows.Forms.Label LblEmailAdOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblBirthdateOut;
        private System.Windows.Forms.Label LblEmailAd;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblBirthDate;
    }
}