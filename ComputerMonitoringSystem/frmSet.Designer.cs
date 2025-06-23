namespace ComputerMonitoringSystem
{
    partial class frmSet
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.txtComputerSet = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(326, 137);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 23);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(255, 140);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 17);
            this.Label4.TabIndex = 43;
            this.Label4.Text = "Search : ";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(288, 67);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 29);
            this.Button1.TabIndex = 42;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(207, 67);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 29);
            this.Button2.TabIndex = 41;
            this.Button2.Text = "Clear";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(126, 67);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 29);
            this.Button3.TabIndex = 40;
            this.Button3.Text = "Save";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
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
            this.dtglist.Location = new System.Drawing.Point(3, 166);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(526, 263);
            this.dtglist.TabIndex = 39;
            this.dtglist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellClick);
            // 
            // txtComputerSet
            // 
            this.txtComputerSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComputerSet.Location = new System.Drawing.Point(126, 38);
            this.txtComputerSet.Name = "txtComputerSet";
            this.txtComputerSet.Size = new System.Drawing.Size(322, 23);
            this.txtComputerSet.TabIndex = 38;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(74, 41);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(53, 17);
            this.Label5.TabIndex = 37;
            this.Label5.Text = "Name :";
            // 
            // frmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 435);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.dtglist);
            this.Controls.Add(this.txtComputerSet);
            this.Controls.Add(this.Label5);
            this.Name = "frmSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Computer Set";
            this.Load += new System.EventHandler(this.frmSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.TextBox txtComputerSet;
        internal System.Windows.Forms.Label Label5;
    }
}