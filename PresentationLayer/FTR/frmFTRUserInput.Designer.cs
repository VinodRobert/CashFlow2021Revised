namespace CashFlow 
{
    partial class frmUserInput
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn4 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn5 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReceivable = new System.Windows.Forms.Label();
            this.gridReceivable = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblHireCharges = new System.Windows.Forms.Label();
            this.gridHire = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.gridMisc = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblMisc = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.cmbProject = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.btnUpdate = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceivable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fund Transfer Request - User Inputs";
            // 
            // lblReceivable
            // 
            this.lblReceivable.AutoSize = true;
            this.lblReceivable.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivable.ForeColor = System.Drawing.Color.Blue;
            this.lblReceivable.Location = new System.Drawing.Point(12, 189);
            this.lblReceivable.Name = "lblReceivable";
            this.lblReceivable.Size = new System.Drawing.Size(217, 29);
            this.lblReceivable.TabIndex = 25;
            this.lblReceivable.Text = "Projected Receivable:";
            // 
            // gridReceivable
            // 
            this.gridReceivable.AccessibleName = "Table";
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "Item";
            gridTextColumn1.MappingName = "DESCRIPTION";
            gridTextColumn1.Width = 180D;
            gridNumericColumn1.HeaderText = "Amount";
            gridNumericColumn1.MappingName = "AMOUNT";
            gridNumericColumn1.Width = 120D;
            gridTextColumn2.HeaderText = "Column3";
            gridTextColumn2.MappingName = "INPUTID";
            gridTextColumn2.Visible = false;
            gridTextColumn2.Width = 0D;
            this.gridReceivable.Columns.Add(gridTextColumn1);
            this.gridReceivable.Columns.Add(gridNumericColumn1);
            this.gridReceivable.Columns.Add(gridTextColumn2);
            this.gridReceivable.Location = new System.Drawing.Point(12, 221);
            this.gridReceivable.Name = "gridReceivable";
            this.gridReceivable.PreviewRowHeight = 35;
            this.gridReceivable.Size = new System.Drawing.Size(344, 336);
            this.gridReceivable.Style.CellStyle.Font.Facename = "Arial";
            this.gridReceivable.Style.CellStyle.Font.Size = 10F;
            this.gridReceivable.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gridReceivable.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.gridReceivable.Style.HeaderStyle.Font.Bold = true;
            this.gridReceivable.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridReceivable.Style.HeaderStyle.Font.Size = 10F;
            this.gridReceivable.TabIndex = 26;
            this.gridReceivable.Text = "sfDataGrid1";
            // 
            // lblHireCharges
            // 
            this.lblHireCharges.AutoSize = true;
            this.lblHireCharges.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireCharges.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblHireCharges.Location = new System.Drawing.Point(380, 189);
            this.lblHireCharges.Name = "lblHireCharges";
            this.lblHireCharges.Size = new System.Drawing.Size(218, 29);
            this.lblHireCharges.TabIndex = 27;
            this.lblHireCharges.Text = "Internal Hire Charges:";
            // 
            // gridHire
            // 
            this.gridHire.AccessibleName = "Table";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.HeaderText = "Item";
            gridTextColumn3.MappingName = "DESCRIPTION";
            gridTextColumn3.Width = 180D;
            gridNumericColumn2.HeaderText = "Amount";
            gridNumericColumn2.MappingName = "AMOUNT";
            gridNumericColumn2.Width = 120D;
            gridNumericColumn3.HeaderText = "Column3";
            gridNumericColumn3.MappingName = "INPUTID";
            gridNumericColumn3.Visible = false;
            gridNumericColumn3.Width = 0D;
            this.gridHire.Columns.Add(gridTextColumn3);
            this.gridHire.Columns.Add(gridNumericColumn2);
            this.gridHire.Columns.Add(gridNumericColumn3);
            this.gridHire.Location = new System.Drawing.Point(380, 221);
            this.gridHire.Name = "gridHire";
            this.gridHire.PreviewRowHeight = 35;
            this.gridHire.Size = new System.Drawing.Size(344, 336);
            this.gridHire.Style.CellStyle.Font.Facename = "Arial";
            this.gridHire.Style.CellStyle.Font.Size = 10F;
            this.gridHire.Style.HeaderStyle.BackColor = System.Drawing.Color.Pink;
            this.gridHire.Style.HeaderStyle.Font.Bold = true;
            this.gridHire.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridHire.Style.HeaderStyle.Font.Size = 10F;
            this.gridHire.TabIndex = 28;
            this.gridHire.Text = "sfDataGrid2";
            // 
            // gridMisc
            // 
            this.gridMisc.AccessibleName = "Table";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.HeaderText = "Item";
            gridTextColumn4.MappingName = "DESCRIPTION";
            gridTextColumn4.Width = 180D;
            gridNumericColumn4.HeaderText = "Amount";
            gridNumericColumn4.MappingName = "AMOUNT";
            gridNumericColumn4.Width = 120D;
            gridNumericColumn5.HeaderText = "Column3";
            gridNumericColumn5.MappingName = "INPUTID";
            gridNumericColumn5.Visible = false;
            gridNumericColumn5.Width = 0D;
            this.gridMisc.Columns.Add(gridTextColumn4);
            this.gridMisc.Columns.Add(gridNumericColumn4);
            this.gridMisc.Columns.Add(gridNumericColumn5);
            this.gridMisc.Location = new System.Drawing.Point(755, 221);
            this.gridMisc.Name = "gridMisc";
            this.gridMisc.PreviewRowHeight = 35;
            this.gridMisc.Size = new System.Drawing.Size(344, 336);
            this.gridMisc.Style.CellStyle.Font.Facename = "Arial";
            this.gridMisc.Style.CellStyle.Font.Size = 10F;
            this.gridMisc.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gridMisc.Style.HeaderStyle.Font.Bold = true;
            this.gridMisc.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridMisc.Style.HeaderStyle.Font.Size = 10F;
            this.gridMisc.TabIndex = 29;
            this.gridMisc.Text = "sfDataGrid3";
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisc.ForeColor = System.Drawing.Color.Purple;
            this.lblMisc.Location = new System.Drawing.Point(755, 189);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(203, 29);
            this.lblMisc.TabIndex = 30;
            this.lblMisc.Text = "Miscellaneous Items";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblProjectName.Location = new System.Drawing.Point(12, 71);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(92, 29);
            this.lblProjectName.TabIndex = 31;
            this.lblProjectName.Text = "Project :";
            // 
            // cmbProject
            // 
            this.cmbProject.DisplayMember = "BORGNAME";
            this.cmbProject.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbProject.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.Location = new System.Drawing.Point(100, 71);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(361, 32);
            this.cmbProject.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProject.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.TabIndex = 32;
            this.cmbProject.ValueMember = "BORGID";
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFetch.Location = new System.Drawing.Point(480, 71);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(96, 28);
            this.btnFetch.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFetch.TabIndex = 33;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // lblMonthName
            // 
            this.lblMonthName.AutoSize = true;
            this.lblMonthName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMonthName.Location = new System.Drawing.Point(12, 133);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(234, 29);
            this.lblMonthName.TabIndex = 34;
            this.lblMonthName.Text = "Enter Details For Month";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "Button";
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(725, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 28);
            this.btnUpdate.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnClose.Location = new System.Drawing.Point(989, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 608);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblMisc);
            this.Controls.Add(this.gridMisc);
            this.Controls.Add(this.gridHire);
            this.Controls.Add(this.lblHireCharges);
            this.Controls.Add(this.gridReceivable);
            this.Controls.Add(this.lblReceivable);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTR | User Inputs";
            this.Load += new System.EventHandler(this.frmCloseFTR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReceivable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReceivable;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridReceivable;
        private System.Windows.Forms.Label lblHireCharges;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridHire;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridMisc;
        private System.Windows.Forms.Label lblMisc;
        private System.Windows.Forms.Label lblProjectName;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProject;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private System.Windows.Forms.Label lblMonthName;
        private Syncfusion.WinForms.Controls.SfButton btnUpdate;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}