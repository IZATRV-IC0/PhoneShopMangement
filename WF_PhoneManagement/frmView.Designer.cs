namespace WF_PhoneManagement
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
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.lboxListPick = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(585, 187);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchInfo
            // 
            this.txtSearchInfo.Location = new System.Drawing.Point(329, 187);
            this.txtSearchInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchInfo.Name = "txtSearchInfo";
            this.txtSearchInfo.PlaceholderText = "id or name";
            this.txtSearchInfo.Size = new System.Drawing.Size(213, 27);
            this.txtSearchInfo.TabIndex = 2;
            // 
            // lblListPick
            // 
            this.lblListPick.AutoSize = true;
            this.lblListPick.Location = new System.Drawing.Point(242, 50);
            this.lblListPick.Name = "lblListPick";
            this.lblListPick.Size = new System.Drawing.Size(34, 20);
            this.lblListPick.TabIndex = 4;
            this.lblListPick.Text = "List:";
            // 
            // dgvShowList
            // 
            this.dgvShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowList.Location = new System.Drawing.Point(104, 256);
            this.dgvShowList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvShowList.Name = "dgvShowList";
            this.dgvShowList.RowHeadersWidth = 51;
            this.dgvShowList.RowTemplate.Height = 25;
            this.dgvShowList.Size = new System.Drawing.Size(752, 317);
            this.dgvShowList.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(432, 602);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 31);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(596, 602);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Location = new System.Drawing.Point(236, 191);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(40, 20);
            this.lblSearchInfo.TabIndex = 11;
            this.lblSearchInfo.Text = "Find:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(757, 602);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 602);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(114, 602);
            this.btnPick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(86, 31);
            this.btnPick.TabIndex = 8;
            this.btnPick.Text = "Detail";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // lboxListPick
            // 
            this.lboxListPick.FormattingEnabled = true;
            this.lboxListPick.ItemHeight = 20;
            this.lboxListPick.Items.AddRange(new object[] {
            "Receipt",
            "Import",
            "Customer",
            "Supplier",
            "Model",
            "Phone"});
            this.lboxListPick.Location = new System.Drawing.Point(346, 13);
            this.lboxListPick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxListPick.Name = "lboxListPick";
            this.lboxListPick.Size = new System.Drawing.Size(172, 124);
            this.lboxListPick.TabIndex = 15;
            this.lboxListPick.SelectedIndexChanged += new System.EventHandler(this.lboxListPick_SelectedIndexChanged);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.lboxListPick);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSearchInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvShowList);
            this.Controls.Add(this.lblListPick);
            this.Controls.Add(this.txtSearchInfo);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Label lblSearchInfo;
        private Button btnExit;
        private Button btnAdd;
        private Button btnPick;
        private ListBox lboxListPick;
    }
}