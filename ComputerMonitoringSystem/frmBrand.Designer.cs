namespace ComputerMonitoringSystem
{
    partial class frmBrand
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
            this.Label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(10, 64);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(87, 17);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Description :";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(103, 63);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(322, 55);
            this.txtDesc.TabIndex = 18;
            this.txtDesc.Text = "";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(272, 188);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 23);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(201, 191);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 17);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Search : ";
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(350, 124);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 29);
            this.btnclose.TabIndex = 13;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(184, 124);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 29);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "Clear";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(103, 124);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 29);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(12, 217);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(470, 213);
            this.dtglist.TabIndex = 12;
            this.dtglist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellClick);
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(103, 34);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(322, 23);
            this.txtBrand.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(39, 37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 17);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Brand : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(265, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmBrand
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 443);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dtglist);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.Label2);
            this.Name = "frmBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Computer Brand";
            this.Load += new System.EventHandler(this.frmBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.RichTextBox txtDesc;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnclose;
        internal System.Windows.Forms.Button btnnew;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.TextBox txtBrand;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnDelete;
    }
}