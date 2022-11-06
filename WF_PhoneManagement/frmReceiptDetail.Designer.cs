namespace WF_PhoneManagement
{
    partial class frmReceiptDetail
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudRe_PQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblRePID = new System.Windows.Forms.Label();
            this.lblRePTotal = new System.Windows.Forms.Label();
            this.cbbRe_PID = new System.Windows.Forms.ComboBox();
            this.lblRePName = new System.Windows.Forms.Label();
            this.lblRePQuantity = new System.Windows.Forms.Label();
            this.txtRe_PName = new System.Windows.Forms.TextBox();
            this.txtRe_PPrice = new System.Windows.Forms.TextBox();
            this.lblRePPrice = new System.Windows.Forms.Label();
            this.txtRe_PTotal = new System.Windows.Forms.TextBox();
            this.btnPhone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRe_PQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(112, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudRe_PQuantity
            // 
            this.nudRe_PQuantity.Location = new System.Drawing.Point(113, 174);
            this.nudRe_PQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRe_PQuantity.Name = "nudRe_PQuantity";
            this.nudRe_PQuantity.Size = new System.Drawing.Size(120, 23);
            this.nudRe_PQuantity.TabIndex = 13;
            this.nudRe_PQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRePID
            // 
            this.lblRePID.AutoSize = true;
            this.lblRePID.Enabled = false;
            this.lblRePID.Location = new System.Drawing.Point(44, 49);
            this.lblRePID.Name = "lblRePID";
            this.lblRePID.Size = new System.Drawing.Size(21, 15);
            this.lblRePID.TabIndex = 8;
            this.lblRePID.Text = "ID:";
            // 
            // lblRePTotal
            // 
            this.lblRePTotal.AutoSize = true;
            this.lblRePTotal.Enabled = false;
            this.lblRePTotal.Location = new System.Drawing.Point(44, 222);
            this.lblRePTotal.Name = "lblRePTotal";
            this.lblRePTotal.Size = new System.Drawing.Size(35, 15);
            this.lblRePTotal.TabIndex = 9;
            this.lblRePTotal.Text = "Total:";
            // 
            // cbbRe_PID
            // 
            this.cbbRe_PID.Enabled = false;
            this.cbbRe_PID.FormattingEnabled = true;
            this.cbbRe_PID.Location = new System.Drawing.Point(112, 46);
            this.cbbRe_PID.Name = "cbbRe_PID";
            this.cbbRe_PID.Size = new System.Drawing.Size(121, 23);
            this.cbbRe_PID.TabIndex = 7;
            // 
            // lblRePName
            // 
            this.lblRePName.AutoSize = true;
            this.lblRePName.Enabled = false;
            this.lblRePName.Location = new System.Drawing.Point(44, 90);
            this.lblRePName.Name = "lblRePName";
            this.lblRePName.Size = new System.Drawing.Size(42, 15);
            this.lblRePName.TabIndex = 10;
            this.lblRePName.Text = "Name:";
            // 
            // lblRePQuantity
            // 
            this.lblRePQuantity.AutoSize = true;
            this.lblRePQuantity.Enabled = false;
            this.lblRePQuantity.Location = new System.Drawing.Point(44, 176);
            this.lblRePQuantity.Name = "lblRePQuantity";
            this.lblRePQuantity.Size = new System.Drawing.Size(56, 15);
            this.lblRePQuantity.TabIndex = 11;
            this.lblRePQuantity.Text = "Quantity:";
            // 
            // txtRe_PName
            // 
            this.txtRe_PName.Enabled = false;
            this.txtRe_PName.Location = new System.Drawing.Point(112, 87);
            this.txtRe_PName.Name = "txtRe_PName";
            this.txtRe_PName.ReadOnly = true;
            this.txtRe_PName.Size = new System.Drawing.Size(233, 23);
            this.txtRe_PName.TabIndex = 4;
            // 
            // txtRe_PPrice
            // 
            this.txtRe_PPrice.Location = new System.Drawing.Point(112, 129);
            this.txtRe_PPrice.Name = "txtRe_PPrice";
            this.txtRe_PPrice.ReadOnly = true;
            this.txtRe_PPrice.Size = new System.Drawing.Size(121, 23);
            this.txtRe_PPrice.TabIndex = 5;
            // 
            // lblRePPrice
            // 
            this.lblRePPrice.AutoSize = true;
            this.lblRePPrice.Enabled = false;
            this.lblRePPrice.Location = new System.Drawing.Point(44, 132);
            this.lblRePPrice.Name = "lblRePPrice";
            this.lblRePPrice.Size = new System.Drawing.Size(36, 15);
            this.lblRePPrice.TabIndex = 12;
            this.lblRePPrice.Text = "Price:";
            // 
            // txtRe_PTotal
            // 
            this.txtRe_PTotal.Enabled = false;
            this.txtRe_PTotal.Location = new System.Drawing.Point(112, 219);
            this.txtRe_PTotal.Name = "txtRe_PTotal";
            this.txtRe_PTotal.ReadOnly = true;
            this.txtRe_PTotal.Size = new System.Drawing.Size(121, 23);
            this.txtRe_PTotal.TabIndex = 6;
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(252, 45);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(93, 23);
            this.btnPhone.TabIndex = 3;
            this.btnPhone.Text = "Phone...";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // frmReceiptDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 339);
            this.Controls.Add(this.nudRe_PQuantity);
            this.Controls.Add(this.lblRePID);
            this.Controls.Add(this.lblRePTotal);
            this.Controls.Add(this.cbbRe_PID);
            this.Controls.Add(this.lblRePName);
            this.Controls.Add(this.lblRePQuantity);
            this.Controls.Add(this.txtRe_PName);
            this.Controls.Add(this.txtRe_PPrice);
            this.Controls.Add(this.lblRePPrice);
            this.Controls.Add(this.txtRe_PTotal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnOK);
            this.Name = "frmReceiptDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Detail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReceiptDetail_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReceiptDetail_FormClosed);
            this.Load += new System.EventHandler(this.frmReceiptDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRe_PQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnOK;
        private Button btnCancel;
        private NumericUpDown nudRe_PQuantity;
        private Label lblRePID;
        private Label lblRePTotal;
        private ComboBox cbbRe_PID;
        private Label lblRePName;
        private Label lblRePQuantity;
        private TextBox txtRe_PName;
        private TextBox txtRe_PPrice;
        private Label lblRePPrice;
        private TextBox txtRe_PTotal;
        private Button btnPhone;
    }
}