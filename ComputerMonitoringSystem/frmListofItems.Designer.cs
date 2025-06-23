namespace ComputerMonitoringSystem
{
    partial class frmListofItems
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
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Good",
            "Damage",
            "Maintenance",
            "Lost"});
            this.ComboBox1.Location = new System.Drawing.Point(688, 11);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(146, 21);
            this.ComboBox1.TabIndex = 13;
            this.ComboBox1.Text = "Select Status";
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(652, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 35);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(744, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(396, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(343, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Search :";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView1.Location = new System.Drawing.Point(3, 38);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(831, 380);
            this.DataGridView1.TabIndex = 8;
            // 
            // frmListofItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 471);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.DataGridView1);
            this.Name = "frmListofItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Items";
            this.Load += new System.EventHandler(this.frmListofItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView DataGridView1;
    }
}