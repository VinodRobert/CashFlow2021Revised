namespace CashFlow
{
    partial class frmUploadGSTCredit
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnBrowse = new Syncfusion.WinForms.Controls.SfButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(153, -5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upload GST Credit";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(20, 49);
            this.autoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(132, 17);
            this.autoLabel1.TabIndex = 2;
            this.autoLabel1.Text = "Select Excel File ? ";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleName = "Button";
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnBrowse.Location = new System.Drawing.Point(158, 43);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(49, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = ".......";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(121, 80);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(12, 16);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = ".";
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.Blue;
            this.btnRead.Location = new System.Drawing.Point(432, 43);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(81, 31);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpload.Location = new System.Drawing.Point(432, 80);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(81, 31);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            this.gridResult.AllowEditing = false;
            this.gridResult.AllowFiltering = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Vendor Code";
            gridTextColumn1.MappingName = "VENDORCODE";
            gridTextColumn1.Width = 150D;
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.HeaderText = "GST Credit";
            gridNumericColumn1.MappingName = "AMOUNT";
            gridNumericColumn1.Width = 150D;
            this.gridResult.Columns.Add(gridTextColumn1);
            this.gridResult.Columns.Add(gridNumericColumn1);
            this.gridResult.Location = new System.Drawing.Point(20, 143);
            this.gridResult.Margin = new System.Windows.Forms.Padding(2);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.Size = new System.Drawing.Size(494, 313);
            this.gridResult.TabIndex = 7;
            this.gridResult.Text = "sfDataGrid1";
            this.gridResult.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.gridResult_DrawCell);
            this.gridResult.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridResult_QueryRowStyle);
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.autoLabel2.Location = new System.Drawing.Point(20, 482);
            this.autoLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(484, 16);
            this.autoLabel2.TabIndex = 8;
            this.autoLabel2.Text = "Excel File With TWO Columns. First Column VENDORCODE and Second Column (Numeric) " +
    "AMOUNT.";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Red;
            this.autoLabel3.Location = new System.Drawing.Point(138, 124);
            this.autoLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(219, 17);
            this.autoLabel3.TabIndex = 9;
            this.autoLabel3.Text = "Current Details Will Be OVER WRITTEN";
            // 
            // frmUploadGSTCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 522);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUploadGSTCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload GST Credit";
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpload;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridResult;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
    }
}