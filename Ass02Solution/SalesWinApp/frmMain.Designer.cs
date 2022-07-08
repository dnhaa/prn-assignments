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
            this.menuProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalesStatisticReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMemberManagement,
            this.menuProductManagement,
            this.menuOrderManagement,
            this.menuSalesStatisticReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMemberManagement
            // 
            this.menuMemberManagement.Name = "menuMemberManagement";
            this.menuMemberManagement.Size = new System.Drawing.Size(171, 24);
            this.menuMemberManagement.Text = "Member management";
            this.menuMemberManagement.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuProductManagement
            // 
            this.menuProductManagement.Name = "menuProductManagement";
            this.menuProductManagement.Size = new System.Drawing.Size(166, 24);
            this.menuProductManagement.Text = "Product management";
            this.menuProductManagement.Click += new System.EventHandler(this.menuProductManagement_Click);
            // 
            // menuOrderManagement
            // 
            this.menuOrderManagement.Name = "menuOrderManagement";
            this.menuOrderManagement.Size = new System.Drawing.Size(153, 24);
            this.menuOrderManagement.Text = "Order management";
            this.menuOrderManagement.Click += new System.EventHandler(this.menuOrderManagement_Click);
            // 
            // menuSalesStatisticReport
            // 
            this.menuSalesStatisticReport.Name = "menuSalesStatisticReport";
            this.menuSalesStatisticReport.Size = new System.Drawing.Size(156, 24);
            this.menuSalesStatisticReport.Text = "Sales statistic report";
            this.menuSalesStatisticReport.Click += new System.EventHandler(this.menuSalesStatisticReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuMemberManagement;
        private ToolStripMenuItem menuProductManagement;
        private ToolStripMenuItem menuOrderManagement;
        private ToolStripMenuItem menuSalesStatisticReport;
    }
}