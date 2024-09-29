using LaundrySystem.Properties;

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

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormService));

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
            this.PicCustomer = new System.Windows.Forms.PictureBox();
            this.LblServiceType = new System.Windows.Forms.Label();
            this.LblGarmentType = new System.Windows.Forms.Label();
            this.TbWeight = new System.Windows.Forms.TextBox();
            this.LblWeight = new System.Windows.Forms.Label();
            this.TbQty = new System.Windows.Forms.TextBox();
            this.LblQty = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbGarmentType = new System.Windows.Forms.ComboBox();
            this.TbAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddOrder = new ReaLTaiizor.Controls.ParrotButton();
            this.GridOrders = new System.Windows.Forms.DataGridView();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GarmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbServiceType = new System.Windows.Forms.ComboBox();
            this.PnlService = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LblEmailAdOut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblBirthdateOut = new System.Windows.Forms.Label();
            this.LblEmailAd = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.BtnFinalizeOrder = new ReaLTaiizor.Controls.ParrotButton();
            this.TbTotal = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.TbGender = new System.Windows.Forms.TextBox();
            this.TbBirthdate = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrders)).BeginInit();
            this.PnlService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbCustomerName.Location = new System.Drawing.Point(19, 248);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.Size = new System.Drawing.Size(225, 23);
            this.TbCustomerName.TabIndex = 0;
            this.TbCustomerName.TextChanged += new System.EventHandler(this.TbCustomerName_TextChanged);
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.ForeColor = System.Drawing.Color.White;
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
            this.LblCustomerInfo.ForeColor = System.Drawing.Color.White;
            this.LblCustomerInfo.Location = new System.Drawing.Point(13, 25);
            this.LblCustomerInfo.Name = "LblCustomerInfo";
            this.LblCustomerInfo.Size = new System.Drawing.Size(185, 31);
            this.LblCustomerInfo.TabIndex = 2;
            this.LblCustomerInfo.Text = "Customer Info";
            // 
            // PicCustomer
            // 
            this.PicCustomer.Image = ((System.Drawing.Image)(resources.GetObject("PicCustomer.Image")));
            this.PicCustomer.Location = new System.Drawing.Point(19, 66);
            this.PicCustomer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.PicCustomer.Name = "PicCustomer";
            this.PicCustomer.Size = new System.Drawing.Size(150, 150);
            this.PicCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCustomer.TabIndex = 5;
            this.PicCustomer.TabStop = false;
            // 
            // LblServiceType
            // 
            this.LblServiceType.AutoSize = true;
            this.LblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceType.ForeColor = System.Drawing.Color.White;
            this.LblServiceType.Location = new System.Drawing.Point(16, 350);
            this.LblServiceType.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblServiceType.Name = "LblServiceType";
            this.LblServiceType.Size = new System.Drawing.Size(88, 16);
            this.LblServiceType.TabIndex = 1;
            this.LblServiceType.Text = "Service Type";
            // 
            // LblGarmentType
            // 
            this.LblGarmentType.AutoSize = true;
            this.LblGarmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGarmentType.ForeColor = System.Drawing.Color.White;
            this.LblGarmentType.Location = new System.Drawing.Point(16, 406);
            this.LblGarmentType.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblGarmentType.Name = "LblGarmentType";
            this.LblGarmentType.Size = new System.Drawing.Size(93, 16);
            this.LblGarmentType.TabIndex = 1;
            this.LblGarmentType.Text = "Garment Type";
            // 
            // TbWeight
            // 
            this.TbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbWeight.Location = new System.Drawing.Point(284, 370);
            this.TbWeight.Name = "TbWeight";
            this.TbWeight.Size = new System.Drawing.Size(225, 23);
            this.TbWeight.TabIndex = 0;
            this.TbWeight.TextChanged += new System.EventHandler(this.TbWeight_TextChanged);
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeight.ForeColor = System.Drawing.Color.White;
            this.LblWeight.Location = new System.Drawing.Point(281, 351);
            this.LblWeight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(49, 16);
            this.LblWeight.TabIndex = 1;
            this.LblWeight.Text = "Weight";
            // 
            // TbQty
            // 
            this.TbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbQty.Location = new System.Drawing.Point(284, 425);
            this.TbQty.Name = "TbQty";
            this.TbQty.Size = new System.Drawing.Size(225, 23);
            this.TbQty.TabIndex = 0;
            this.TbQty.TextChanged += new System.EventHandler(this.TbQty_TextChanged);
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.ForeColor = System.Drawing.Color.White;
            this.LblQty.Location = new System.Drawing.Point(281, 406);
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
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Laundry Info";
            // 
            // CmbGarmentType
            // 
            this.CmbGarmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbGarmentType.FormattingEnabled = true;
            this.CmbGarmentType.Location = new System.Drawing.Point(19, 426);
            this.CmbGarmentType.Name = "CmbGarmentType";
            this.CmbGarmentType.Size = new System.Drawing.Size(225, 24);
            this.CmbGarmentType.TabIndex = 6;
            // 
            // TbAmount
            // 
            this.TbAmount.Enabled = false;
            this.TbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbAmount.Location = new System.Drawing.Point(19, 482);
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(225, 23);
            this.TbAmount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 463);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddOrder.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnAddOrder.ButtonImage")));
            this.BtnAddOrder.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnAddOrder.ButtonText = "Add Order";
            this.BtnAddOrder.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnAddOrder.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddOrder.CornerRadius = 5;
            this.BtnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddOrder.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAddOrder.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnAddOrder.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddOrder.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnAddOrder.Location = new System.Drawing.Point(19, 525);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(490, 42);
            this.BtnAddOrder.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnAddOrder.TabIndex = 7;
            this.BtnAddOrder.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddOrder.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnAddOrder.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // GridOrders
            // 
            this.GridOrders.AllowUserToResizeColumns = false;
            this.GridOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceType,
            this.GarmentType,
            this.Weight,
            this.Quantity,
            this.Amount});
            this.GridOrders.Location = new System.Drawing.Point(651, 12);
            this.GridOrders.Name = "GridOrders";
            this.GridOrders.RowHeadersVisible = false;
            this.GridOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridOrders.Size = new System.Drawing.Size(557, 456);
            this.GridOrders.TabIndex = 8;
            // 
            // ServiceType
            // 
            this.ServiceType.HeaderText = "Service Type";
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.ReadOnly = true;
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
            this.CmbServiceType.SelectedIndexChanged += new System.EventHandler(this.CmbServiceType_SelectedIndexChanged);
            // 
            // PnlService
            // 
            this.PnlService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlService.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnlService.Controls.Add(this.PicLogo);
            this.PnlService.Controls.Add(this.LblEmailAdOut);
            this.PnlService.Controls.Add(this.label5);
            this.PnlService.Controls.Add(this.label3);
            this.PnlService.Controls.Add(this.LblBirthdateOut);
            this.PnlService.Controls.Add(this.LblEmailAd);
            this.PnlService.Controls.Add(this.LblAddress);
            this.PnlService.Controls.Add(this.LblGender);
            this.PnlService.Controls.Add(this.LblBirthDate);
            this.PnlService.Controls.Add(this.BtnFinalizeOrder);
            this.PnlService.Controls.Add(this.PicCustomer);
            this.PnlService.Controls.Add(this.GridOrders);
            this.PnlService.Controls.Add(this.TbCustomerName);
            this.PnlService.Controls.Add(this.BtnAddOrder);
            this.PnlService.Controls.Add(this.LblCustomerName);
            this.PnlService.Controls.Add(this.CmbGarmentType);
            this.PnlService.Controls.Add(this.CmbServiceType);
            this.PnlService.Controls.Add(this.label7);
            this.PnlService.Controls.Add(this.label1);
            this.PnlService.Controls.Add(this.LblQty);
            this.PnlService.Controls.Add(this.TbAmount);
            this.PnlService.Controls.Add(this.TbTotal);
            this.PnlService.Controls.Add(this.TbQty);
            this.PnlService.Controls.Add(this.LblWeight);
            this.PnlService.Controls.Add(this.TbEmail);
            this.PnlService.Controls.Add(this.TbAddress);
            this.PnlService.Controls.Add(this.TbGender);
            this.PnlService.Controls.Add(this.TbBirthdate);
            this.PnlService.Controls.Add(this.TbWeight);
            this.PnlService.Controls.Add(this.LblGarmentType);
            this.PnlService.Controls.Add(this.lblTotal);
            this.PnlService.Controls.Add(this.LblCustomerInfo);
            this.PnlService.Controls.Add(this.LblServiceType);
            this.PnlService.Location = new System.Drawing.Point(-1, 0);
            this.PnlService.Margin = new System.Windows.Forms.Padding(0);
            this.PnlService.Name = "PnlService";
            this.PnlService.Size = new System.Drawing.Size(1221, 622);
            this.PnlService.TabIndex = 10;
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(351, 229);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(10);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(225, 105);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 15;
            this.PicLogo.TabStop = false;
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
            this.LblEmailAd.ForeColor = System.Drawing.Color.White;
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
            this.LblAddress.ForeColor = System.Drawing.Color.White;
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
            this.LblGender.ForeColor = System.Drawing.Color.White;
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
            this.LblBirthDate.ForeColor = System.Drawing.Color.White;
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
            this.BtnFinalizeOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnFinalizeOrder.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnFinalizeOrder.ButtonImage")));
            this.BtnFinalizeOrder.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnFinalizeOrder.ButtonText = "Finalize Order";
            this.BtnFinalizeOrder.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnFinalizeOrder.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnFinalizeOrder.CornerRadius = 5;
            this.BtnFinalizeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinalizeOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizeOrder.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnFinalizeOrder.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnFinalizeOrder.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnFinalizeOrder.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnFinalizeOrder.Location = new System.Drawing.Point(651, 525);
            this.BtnFinalizeOrder.Name = "BtnFinalizeOrder";
            this.BtnFinalizeOrder.Size = new System.Drawing.Size(557, 82);
            this.BtnFinalizeOrder.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnFinalizeOrder.TabIndex = 9;
            this.BtnFinalizeOrder.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnFinalizeOrder.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnFinalizeOrder.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // TbTotal
            // 
            this.TbTotal.Enabled = false;
            this.TbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TbTotal.Location = new System.Drawing.Point(734, 474);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.Size = new System.Drawing.Size(474, 38);
            this.TbTotal.TabIndex = 0;
            // 
            // TbEmail
            // 
            this.TbEmail.Enabled = false;
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbEmail.Location = new System.Drawing.Point(351, 190);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(225, 23);
            this.TbEmail.TabIndex = 0;
            // 
            // TbAddress
            // 
            this.TbAddress.Enabled = false;
            this.TbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbAddress.Location = new System.Drawing.Point(351, 150);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(225, 23);
            this.TbAddress.TabIndex = 0;
            // 
            // TbGender
            // 
            this.TbGender.Enabled = false;
            this.TbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbGender.Location = new System.Drawing.Point(351, 110);
            this.TbGender.Name = "TbGender";
            this.TbGender.Size = new System.Drawing.Size(225, 23);
            this.TbGender.TabIndex = 0;
            // 
            // TbBirthdate
            // 
            this.TbBirthdate.Enabled = false;
            this.TbBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbBirthdate.Location = new System.Drawing.Point(351, 70);
            this.TbBirthdate.Name = "TbBirthdate";
            this.TbBirthdate.Size = new System.Drawing.Size(225, 23);
            this.TbBirthdate.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(645, 482);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 31);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 619);
            this.Controls.Add(this.PnlService);
            this.Name = "FormService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laundry System";
            this.Load += new System.EventHandler(this.FormService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrders)).EndInit();
            this.PnlService.ResumeLayout(false);
            this.PnlService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public void ClearCustomerPhoto()
        {
            this.PicCustomer.Image = ((System.Drawing.Image)(resources.GetObject("PicCustomer.Image")));
        }

        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label LblCustomerInfo;
        private System.Windows.Forms.PictureBox PicCustomer;
        private System.Windows.Forms.Label LblServiceType;
        private System.Windows.Forms.Label LblGarmentType;
        private System.Windows.Forms.TextBox TbWeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.TextBox TbQty;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbGarmentType;
        private System.Windows.Forms.TextBox TbAmount;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.ParrotButton BtnAddOrder;
        private System.Windows.Forms.DataGridView GridOrders;
        private System.Windows.Forms.ComboBox CmbServiceType;
        private System.Windows.Forms.Panel PnlService;
        private ReaLTaiizor.Controls.ParrotButton BtnFinalizeOrder;
        private System.Windows.Forms.Label LblEmailAdOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblBirthdateOut;
        private System.Windows.Forms.Label LblEmailAd;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblBirthDate;
        private System.Windows.Forms.TextBox TbBirthdate;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbAddress;
        private System.Windows.Forms.TextBox TbGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn GarmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.TextBox TbTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}