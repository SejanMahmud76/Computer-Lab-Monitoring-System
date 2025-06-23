namespace ComputerMonitoringSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsTransfer = new System.Windows.Forms.ToolStripButton();
            this.tsUnderMaintenance = new System.Windows.Forms.ToolStripButton();
            this.tsLost = new System.Windows.Forms.ToolStripButton();
            this.tsDamage = new System.Windows.Forms.ToolStripButton();
            this.tsListOfItems = new System.Windows.Forms.ToolStripButton();
            this.tsReports = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUtilities = new System.Windows.Forms.ToolStripMenuItem();
            this.tsParts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCompSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(90, 90);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTransfer,
            this.tsUnderMaintenance,
            this.tsLost,
            this.tsDamage,
            this.tsListOfItems,
            this.tsReports});
            this.toolStrip1.Location = new System.Drawing.Point(6, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(607, 114);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsTransfer
            // 
            this.tsTransfer.Image = ((System.Drawing.Image)(resources.GetObject("tsTransfer.Image")));
            this.tsTransfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTransfer.Name = "tsTransfer";
            this.tsTransfer.Size = new System.Drawing.Size(94, 111);
            this.tsTransfer.Text = "Transfer Item";
            this.tsTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsTransfer.Click += new System.EventHandler(this.tsTransfer_Click);
            // 
            // tsUnderMaintenance
            // 
            this.tsUnderMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("tsUnderMaintenance.Image")));
            this.tsUnderMaintenance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUnderMaintenance.Name = "tsUnderMaintenance";
            this.tsUnderMaintenance.Size = new System.Drawing.Size(115, 111);
            this.tsUnderMaintenance.Text = "Under Maintenance";
            this.tsUnderMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUnderMaintenance.Click += new System.EventHandler(this.tsUnderMaintenance_Click);
            // 
            // tsLost
            // 
            this.tsLost.Image = ((System.Drawing.Image)(resources.GetObject("tsLost.Image")));
            this.tsLost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLost.Name = "tsLost";
            this.tsLost.Size = new System.Drawing.Size(94, 111);
            this.tsLost.Text = "Lost Items";
            this.tsLost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLost.Click += new System.EventHandler(this.tsLost_Click);
            // 
            // tsDamage
            // 
            this.tsDamage.Image = ((System.Drawing.Image)(resources.GetObject("tsDamage.Image")));
            this.tsDamage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDamage.Name = "tsDamage";
            this.tsDamage.Size = new System.Drawing.Size(94, 111);
            this.tsDamage.Text = "Damage Items";
            this.tsDamage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsDamage.Click += new System.EventHandler(this.tsDamage_Click);
            // 
            // tsListOfItems
            // 
            this.tsListOfItems.Image = ((System.Drawing.Image)(resources.GetObject("tsListOfItems.Image")));
            this.tsListOfItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsListOfItems.Name = "tsListOfItems";
            this.tsListOfItems.Size = new System.Drawing.Size(94, 111);
            this.tsListOfItems.Text = "List of Items";
            this.tsListOfItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsListOfItems.Click += new System.EventHandler(this.tsListOfItems_Click);
            // 
            // tsReports
            // 
            this.tsReports.Image = ((System.Drawing.Image)(resources.GetObject("tsReports.Image")));
            this.tsReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReports.Name = "tsReports";
            this.tsReports.Size = new System.Drawing.Size(94, 111);
            this.tsReports.Text = "Reports";
            this.tsReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReports.Click += new System.EventHandler(this.tsReports_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tsItems,
            this.tsUtilities,
            this.tsUsers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLogin,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsLogin
            // 
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(152, 22);
            this.tsLogin.Text = "Login";
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tsItems
            // 
            this.tsItems.Name = "tsItems";
            this.tsItems.Size = new System.Drawing.Size(94, 20);
            this.tsItems.Text = "Manage Items";
            this.tsItems.Click += new System.EventHandler(this.tsItems_Click);
            // 
            // tsUtilities
            // 
            this.tsUtilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsParts,
            this.tsBrand,
            this.tsLocation,
            this.tsCompSet});
            this.tsUtilities.Name = "tsUtilities";
            this.tsUtilities.Size = new System.Drawing.Size(58, 20);
            this.tsUtilities.Text = "Utilities";
            // 
            // tsParts
            // 
            this.tsParts.Name = "tsParts";
            this.tsParts.Size = new System.Drawing.Size(162, 22);
            this.tsParts.Text = "Computer Parts";
            this.tsParts.Click += new System.EventHandler(this.tsParts_Click);
            // 
            // tsBrand
            // 
            this.tsBrand.Name = "tsBrand";
            this.tsBrand.Size = new System.Drawing.Size(162, 22);
            this.tsBrand.Text = "Computer Brand";
            this.tsBrand.Click += new System.EventHandler(this.tsBrand_Click);
            // 
            // tsLocation
            // 
            this.tsLocation.Name = "tsLocation";
            this.tsLocation.Size = new System.Drawing.Size(162, 22);
            this.tsLocation.Text = "Location";
            this.tsLocation.Click += new System.EventHandler(this.tsLocation_Click);
            // 
            // tsCompSet
            // 
            this.tsCompSet.Name = "tsCompSet";
            this.tsCompSet.Size = new System.Drawing.Size(162, 22);
            this.tsCompSet.Text = "Computer Set";
            this.tsCompSet.Click += new System.EventHandler(this.tsCompSet_Click);
            // 
            // tsUsers
            // 
            this.tsUsers.Name = "tsUsers";
            this.tsUsers.Size = new System.Drawing.Size(93, 20);
            this.tsUsers.Text = "Manage Users";
            this.tsUsers.Click += new System.EventHandler(this.tsUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 512);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Equipment Monitoring System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsTransfer;
        private System.Windows.Forms.ToolStripButton tsUnderMaintenance;
        private System.Windows.Forms.ToolStripButton tsLost;
        private System.Windows.Forms.ToolStripButton tsDamage;
        private System.Windows.Forms.ToolStripButton tsListOfItems;
        private System.Windows.Forms.ToolStripButton tsReports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsLogin;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsItems;
        private System.Windows.Forms.ToolStripMenuItem tsUtilities;
        private System.Windows.Forms.ToolStripMenuItem tsUsers;
        private System.Windows.Forms.ToolStripMenuItem tsParts;
        private System.Windows.Forms.ToolStripMenuItem tsBrand;
        private System.Windows.Forms.ToolStripMenuItem tsLocation;
        private System.Windows.Forms.ToolStripMenuItem tsCompSet;
    }
}

