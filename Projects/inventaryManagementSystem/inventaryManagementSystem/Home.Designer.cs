namespace inventaryManagementSystem
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.athorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDealerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.athorityToolStripMenuItem,
            this.unitToolStripMenuItem,
            this.productToolStripMenuItem,
            this.dealerToolStripMenuItem,
            this.pReportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(835, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // athorityToolStripMenuItem
            // 
            this.athorityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAdminToolStripMenuItem});
            this.athorityToolStripMenuItem.Name = "athorityToolStripMenuItem";
            this.athorityToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.athorityToolStripMenuItem.Text = "Authority";
            // 
            // addNewAdminToolStripMenuItem
            // 
            this.addNewAdminToolStripMenuItem.Name = "addNewAdminToolStripMenuItem";
            this.addNewAdminToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewAdminToolStripMenuItem.Text = "Add New Admin";
            this.addNewAdminToolStripMenuItem.Click += new System.EventHandler(this.addNewAdminToolStripMenuItem_Click);
            // 
            // unitToolStripMenuItem
            // 
            this.unitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUnitToolStripMenuItem});
            this.unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            this.unitToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.unitToolStripMenuItem.Text = "Unit";
            // 
            // addUnitToolStripMenuItem
            // 
            this.addUnitToolStripMenuItem.Name = "addUnitToolStripMenuItem";
            this.addUnitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addUnitToolStripMenuItem.Text = "Add Unit";
            this.addUnitToolStripMenuItem.Click += new System.EventHandler(this.addUnitToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductNameToolStripMenuItem,
            this.purchaseProductToolStripMenuItem,
            this.saleProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addProductNameToolStripMenuItem
            // 
            this.addProductNameToolStripMenuItem.Name = "addProductNameToolStripMenuItem";
            this.addProductNameToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addProductNameToolStripMenuItem.Text = "Add Product";
            this.addProductNameToolStripMenuItem.Click += new System.EventHandler(this.addProductNameToolStripMenuItem_Click);
            // 
            // purchaseProductToolStripMenuItem
            // 
            this.purchaseProductToolStripMenuItem.Name = "purchaseProductToolStripMenuItem";
            this.purchaseProductToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.purchaseProductToolStripMenuItem.Text = "Purchase Product";
            this.purchaseProductToolStripMenuItem.Click += new System.EventHandler(this.purchaseProductToolStripMenuItem_Click);
            // 
            // saleProductToolStripMenuItem
            // 
            this.saleProductToolStripMenuItem.Name = "saleProductToolStripMenuItem";
            this.saleProductToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saleProductToolStripMenuItem.Text = "Sale Product";
            this.saleProductToolStripMenuItem.Click += new System.EventHandler(this.saleProductToolStripMenuItem_Click);
            // 
            // dealerToolStripMenuItem
            // 
            this.dealerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDealerToolStripMenuItem});
            this.dealerToolStripMenuItem.Name = "dealerToolStripMenuItem";
            this.dealerToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dealerToolStripMenuItem.Text = "Dealer";
            // 
            // addDealerToolStripMenuItem
            // 
            this.addDealerToolStripMenuItem.Name = "addDealerToolStripMenuItem";
            this.addDealerToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addDealerToolStripMenuItem.Text = "Add Dealer";
            this.addDealerToolStripMenuItem.Click += new System.EventHandler(this.addDealerToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(835, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // pReportToolStripMenuItem
            // 
            this.pReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prToolStripMenuItem});
            this.pReportToolStripMenuItem.Name = "pReportToolStripMenuItem";
            this.pReportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.pReportToolStripMenuItem.Text = "Report";
            // 
            // prToolStripMenuItem
            // 
            this.prToolStripMenuItem.Name = "prToolStripMenuItem";
            this.prToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prToolStripMenuItem.Text = "Pr";
            this.prToolStripMenuItem.Click += new System.EventHandler(this.prToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 457);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem athorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDealerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prToolStripMenuItem;
    }
}



