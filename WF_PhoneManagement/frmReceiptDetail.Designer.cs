﻿namespace WF_PhoneManagement
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudRe_PQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(121, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(202, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nudRe_PQuantity
            // 
            this.nudRe_PQuantity.Enabled = false;
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
            this.txtRe_PPrice.Enabled = false;
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private Button button1;
        private Button button2;
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
    }
}