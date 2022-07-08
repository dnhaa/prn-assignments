namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.lbSearchByID = new System.Windows.Forms.Label();
            this.lbSearchByName = new System.Windows.Forms.Label();
            this.lbFilterByCity = new System.Windows.Forms.Label();
            this.lbFilterByCountry = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.cboFilterByCity = new System.Windows.Forms.ComboBox();
            this.cboFilterByCountry = new System.Windows.Forms.ComboBox();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnFilterByCity = new System.Windows.Forms.Button();
            this.btnFilterByCountry = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dvgMemberList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSearchByID
            // 
            this.lbSearchByID.AutoSize = true;
            this.lbSearchByID.Location = new System.Drawing.Point(36, 31);
            this.lbSearchByID.Name = "lbSearchByID";
            this.lbSearchByID.Size = new System.Drawing.Size(92, 20);
            this.lbSearchByID.TabIndex = 0;
            this.lbSearchByID.Text = "Search By ID";
            // 
            // lbSearchByName
            // 
            this.lbSearchByName.AutoSize = true;
            this.lbSearchByName.Location = new System.Drawing.Point(409, 31);
            this.lbSearchByName.Name = "lbSearchByName";
            this.lbSearchByName.Size = new System.Drawing.Size(117, 20);
            this.lbSearchByName.TabIndex = 1;
            this.lbSearchByName.Text = "Search By Name";
            // 
            // lbFilterByCity
            // 
            this.lbFilterByCity.AutoSize = true;
            this.lbFilterByCity.Location = new System.Drawing.Point(36, 78);
            this.lbFilterByCity.Name = "lbFilterByCity";
            this.lbFilterByCity.Size = new System.Drawing.Size(91, 20);
            this.lbFilterByCity.TabIndex = 2;
            this.lbFilterByCity.Text = "Filter By City";
            // 
            // lbFilterByCountry
            // 
            this.lbFilterByCountry.AutoSize = true;
            this.lbFilterByCountry.Location = new System.Drawing.Point(409, 78);
            this.lbFilterByCountry.Name = "lbFilterByCountry";
            this.lbFilterByCountry.Size = new System.Drawing.Size(117, 20);
            this.lbFilterByCountry.TabIndex = 3;
            this.lbFilterByCountry.Text = "Filter By Country";
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(134, 28);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(171, 27);
            this.txtSearchByID.TabIndex = 4;
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(532, 28);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(171, 27);
            this.txtSearchByName.TabIndex = 5;
            // 
            // cboFilterByCity
            // 
            this.cboFilterByCity.FormattingEnabled = true;
            this.cboFilterByCity.Items.AddRange(new object[] {
            "Ho Chi Minh",
            "Hai Phong",
            "London",
            "Manchester",
            "Tokyo",
            "Osaka",
            "New York",
            "Los Angeles",
            "Beijing"});
            this.cboFilterByCity.Location = new System.Drawing.Point(134, 75);
            this.cboFilterByCity.Name = "cboFilterByCity";
            this.cboFilterByCity.Size = new System.Drawing.Size(171, 28);
            this.cboFilterByCity.TabIndex = 6;
            // 
            // cboFilterByCountry
            // 
            this.cboFilterByCountry.FormattingEnabled = true;
            this.cboFilterByCountry.Items.AddRange(new object[] {
            "Vietnam",
            "England",
            "Japan",
            "United States",
            "China"});
            this.cboFilterByCountry.Location = new System.Drawing.Point(532, 75);
            this.cboFilterByCountry.Name = "cboFilterByCountry";
            this.cboFilterByCountry.Size = new System.Drawing.Size(171, 28);
            this.cboFilterByCountry.TabIndex = 7;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearchByID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchByID.Location = new System.Drawing.Point(311, 27);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(73, 29);
            this.btnSearchByID.TabIndex = 8;
            this.btnSearchByID.Text = "Search";
            this.btnSearchByID.UseVisualStyleBackColor = false;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearchByName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchByName.Location = new System.Drawing.Point(709, 27);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(73, 29);
            this.btnSearchByName.TabIndex = 9;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = false;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnFilterByCity
            // 
            this.btnFilterByCity.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFilterByCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilterByCity.Location = new System.Drawing.Point(311, 74);
            this.btnFilterByCity.Name = "btnFilterByCity";
            this.btnFilterByCity.Size = new System.Drawing.Size(73, 29);
            this.btnFilterByCity.TabIndex = 10;
            this.btnFilterByCity.Text = "Filter";
            this.btnFilterByCity.UseVisualStyleBackColor = false;
            this.btnFilterByCity.Click += new System.EventHandler(this.btnFilterByCity_Click);
            // 
            // btnFilterByCountry
            // 
            this.btnFilterByCountry.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFilterByCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilterByCountry.Location = new System.Drawing.Point(709, 74);
            this.btnFilterByCountry.Name = "btnFilterByCountry";
            this.btnFilterByCountry.Size = new System.Drawing.Size(73, 29);
            this.btnFilterByCountry.TabIndex = 11;
            this.btnFilterByCountry.Text = "Filter";
            this.btnFilterByCountry.UseVisualStyleBackColor = false;
            this.btnFilterByCountry.Click += new System.EventHandler(this.btnFilterByCountry_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(369, 141);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 29);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(605, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewAll.Location = new System.Drawing.Point(134, 141);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(98, 29);
            this.btnViewAll.TabIndex = 14;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // dvgMemberList
            // 
            this.dvgMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMemberList.Location = new System.Drawing.Point(36, 192);
            this.dvgMemberList.Name = "dvgMemberList";
            this.dvgMemberList.ReadOnly = true;
            this.dvgMemberList.RowHeadersWidth = 51;
            this.dvgMemberList.RowTemplate.Height = 29;
            this.dvgMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMemberList.Size = new System.Drawing.Size(806, 340);
            this.dvgMemberList.TabIndex = 15;
            this.dvgMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMemberList_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(369, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 29);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(890, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dvgMemberList);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnFilterByCountry);
            this.Controls.Add(this.btnFilterByCity);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.cboFilterByCountry);
            this.Controls.Add(this.cboFilterByCity);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.lbFilterByCountry);
            this.Controls.Add(this.lbFilterByCity);
            this.Controls.Add(this.lbSearchByName);
            this.Controls.Add(this.lbSearchByID);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSearchByID;
        private Label lbSearchByName;
        private Label lbFilterByCity;
        private Label lbFilterByCountry;
        private TextBox txtSearchByID;
        private TextBox txtSearchByName;
        private ComboBox cboFilterByCity;
        private ComboBox cboFilterByCountry;
        private Button btnSearchByID;
        private Button btnSearchByName;
        private Button btnFilterByCity;
        private Button btnFilterByCountry;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnViewAll;
        private DataGridView dvgMemberList;
        private Button btnClose;
    }
}