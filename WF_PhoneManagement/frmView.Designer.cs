﻿namespace WF_PhoneManagement
{
    partial class frmView
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchInfo = new System.Windows.Forms.TextBox();
            this.lblListPick = new System.Windows.Forms.Label();
            this.dgvShowList = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblField = new System.Windows.Forms.Label();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.lboxListPick = new System.Windows.Forms.ListBox();
            this.lboxBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(658, 151);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchInfo
            // 
            this.txtSearchInfo.Location = new System.Drawing.Point(434, 151);
            this.txtSearchInfo.Name = "txtSearchInfo";
            this.txtSearchInfo.PlaceholderText = "id or name";
            this.txtSearchInfo.Size = new System.Drawing.Size(187, 23);
            this.txtSearchInfo.TabIndex = 2;
            // 
            // lblListPick
            // 
            this.lblListPick.AutoSize = true;
            this.lblListPick.Location = new System.Drawing.Point(75, 48);
            this.lblListPick.Name = "lblListPick";
            this.lblListPick.Size = new System.Drawing.Size(28, 15);
            this.lblListPick.TabIndex = 4;
            this.lblListPick.Text = "List:";
            // 
            // dgvShowList
            // 
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.Location = new System.Drawing.Point(75, 202);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.RowTemplate.Height = 25;
            this.dgvShowList.Size = new System.Drawing.Size(658, 238);
            this.dgvShowList.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(362, 461);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(506, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(353, 48);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(58, 15);
            this.lblField.TabIndex = 11;
            this.lblField.Text = "Category:";
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Location = new System.Drawing.Point(353, 154);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(33, 15);
            this.lblSearchInfo.TabIndex = 11;
            this.lblSearchInfo.Text = "Find:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(647, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 461);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(84, 461);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 8;
            this.btnPick.Text = "Detail";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // lboxListPick
            // 
            this.lboxListPick.FormattingEnabled = true;
            this.lboxListPick.ItemHeight = 15;
            this.lboxListPick.Items.AddRange(new object[] {
            "Receipt",
            "Import",
            "Customer",
            "Supplier",
            "Model",
            "Phone"});
            this.lboxListPick.Location = new System.Drawing.Point(124, 18);
            this.lboxListPick.Name = "lboxListPick";
            this.lboxListPick.Size = new System.Drawing.Size(120, 94);
            this.lboxListPick.TabIndex = 15;
            this.lboxListPick.SelectedIndexChanged += new System.EventHandler(this.lboxListPick_SelectedIndexChanged);
            // 
            // lboxBox
            // 
            this.lboxBox.FormattingEnabled = true;
            this.lboxBox.ItemHeight = 15;
            this.lboxBox.Location = new System.Drawing.Point(452, 18);
            this.lboxBox.Name = "lboxBox";
            this.lboxBox.Size = new System.Drawing.Size(120, 94);
            this.lboxBox.TabIndex = 16;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 513);
            this.Controls.Add(this.lboxBox);
            this.Controls.Add(this.lboxListPick);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSearchInfo);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvShowList);
            this.Controls.Add(this.lblListPick);
            this.Controls.Add(this.txtSearchInfo);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmView";
            this.Text = "View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmView_FormClosed);
            this.Load += new System.EventHandler(this.frmView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSearch;
        private TextBox txtSearchInfo;
        private Label lblListPick;
        private DataGridView dgvShowList;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblField;
        private Label lblSearchInfo;
        private Button btnExit;
        private Button btnAdd;
        private Button btnPick;
        private ListBox lboxListPick;
        private ListBox lboxBox;
    }
}