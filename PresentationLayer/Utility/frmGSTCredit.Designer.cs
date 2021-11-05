namespace CashFlow
{
    partial class frmGSTCredit
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblHeader.Location = new System.Drawing.Point(554, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(163, 33);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "GST Credit";
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            gridTextColumn4.HeaderText = "Vendor Type";
            gridTextColumn4.MappingName = "VENDORTYPE";
            gridTextColumn4.Width = 125D;
            gridTextColumn5.HeaderText = "Vendor Code";
            gridTextColumn5.MappingName = "PARTYCODE";
            gridTextColumn5.Width = 150D;
            gridTextColumn6.HeaderText = "Vendor Name";
            gridTextColumn6.MappingName = "PARTYNAME";
            gridTextColumn6.Width = 350D;
            gridNumericColumn2.HeaderText = "GST Credit";
            gridNumericColumn2.MappingName = "GSTCREDIT";
            gridNumericColumn2.Width = 125D;
            this.gridResult.Columns.Add(gridTextColumn4);
            this.gridResult.Columns.Add(gridTextColumn5);
            this.gridResult.Columns.Add(gridTextColumn6);
            this.gridResult.Columns.Add(gridNumericColumn2);
            this.gridResult.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridResult.Location = new System.Drawing.Point(26, 89);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.Size = new System.Drawing.Size(1261, 558);
            this.gridResult.TabIndex = 3;
            this.gridResult.Text = "sfDataGrid1";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1181, 39);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmGSTCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 674);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmGSTCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GST Credit | View";
            this.Load += new System.EventHandler(this.frmGSTCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridResult;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}