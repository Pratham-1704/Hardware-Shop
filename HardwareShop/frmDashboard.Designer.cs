
namespace HardwareShop
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerBillInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerBillInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerBillTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerBillInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterTableToolStripMenuItem,
            this.transactionTableToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterTableToolStripMenuItem
            // 
            this.masterTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productInformationToolStripMenuItem,
            this.priceInformationToolStripMenuItem});
            this.masterTableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("masterTableToolStripMenuItem.Image")));
            this.masterTableToolStripMenuItem.Name = "masterTableToolStripMenuItem";
            this.masterTableToolStripMenuItem.Size = new System.Drawing.Size(168, 32);
            this.masterTableToolStripMenuItem.Text = "Master Table";
            // 
            // productInformationToolStripMenuItem
            // 
            this.productInformationToolStripMenuItem.Name = "productInformationToolStripMenuItem";
            this.productInformationToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.productInformationToolStripMenuItem.Text = "Product Information";
            this.productInformationToolStripMenuItem.Click += new System.EventHandler(this.productInformationToolStripMenuItem_Click);
            // 
            // priceInformationToolStripMenuItem
            // 
            this.priceInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("priceInformationToolStripMenuItem.Image")));
            this.priceInformationToolStripMenuItem.Name = "priceInformationToolStripMenuItem";
            this.priceInformationToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.priceInformationToolStripMenuItem.Text = "Price Information";
            this.priceInformationToolStripMenuItem.Click += new System.EventHandler(this.priceInformationToolStripMenuItem_Click);
            // 
            // transactionTableToolStripMenuItem
            // 
            this.transactionTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerBillInformationToolStripMenuItem,
            this.customerBillToolStripMenuItem,
            this.customerBillInformationToolStripMenuItem1,
            this.dealerRegistrationToolStripMenuItem,
            this.dealerBillTableToolStripMenuItem,
            this.dealerBillInformationToolStripMenuItem,
            this.stockInformationToolStripMenuItem});
            this.transactionTableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transactionTableToolStripMenuItem.Image")));
            this.transactionTableToolStripMenuItem.Name = "transactionTableToolStripMenuItem";
            this.transactionTableToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.transactionTableToolStripMenuItem.Text = "Transaction Table";
            // 
            // customerBillInformationToolStripMenuItem
            // 
            this.customerBillInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBillInformationToolStripMenuItem.Image")));
            this.customerBillInformationToolStripMenuItem.Name = "customerBillInformationToolStripMenuItem";
            this.customerBillInformationToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.customerBillInformationToolStripMenuItem.Text = "Customer Registration";
            this.customerBillInformationToolStripMenuItem.Click += new System.EventHandler(this.customerBillInformationToolStripMenuItem_Click);
            // 
            // customerBillToolStripMenuItem
            // 
            this.customerBillToolStripMenuItem.Name = "customerBillToolStripMenuItem";
            this.customerBillToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.customerBillToolStripMenuItem.Text = "Customer Bill Table";
            this.customerBillToolStripMenuItem.Click += new System.EventHandler(this.customerBillToolStripMenuItem_Click);
            // 
            // customerBillInformationToolStripMenuItem1
            // 
            this.customerBillInformationToolStripMenuItem1.Name = "customerBillInformationToolStripMenuItem1";
            this.customerBillInformationToolStripMenuItem1.Size = new System.Drawing.Size(344, 32);
            this.customerBillInformationToolStripMenuItem1.Text = "Customer Bill Information";
            this.customerBillInformationToolStripMenuItem1.Click += new System.EventHandler(this.customerBillInformationToolStripMenuItem1_Click);
            // 
            // dealerRegistrationToolStripMenuItem
            // 
            this.dealerRegistrationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dealerRegistrationToolStripMenuItem.Image")));
            this.dealerRegistrationToolStripMenuItem.Name = "dealerRegistrationToolStripMenuItem";
            this.dealerRegistrationToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.dealerRegistrationToolStripMenuItem.Text = "Dealer Registration";
            this.dealerRegistrationToolStripMenuItem.Click += new System.EventHandler(this.dealerRegistrationToolStripMenuItem_Click);
            // 
            // dealerBillTableToolStripMenuItem
            // 
            this.dealerBillTableToolStripMenuItem.Name = "dealerBillTableToolStripMenuItem";
            this.dealerBillTableToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.dealerBillTableToolStripMenuItem.Text = "Dealer Bill Table";
            this.dealerBillTableToolStripMenuItem.Click += new System.EventHandler(this.dealerBillTableToolStripMenuItem_Click);
            // 
            // dealerBillInformationToolStripMenuItem
            // 
            this.dealerBillInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dealerBillInformationToolStripMenuItem.Image")));
            this.dealerBillInformationToolStripMenuItem.Name = "dealerBillInformationToolStripMenuItem";
            this.dealerBillInformationToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.dealerBillInformationToolStripMenuItem.Text = "Dealer Bill Information";
            this.dealerBillInformationToolStripMenuItem.Click += new System.EventHandler(this.dealerBillInformationToolStripMenuItem_Click);
            // 
            // stockInformationToolStripMenuItem
            // 
            this.stockInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockInformationToolStripMenuItem.Image")));
            this.stockInformationToolStripMenuItem.Name = "stockInformationToolStripMenuItem";
            this.stockInformationToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.stockInformationToolStripMenuItem.Text = "Stock Information";
            this.stockInformationToolStripMenuItem.Click += new System.EventHandler(this.stockInformationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerBillInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerBillInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dealerRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealerBillTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealerBillInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}