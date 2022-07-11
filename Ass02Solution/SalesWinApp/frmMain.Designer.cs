namespace SalesWinApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMemberManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMemberManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbTo = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbFrom = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvOrderDetailList = new System.Windows.Forms.DataGridView();
            this.lbMain = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMemberManagement,
            this.menuOrderManagement,
            this.menuProductManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMemberManagement
            // 
            this.menuMemberManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMemberManagement,
            this.btnAddMember});
            this.menuMemberManagement.Name = "menuMemberManagement";
            this.menuMemberManagement.Size = new System.Drawing.Size(79, 24);
            this.menuMemberManagement.Text = "Member";
            this.menuMemberManagement.Click += new System.EventHandler(this.menuMemberManagement_Click);
            // 
            // btnMemberManagement
            // 
            this.btnMemberManagement.Name = "btnMemberManagement";
            this.btnMemberManagement.Size = new System.Drawing.Size(220, 26);
            this.btnMemberManagement.Text = "Open management";
            this.btnMemberManagement.Click += new System.EventHandler(this.btnMemberManagement_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(220, 26);
            this.btnAddMember.Text = "Add member";
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // menuOrderManagement
            // 
            this.menuOrderManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOrderManagement,
            this.btnAddOrder});
            this.menuOrderManagement.Name = "menuOrderManagement";
            this.menuOrderManagement.Size = new System.Drawing.Size(61, 24);
            this.menuOrderManagement.Text = "Order";
            this.menuOrderManagement.Click += new System.EventHandler(this.menuOrderManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(220, 26);
            this.btnOrderManagement.Text = "Open management";
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(220, 26);
            this.btnAddOrder.Text = "Add order";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // menuProductManagement
            // 
            this.menuProductManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProductManagement,
            this.btnAddProduct});
            this.menuProductManagement.Name = "menuProductManagement";
            this.menuProductManagement.Size = new System.Drawing.Size(74, 24);
            this.menuProductManagement.Text = "Product";
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(220, 26);
            this.btnProductManagement.Text = "Open management";
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(220, 26);
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(546, 213);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(250, 27);
            this.txtEndDate.TabIndex = 17;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(517, 219);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(23, 20);
            this.lbTo.TabIndex = 16;
            this.lbTo.Text = "to";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(254, 214);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(250, 27);
            this.txtStartDate.TabIndex = 15;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(201, 219);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(41, 20);
            this.lbFrom.TabIndex = 14;
            this.lbFrom.Text = "from";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(93, 214);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(94, 29);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(482, 148);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(94, 29);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Sort sales";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(335, 148);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(412, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvOrderDetailList
            // 
            this.dgvOrderDetailList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvOrderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailList.Location = new System.Drawing.Point(38, 269);
            this.dgvOrderDetailList.Name = "dgvOrderDetailList";
            this.dgvOrderDetailList.ReadOnly = true;
            this.dgvOrderDetailList.RowHeadersWidth = 51;
            this.dgvOrderDetailList.RowTemplate.Height = 29;
            this.dgvOrderDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailList.Size = new System.Drawing.Size(858, 188);
            this.dgvOrderDetailList.TabIndex = 9;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbMain.Location = new System.Drawing.Point(234, 56);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(449, 59);
            this.lbMain.TabIndex = 18;
            this.lbMain.Text = "Sales Statistic Report";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 591);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvOrderDetailList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuMemberManagement;
        private ToolStripMenuItem menuProductManagement;
        private ToolStripMenuItem menuOrderManagement;
        private DateTimePicker txtEndDate;
        private Label lbTo;
        private DateTimePicker txtStartDate;
        private Label lbFrom;
        private Button btnFilter;
        private Button btnSort;
        private Button btnLoad;
        private Button btnClose;
        private DataGridView dgvOrderDetailList;
        private Label lbMain;
        private ToolStripMenuItem btnMemberManagement;
        private ToolStripMenuItem btnAddMember;
        private ToolStripMenuItem btnProductManagement;
        private ToolStripMenuItem btnAddProduct;
        private ToolStripMenuItem btnOrderManagement;
        private ToolStripMenuItem btnAddOrder;
    }
}