namespace CashFlow 
{
    partial class frmLedgerMapping
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridLM = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fund Transfer Request - Ledger Mapping";
            // 
            // gridLM
            // 
            this.gridLM.AccessibleName = "Table";
            this.gridLM.AllowFiltering = true;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "TransGroup";
            gridTextColumn1.HeaderTextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            gridTextColumn1.MappingName = "LINEORDER";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "FTR Narration";
            gridTextColumn2.MappingName = "DESCRIPTION";
            gridTextColumn2.Width = 300D;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Ledger Code";
            gridTextColumn3.MappingName = "LEDGERCODE";
            gridTextColumn3.Width = 100D;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Ledger Name";
            gridTextColumn4.MappingName = "LEDGERNAME";
            gridTextColumn4.Width = 500D;
            this.gridLM.Columns.Add(gridTextColumn1);
            this.gridLM.Columns.Add(gridTextColumn2);
            this.gridLM.Columns.Add(gridTextColumn3);
            this.gridLM.Columns.Add(gridTextColumn4);
            this.gridLM.Location = new System.Drawing.Point(11, 54);
            this.gridLM.Margin = new System.Windows.Forms.Padding(2);
            this.gridLM.Name = "gridLM";
            this.gridLM.PreviewRowHeight = 35;
            this.gridLM.Size = new System.Drawing.Size(999, 373);
            this.gridLM.Style.CellStyle.Font.Facename = "Arial";
            this.gridLM.Style.CellStyle.Font.Size = 8F;
            this.gridLM.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gridLM.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.gridLM.Style.HeaderStyle.Font.Bold = true;
            this.gridLM.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridLM.Style.HeaderStyle.Font.Size = 10F;
            this.gridLM.TabIndex = 41;
            this.gridLM.Text = "sfDataGrid1";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnClose.Location = new System.Drawing.Point(938, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.Style.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLedgerMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridLM);
            this.Controls.Add(this.label1);
            this.Name = "frmLedgerMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger Mapping";
            this.Load += new System.EventHandler(this.frmLedgerMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridLM;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}