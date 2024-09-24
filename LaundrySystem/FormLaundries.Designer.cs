namespace LaundrySystem
{
    partial class FormLaundries
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
            this.PnlLaundries = new System.Windows.Forms.Panel();
            this.btnLaundryFinished = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GarmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaundryContentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.LblLaundryContents = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LaundryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblGarmetType = new System.Windows.Forms.Label();
            this.PnlLaundries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLaundries
            // 
            this.PnlLaundries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlLaundries.Controls.Add(this.LblGarmetType);
            this.PnlLaundries.Controls.Add(this.btnLaundryFinished);
            this.PnlLaundries.Controls.Add(this.dataGridView2);
            this.PnlLaundries.Controls.Add(this.label1);
            this.PnlLaundries.Controls.Add(this.LblLaundryContents);
            this.PnlLaundries.Controls.Add(this.dataGridView1);
            this.PnlLaundries.Location = new System.Drawing.Point(12, 12);
            this.PnlLaundries.Name = "PnlLaundries";
            this.PnlLaundries.Size = new System.Drawing.Size(1035, 570);
            this.PnlLaundries.TabIndex = 0;
            // 
            // btnLaundryFinished
            // 
            this.btnLaundryFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLaundryFinished.Location = new System.Drawing.Point(8, 397);
            this.btnLaundryFinished.Name = "btnLaundryFinished";
            this.btnLaundryFinished.Size = new System.Drawing.Size(75, 23);
            this.btnLaundryFinished.TabIndex = 3;
            this.btnLaundryFinished.Text = "Finished";
            this.btnLaundryFinished.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GarmentType,
            this.Quantity,
            this.LaundryContentAmount});
            this.dataGridView2.Location = new System.Drawing.Point(8, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(494, 283);
            this.dataGridView2.TabIndex = 2;
            // 
            // GarmentType
            // 
            this.GarmentType.HeaderText = "Garment Type";
            this.GarmentType.Name = "GarmentType";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // LaundryContentAmount
            // 
            this.LaundryContentAmount.HeaderText = "Amount";
            this.LaundryContentAmount.Name = "LaundryContentAmount";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ongoing Laundries";
            // 
            // LblLaundryContents
            // 
            this.LblLaundryContents.AutoSize = true;
            this.LblLaundryContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLaundryContents.Location = new System.Drawing.Point(3, 3);
            this.LblLaundryContents.Name = "LblLaundryContents";
            this.LblLaundryContents.Size = new System.Drawing.Size(182, 25);
            this.LblLaundryContents.TabIndex = 1;
            this.LblLaundryContents.Text = "Laundry Contents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LaundryID,
            this.ServiceType,
            this.Weight,
            this.Amount,
            this.Status,
            this.Staff});
            this.dataGridView1.Location = new System.Drawing.Point(508, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(524, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // LaundryID
            // 
            this.LaundryID.HeaderText = "Laundry ID";
            this.LaundryID.Name = "LaundryID";
            // 
            // ServiceType
            // 
            this.ServiceType.HeaderText = "Service Type";
            this.ServiceType.Name = "ServiceType";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Staff
            // 
            this.Staff.HeaderText = "Staff";
            this.Staff.Name = "Staff";
            // 
            // LblGarmetType
            // 
            this.LblGarmetType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblGarmetType.AutoSize = true;
            this.LblGarmetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGarmetType.Location = new System.Drawing.Point(3, 356);
            this.LblGarmetType.Name = "LblGarmetType";
            this.LblGarmetType.Size = new System.Drawing.Size(154, 25);
            this.LblGarmetType.TabIndex = 4;
            this.LblGarmetType.Text = "Garment Type:";
            // 
            // Laundries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 594);
            this.Controls.Add(this.PnlLaundries);
            this.Name = "Laundries";
            this.Text = "Laundries";
            this.PnlLaundries.ResumeLayout(false);
            this.PnlLaundries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLaundries;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaundryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label LblLaundryContents;
        private System.Windows.Forms.DataGridViewTextBoxColumn GarmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaundryContentAmount;
        private System.Windows.Forms.Button btnLaundryFinished;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblGarmetType;
    }
}