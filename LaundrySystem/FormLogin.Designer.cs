namespace LaundrySystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.LblUser = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new ReaLTaiizor.Controls.ParrotButton();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(12, 206);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(147, 31);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Username";
            // 
            // TbUsername
            // 
            this.TbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsername.Location = new System.Drawing.Point(214, 203);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(283, 38);
            this.TbUsername.TabIndex = 0;
            this.TbUsername.TextChanged += new System.EventHandler(this.TbUsername_TextChanged);
            this.TbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPassword_KeyDown);
            // 
            // LblPass
            // 
            this.LblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.Color.White;
            this.LblPass.Location = new System.Drawing.Point(12, 266);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(142, 31);
            this.LblPass.TabIndex = 0;
            this.LblPass.Text = "Password";
            // 
            // TbPassword
            // 
            this.TbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(214, 263);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(283, 38);
            this.TbPassword.TabIndex = 1;
            this.TbPassword.TextChanged += new System.EventHandler(this.TbPassword_TextChanged);
            this.TbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPassword_KeyDown);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLogin.ButtonImage = null;
            this.BtnLogin.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.BtnLogin.ButtonText = "LOG IN";
            this.BtnLogin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnLogin.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogin.CornerRadius = 5;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnLogin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnLogin.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogin.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.BtnLogin.Location = new System.Drawing.Point(12, 326);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(485, 50);
            this.BtnLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(19, 8);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(10);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(478, 188);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 5;
            this.PicLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(509, 407);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblUser);
            this.Name = "FormLogin";
            this.Text = "Laundry System";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox TbPassword;
        private ReaLTaiizor.Controls.ParrotButton BtnLogin;
        private System.Windows.Forms.PictureBox PicLogo;
    }
}

