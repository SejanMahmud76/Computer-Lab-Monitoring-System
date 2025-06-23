namespace ComputerMonitoringSystem
{
    partial class frmReports
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboParts = new System.Windows.Forms.ComboBox();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.Button5);
            this.Panel1.Controls.Add(this.Button4);
            this.Panel1.Controls.Add(this.Button3);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(200, 536);
            this.Panel1.TabIndex = 2;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cboParts);
            this.GroupBox1.Controls.Add(this.cboLocation);
            this.GroupBox1.Location = new System.Drawing.Point(12, 24);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(173, 129);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search For";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 66);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Location";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Parts";
            // 
            // cboParts
            // 
            this.cboParts.FormattingEnabled = true;
            this.cboParts.Location = new System.Drawing.Point(6, 42);
            this.cboParts.Name = "cboParts";
            this.cboParts.Size = new System.Drawing.Size(161, 21);
            this.cboParts.TabIndex = 4;
            this.cboParts.Text = "Select";
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(6, 82);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(161, 21);
            this.cboLocation.TabIndex = 3;
            this.cboLocation.Text = "Select";
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(12, 305);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(173, 28);
            this.Button5.TabIndex = 4;
            this.Button5.Text = "Transfered Items";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(12, 271);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(173, 28);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "Damaged Items";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(12, 237);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(173, 28);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "Under Maintenance";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(12, 203);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(173, 28);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "Lost Items";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 169);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(173, 28);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "List of Items";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(200, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(832, 536);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 536);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Panel1);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.Panel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cboParts;
        internal System.Windows.Forms.ComboBox cboLocation;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}