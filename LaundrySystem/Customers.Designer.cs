namespace LaundrySystem
{
    partial class Customers
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

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.PnlCustomers = new System.Windows.Forms.Panel();
            this.BtnDelete = new ReaLTaiizor.Controls.ParrotButton();
            this.BtnCancel = new ReaLTaiizor.Controls.ParrotButton();
            this.BtnUpdate = new ReaLTaiizor.Controls.ParrotButton();
            this.BtnSearch = new ReaLTaiizor.Controls.ParrotButton();
            this.TbFullnameSearch = new System.Windows.Forms.TextBox();
            this.GridCustomers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbCustGender = new System.Windows.Forms.ComboBox();
            this.DtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.BtnAddCustomer = new ReaLTaiizor.Controls.ParrotButton();
            this.BtnUpload = new ReaLTaiizor.Controls.ParrotButton();
            this.PicCustomer = new System.Windows.Forms.PictureBox();
            this.TbEmailAdd = new System.Windows.Forms.TextBox();
            this.TbContactNum = new System.Windows.Forms.TextBox();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            this.LblEmailAd = new System.Windows.Forms.Label();
            this.LblContactNo = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.LblTotalRecs = new System.Windows.Forms.Label();
            this.LblFullNameSearch = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.LblSearch = new System.Windows.Forms.Label();
            this.LblCustomerInfo = new System.Windows.Forms.Label();
            this.PnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCustomers
            // 
            this.PnlCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCustomers.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnlCustomers.Controls.Add(this.BtnDelete);
            this.PnlCustomers.Controls.Add(this.BtnCancel);
            this.PnlCustomers.Controls.Add(this.BtnUpdate);
            this.PnlCustomers.Controls.Add(this.BtnSearch);
            this.PnlCustomers.Controls.Add(this.TbFullnameSearch);
            this.PnlCustomers.Controls.Add(this.GridCustomers);
            this.PnlCustomers.Controls.Add(this.CmbCustGender);
            this.PnlCustomers.Controls.Add(this.DtpBirthdate);
            this.PnlCustomers.Controls.Add(this.BtnAddCustomer);
            this.PnlCustomers.Controls.Add(this.BtnUpload);
            this.PnlCustomers.Controls.Add(this.PicCustomer);
            this.PnlCustomers.Controls.Add(this.TbEmailAdd);
            this.PnlCustomers.Controls.Add(this.TbContactNum);
            this.PnlCustomers.Controls.Add(this.TbAddress);
            this.PnlCustomers.Controls.Add(this.TbCustomerName);
            this.PnlCustomers.Controls.Add(this.LblEmailAd);
            this.PnlCustomers.Controls.Add(this.LblContactNo);
            this.PnlCustomers.Controls.Add(this.LblAddress);
            this.PnlCustomers.Controls.Add(this.LblGender);
            this.PnlCustomers.Controls.Add(this.LblBirthDate);
            this.PnlCustomers.Controls.Add(this.LblTotalRecs);
            this.PnlCustomers.Controls.Add(this.LblFullNameSearch);
            this.PnlCustomers.Controls.Add(this.LblCustomerName);
            this.PnlCustomers.Controls.Add(this.LblSearch);
            this.PnlCustomers.Controls.Add(this.LblCustomerInfo);
            this.PnlCustomers.Location = new System.Drawing.Point(-2, 0);
            this.PnlCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.PnlCustomers.Name = "PnlCustomers";
            this.PnlCustomers.Size = new System.Drawing.Size(1205, 624);
            this.PnlCustomers.TabIndex = 0;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackgroundColor = System.Drawing.Color.Black;
            this.BtnDelete.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ButtonImage")));
            this.BtnDelete.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnDelete.ButtonText = "Delete";
            this.BtnDelete.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnDelete.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnDelete.CornerRadius = 5;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnDelete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnDelete.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnDelete.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnDelete.Location = new System.Drawing.Point(16, 475);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(179, 35);
            this.BtnDelete.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnDelete.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackgroundColor = System.Drawing.Color.Black;
            this.BtnCancel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ButtonImage")));
            this.BtnCancel.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnCancel.ButtonText = "Cancel";
            this.BtnCancel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnCancel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancel.CornerRadius = 5;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCancel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnCancel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancel.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnCancel.Location = new System.Drawing.Point(16, 516);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(179, 35);
            this.BtnCancel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnCancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackgroundColor = System.Drawing.Color.Black;
            this.BtnUpdate.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ButtonImage")));
            this.BtnUpdate.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnUpdate.ButtonText = "Update";
            this.BtnUpdate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnUpdate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.CornerRadius = 5;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnUpdate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnUpdate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnUpdate.Location = new System.Drawing.Point(16, 434);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(179, 35);
            this.BtnUpdate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnUpdate.TabIndex = 12;
            this.BtnUpdate.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnUpdate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BackgroundColor = System.Drawing.Color.Black;
            this.BtnSearch.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ButtonImage")));
            this.BtnSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnSearch.ButtonText = "Search";
            this.BtnSearch.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnSearch.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSearch.CornerRadius = 5;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSearch.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnSearch.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnSearch.Location = new System.Drawing.Point(1059, 589);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(131, 30);
            this.BtnSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // TbFullnameSearch
            // 
            this.TbFullnameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFullnameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFullnameSearch.Location = new System.Drawing.Point(433, 70);
            this.TbFullnameSearch.Name = "TbFullnameSearch";
            this.TbFullnameSearch.Size = new System.Drawing.Size(757, 31);
            this.TbFullnameSearch.TabIndex = 9;
            this.TbFullnameSearch.TextChanged += new System.EventHandler(this.TbFullnameSearch_TextChanged);
            // 
            // GridCustomers
            // 
            this.GridCustomers.AllowUserToAddRows = false;
            this.GridCustomers.AllowUserToDeleteRows = false;
            this.GridCustomers.AllowUserToOrderColumns = true;
            this.GridCustomers.AllowUserToResizeRows = false;
            this.GridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fullname,
            this.Birthdate,
            this.Gender,
            this.Address,
            this.ContactNum,
            this.EmailAddress,
            this.ImageLoc});
            this.GridCustomers.Location = new System.Drawing.Point(433, 106);
            this.GridCustomers.Margin = new System.Windows.Forms.Padding(5);
            this.GridCustomers.MultiSelect = false;
            this.GridCustomers.Name = "GridCustomers";
            this.GridCustomers.ReadOnly = true;
            this.GridCustomers.RowHeadersVisible = false;
            this.GridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCustomers.Size = new System.Drawing.Size(757, 475);
            this.GridCustomers.TabIndex = 10;
            this.GridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCustomers_CellClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 36.93885F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.FillWeight = 82.20373F;
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.FillWeight = 78.38728F;
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.FillWeight = 56.67597F;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.FillWeight = 116.8864F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // ContactNum
            // 
            this.ContactNum.FillWeight = 101.5229F;
            this.ContactNum.HeaderText = "Contact Number";
            this.ContactNum.Name = "ContactNum";
            this.ContactNum.ReadOnly = true;
            // 
            // EmailAddress
            // 
            this.EmailAddress.FillWeight = 147.2571F;
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            // 
            // ImageLoc
            // 
            this.ImageLoc.FillWeight = 180.1279F;
            this.ImageLoc.HeaderText = "Image Location";
            this.ImageLoc.Name = "ImageLoc";
            this.ImageLoc.ReadOnly = true;
            // 
            // CmbCustGender
            // 
            this.CmbCustGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbCustGender.FormattingEnabled = true;
            this.CmbCustGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CmbCustGender.Location = new System.Drawing.Point(16, 180);
            this.CmbCustGender.Name = "CmbCustGender";
            this.CmbCustGender.Size = new System.Drawing.Size(179, 24);
            this.CmbCustGender.TabIndex = 3;
            this.CmbCustGender.SelectedIndexChanged += new System.EventHandler(this.CmbCustGender_SelectedIndexChanged);
            // 
            // DtpBirthdate
            // 
            this.DtpBirthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DtpBirthdate.Location = new System.Drawing.Point(16, 125);
            this.DtpBirthdate.Name = "DtpBirthdate";
            this.DtpBirthdate.Size = new System.Drawing.Size(179, 20);
            this.DtpBirthdate.TabIndex = 2;
            this.DtpBirthdate.ValueChanged += new System.EventHandler(this.DtpBirthdate_ValueChanged);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackgroundColor = System.Drawing.Color.Black;
            this.BtnAddCustomer.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnAddCustomer.ButtonImage")));
            this.BtnAddCustomer.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnAddCustomer.ButtonText = "Add Customer";
            this.BtnAddCustomer.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnAddCustomer.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.BtnAddCustomer.CornerRadius = 5;
            this.BtnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnAddCustomer.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAddCustomer.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnAddCustomer.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddCustomer.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnAddCustomer.Location = new System.Drawing.Point(16, 393);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(179, 35);
            this.BtnAddCustomer.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnAddCustomer.TabIndex = 8;
            this.BtnAddCustomer.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddCustomer.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnAddCustomer.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // BtnUpload
            // 
            this.BtnUpload.BackgroundColor = System.Drawing.Color.Black;
            this.BtnUpload.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnUpload.ButtonImage")));
            this.BtnUpload.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnUpload.ButtonText = "";
            this.BtnUpload.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnUpload.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpload.CornerRadius = 5;
            this.BtnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnUpload.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnUpload.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnUpload.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpload.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Center;
            this.BtnUpload.Location = new System.Drawing.Point(298, 226);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(64, 23);
            this.BtnUpload.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnUpload.TabIndex = 7;
            this.BtnUpload.TextColor = System.Drawing.Color.Black;
            this.BtnUpload.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnUpload.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // PicCustomer
            // 
            this.PicCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicCustomer.Image = ((System.Drawing.Image)(resources.GetObject("PicCustomer.Image")));
            this.PicCustomer.Location = new System.Drawing.Point(258, 70);
            this.PicCustomer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.PicCustomer.Name = "PicCustomer";
            this.PicCustomer.Size = new System.Drawing.Size(150, 150);
            this.PicCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCustomer.TabIndex = 9;
            this.PicCustomer.TabStop = false;
            // 
            // TbEmailAdd
            // 
            this.TbEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbEmailAdd.Location = new System.Drawing.Point(16, 345);
            this.TbEmailAdd.Name = "TbEmailAdd";
            this.TbEmailAdd.Size = new System.Drawing.Size(179, 23);
            this.TbEmailAdd.TabIndex = 6;
            this.TbEmailAdd.TextChanged += new System.EventHandler(this.TbEmailAdd_TextChanged);
            // 
            // TbContactNum
            // 
            this.TbContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbContactNum.Location = new System.Drawing.Point(16, 290);
            this.TbContactNum.Name = "TbContactNum";
            this.TbContactNum.Size = new System.Drawing.Size(179, 23);
            this.TbContactNum.TabIndex = 5;
            this.TbContactNum.TextChanged += new System.EventHandler(this.TbContactNum_TextChanged);
            // 
            // TbAddress
            // 
            this.TbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbAddress.Location = new System.Drawing.Point(16, 235);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(179, 23);
            this.TbAddress.TabIndex = 4;
            this.TbAddress.TextChanged += new System.EventHandler(this.TbAddress_TextChanged);
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbCustomerName.Location = new System.Drawing.Point(16, 70);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.Size = new System.Drawing.Size(179, 23);
            this.TbCustomerName.TabIndex = 1;
            this.TbCustomerName.TextChanged += new System.EventHandler(this.TbCustomerName_TextChanged);
            // 
            // LblEmailAd
            // 
            this.LblEmailAd.AutoSize = true;
            this.LblEmailAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailAd.ForeColor = System.Drawing.Color.White;
            this.LblEmailAd.Location = new System.Drawing.Point(13, 326);
            this.LblEmailAd.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblEmailAd.Name = "LblEmailAd";
            this.LblEmailAd.Size = new System.Drawing.Size(95, 16);
            this.LblEmailAd.TabIndex = 7;
            this.LblEmailAd.Text = "Email Address";
            // 
            // LblContactNo
            // 
            this.LblContactNo.AutoSize = true;
            this.LblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactNo.ForeColor = System.Drawing.Color.White;
            this.LblContactNo.Location = new System.Drawing.Point(13, 271);
            this.LblContactNo.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblContactNo.Name = "LblContactNo";
            this.LblContactNo.Size = new System.Drawing.Size(103, 16);
            this.LblContactNo.TabIndex = 7;
            this.LblContactNo.Text = "Contact Number";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.ForeColor = System.Drawing.Color.White;
            this.LblAddress.Location = new System.Drawing.Point(13, 216);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(58, 16);
            this.LblAddress.TabIndex = 7;
            this.LblAddress.Text = "Address";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.ForeColor = System.Drawing.Color.White;
            this.LblGender.Location = new System.Drawing.Point(13, 161);
            this.LblGender.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(52, 16);
            this.LblGender.TabIndex = 7;
            this.LblGender.Text = "Gender";
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBirthDate.ForeColor = System.Drawing.Color.White;
            this.LblBirthDate.Location = new System.Drawing.Point(13, 106);
            this.LblBirthDate.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(60, 16);
            this.LblBirthDate.TabIndex = 7;
            this.LblBirthDate.Text = "Birthdate";
            // 
            // LblTotalRecs
            // 
            this.LblTotalRecs.AutoSize = true;
            this.LblTotalRecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalRecs.ForeColor = System.Drawing.Color.White;
            this.LblTotalRecs.Location = new System.Drawing.Point(430, 589);
            this.LblTotalRecs.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblTotalRecs.Name = "LblTotalRecs";
            this.LblTotalRecs.Size = new System.Drawing.Size(96, 16);
            this.LblTotalRecs.TabIndex = 7;
            this.LblTotalRecs.Text = "Total Records:";
            // 
            // LblFullNameSearch
            // 
            this.LblFullNameSearch.AutoSize = true;
            this.LblFullNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullNameSearch.ForeColor = System.Drawing.Color.White;
            this.LblFullNameSearch.Location = new System.Drawing.Point(430, 51);
            this.LblFullNameSearch.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblFullNameSearch.Name = "LblFullNameSearch";
            this.LblFullNameSearch.Size = new System.Drawing.Size(68, 16);
            this.LblFullNameSearch.TabIndex = 7;
            this.LblFullNameSearch.Text = "Full Name";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.ForeColor = System.Drawing.Color.White;
            this.LblCustomerName.Location = new System.Drawing.Point(13, 51);
            this.LblCustomerName.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(68, 16);
            this.LblCustomerName.TabIndex = 7;
            this.LblCustomerName.Text = "Full Name";
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.ForeColor = System.Drawing.Color.White;
            this.LblSearch.Location = new System.Drawing.Point(427, 10);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(100, 31);
            this.LblSearch.TabIndex = 8;
            this.LblSearch.Text = "Search";
            // 
            // LblCustomerInfo
            // 
            this.LblCustomerInfo.AutoSize = true;
            this.LblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerInfo.ForeColor = System.Drawing.Color.White;
            this.LblCustomerInfo.Location = new System.Drawing.Point(10, 10);
            this.LblCustomerInfo.Name = "LblCustomerInfo";
            this.LblCustomerInfo.Size = new System.Drawing.Size(390, 31);
            this.LblCustomerInfo.TabIndex = 8;
            this.LblCustomerInfo.Text = "Customer Info (New Customer)";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 624);
            this.Controls.Add(this.PnlCustomers);
            this.Name = "Customers";
            this.Text = "Customers";
            this.PnlCustomers.ResumeLayout(false);
            this.PnlCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCustomers;
        private System.Windows.Forms.PictureBox PicCustomer;
        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label LblCustomerInfo;
        private System.Windows.Forms.TextBox TbAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblBirthDate;
        private ReaLTaiizor.Controls.ParrotButton BtnAddCustomer;
        private ReaLTaiizor.Controls.ParrotButton BtnUpload;
        private System.Windows.Forms.TextBox TbEmailAdd;
        private System.Windows.Forms.TextBox TbContactNum;
        private System.Windows.Forms.Label LblEmailAd;
        private System.Windows.Forms.Label LblContactNo;
        private System.Windows.Forms.DateTimePicker DtpBirthdate;
        private System.Windows.Forms.ComboBox CmbCustGender;
        private System.Windows.Forms.DataGridView GridCustomers;
        private System.Windows.Forms.Label LblFullNameSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageLoc;
        private ReaLTaiizor.Controls.ParrotButton BtnSearch;
        private ReaLTaiizor.Controls.ParrotButton BtnDelete;
        private ReaLTaiizor.Controls.ParrotButton BtnUpdate;
        private System.Windows.Forms.TextBox TbFullnameSearch;
        private System.Windows.Forms.Label LblTotalRecs;

        private void ClearCustomerPic()
        {
            this.PicCustomer.Image = ((System.Drawing.Image)(resources.GetObject("PicCustomer.Image")));
            //this.PicCustomer.Image =
        }

        private ReaLTaiizor.Controls.ParrotButton BtnCancel;
    }
}