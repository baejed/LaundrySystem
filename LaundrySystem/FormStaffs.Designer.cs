namespace LaundrySystem
{
    partial class FormStaffs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaffs));
            this.BtnDelete = new ReaLTaiizor.Controls.ParrotButton();
            this.BtnUpdate = new ReaLTaiizor.Controls.ParrotButton();
            this.BtnSearch = new ReaLTaiizor.Controls.ParrotButton();
            this.TbFullnameSearch = new System.Windows.Forms.TextBox();
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbCustGender = new System.Windows.Forms.ComboBox();
            this.DtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.BtnAddStaff = new ReaLTaiizor.Controls.ParrotButton();
            this.TbEmailAdd = new System.Windows.Forms.TextBox();
            this.PnlCustomers = new System.Windows.Forms.Panel();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.TbContactNum = new System.Windows.Forms.TextBox();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.TbCustomerName = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblEmailAd = new System.Windows.Forms.Label();
            this.LblContactNo = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.LblFullNameSearch = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.LblSearch = new System.Windows.Forms.Label();
            this.LblCustomerInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.PnlCustomers.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnDelete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnDelete.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnDelete.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnDelete.Location = new System.Drawing.Point(838, 563);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(131, 30);
            this.BtnDelete.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnDelete.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnDelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnUpdate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnUpdate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnUpdate.Location = new System.Drawing.Point(975, 563);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(131, 30);
            this.BtnUpdate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnUpdate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.BtnSearch.Location = new System.Drawing.Point(1112, 563);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(131, 30);
            this.BtnSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnSearch.TabIndex = 16;
            this.BtnSearch.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // TbFullnameSearch
            // 
            this.TbFullnameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFullnameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFullnameSearch.Location = new System.Drawing.Point(363, 70);
            this.TbFullnameSearch.Name = "TbFullnameSearch";
            this.TbFullnameSearch.Size = new System.Drawing.Size(880, 31);
            this.TbFullnameSearch.TabIndex = 15;
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fullname,
            this.Birthdate,
            this.Gender,
            this.Address,
            this.ContactNum,
            this.EmailAddress,
            this.Username,
            this.Password});
            this.DgvCustomers.Location = new System.Drawing.Point(363, 106);
            this.DgvCustomers.Margin = new System.Windows.Forms.Padding(5);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.RowHeadersVisible = false;
            this.DgvCustomers.Size = new System.Drawing.Size(880, 449);
            this.DgvCustomers.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.FillWeight = 36.93885F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Fullname
            // 
            this.Fullname.FillWeight = 82.20373F;
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.Name = "Fullname";
            // 
            // Birthdate
            // 
            this.Birthdate.FillWeight = 78.38728F;
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            // 
            // Gender
            // 
            this.Gender.FillWeight = 56.67597F;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Address
            // 
            this.Address.FillWeight = 116.8864F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // ContactNum
            // 
            this.ContactNum.FillWeight = 101.5229F;
            this.ContactNum.HeaderText = "Contact Number";
            this.ContactNum.Name = "ContactNum";
            // 
            // EmailAddress
            // 
            this.EmailAddress.FillWeight = 147.2571F;
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
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
            this.CmbCustGender.Size = new System.Drawing.Size(212, 24);
            this.CmbCustGender.TabIndex = 13;
            // 
            // DtpBirthdate
            // 
            this.DtpBirthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DtpBirthdate.Location = new System.Drawing.Point(16, 125);
            this.DtpBirthdate.Name = "DtpBirthdate";
            this.DtpBirthdate.Size = new System.Drawing.Size(212, 20);
            this.DtpBirthdate.TabIndex = 12;
            this.DtpBirthdate.ValueChanged += new System.EventHandler(this.DtpBirthdate_ValueChanged);
            // 
            // BtnAddStaff
            // 
            this.BtnAddStaff.BackgroundColor = System.Drawing.Color.Black;
            this.BtnAddStaff.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnAddStaff.ButtonImage")));
            this.BtnAddStaff.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnAddStaff.ButtonText = "Add Staff";
            this.BtnAddStaff.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.BtnAddStaff.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.BtnAddStaff.CornerRadius = 5;
            this.BtnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnAddStaff.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAddStaff.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnAddStaff.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddStaff.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnAddStaff.Location = new System.Drawing.Point(12, 494);
            this.BtnAddStaff.Name = "BtnAddStaff";
            this.BtnAddStaff.Size = new System.Drawing.Size(179, 35);
            this.BtnAddStaff.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnAddStaff.TabIndex = 11;
            this.BtnAddStaff.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddStaff.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnAddStaff.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
            // 
            // TbEmailAdd
            // 
            this.TbEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbEmailAdd.Location = new System.Drawing.Point(16, 345);
            this.TbEmailAdd.Name = "TbEmailAdd";
            this.TbEmailAdd.Size = new System.Drawing.Size(212, 23);
            this.TbEmailAdd.TabIndex = 6;
            this.TbEmailAdd.TextChanged += new System.EventHandler(this.TbEmailAdd_TextChanged);
            // 
            // PnlCustomers
            // 
            this.PnlCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCustomers.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnlCustomers.Controls.Add(this.BtnDelete);
            this.PnlCustomers.Controls.Add(this.BtnUpdate);
            this.PnlCustomers.Controls.Add(this.BtnSearch);
            this.PnlCustomers.Controls.Add(this.TbFullnameSearch);
            this.PnlCustomers.Controls.Add(this.DgvCustomers);
            this.PnlCustomers.Controls.Add(this.CmbCustGender);
            this.PnlCustomers.Controls.Add(this.DtpBirthdate);
            this.PnlCustomers.Controls.Add(this.BtnAddStaff);
            this.PnlCustomers.Controls.Add(this.TbPassword);
            this.PnlCustomers.Controls.Add(this.TbUser);
            this.PnlCustomers.Controls.Add(this.TbEmailAdd);
            this.PnlCustomers.Controls.Add(this.TbContactNum);
            this.PnlCustomers.Controls.Add(this.TbAddress);
            this.PnlCustomers.Controls.Add(this.TbCustomerName);
            this.PnlCustomers.Controls.Add(this.LblPass);
            this.PnlCustomers.Controls.Add(this.LblUser);
            this.PnlCustomers.Controls.Add(this.LblEmailAd);
            this.PnlCustomers.Controls.Add(this.LblContactNo);
            this.PnlCustomers.Controls.Add(this.LblAddress);
            this.PnlCustomers.Controls.Add(this.LblGender);
            this.PnlCustomers.Controls.Add(this.LblBirthDate);
            this.PnlCustomers.Controls.Add(this.LblFullNameSearch);
            this.PnlCustomers.Controls.Add(this.LblCustomerName);
            this.PnlCustomers.Controls.Add(this.LblSearch);
            this.PnlCustomers.Controls.Add(this.LblCustomerInfo);
            this.PnlCustomers.Location = new System.Drawing.Point(0, 0);
            this.PnlCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.PnlCustomers.Name = "PnlCustomers";
            this.PnlCustomers.Size = new System.Drawing.Size(1258, 598);
            this.PnlCustomers.TabIndex = 1;
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbPassword.Location = new System.Drawing.Point(16, 455);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(212, 23);
            this.TbPassword.TabIndex = 6;
            this.TbPassword.TextChanged += new System.EventHandler(this.TbPassword_TextChanged);
            // 
            // TbUser
            // 
            this.TbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbUser.Location = new System.Drawing.Point(16, 400);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(212, 23);
            this.TbUser.TabIndex = 6;
            this.TbUser.TextChanged += new System.EventHandler(this.TbUser_TextChanged);
            // 
            // TbContactNum
            // 
            this.TbContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbContactNum.Location = new System.Drawing.Point(16, 290);
            this.TbContactNum.Name = "TbContactNum";
            this.TbContactNum.Size = new System.Drawing.Size(212, 23);
            this.TbContactNum.TabIndex = 6;
            this.TbContactNum.TextChanged += new System.EventHandler(this.TbContactNum_TextChanged);
            // 
            // TbAddress
            // 
            this.TbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbAddress.Location = new System.Drawing.Point(16, 235);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(212, 23);
            this.TbAddress.TabIndex = 6;
            this.TbAddress.TextChanged += new System.EventHandler(this.TbAddress_TextChanged);
            // 
            // TbCustomerName
            // 
            this.TbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbCustomerName.Location = new System.Drawing.Point(16, 70);
            this.TbCustomerName.Name = "TbCustomerName";
            this.TbCustomerName.Size = new System.Drawing.Size(212, 23);
            this.TbCustomerName.TabIndex = 6;
            this.TbCustomerName.TextChanged += new System.EventHandler(this.TbCustomerName_TextChanged);
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.Color.White;
            this.LblPass.Location = new System.Drawing.Point(13, 436);
            this.LblPass.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(67, 16);
            this.LblPass.TabIndex = 7;
            this.LblPass.Text = "Password";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(13, 381);
            this.LblUser.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(70, 16);
            this.LblUser.TabIndex = 7;
            this.LblUser.Text = "Username";
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
            // LblFullNameSearch
            // 
            this.LblFullNameSearch.AutoSize = true;
            this.LblFullNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullNameSearch.ForeColor = System.Drawing.Color.White;
            this.LblFullNameSearch.Location = new System.Drawing.Point(360, 51);
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
            this.LblSearch.Location = new System.Drawing.Point(357, 10);
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
            this.LblCustomerInfo.Size = new System.Drawing.Size(329, 31);
            this.LblCustomerInfo.TabIndex = 8;
            this.LblCustomerInfo.Text = "Staff Info (New Customer)";
            // 
            // FormStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 598);
            this.Controls.Add(this.PnlCustomers);
            this.Name = "FormStaffs";
            this.Text = "FormStaffs";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.PnlCustomers.ResumeLayout(false);
            this.PnlCustomers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton BtnDelete;
        private ReaLTaiizor.Controls.ParrotButton BtnUpdate;
        private ReaLTaiizor.Controls.ParrotButton BtnSearch;
        private System.Windows.Forms.TextBox TbFullnameSearch;
        private System.Windows.Forms.DataGridView DgvCustomers;
        private System.Windows.Forms.ComboBox CmbCustGender;
        private System.Windows.Forms.DateTimePicker DtpBirthdate;
        private ReaLTaiizor.Controls.ParrotButton BtnAddStaff;
        private System.Windows.Forms.TextBox TbEmailAdd;
        private System.Windows.Forms.Panel PnlCustomers;
        private System.Windows.Forms.TextBox TbContactNum;
        private System.Windows.Forms.TextBox TbAddress;
        private System.Windows.Forms.TextBox TbCustomerName;
        private System.Windows.Forms.Label LblEmailAd;
        private System.Windows.Forms.Label LblContactNo;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblBirthDate;
        private System.Windows.Forms.Label LblFullNameSearch;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Label LblCustomerInfo;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}