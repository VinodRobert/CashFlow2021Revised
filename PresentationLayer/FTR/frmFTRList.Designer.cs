namespace CashFlow.PresentationLayer.Cash_Flow
{
    partial class frmFTRList
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn1 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn2 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn3 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFTRHistory = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnNew = new Syncfusion.WinForms.Controls.SfButton();
            this.panelNewFTR = new System.Windows.Forms.Panel();
            this.cmbCalYear = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnGO = new Syncfusion.WinForms.Controls.SfButton();
            this.lblHeader = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbCalMonth = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblCalendarMonth = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblCalendarYear = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtConfirm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblConfirm = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.lblProjectName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbProjectName = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridFTRHistory)).BeginInit();
            this.panelNewFTR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCalYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCalMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Olive;
            this.btnClose.Location = new System.Drawing.Point(1293, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 27);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Olive;
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(576, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fund Transfer Request - History";
            // 
            // gridFTRHistory
            // 
            this.gridFTRHistory.AccessibleName = "Table";
            this.gridFTRHistory.AllowEditing = false;
            this.gridFTRHistory.AllowFiltering = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "FTRID";
            gridTextColumn1.MappingName = "FTRID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Project Name";
            gridTextColumn2.MappingName = "BORGNAME";
            gridTextColumn2.Width = 180D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Year";
            gridTextColumn3.MappingName = "CALYEAR";
            gridTextColumn3.Width = 75D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Month";
            gridTextColumn4.MappingName = "CALMONTH";
            gridTextColumn4.Width = 100D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "FTR Number";
            gridTextColumn5.MappingName = "FTRNUMBER";
            gridTextColumn5.Width = 150D;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowFiltering = true;
            gridDateTimeColumn1.HeaderText = "Created On";
            gridDateTimeColumn1.MappingName = "CREATEDATE";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.FullDateTime;
            gridDateTimeColumn1.Width = 180D;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Status";
            gridTextColumn6.MappingName = "FTRSTATUS";
            gridTextColumn6.Width = 90D;
            gridDateTimeColumn2.AllowEditing = false;
            gridDateTimeColumn2.AllowFiltering = true;
            gridDateTimeColumn2.HeaderText = "Last Updated At";
            gridDateTimeColumn2.MappingName = "LASTUPDATE";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.FullDateTime;
            gridDateTimeColumn2.Width = 180D;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "Current Owner";
            gridTextColumn7.MappingName = "CUSTODIAN";
            gridTextColumn7.Width = 120D;
            gridButtonColumn1.AllowDefaultButtonText = false;
            gridButtonColumn1.AllowEditing = false;
            gridButtonColumn1.AllowFiltering = true;
            gridButtonColumn1.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.CellStyle.Font.Bold = true;
            gridButtonColumn1.CellStyle.TextColor = System.Drawing.Color.Blue;
            gridButtonColumn1.DefaultButtonText = "";
            gridButtonColumn1.HeaderStyle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            gridButtonColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridButtonColumn1.HeaderText = "Open";
            gridButtonColumn1.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.MappingName = "FOREDIT";
            gridButtonColumn2.AllowDefaultButtonText = false;
            gridButtonColumn2.AllowEditing = false;
            gridButtonColumn2.AllowFiltering = true;
            gridButtonColumn2.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn2.CellStyle.Font.Bold = true;
            gridButtonColumn2.CellStyle.TextColor = System.Drawing.Color.Red;
            gridButtonColumn2.DefaultButtonText = "";
            gridButtonColumn2.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            gridButtonColumn2.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridButtonColumn2.HeaderText = "Export";
            gridButtonColumn2.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn2.MappingName = "FOREXPORT";
            gridButtonColumn3.AllowDefaultButtonText = false;
            gridButtonColumn3.AllowEditing = false;
            gridButtonColumn3.AllowFiltering = true;
            gridButtonColumn3.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn3.DefaultButtonText = "";
            gridButtonColumn3.HeaderStyle.BackColor = System.Drawing.Color.Violet;
            gridButtonColumn3.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridButtonColumn3.HeaderText = "Print";
            gridButtonColumn3.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn3.MappingName = "FORPRINT";
            this.gridFTRHistory.Columns.Add(gridTextColumn1);
            this.gridFTRHistory.Columns.Add(gridTextColumn2);
            this.gridFTRHistory.Columns.Add(gridTextColumn3);
            this.gridFTRHistory.Columns.Add(gridTextColumn4);
            this.gridFTRHistory.Columns.Add(gridTextColumn5);
            this.gridFTRHistory.Columns.Add(gridDateTimeColumn1);
            this.gridFTRHistory.Columns.Add(gridTextColumn6);
            this.gridFTRHistory.Columns.Add(gridDateTimeColumn2);
            this.gridFTRHistory.Columns.Add(gridTextColumn7);
            this.gridFTRHistory.Columns.Add(gridButtonColumn1);
            this.gridFTRHistory.Columns.Add(gridButtonColumn2);
            this.gridFTRHistory.Columns.Add(gridButtonColumn3);
            this.gridFTRHistory.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridFTRHistory.Location = new System.Drawing.Point(13, 61);
            this.gridFTRHistory.Name = "gridFTRHistory";
            this.gridFTRHistory.PreviewRowHeight = 35;
            this.gridFTRHistory.Size = new System.Drawing.Size(1402, 526);
            this.gridFTRHistory.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridFTRHistory.Style.HeaderStyle.Font.Bold = true;
            this.gridFTRHistory.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridFTRHistory.Style.HeaderStyle.TextColor = System.Drawing.Color.White;
            this.gridFTRHistory.TabIndex = 24;
            this.gridFTRHistory.Text = "sfDataGrid1";
            this.gridFTRHistory.ThemeName = "Office2019Colorful";
            this.gridFTRHistory.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.gridFTRHistory_AutoGeneratingColumn);
            this.gridFTRHistory.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridFTRHistory_QueryRowStyle);
            this.gridFTRHistory.QueryButtonCellStyle += new Syncfusion.WinForms.DataGrid.Events.QueryButtonCellStyleEventHandler(this.gridFTRHistory_QueryButtonCellStyle);
            this.gridFTRHistory.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.gridFTRHistory_CellButtonClick);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleName = "Button";
            this.btnNew.FocusRectangleVisible = true;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.Blue;
            this.btnNew.Location = new System.Drawing.Point(1154, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(109, 28);
            this.btnNew.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panelNewFTR
            // 
            this.panelNewFTR.Controls.Add(this.cmbProjectName);
            this.panelNewFTR.Controls.Add(this.cmbCalYear);
            this.panelNewFTR.Controls.Add(this.btnGO);
            this.panelNewFTR.Controls.Add(this.lblHeader);
            this.panelNewFTR.Controls.Add(this.cmbCalMonth);
            this.panelNewFTR.Controls.Add(this.lblCalendarMonth);
            this.panelNewFTR.Controls.Add(this.lblCalendarYear);
            this.panelNewFTR.Controls.Add(this.txtConfirm);
            this.panelNewFTR.Controls.Add(this.lblConfirm);
            this.panelNewFTR.Controls.Add(this.btnCancel);
            this.panelNewFTR.Controls.Add(this.btnSubmit);
            this.panelNewFTR.Controls.Add(this.lblProjectName);
            this.panelNewFTR.Location = new System.Drawing.Point(396, 214);
            this.panelNewFTR.Name = "panelNewFTR";
            this.panelNewFTR.Size = new System.Drawing.Size(772, 263);
            this.panelNewFTR.TabIndex = 26;
            this.panelNewFTR.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNewFTR_Paint);
            // 
            // cmbCalYear
            // 
            this.cmbCalYear.DisplayMember = "DISPLAYYEAR";
            this.cmbCalYear.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbCalYear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalYear.Location = new System.Drawing.Point(167, 103);
            this.cmbCalYear.Name = "cmbCalYear";
            this.cmbCalYear.Size = new System.Drawing.Size(135, 32);
            this.cmbCalYear.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbCalYear.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalYear.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalYear.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCalYear.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalYear.TabIndex = 12;
            this.cmbCalYear.Text = "Select Year";
            this.cmbCalYear.ThemeName = "";
            this.cmbCalYear.ValueMember = "CALYEAR";
            // 
            // btnGO
            // 
            this.btnGO.AccessibleName = "Button";
            this.btnGO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.ForeColor = System.Drawing.Color.Blue;
            this.btnGO.Location = new System.Drawing.Point(683, 56);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(71, 32);
            this.btnGO.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnGO.TabIndex = 11;
            this.btnGO.Text = "Go";
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(319, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(116, 29);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "New FTR";
            // 
            // cmbCalMonth
            // 
            this.cmbCalMonth.DisplayMember = "MONTHNAME";
            this.cmbCalMonth.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbCalMonth.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalMonth.Location = new System.Drawing.Point(551, 103);
            this.cmbCalMonth.Name = "cmbCalMonth";
            this.cmbCalMonth.Size = new System.Drawing.Size(203, 32);
            this.cmbCalMonth.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalMonth.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalMonth.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCalMonth.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalMonth.TabIndex = 8;
            this.cmbCalMonth.Text = "Select Month";
            this.cmbCalMonth.ValueMember = "MONTHID";
            // 
            // lblCalendarMonth
            // 
            this.lblCalendarMonth.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarMonth.ForeColor = System.Drawing.Color.Blue;
            this.lblCalendarMonth.Location = new System.Drawing.Point(398, 113);
            this.lblCalendarMonth.Name = "lblCalendarMonth";
            this.lblCalendarMonth.Size = new System.Drawing.Size(147, 22);
            this.lblCalendarMonth.TabIndex = 7;
            this.lblCalendarMonth.Text = "Calendar Month:";
            // 
            // lblCalendarYear
            // 
            this.lblCalendarYear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarYear.ForeColor = System.Drawing.Color.Blue;
            this.lblCalendarYear.Location = new System.Drawing.Point(15, 113);
            this.lblCalendarYear.Name = "lblCalendarYear";
            this.lblCalendarYear.Size = new System.Drawing.Size(138, 22);
            this.lblCalendarYear.TabIndex = 6;
            this.lblCalendarYear.Text = "Calendar Year :";
            // 
            // txtConfirm
            // 
            this.txtConfirm.BeforeTouchSize = new System.Drawing.Size(100, 28);
            this.txtConfirm.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtConfirm.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(280, 219);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(100, 28);
            this.txtConfirm.TabIndex = 5;
            this.txtConfirm.Text = "NO";
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // lblConfirm
            // 
            this.lblConfirm.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblConfirm.Location = new System.Drawing.Point(18, 219);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(244, 22);
            this.lblConfirm.TabIndex = 4;
            this.lblConfirm.Text = "Are You Sure ? (Type YES )";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "Button";
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Purple;
            this.btnCancel.Location = new System.Drawing.Point(584, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 46);
            this.btnCancel.Style.ForeColor = System.Drawing.Color.Purple;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleName = "Button";
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.Location = new System.Drawing.Point(167, 155);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(166, 46);
            this.btnSubmit.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.Red;
            this.lblProjectName.Location = new System.Drawing.Point(18, 56);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(135, 22);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project Name :";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.AllowDrop = true;
            this.cmbProjectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProjectName.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            this.cmbProjectName.DisplayMember = "ORGNAME";
            this.cmbProjectName.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbProjectName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjectName.Location = new System.Drawing.Point(167, 56);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(495, 32);
            this.cmbProjectName.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjectName.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjectName.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProjectName.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjectName.TabIndex = 13;
            this.cmbProjectName.ValueMember = "ORGID";
            // 
            // frmFTRList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 599);
            this.Controls.Add(this.panelNewFTR);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gridFTRHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFTRList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTR | List";
            this.Load += new System.EventHandler(this.frmFTRSubbie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFTRHistory)).EndInit();
            this.panelNewFTR.ResumeLayout(false);
            this.panelNewFTR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCalYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCalMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridFTRHistory;
        private Syncfusion.WinForms.Controls.SfButton btnNew;
        private System.Windows.Forms.Panel panelNewFTR;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblProjectName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtConfirm;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblConfirm;
        private System.Windows.Forms.Timer timer1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblHeader;
        private Syncfusion.WinForms.ListView.SfComboBox cmbCalMonth;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCalendarMonth;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCalendarYear;
        private Syncfusion.WinForms.Controls.SfButton btnGO;
        private Syncfusion.WinForms.ListView.SfComboBox cmbCalYear;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProjectName;
    }
}