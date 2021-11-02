namespace CashFlow.PresentationLayer.Cash_Flow
{
    partial class frmFTRWorkSheet
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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn14 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn15 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn16 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn17 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn18 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn19 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn20 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn21 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn22 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn23 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn24 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn25 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn26 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.lblProjectName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblFTRNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnUpdate = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.Blue;
            this.lblProjectName.Location = new System.Drawing.Point(12, 19);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(118, 29);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Project ";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Olive;
            this.btnClose.Location = new System.Drawing.Point(1280, 29);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 27);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Olive;
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Exit";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFTRNumber
            // 
            this.lblFTRNumber.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTRNumber.ForeColor = System.Drawing.Color.Red;
            this.lblFTRNumber.Location = new System.Drawing.Point(651, 19);
            this.lblFTRNumber.Name = "lblFTRNumber";
            this.lblFTRNumber.Size = new System.Drawing.Size(171, 29);
            this.lblFTRNumber.TabIndex = 20;
            this.lblFTRNumber.Text = "FTRNumber";
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            this.gridResult.AllowFiltering = true;
            this.gridResult.AllowGrouping = false;
            this.gridResult.AllowResizingColumns = true;
            this.gridResult.AllowStandardTab = true;
            gridNumericColumn14.AllowFiltering = true;
            gridNumericColumn14.AllowGrouping = false;
            gridNumericColumn14.AllowResizing = true;
            gridNumericColumn14.HeaderText = "SLNO";
            gridNumericColumn14.MappingName = "LINEORDER";
            gridNumericColumn14.SortMode = Syncfusion.Data.DataReflectionMode.Value;
            gridNumericColumn14.Visible = false;
            gridNumericColumn14.Width = 0D;
            gridNumericColumn15.AllowFiltering = true;
            gridNumericColumn15.AllowGrouping = false;
            gridNumericColumn15.AllowResizing = true;
            gridNumericColumn15.HeaderText = "Column1";
            gridNumericColumn15.MappingName = "RESULTID";
            gridNumericColumn15.Visible = false;
            gridNumericColumn15.Width = 0D;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowFiltering = true;
            gridTextColumn9.AllowGrouping = false;
            gridTextColumn9.AllowResizing = true;
            gridTextColumn9.HeaderText = "Major Category";
            gridTextColumn9.MappingName = "MAJORCATEGORY";
            gridTextColumn9.Width = 125D;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowFiltering = true;
            gridTextColumn10.AllowGrouping = false;
            gridTextColumn10.AllowResizing = true;
            gridTextColumn10.HeaderText = "Minor Category";
            gridTextColumn10.MappingName = "MINORCATEGORY";
            gridTextColumn10.Width = 120D;
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.AllowFiltering = true;
            gridTextColumn11.AllowGrouping = false;
            gridTextColumn11.AllowResizing = true;
            gridTextColumn11.HeaderText = "Category";
            gridTextColumn11.MappingName = "CATEGORY";
            gridTextColumn11.Width = 120D;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.AllowFiltering = true;
            gridTextColumn12.AllowGrouping = false;
            gridTextColumn12.AllowResizing = true;
            gridTextColumn12.HeaderText = "Type";
            gridTextColumn12.MappingName = "VENDORTYPE";
            gridTextColumn12.Width = 100D;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.AllowFiltering = true;
            gridTextColumn13.AllowGrouping = false;
            gridTextColumn13.AllowResizing = true;
            gridTextColumn13.HeaderText = "Vendor Code";
            gridTextColumn13.MappingName = "PARTYCODE";
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.AllowFiltering = true;
            gridTextColumn14.AllowGrouping = false;
            gridTextColumn14.AllowResizing = true;
            gridTextColumn14.HeaderText = "Vendor Name";
            gridTextColumn14.MappingName = "PARTYNAME";
            gridTextColumn14.Width = 150D;
            gridNumericColumn16.AllowEditing = false;
            gridNumericColumn16.AllowFiltering = true;
            gridNumericColumn16.AllowGrouping = false;
            gridNumericColumn16.AllowResizing = true;
            gridNumericColumn16.HeaderText = "Gross Payable";
            gridNumericColumn16.MappingName = "NETPAYABLE";
            gridNumericColumn16.Width = 110D;
            gridNumericColumn17.AllowEditing = false;
            gridNumericColumn17.AllowFiltering = true;
            gridNumericColumn17.AllowGrouping = false;
            gridNumericColumn17.AllowResizing = true;
            gridNumericColumn17.HeaderText = "Paid";
            gridNumericColumn17.MappingName = "PAID";
            gridNumericColumn17.Width = 110D;
            gridNumericColumn18.AllowEditing = false;
            gridNumericColumn18.AllowFiltering = true;
            gridNumericColumn18.AllowGrouping = false;
            gridNumericColumn18.AllowResizing = true;
            gridNumericColumn18.HeaderText = "Balance Payable";
            gridNumericColumn18.MappingName = "PROJECTLIABILITY";
            gridNumericColumn18.Width = 110D;
            gridNumericColumn19.AllowFiltering = true;
            gridNumericColumn19.AllowGrouping = false;
            gridNumericColumn19.AllowResizing = true;
            gridNumericColumn19.HeaderText = "Mob Adv";
            gridNumericColumn19.MappingName = "MOBADVANCE";
            gridNumericColumn19.Width = 110D;
            gridNumericColumn20.AllowFiltering = true;
            gridNumericColumn20.AllowGrouping = false;
            gridNumericColumn20.AllowResizing = true;
            gridNumericColumn20.HeaderText = "GST Credit";
            gridNumericColumn20.MappingName = "GSTCREDIT";
            gridNumericColumn20.Width = 110D;
            gridNumericColumn21.AllowEditing = false;
            gridNumericColumn21.AllowFiltering = true;
            gridNumericColumn21.AllowGrouping = false;
            gridNumericColumn21.AllowResizing = true;
            gridNumericColumn21.HeaderText = "Liability";
            gridNumericColumn21.MappingName = "COMPANYLIABILITY";
            gridNumericColumn21.Width = 110D;
            gridNumericColumn22.AllowFiltering = true;
            gridNumericColumn22.AllowGrouping = false;
            gridNumericColumn22.AllowResizing = true;
            gridNumericColumn22.HeaderText = "PAY after GST";
            gridNumericColumn22.MappingName = "PAYABLEAFTERGST";
            gridNumericColumn22.Width = 110D;
            gridNumericColumn23.AllowFiltering = true;
            gridNumericColumn23.AllowGrouping = false;
            gridNumericColumn23.AllowResizing = true;
            gridNumericColumn23.HeaderText = "Net Payable";
            gridNumericColumn23.MappingName = "FINALPAYABLE";
            gridNumericColumn23.Width = 110D;
            gridNumericColumn24.AllowFiltering = true;
            gridNumericColumn24.AllowGrouping = false;
            gridNumericColumn24.AllowResizing = true;
            gridNumericColumn24.HeaderText = "Project Site";
            gridNumericColumn24.MappingName = "PROJECTSITE";
            gridNumericColumn24.Width = 100D;
            gridNumericColumn25.AllowFiltering = true;
            gridNumericColumn25.AllowGrouping = false;
            gridNumericColumn25.AllowResizing = true;
            gridNumericColumn25.HeaderText = "Accountant";
            gridNumericColumn25.MappingName = "ACCOUNTANT";
            gridNumericColumn25.Width = 100D;
            gridNumericColumn26.AllowFiltering = true;
            gridNumericColumn26.AllowGrouping = false;
            gridNumericColumn26.AllowResizing = true;
            gridNumericColumn26.HeaderText = "Accounts Head";
            gridNumericColumn26.MappingName = "ACCOUNTSHEAD";
            gridNumericColumn26.Width = 100D;
            gridTextColumn15.AllowFiltering = true;
            gridTextColumn15.AllowGrouping = false;
            gridTextColumn15.AllowResizing = true;
            gridTextColumn15.HeaderText = "Control Cell";
            gridTextColumn15.MappingName = "CONTROLCELL";
            gridTextColumn15.Width = 100D;
            gridTextColumn16.AllowFiltering = true;
            gridTextColumn16.AllowGrouping = false;
            gridTextColumn16.AllowResizing = true;
            gridTextColumn16.HeaderText = "Remarks";
            gridTextColumn16.MappingName = "REMARKS";
            gridTextColumn16.Visible = false;
            gridTextColumn16.Width = 0D;
            this.gridResult.Columns.Add(gridNumericColumn14);
            this.gridResult.Columns.Add(gridNumericColumn15);
            this.gridResult.Columns.Add(gridTextColumn9);
            this.gridResult.Columns.Add(gridTextColumn10);
            this.gridResult.Columns.Add(gridTextColumn11);
            this.gridResult.Columns.Add(gridTextColumn12);
            this.gridResult.Columns.Add(gridTextColumn13);
            this.gridResult.Columns.Add(gridTextColumn14);
            this.gridResult.Columns.Add(gridNumericColumn16);
            this.gridResult.Columns.Add(gridNumericColumn17);
            this.gridResult.Columns.Add(gridNumericColumn18);
            this.gridResult.Columns.Add(gridNumericColumn19);
            this.gridResult.Columns.Add(gridNumericColumn20);
            this.gridResult.Columns.Add(gridNumericColumn21);
            this.gridResult.Columns.Add(gridNumericColumn22);
            this.gridResult.Columns.Add(gridNumericColumn23);
            this.gridResult.Columns.Add(gridNumericColumn24);
            this.gridResult.Columns.Add(gridNumericColumn25);
            this.gridResult.Columns.Add(gridNumericColumn26);
            this.gridResult.Columns.Add(gridTextColumn15);
            this.gridResult.Columns.Add(gridTextColumn16);
            this.gridResult.Location = new System.Drawing.Point(12, 63);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.ShowGroupDropArea = true;
            this.gridResult.Size = new System.Drawing.Size(1403, 524);
            this.gridResult.TabIndex = 25;
            this.gridResult.Text = "sfDataGrid1";
            this.gridResult.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridResult_QueryRowStyle);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "Button";
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(1271, 3);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 27);
            this.btnUpdate.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update and Close";
            // 
            // frmFTRWorkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 599);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.lblFTRNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblProjectName);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFTRWorkSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTR | Work Sheet";
            this.Load += new System.EventHandler(this.frmFTRWorkSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblProjectName;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblFTRNumber;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridResult;
        private Syncfusion.WinForms.Controls.SfButton btnUpdate;
    }
}