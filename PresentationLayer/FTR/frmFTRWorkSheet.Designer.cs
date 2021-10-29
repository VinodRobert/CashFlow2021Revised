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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn4 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn5 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn6 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn7 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn8 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.lblProjectName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbProject = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnnView = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbFinYear = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbPeriod = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkReCreate = new System.Windows.Forms.CheckBox();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnUpdate = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.Blue;
            this.lblProjectName.Location = new System.Drawing.Point(12, 40);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(74, 20);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Project ";
            // 
            // cmbProject
            // 
            this.cmbProject.AllowCaseSensitiveOnAutoComplete = true;
            this.cmbProject.AllowDrop = true;
            this.cmbProject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProject.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            this.cmbProject.DisplayMember = "BorgName";
            this.cmbProject.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.Location = new System.Drawing.Point(77, 40);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(484, 27);
            this.cmbProject.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbProject.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProject.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.TabIndex = 2;
            this.cmbProject.ValueMember = "BorgID";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Olive;
            this.btnClose.Location = new System.Drawing.Point(1302, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 27);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Olive;
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnnView
            // 
            this.btnnView.AccessibleName = "Button";
            this.btnnView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnnView.ForeColor = System.Drawing.Color.Blue;
            this.btnnView.Location = new System.Drawing.Point(1302, 31);
            this.btnnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnnView.Name = "btnnView";
            this.btnnView.Size = new System.Drawing.Size(113, 27);
            this.btnnView.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnnView.TabIndex = 15;
            this.btnnView.Text = "Generate";
            this.btnnView.Click += new System.EventHandler(this.btnnView_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(567, 40);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(127, 20);
            this.autoLabel1.TabIndex = 11;
            this.autoLabel1.Text = "Financial Year";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel2.Location = new System.Drawing.Point(797, 40);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(62, 20);
            this.autoLabel2.TabIndex = 20;
            this.autoLabel2.Text = "Period";
            // 
            // cmbFinYear
            // 
            this.cmbFinYear.DisplayMember = "FINYEAR";
            this.cmbFinYear.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbFinYear.Location = new System.Drawing.Point(701, 40);
            this.cmbFinYear.Name = "cmbFinYear";
            this.cmbFinYear.Size = new System.Drawing.Size(90, 27);
            this.cmbFinYear.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFinYear.TabIndex = 21;
            this.cmbFinYear.ValueMember = "FINYEAR";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.DisplayMember = "PERIODDESC";
            this.cmbPeriod.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbPeriod.Location = new System.Drawing.Point(865, 40);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(181, 27);
            this.cmbPeriod.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPeriod.TabIndex = 22;
            this.cmbPeriod.ValueMember = "PERIODID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(604, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "FTR - Work Sheet";
            // 
            // chkReCreate
            // 
            this.chkReCreate.AutoSize = true;
            this.chkReCreate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReCreate.ForeColor = System.Drawing.Color.Blue;
            this.chkReCreate.Location = new System.Drawing.Point(1053, 45);
            this.chkReCreate.Name = "chkReCreate";
            this.chkReCreate.Size = new System.Drawing.Size(159, 26);
            this.chkReCreate.TabIndex = 24;
            this.chkReCreate.Text = "Re-Create If Exists";
            this.chkReCreate.UseVisualStyleBackColor = true;
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            this.gridResult.AllowFiltering = true;
            this.gridResult.AllowGrouping = false;
            this.gridResult.AllowResizingColumns = true;
            this.gridResult.AllowStandardTab = true;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.AllowGrouping = false;
            gridNumericColumn1.AllowResizing = true;
            gridNumericColumn1.HeaderText = "Column1";
            gridNumericColumn1.MappingName = "WORKSHEETID";
            gridNumericColumn1.Visible = false;
            gridNumericColumn1.Width = 0D;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "Major Category";
            gridTextColumn1.MappingName = "MAJORCATEGORY";
            gridTextColumn1.Width = 125D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderText = "Minor Category";
            gridTextColumn2.MappingName = "MINORCATEGORY";
            gridTextColumn2.Width = 120D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderText = "Category";
            gridTextColumn3.MappingName = "CATEGORY";
            gridTextColumn3.Width = 120D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.AllowGrouping = false;
            gridTextColumn4.AllowResizing = true;
            gridTextColumn4.HeaderText = "Type";
            gridTextColumn4.MappingName = "VENDORTYPE";
            gridTextColumn4.Width = 100D;
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
            gridTextColumn6.Width = 150D;
            gridNumericColumn2.AllowEditing = false;
            gridNumericColumn2.AllowFiltering = true;
            gridNumericColumn2.AllowGrouping = false;
            gridNumericColumn2.AllowResizing = true;
            gridNumericColumn2.HeaderText = "Net Payable";
            gridNumericColumn2.MappingName = "NETPAYABLE";
            gridNumericColumn2.Width = 110D;
            gridNumericColumn3.AllowEditing = false;
            gridNumericColumn3.AllowFiltering = true;
            gridNumericColumn3.AllowGrouping = false;
            gridNumericColumn3.AllowResizing = true;
            gridNumericColumn3.HeaderText = "Paid";
            gridNumericColumn3.MappingName = "PAID";
            gridNumericColumn3.Width = 110D;
            gridNumericColumn4.AllowEditing = false;
            gridNumericColumn4.AllowFiltering = true;
            gridNumericColumn4.AllowGrouping = false;
            gridNumericColumn4.AllowResizing = true;
            gridNumericColumn4.HeaderText = "Project Liability";
            gridNumericColumn4.MappingName = "PROJECTLIABILITY";
            gridNumericColumn4.Width = 110D;
            gridNumericColumn5.AllowEditing = false;
            gridNumericColumn5.AllowFiltering = true;
            gridNumericColumn5.AllowGrouping = false;
            gridNumericColumn5.AllowResizing = true;
            gridNumericColumn5.HeaderText = "Zonal Liability";
            gridNumericColumn5.MappingName = "ZONALLIABILITY";
            gridNumericColumn5.Width = 110D;
            gridNumericColumn6.AllowFiltering = true;
            gridNumericColumn6.AllowGrouping = false;
            gridNumericColumn6.AllowResizing = true;
            gridNumericColumn6.HeaderText = "Project Site";
            gridNumericColumn6.MappingName = "PROJECTSITE";
            gridNumericColumn6.Width = 100D;
            gridNumericColumn7.AllowFiltering = true;
            gridNumericColumn7.AllowGrouping = false;
            gridNumericColumn7.AllowResizing = true;
            gridNumericColumn7.HeaderText = "Accountant";
            gridNumericColumn7.MappingName = "ACCOUNTANT";
            gridNumericColumn7.Width = 100D;
            gridNumericColumn8.AllowFiltering = true;
            gridNumericColumn8.AllowGrouping = false;
            gridNumericColumn8.AllowResizing = true;
            gridNumericColumn8.HeaderText = "Accounts Head";
            gridNumericColumn8.MappingName = "ACCOUNTSHEAD";
            gridNumericColumn8.Width = 100D;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.AllowGrouping = false;
            gridTextColumn7.AllowResizing = true;
            gridTextColumn7.HeaderText = "Control Cell";
            gridTextColumn7.MappingName = "CONTROLCELL";
            gridTextColumn7.Width = 100D;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.AllowGrouping = false;
            gridTextColumn8.AllowResizing = true;
            gridTextColumn8.HeaderText = "Remarks";
            gridTextColumn8.MappingName = "REMARKS";
            gridTextColumn8.Width = 100D;
            gridTextColumn9.AllowFiltering = true;
            gridTextColumn9.AllowGrouping = false;
            gridTextColumn9.AllowResizing = true;
            gridTextColumn9.HeaderText = "RESULTID";
            gridTextColumn9.MappingName = "RESULTID";
            gridTextColumn9.Visible = false;
            gridTextColumn9.Width = 0D;
            this.gridResult.Columns.Add(gridNumericColumn1);
            this.gridResult.Columns.Add(gridTextColumn1);
            this.gridResult.Columns.Add(gridTextColumn2);
            this.gridResult.Columns.Add(gridTextColumn3);
            this.gridResult.Columns.Add(gridTextColumn4);
            this.gridResult.Columns.Add(gridTextColumn5);
            this.gridResult.Columns.Add(gridTextColumn6);
            this.gridResult.Columns.Add(gridNumericColumn2);
            this.gridResult.Columns.Add(gridNumericColumn3);
            this.gridResult.Columns.Add(gridNumericColumn4);
            this.gridResult.Columns.Add(gridNumericColumn5);
            this.gridResult.Columns.Add(gridNumericColumn6);
            this.gridResult.Columns.Add(gridNumericColumn7);
            this.gridResult.Columns.Add(gridNumericColumn8);
            this.gridResult.Columns.Add(gridTextColumn7);
            this.gridResult.Columns.Add(gridTextColumn8);
            this.gridResult.Columns.Add(gridTextColumn9);
            this.gridResult.Location = new System.Drawing.Point(12, 100);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.ShowGroupDropArea = true;
            this.gridResult.Size = new System.Drawing.Size(1403, 487);
            this.gridResult.TabIndex = 25;
            this.gridResult.Text = "sfDataGrid1";
            this.gridResult.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridResult_QueryRowStyle);
            this.gridResult.CurrentCellBeginEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellBeginEditEventHandler(this.gridResult_CurrentCellBeginEdit);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "Button";
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(1302, 65);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 27);
            this.btnUpdate.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmFTRWorkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 599);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.chkReCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.cmbFinYear);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnnView);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.lblProjectName);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFTRWorkSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTR | Work Sheet";
            this.Load += new System.EventHandler(this.frmFTRSubbie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblProjectName;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProject;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnnView;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.WinForms.ListView.SfComboBox cmbFinYear;
        private Syncfusion.WinForms.ListView.SfComboBox cmbPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkReCreate;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridResult;
        private Syncfusion.WinForms.Controls.SfButton btnUpdate;
    }
}