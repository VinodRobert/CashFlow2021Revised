namespace CashFlow 
{
    partial class frmLC
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
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.gridLC = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.cmbProject = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProject)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFetch.Location = new System.Drawing.Point(553, 41);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(2);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(190, 23);
            this.btnFetch.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFetch.TabIndex = 37;
            this.btnFetch.Text = "Fetch Current FTR Period";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblProjectName.Location = new System.Drawing.Point(9, 41);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(72, 23);
            this.lblProjectName.TabIndex = 35;
            this.lblProjectName.Text = "Project :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(364, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fund Transfer Request - LC Details";
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sfButton1.Location = new System.Drawing.Point(783, 41);
            this.sfButton1.Margin = new System.Windows.Forms.Padding(2);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(190, 23);
            this.sfButton1.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sfButton1.TabIndex = 38;
            this.sfButton1.Text = "Fetch  Future Periods";
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // lblMonthName
            // 
            this.lblMonthName.AutoSize = true;
            this.lblMonthName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMonthName.Location = new System.Drawing.Point(9, 82);
            this.lblMonthName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(187, 23);
            this.lblMonthName.TabIndex = 39;
            this.lblMonthName.Text = "Enter Details For Month";
            // 
            // gridLC
            // 
            this.gridLC.AccessibleName = "Table";
            this.gridLC.AllowFiltering = true;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "TransGroup";
            gridTextColumn1.HeaderTextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            gridTextColumn1.MappingName = "TRANGRP";
            gridTextColumn1.Width = 100D;
            gridDateTimeColumn1.AllowFiltering = true;
            gridDateTimeColumn1.HeaderText = "TranDate";
            gridDateTimeColumn1.MappingName = "PDATE";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Width = 95D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Bank";
            gridTextColumn2.MappingName = "BANKNAME";
            gridTextColumn2.Width = 180D;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "TransRef";
            gridTextColumn3.MappingName = "TRANSREF";
            gridTextColumn3.Width = 100D;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "DESCRIPTION";
            gridTextColumn4.MappingName = "DESCRIPTION";
            gridTextColumn4.Width = 400D;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.HeaderText = "Debit";
            gridNumericColumn1.MappingName = "DEBIT";
            gridNumericColumn1.Width = 120D;
            gridNumericColumn2.AllowFiltering = true;
            gridNumericColumn2.HeaderText = "Credit";
            gridNumericColumn2.MappingName = "CREDIT";
            gridNumericColumn3.AllowFiltering = true;
            gridNumericColumn3.HeaderText = "Amount";
            gridNumericColumn3.MappingName = "AMOUNT";
            gridNumericColumn3.Visible = false;
            gridNumericColumn3.Width = 0D;
            this.gridLC.Columns.Add(gridTextColumn1);
            this.gridLC.Columns.Add(gridDateTimeColumn1);
            this.gridLC.Columns.Add(gridTextColumn2);
            this.gridLC.Columns.Add(gridTextColumn3);
            this.gridLC.Columns.Add(gridTextColumn4);
            this.gridLC.Columns.Add(gridNumericColumn1);
            this.gridLC.Columns.Add(gridNumericColumn2);
            this.gridLC.Columns.Add(gridNumericColumn3);
            this.gridLC.Location = new System.Drawing.Point(9, 108);
            this.gridLC.Margin = new System.Windows.Forms.Padding(2);
            this.gridLC.Name = "gridLC";
            this.gridLC.PreviewRowHeight = 35;
            this.gridLC.Size = new System.Drawing.Size(1117, 427);
            this.gridLC.Style.CellStyle.Font.Facename = "Arial";
            this.gridLC.Style.CellStyle.Font.Size = 8F;
            this.gridLC.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gridLC.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.gridLC.Style.HeaderStyle.Font.Bold = true;
            this.gridLC.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridLC.Style.HeaderStyle.Font.Size = 10F;
            this.gridLC.Style.HeaderStyle.TextColor = System.Drawing.Color.Red;
            this.gridLC.TabIndex = 40;
            this.gridLC.Text = "sfDataGrid1";
            this.gridLC.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridLC_QueryRowStyle);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnClose.Location = new System.Drawing.Point(1054, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.Style.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbProject
            // 
            this.cmbProject.DisplayMember = "BORGNAME";
            this.cmbProject.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbProject.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.Location = new System.Drawing.Point(82, 38);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cmbProject.Size = new System.Drawing.Size(454, 32);
            this.cmbProject.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProject.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.TabIndex = 42;
            this.cmbProject.ValueMember = "BORGID";
            // 
            // frmLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 560);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridLC);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LC ";
            this.Load += new System.EventHandler(this.frmLC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private System.Windows.Forms.Label lblMonthName;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridLC;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProject;
    }
}