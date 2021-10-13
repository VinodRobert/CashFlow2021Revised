namespace CashFlow.PresentationLayer.Cash_Flow
{
    partial class frmFTRSubbie
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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn13 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            this.lblProjectName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbProject = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnReset = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnnView = new Syncfusion.WinForms.Controls.SfButton();
            this.txtFinYear = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnExcel = new Syncfusion.WinForms.Controls.SfButton();
            this.tabControlResult = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabTopSheet = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlResult)).BeginInit();
            this.tabControlResult.SuspendLayout();
            this.tabTopSheet.SuspendLayout();
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
            this.cmbProject.Location = new System.Drawing.Point(101, 40);
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
            // btnReset
            // 
            this.btnReset.AccessibleName = "Button";
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnReset.Location = new System.Drawing.Point(917, 40);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 27);
            this.btnReset.Style.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Olive;
            this.btnClose.Location = new System.Drawing.Point(1155, 40);
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
            this.btnnView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnnView.ForeColor = System.Drawing.Color.Blue;
            this.btnnView.Location = new System.Drawing.Point(814, 40);
            this.btnnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnnView.Name = "btnnView";
            this.btnnView.Size = new System.Drawing.Size(88, 27);
            this.btnnView.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnnView.TabIndex = 15;
            this.btnnView.Text = "View";
            this.btnnView.Click += new System.EventHandler(this.btnnView_Click);
            // 
            // txtFinYear
            // 
            this.txtFinYear.BeforeTouchSize = new System.Drawing.Size(60, 27);
            this.txtFinYear.Location = new System.Drawing.Point(724, 40);
            this.txtFinYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinYear.Name = "txtFinYear";
            this.txtFinYear.Size = new System.Drawing.Size(60, 27);
            this.txtFinYear.TabIndex = 12;
            this.txtFinYear.Text = "2022";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(591, 40);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(127, 20);
            this.autoLabel1.TabIndex = 11;
            this.autoLabel1.Text = "Financial Year";
            // 
            // btnExcel
            // 
            this.btnExcel.AccessibleName = "Button";
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcel.Location = new System.Drawing.Point(1025, 40);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(122, 27);
            this.btnExcel.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcel.TabIndex = 19;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // tabControlResult
            // 
            this.tabControlResult.ActiveTabFont = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.tabControlResult.BeforeTouchSize = new System.Drawing.Size(1405, 493);
            this.tabControlResult.Controls.Add(this.tabTopSheet);
            this.tabControlResult.Location = new System.Drawing.Point(13, 84);
            this.tabControlResult.Name = "tabControlResult";
            this.tabControlResult.Size = new System.Drawing.Size(1405, 493);
            this.tabControlResult.TabIndex = 20;
            this.tabControlResult.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbeyBeta);
            this.tabControlResult.ThemeName = "TabRendererDockingWhidbeyBeta";
            this.tabControlResult.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.tabControlResult.SelectedIndexChanged += new System.EventHandler(this.tabControlResult_SelectedIndexChanged);
            // 
            // tabTopSheet
            // 
            this.tabTopSheet.Controls.Add(this.gridResult);
            this.tabTopSheet.Image = null;
            this.tabTopSheet.ImageSize = new System.Drawing.Size(20, 20);
            this.tabTopSheet.Location = new System.Drawing.Point(1, 39);
            this.tabTopSheet.Name = "tabTopSheet";
            this.tabTopSheet.ShowCloseButton = true;
            this.tabTopSheet.Size = new System.Drawing.Size(1402, 451);
            this.tabTopSheet.TabForeColor = System.Drawing.Color.Blue;
            this.tabTopSheet.TabIndex = 1;
            this.tabTopSheet.Text = "Top Sheet";
            this.tabTopSheet.ThemesEnabled = false;
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            this.gridResult.AllowFiltering = true;
            this.gridResult.AllowGrouping = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.HeaderText = "Category";
            gridTextColumn1.MappingName = "CATEGORY";
            gridTextColumn1.Width = 100D;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.HeaderText = "Party Name";
            gridTextColumn2.MappingName = "PARTYNAME";
            gridTextColumn2.Width = 175D;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.HeaderText = "Party";
            gridTextColumn3.MappingName = "PARTYCODE";
            gridTextColumn3.Width = 100D;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.AllowGrouping = false;
            gridNumericColumn1.HeaderText = "Work Done";
            gridNumericColumn1.MappingName = "WORKDONE";
            gridNumericColumn1.Width = 100D;
            gridNumericColumn2.AllowFiltering = true;
            gridNumericColumn2.AllowGrouping = false;
            gridNumericColumn2.HeaderText = "Tax";
            gridNumericColumn2.MappingName = "TAX";
            gridNumericColumn2.Width = 90D;
            gridNumericColumn3.AllowFiltering = true;
            gridNumericColumn3.AllowGrouping = false;
            gridNumericColumn3.HeaderText = "Contras";
            gridNumericColumn3.MappingName = "DEBITS";
            gridNumericColumn3.Width = 90D;
            gridNumericColumn4.AllowFiltering = true;
            gridNumericColumn4.AllowGrouping = false;
            gridNumericColumn4.HeaderText = "Retention";
            gridNumericColumn4.MappingName = "RETENTION";
            gridNumericColumn4.Width = 100D;
            gridNumericColumn5.AllowFiltering = true;
            gridNumericColumn5.AllowGrouping = false;
            gridNumericColumn5.HeaderText = "WithHeld";
            gridNumericColumn5.MappingName = "WITHHELD";
            gridNumericColumn6.AllowFiltering = true;
            gridNumericColumn6.AllowGrouping = false;
            gridNumericColumn6.HeaderText = "Discount";
            gridNumericColumn6.MappingName = "DISCOUNT";
            gridNumericColumn7.AllowFiltering = true;
            gridNumericColumn7.AllowGrouping = false;
            gridNumericColumn7.HeaderText = "Others";
            gridNumericColumn7.MappingName = "OTHERS";
            gridNumericColumn7.Width = 90D;
            gridNumericColumn8.AllowFiltering = true;
            gridNumericColumn8.AllowGrouping = false;
            gridNumericColumn8.HeaderText = "TDS";
            gridNumericColumn8.MappingName = "TDS";
            gridNumericColumn8.Width = 90D;
            gridNumericColumn9.AllowFiltering = true;
            gridNumericColumn9.AllowGrouping = false;
            gridNumericColumn9.HeaderText = "Net Payable";
            gridNumericColumn9.MappingName = "NETPAYABLE";
            gridNumericColumn9.Width = 110D;
            gridNumericColumn10.AllowFiltering = true;
            gridNumericColumn10.AllowGrouping = false;
            gridNumericColumn10.HeaderText = "Paid";
            gridNumericColumn10.MappingName = "PAID";
            gridNumericColumn10.Width = 110D;
            gridNumericColumn11.AllowFiltering = true;
            gridNumericColumn11.AllowGrouping = false;
            gridNumericColumn11.HeaderText = "Project Liablity";
            gridNumericColumn11.MappingName = "PROJECTLIABILITY";
            gridNumericColumn11.Width = 110D;
            gridNumericColumn12.AllowFiltering = true;
            gridNumericColumn12.AllowGrouping = false;
            gridNumericColumn12.HeaderText = "Zonal Outstanding";
            gridNumericColumn12.MappingName = "ZONALLIABILITY";
            gridNumericColumn12.Width = 110D;
            gridNumericColumn13.AllowFiltering = true;
            gridNumericColumn13.AllowGrouping = false;
            gridNumericColumn13.HeaderText = "Advance";
            gridNumericColumn13.MappingName = "ADVANCE";
            gridNumericColumn13.Width = 100D;
            this.gridResult.Columns.Add(gridTextColumn1);
            this.gridResult.Columns.Add(gridTextColumn2);
            this.gridResult.Columns.Add(gridTextColumn3);
            this.gridResult.Columns.Add(gridNumericColumn1);
            this.gridResult.Columns.Add(gridNumericColumn2);
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
            this.gridResult.Columns.Add(gridNumericColumn13);
            this.gridResult.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridResult.Location = new System.Drawing.Point(3, 3);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.Size = new System.Drawing.Size(1391, 437);
            this.gridResult.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.gridResult.Style.HeaderStyle.Font.Bold = true;
            this.gridResult.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridResult.Style.HeaderStyle.Font.Size = 9F;
            this.gridResult.Style.HeaderStyle.TextColor = System.Drawing.Color.Fuchsia;
            this.gridResult.Style.RowHeaderStyle.Font.Bold = true;
            this.gridResult.Style.RowHeaderStyle.Font.Facename = "Arial";
            this.gridResult.Style.RowHeaderStyle.Font.Size = 9F;
            this.gridResult.Style.RowHeaderStyle.TextColor = System.Drawing.Color.Blue;
            this.gridResult.TabIndex = 1;
            this.gridResult.Text = "sfDataGrid1";
            this.gridResult.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridResult_QueryRowStyle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(619, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "FTR - Sub Contractors";
            // 
            // frmFTRSubbie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlResult);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnnView);
            this.Controls.Add(this.txtFinYear);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.lblProjectName);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFTRSubbie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTR | Sub Contractors |Result";
            this.Load += new System.EventHandler(this.frmFTRSubbie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlResult)).EndInit();
            this.tabControlResult.ResumeLayout(false);
            this.tabTopSheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblProjectName;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProject;
        private Syncfusion.WinForms.Controls.SfButton btnReset;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnnView;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFinYear;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton btnExcel;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlResult;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabTopSheet;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridResult;
        private System.Windows.Forms.Label label1;
    }
}