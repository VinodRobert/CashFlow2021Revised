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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn4 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn5 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn6 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn7 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn8 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn9 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn10 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn11 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn12 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn2 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.lblProjectName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblFTRNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnUpdate = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
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
            this.btnClose.Location = new System.Drawing.Point(1267, 29);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 27);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Olive;
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Exit";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFTRNumber
            // 
            this.lblFTRNumber.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTRNumber.ForeColor = System.Drawing.Color.Red;
            this.lblFTRNumber.Location = new System.Drawing.Point(591, 19);
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
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.AllowGrouping = false;
            gridNumericColumn1.AllowResizing = true;
            gridNumericColumn1.HeaderText = "SLNO";
            gridNumericColumn1.MappingName = "LINEORDER";
            gridNumericColumn1.SortMode = Syncfusion.Data.DataReflectionMode.Value;
            gridNumericColumn1.Visible = false;
            gridNumericColumn1.Width = 0D;
            gridNumericColumn2.AllowEditing = false;
            gridNumericColumn2.AllowFiltering = true;
            gridNumericColumn2.AllowGrouping = false;
            gridNumericColumn2.AllowResizing = true;
            gridNumericColumn2.HeaderText = "Column1";
            gridNumericColumn2.MappingName = "RESULTID";
            gridNumericColumn2.Visible = false;
            gridNumericColumn2.Width = 0D;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "Major Category";
            gridTextColumn1.MappingName = "MAJORCATEGORY";
            gridTextColumn1.Width = 120D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Minor Category";
            gridTextColumn2.MappingName = "MINORCATEGORY";
            gridTextColumn2.Width = 110D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "Category";
            gridTextColumn3.MappingName = "CATEGORY";
            gridTextColumn3.Width = 110D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.AllowResizing = true;
            gridTextColumn4.HeaderText = "Type";
            gridTextColumn4.MappingName = "VENDORTYPE";
            gridTextColumn4.Width = 70D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.AllowGrouping = false;
            gridTextColumn5.AllowResizing = true;
            gridTextColumn5.HeaderText = "Vendor Code";
            gridTextColumn5.MappingName = "PARTYCODE";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.AllowGrouping = false;
            gridTextColumn6.AllowResizing = true;
            gridTextColumn6.HeaderText = "Vendor Name";
            gridTextColumn6.MappingName = "PARTYNAME";
            gridTextColumn6.Width = 140D;
            gridNumericColumn3.AllowEditing = false;
            gridNumericColumn3.AllowFiltering = true;
            gridNumericColumn3.AllowGrouping = false;
            gridNumericColumn3.AllowResizing = true;
            gridNumericColumn3.HeaderText = "Gross Payable";
            gridNumericColumn3.MappingName = "NETPAYABLE";
            gridNumericColumn3.Width = 150D;
            gridNumericColumn4.AllowEditing = false;
            gridNumericColumn4.AllowFiltering = true;
            gridNumericColumn4.AllowGrouping = false;
            gridNumericColumn4.AllowResizing = true;
            gridNumericColumn4.HeaderText = "Paid";
            gridNumericColumn4.MappingName = "PAID";
            gridNumericColumn4.Width = 150D;
            gridNumericColumn5.AllowEditing = false;
            gridNumericColumn5.AllowFiltering = true;
            gridNumericColumn5.AllowGrouping = false;
            gridNumericColumn5.AllowResizing = true;
            gridNumericColumn5.HeaderText = "Balance Payable";
            gridNumericColumn5.MappingName = "PROJECTLIABILITY";
            gridNumericColumn5.Width = 150D;
            gridNumericColumn6.AllowEditing = false;
            gridNumericColumn6.AllowFiltering = true;
            gridNumericColumn6.AllowGrouping = false;
            gridNumericColumn6.AllowResizing = true;
            gridNumericColumn6.HeaderText = "Mob Adv";
            gridNumericColumn6.MappingName = "MOBADVANCE";
            gridNumericColumn6.Width = 150D;
            gridNumericColumn7.AllowEditing = false;
            gridNumericColumn7.AllowFiltering = true;
            gridNumericColumn7.AllowGrouping = false;
            gridNumericColumn7.AllowResizing = true;
            gridNumericColumn7.HeaderText = "GST Credit";
            gridNumericColumn7.MappingName = "GSTCREDIT";
            gridNumericColumn7.Width = 150D;
            gridNumericColumn8.AllowEditing = false;
            gridNumericColumn8.AllowFiltering = true;
            gridNumericColumn8.AllowGrouping = false;
            gridNumericColumn8.AllowResizing = true;
            gridNumericColumn8.HeaderText = "Liability";
            gridNumericColumn8.MappingName = "COMPANYLIABILITY";
            gridNumericColumn8.Width = 150D;
            gridNumericColumn9.AllowEditing = false;
            gridNumericColumn9.AllowFiltering = true;
            gridNumericColumn9.AllowGrouping = false;
            gridNumericColumn9.AllowResizing = true;
            gridNumericColumn9.HeaderText = "PAY after GST";
            gridNumericColumn9.MappingName = "PAYABLEAFTERGST";
            gridNumericColumn9.Width = 150D;
            gridNumericColumn10.AllowEditing = false;
            gridNumericColumn10.AllowFiltering = true;
            gridNumericColumn10.AllowGrouping = false;
            gridNumericColumn10.AllowResizing = true;
            gridNumericColumn10.CellStyle.BackColor = System.Drawing.Color.Fuchsia;
            gridNumericColumn10.CellStyle.Font.Bold = true;
            gridNumericColumn10.HeaderText = "Payable";
            gridNumericColumn10.MappingName = "PAYABLE";
            gridNumericColumn10.Width = 150D;
            gridNumericColumn11.AllowFiltering = true;
            gridNumericColumn11.AllowGrouping = false;
            gridNumericColumn11.AllowResizing = true;
            gridNumericColumn11.CellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            gridNumericColumn11.HeaderText = "Project Site";
            gridNumericColumn11.MappingName = "PROJECTSITE";
            gridNumericColumn11.Width = 150D;
            gridNumericColumn12.AllowFiltering = true;
            gridNumericColumn12.AllowGrouping = false;
            gridNumericColumn12.AllowResizing = true;
            gridNumericColumn12.CellStyle.BackColor = System.Drawing.SystemColors.Info;
            gridNumericColumn12.HeaderText = "Final Payable";
            gridNumericColumn12.MappingName = "PAYABLERECOMMENDED";
            gridNumericColumn12.Width = 150D;
            gridCheckBoxColumn1.AllowFiltering = true;
            gridCheckBoxColumn1.AllowGrouping = false;
            gridCheckBoxColumn1.AllowResizing = true;
            gridCheckBoxColumn1.CellStyle.BackColor = System.Drawing.Color.Aquamarine;
            gridCheckBoxColumn1.HeaderText = "Accounts Head";
            gridCheckBoxColumn1.MappingName = "ACCOUNTSHEAD";
            gridCheckBoxColumn1.Width = 150D;
            gridCheckBoxColumn2.AllowFiltering = true;
            gridCheckBoxColumn2.AllowGrouping = false;
            gridCheckBoxColumn2.AllowResizing = true;
            gridCheckBoxColumn2.CellStyle.BackColor = System.Drawing.Color.Salmon;
            gridCheckBoxColumn2.HeaderText = "Contrl Cell";
            gridCheckBoxColumn2.MappingName = "CONTROLCELL";
            gridCheckBoxColumn2.Width = 150D;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.AllowGrouping = false;
            gridTextColumn7.AllowResizing = true;
            gridTextColumn7.HeaderText = "Remarks";
            gridTextColumn7.MappingName = "REMARKS";
            gridTextColumn7.Visible = false;
            gridTextColumn7.Width = 0D;
            this.gridResult.Columns.Add(gridNumericColumn1);
            this.gridResult.Columns.Add(gridNumericColumn2);
            this.gridResult.Columns.Add(gridTextColumn1);
            this.gridResult.Columns.Add(gridTextColumn2);
            this.gridResult.Columns.Add(gridTextColumn3);
            this.gridResult.Columns.Add(gridTextColumn4);
            this.gridResult.Columns.Add(gridTextColumn5);
            this.gridResult.Columns.Add(gridTextColumn6);
            this.gridResult.Columns.Add(gridNumericColumn3);
            this.gridResult.Columns.Add(gridNumericColumn4);
            this.gridResult.Columns.Add(gridNumericColumn5);
            this.gridResult.Columns.Add(gridNumericColumn6);
            this.gridResult.Columns.Add(gridNumericColumn7);
            this.gridResult.Columns.Add(gridNumericColumn8);
            this.gridResult.Columns.Add(gridNumericColumn9);
            this.gridResult.Columns.Add(gridNumericColumn10);
            this.gridResult.Columns.Add(gridNumericColumn11);
            this.gridResult.Columns.Add(gridNumericColumn12);
            this.gridResult.Columns.Add(gridCheckBoxColumn1);
            this.gridResult.Columns.Add(gridCheckBoxColumn2);
            this.gridResult.Columns.Add(gridTextColumn7);
            this.gridResult.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridResult.Location = new System.Drawing.Point(12, 79);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.ShowGroupDropArea = true;
            this.gridResult.Size = new System.Drawing.Size(1360, 508);
            this.gridResult.TabIndex = 25;
            this.gridResult.Text = "sfDataGrid1";
            this.gridResult.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridResult_QueryRowStyle);
            this.gridResult.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.gridResult_CurrentCellEndEdit);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "Button";
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(953, 29);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 27);
            this.btnUpdate.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleName = "Button";
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.Location = new System.Drawing.Point(1112, 29);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 27);
            this.btnSubmit.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // frmFTRWorkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 599);
            this.Controls.Add(this.btnSubmit);
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
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
    }
}