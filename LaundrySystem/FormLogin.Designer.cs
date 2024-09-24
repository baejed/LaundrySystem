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
            this.LblUser = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.LblLaundrySystem = new System.Windows.Forms.Label();
            this.BtnLogin = new ReaLTaiizor.Controls.ParrotButton();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(12, 109);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(147, 31);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Username";
            // 
            // TbUsername
            // 
            this.TbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsername.Location = new System.Drawing.Point(214, 106);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(248, 38);
            this.TbUsername.TabIndex = 0;
            this.TbUsername.TextChanged += new System.EventHandler(this.TbUsername_TextChanged);
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.Color.White;
            this.LblPass.Location = new System.Drawing.Point(12, 169);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(142, 31);
            this.LblPass.TabIndex = 0;
            this.LblPass.Text = "Password";
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(214, 166);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(248, 38);
            this.TbPassword.TabIndex = 1;
            this.TbPassword.TextChanged += new System.EventHandler(this.TbPassword_TextChanged);
            // 
            // LblLaundrySystem
            // 
            this.LblLaundrySystem.AutoSize = true;
            this.LblLaundrySystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLaundrySystem.ForeColor = System.Drawing.Color.White;
            this.LblLaundrySystem.Location = new System.Drawing.Point(88, 23);
            this.LblLaundrySystem.Name = "LblLaundrySystem";
            this.LblLaundrySystem.Size = new System.Drawing.Size(302, 42);
            this.LblLaundrySystem.TabIndex = 3;
            this.LblLaundrySystem.Text = "Laundry System";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BtnLogin.Location = new System.Drawing.Point(12, 229);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(450, 50);
            this.BtnLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.TextColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(474, 310);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblLaundrySystem);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblUser);
            this.Name = "FormLogin";
            this.Text = "Laundry System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label LblLaundrySystem;
        private ReaLTaiizor.Controls.ParrotButton BtnLogin;
    }
}

