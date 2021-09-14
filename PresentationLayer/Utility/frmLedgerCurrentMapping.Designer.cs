namespace CashFlow 
{
    partial class frmLedgerCodeCurrentMapping
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gridLedgerCurrentMapping = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridLedgerCurrentMapping)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ledger Code - Mapping";
            // 
            // gridLedgerCurrentMapping
            // 
            this.gridLedgerCurrentMapping.AccessibleName = "Table";
            this.gridLedgerCurrentMapping.AllowEditing = false;
            this.gridLedgerCurrentMapping.AllowFiltering = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Ledger  ";
            gridTextColumn1.MappingName = "LEDGERCODE";
            gridTextColumn1.Width = 80D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Ledger Name";
            gridTextColumn2.MappingName = "LEDGERNAME";
            gridTextColumn2.Width = 250D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Category";
            gridTextColumn3.MappingName = "FLOWCATEGORY";
            gridTextColumn3.Width = 90D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Level - 1";
            gridTextColumn4.MappingName = "LEVEL1";
            gridTextColumn4.Width = 190D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Level - 2";
            gridTextColumn5.MappingName = "LEVEL2";
            gridTextColumn5.Width = 250D;
            this.gridLedgerCurrentMapping.Columns.Add(gridTextColumn1);
            this.gridLedgerCurrentMapping.Columns.Add(gridTextColumn2);
            this.gridLedgerCurrentMapping.Columns.Add(gridTextColumn3);
            this.gridLedgerCurrentMapping.Columns.Add(gridTextColumn4);
            this.gridLedgerCurrentMapping.Columns.Add(gridTextColumn5);
            this.gridLedgerCurrentMapping.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLedgerCurrentMapping.Location = new System.Drawing.Point(13, 45);
            this.gridLedgerCurrentMapping.Name = "gridLedgerCurrentMapping";
            this.gridLedgerCurrentMapping.PreviewRowHeight = 35;
            this.gridLedgerCurrentMapping.Size = new System.Drawing.Size(1170, 670);
            this.gridLedgerCurrentMapping.Style.HeaderStyle.Font.Bold = true;
            this.gridLedgerCurrentMapping.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridLedgerCurrentMapping.Style.HeaderStyle.Font.Size = 8F;
            this.gridLedgerCurrentMapping.Style.HeaderStyle.TextColor = System.Drawing.Color.Red;
            this.gridLedgerCurrentMapping.TabIndex = 2;
            this.gridLedgerCurrentMapping.Text = "sfDataGrid1";
            // 
            // frmLedgerCodeCurrentMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 727);
            this.Controls.Add(this.gridLedgerCurrentMapping);
            this.Controls.Add(this.label1);
            this.Name = "frmLedgerCodeCurrentMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger Codes | Current Mapping";
            this.Load += new System.EventHandler(this.frmLedgerCodeCurrentMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLedgerCurrentMapping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridLedgerCurrentMapping;
    }
}