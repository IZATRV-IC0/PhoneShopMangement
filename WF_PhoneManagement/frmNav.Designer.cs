
namespace WF_PhoneManagement
{
    partial class frmNav
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
            this.grbManage = new System.Windows.Forms.GroupBox();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.grbOther = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grbManage.SuspendLayout();
            this.grbOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbManage
            // 
            this.grbManage.Controls.Add(this.btnSales);
            this.grbManage.Controls.Add(this.btnView);
            this.grbManage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbManage.Location = new System.Drawing.Point(34, 32);
            this.grbManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbManage.Name = "grbManage";
            this.grbManage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbManage.Size = new System.Drawing.Size(501, 249);
            this.grbManage.TabIndex = 0;
            this.grbManage.TabStop = false;
            this.grbManage.Text = "Manage";
            // 
            // btnSales
            // 
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSales.Location = new System.Drawing.Point(261, 104);
            this.btnSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(162, 31);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(29, 104);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(162, 31);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Manage";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // grbOther
            // 
            this.grbOther.Controls.Add(this.btnLogout);
            this.grbOther.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbOther.Location = new System.Drawing.Point(34, 321);
            this.grbOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbOther.Name = "grbOther";
            this.grbOther.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbOther.Size = new System.Drawing.Size(501, 173);
            this.grbOther.TabIndex = 0;
            this.grbOther.TabStop = false;
            this.grbOther.Text = "Other";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(145, 71);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(162, 31);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 541);
            this.Controls.Add(this.grbOther);
            this.Controls.Add(this.grbManage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNav";
            this.Text = "Navigation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.grbManage.ResumeLayout(false);
            this.grbOther.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grbOther;
        private GroupBox grbManage;
        private Button btnView;
        private Button btnSales;
        private Button btnLogout;
    }
}