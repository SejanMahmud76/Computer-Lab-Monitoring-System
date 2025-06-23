namespace ComputerMonitoringSystem
{
    partial class frmEditItem
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
            this.cboCompSet = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cboParts = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCompSet
            // 
            this.cboCompSet.FormattingEnabled = true;
            this.cboCompSet.Location = new System.Drawing.Point(133, 220);
            this.cboCompSet.Name = "cboCompSet";
            this.cboCompSet.Size = new System.Drawing.Size(347, 21);
            this.cboCompSet.TabIndex = 43;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(214, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(38, 226);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 13);
            this.Label7.TabIndex = 42;
            this.Label7.Text = "Computer Set :";
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(133, 193);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(347, 21);
            this.cboLocation.TabIndex = 35;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(59, 199);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(54, 13);
            this.Label6.TabIndex = 41;
            this.Label6.Text = "Location :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(47, 124);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 13);
            this.Label5.TabIndex = 39;
            this.Label5.Text = "Description :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(62, 44);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 13);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Barcode :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(133, 41);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(347, 20);
            this.txtBarcode.TabIndex = 29;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(133, 121);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(347, 66);
            this.txtDescription.TabIndex = 34;
            this.txtDescription.Text = "";
            // 
            // cboBrand
            // 
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(133, 94);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(347, 21);
            this.cboBrand.TabIndex = 32;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(72, 100);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 13);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "Brand :";
            // 
            // cboParts
            // 
            this.cboParts.FormattingEnabled = true;
            this.cboParts.Location = new System.Drawing.Point(133, 67);
            this.cboParts.Name = "cboParts";
            this.cboParts.Size = new System.Drawing.Size(347, 21);
            this.cboParts.TabIndex = 31;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(76, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 13);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Parts :";
            // 
            // frmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 358);
            this.Controls.Add(this.cboCompSet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cboParts);
            this.Controls.Add(this.Label2);
            this.Name = "frmEditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.frmEditItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboCompSet;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cboLocation;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.RichTextBox txtDescription;
        internal System.Windows.Forms.ComboBox cboBrand;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cboParts;
        internal System.Windows.Forms.Label Label2;
    }
}