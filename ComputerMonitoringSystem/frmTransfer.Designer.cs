namespace ComputerMonitoringSystem
{
    partial class frmTransfer
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.cboCompSet = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCompSet = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtLocated = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.RichTextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(726, 437);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(100, 33);
            this.btnTransfer.TabIndex = 13;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // cboCompSet
            // 
            this.cboCompSet.FormattingEnabled = true;
            this.cboCompSet.Location = new System.Drawing.Point(159, 53);
            this.cboCompSet.Name = "cboCompSet";
            this.cboCompSet.Size = new System.Drawing.Size(276, 21);
            this.cboCompSet.TabIndex = 3;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(76, 61);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(77, 13);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "Computer Set :";
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(159, 26);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(276, 21);
            this.cboLocation.TabIndex = 1;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cboCompSet);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.cboLocation);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Location = new System.Drawing.Point(261, 288);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(570, 117);
            this.GroupBox2.TabIndex = 12;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Transfer To";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(76, 34);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(54, 13);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Location :";
            // 
            // txtCompSet
            // 
            this.txtCompSet.Enabled = false;
            this.txtCompSet.Location = new System.Drawing.Point(385, 117);
            this.txtCompSet.Name = "txtCompSet";
            this.txtCompSet.Size = new System.Drawing.Size(180, 20);
            this.txtCompSet.TabIndex = 11;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(308, 120);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(71, 13);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Computer Set";
            // 
            // txtLocated
            // 
            this.txtLocated.Enabled = false;
            this.txtLocated.Location = new System.Drawing.Point(385, 91);
            this.txtLocated.Name = "txtLocated";
            this.txtLocated.Size = new System.Drawing.Size(180, 20);
            this.txtLocated.TabIndex = 9;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(329, 94);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(49, 13);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Located ";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 94);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(32, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Items";
            // 
            // txtParts
            // 
            this.txtParts.Enabled = false;
            this.txtParts.Location = new System.Drawing.Point(385, 65);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(180, 20);
            this.txtParts.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(347, 68);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(31, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Parts";
            // 
            // txtItems
            // 
            this.txtItems.Enabled = false;
            this.txtItems.Location = new System.Drawing.Point(63, 91);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(240, 75);
            this.txtItems.TabIndex = 4;
            this.txtItems.Text = "";
            // 
            // txtBrand
            // 
            this.txtBrand.Enabled = false;
            this.txtBrand.Location = new System.Drawing.Point(65, 64);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(239, 20);
            this.txtBrand.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 67);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Brand";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Location = new System.Drawing.Point(65, 38);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(239, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Barcode";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(3, 28);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(188, 13);
            this.Label10.TabIndex = 1;
            this.Label10.Text = "Search for (Parts, Location, Comp Set)";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtSearch);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.dtgList);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(255, 511);
            this.Panel1.TabIndex = 10;
            // 
            // dtgList
            // 
            this.dtgList.AllowUserToAddRows = false;
            this.dtgList.AllowUserToDeleteRows = false;
            this.dtgList.AllowUserToResizeColumns = false;
            this.dtgList.AllowUserToResizeRows = false;
            this.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(5, 82);
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersVisible = false;
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(243, 417);
            this.dtgList.TabIndex = 0;
            this.dtgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellClick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtCompSet);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.txtLocated);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtParts);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtItems);
            this.GroupBox1.Controls.Add(this.txtBrand);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtBarcode);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(261, 44);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(570, 229);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Item Details";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 511);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Transfer Items";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnTransfer;
        internal System.Windows.Forms.ComboBox cboCompSet;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox cboLocation;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCompSet;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtLocated;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtParts;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.RichTextBox txtItems;
        internal System.Windows.Forms.TextBox txtBrand;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}