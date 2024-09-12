namespace LaundrySystem
{
    partial class LoginForm
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
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.LblLaundrySystem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.Location = new System.Drawing.Point(18, 228);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(444, 54);
            this.BtnSignIn.TabIndex = 2;
            this.BtnSignIn.Text = "Sign in";
            this.BtnSignIn.UseVisualStyleBackColor = true;
            // 
            // LblLaundrySystem
            // 
            this.LblLaundrySystem.AutoSize = true;
            this.LblLaundrySystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLaundrySystem.Location = new System.Drawing.Point(88, 23);
            this.LblLaundrySystem.Name = "LblLaundrySystem";
            this.LblLaundrySystem.Size = new System.Drawing.Size(302, 42);
            this.LblLaundrySystem.TabIndex = 3;
            this.LblLaundrySystem.Text = "Laundry System";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 310);
            this.Controls.Add(this.LblLaundrySystem);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblUser);
            this.Name = "LoginForm";
            this.Text = "Laundry System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label LblLaundrySystem;
    }
}

