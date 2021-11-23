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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
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
            this.lblHeader.Location = new System.Drawing.Point(416, 7);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(126, 26);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "GST Credit";
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            this.gridResult.AllowEditing = false;
            this.gridResult.AllowFiltering = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Vendor Type";
            gridTextColumn1.MappingName = "VENDORTYPE";
            gridTextColumn1.Width = 125D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Vendor Code";
            gridTextColumn2.MappingName = "PARTYCODE";
            gridTextColumn2.Width = 150D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Vendor Name";
            gridTextColumn3.MappingName = "PARTYNAME";
            gridTextColumn3.Width = 350D;
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.HeaderText = "GST Credit";
            gridNumericColumn1.MappingName = "GSTCREDIT";
            gridNumericColumn1.Width = 125D;
            this.gridResult.Columns.Add(gridTextColumn1);
            this.gridResult.Columns.Add(gridTextColumn2);
            this.gridResult.Columns.Add(gridTextColumn3);
            this.gridResult.Columns.Add(gridNumericColumn1);
            this.gridResult.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridResult.Location = new System.Drawing.Point(20, 72);
            this.gridResult.Margin = new System.Windows.Forms.Padding(2);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.Size = new System.Drawing.Size(946, 454);
            this.gridResult.Style.HeaderStyle.Font.Bold = true;
            this.gridResult.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridResult.Style.HeaderStyle.Font.Size = 10F;
            this.gridResult.Style.HeaderStyle.TextColor = System.Drawing.Color.Blue;
            this.gridResult.TabIndex = 3;
            this.gridResult.Text = "sfDataGrid1";
            this.gridResult.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridResult_QueryRowStyle);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(886, 32);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmGSTCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 548);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
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