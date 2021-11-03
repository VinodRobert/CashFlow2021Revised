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
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFTRHistory = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnNew = new Syncfusion.WinForms.Controls.SfButton();
            this.panelNewFTR = new System.Windows.Forms.Panel();
            this.txtConfirm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblConfirm = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.cmbProjectName = new Syncfusion.WinForms.ListView.SfComboBox();
            this.lblProjectName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridFTRHistory)).BeginInit();
            this.panelNewFTR.SuspendLayout();
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
            gridTextColumn2.Width = 300D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "FTR Number";
            gridTextColumn3.MappingName = "FTRNUMBER";
            gridTextColumn3.Width = 180D;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowFiltering = true;
            gridDateTimeColumn1.HeaderText = "Created On";
            gridDateTimeColumn1.MappingName = "CREATEDATE";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.FullDateTime;
            gridDateTimeColumn1.Width = 180D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Status";
            gridTextColumn4.MappingName = "FTRSTATUS";
            gridTextColumn4.Width = 100D;
            gridDateTimeColumn2.AllowEditing = false;
            gridDateTimeColumn2.AllowFiltering = true;
            gridDateTimeColumn2.HeaderText = "Last Updated At";
            gridDateTimeColumn2.MappingName = "LASTUPDATE";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.FullDateTime;
            gridDateTimeColumn2.Width = 220D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Current Owner";
            gridTextColumn5.MappingName = "CUSTODIAN";
            gridTextColumn5.Width = 120D;
            this.gridFTRHistory.Columns.Add(gridTextColumn1);
            this.gridFTRHistory.Columns.Add(gridTextColumn2);
            this.gridFTRHistory.Columns.Add(gridTextColumn3);
            this.gridFTRHistory.Columns.Add(gridDateTimeColumn1);
            this.gridFTRHistory.Columns.Add(gridTextColumn4);
            this.gridFTRHistory.Columns.Add(gridDateTimeColumn2);
            this.gridFTRHistory.Columns.Add(gridTextColumn5);
            this.gridFTRHistory.Location = new System.Drawing.Point(13, 61);
            this.gridFTRHistory.Name = "gridFTRHistory";
            this.gridFTRHistory.PreviewRowHeight = 35;
            this.gridFTRHistory.Size = new System.Drawing.Size(1402, 526);
            this.gridFTRHistory.TabIndex = 24;
            this.gridFTRHistory.Text = "sfDataGrid1";
            this.gridFTRHistory.ThemeName = "Office2019Colorful";
            this.gridFTRHistory.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.gridFTRHistory_AutoGeneratingColumn);
            this.gridFTRHistory.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridFTRHistory_QueryRowStyle);
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
            this.panelNewFTR.Controls.Add(this.txtConfirm);
            this.panelNewFTR.Controls.Add(this.lblConfirm);
            this.panelNewFTR.Controls.Add(this.btnCancel);
            this.panelNewFTR.Controls.Add(this.btnSubmit);
            this.panelNewFTR.Controls.Add(this.cmbProjectName);
            this.panelNewFTR.Controls.Add(this.lblProjectName);
            this.panelNewFTR.Location = new System.Drawing.Point(396, 214);
            this.panelNewFTR.Name = "panelNewFTR";
            this.panelNewFTR.Size = new System.Drawing.Size(752, 205);
            this.panelNewFTR.TabIndex = 26;
            this.panelNewFTR.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNewFTR_Paint);
            // 
            // txtConfirm
            // 
            this.txtConfirm.BeforeTouchSize = new System.Drawing.Size(100, 28);
            this.txtConfirm.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtConfirm.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(280, 167);
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
            this.lblConfirm.Location = new System.Drawing.Point(18, 167);
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
            this.btnCancel.Location = new System.Drawing.Point(553, 100);
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
            this.btnSubmit.Location = new System.Drawing.Point(185, 100);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(166, 46);
            this.btnSubmit.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.DisplayMember = "ORGNAME";
            this.cmbProjectName.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbProjectName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjectName.Location = new System.Drawing.Point(185, 43);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(548, 32);
            this.cmbProjectName.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjectName.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjectName.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProjectName.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjectName.TabIndex = 1;
            this.cmbProjectName.ValueMember = "ORGID";
            // 
            // lblProjectName
            // 
            this.lblProjectName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(18, 48);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(135, 22);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project Name :";
            // 
            // frmFTRList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 599);
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
        private Syncfusion.WinForms.ListView.SfComboBox cmbProjectName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblProjectName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtConfirm;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblConfirm;
        private System.Windows.Forms.Timer timer1;
    }
}