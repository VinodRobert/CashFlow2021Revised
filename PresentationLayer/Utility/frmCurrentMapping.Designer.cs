namespace CashFlow
{
    partial class frmCurrentMapping
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.rdCreditor = new System.Windows.Forms.RadioButton();
            this.rdSubbie = new System.Windows.Forms.RadioButton();
            this.btnShow = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblHeader.Location = new System.Drawing.Point(490, 2);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(392, 33);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Sub Contractors  -  Mapping";
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            this.gridResult.AllowEditing = false;
            this.gridResult.AllowFiltering = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Vendor Code";
            gridTextColumn1.MappingName = "PARTYCODE";
            gridTextColumn1.Width = 100D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "PARTY NAME";
            gridTextColumn2.MappingName = "PARTYNAME";
            gridTextColumn2.Width = 350D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Major Category";
            gridTextColumn3.MappingName = "MAJORCATEGORY";
            gridTextColumn3.Width = 200D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Minor Category";
            gridTextColumn4.MappingName = "MINORCATEGORY";
            gridTextColumn4.Width = 200D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Category";
            gridTextColumn5.MappingName = "CATEGORY";
            gridTextColumn5.Width = 300D;
            this.gridResult.Columns.Add(gridTextColumn1);
            this.gridResult.Columns.Add(gridTextColumn2);
            this.gridResult.Columns.Add(gridTextColumn3);
            this.gridResult.Columns.Add(gridTextColumn4);
            this.gridResult.Columns.Add(gridTextColumn5);
            this.gridResult.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridResult.Location = new System.Drawing.Point(13, 73);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.ShowGroupDropArea = true;
            this.gridResult.Size = new System.Drawing.Size(1383, 642);
            this.gridResult.Style.HeaderStyle.Font.Bold = true;
            this.gridResult.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridResult.Style.HeaderStyle.Font.Size = 8F;
            this.gridResult.Style.HeaderStyle.TextColor = System.Drawing.Color.Red;
            this.gridResult.TabIndex = 2;
            this.gridResult.Text = "sfDataGrid1";
            // 
            // rdCreditor
            // 
            this.rdCreditor.AutoSize = true;
            this.rdCreditor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCreditor.Location = new System.Drawing.Point(13, 38);
            this.rdCreditor.Name = "rdCreditor";
            this.rdCreditor.Size = new System.Drawing.Size(101, 26);
            this.rdCreditor.TabIndex = 3;
            this.rdCreditor.TabStop = true;
            this.rdCreditor.Text = "Supplier";
            this.rdCreditor.UseVisualStyleBackColor = true;
            // 
            // rdSubbie
            // 
            this.rdSubbie.AutoSize = true;
            this.rdSubbie.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSubbie.Location = new System.Drawing.Point(205, 38);
            this.rdSubbie.Name = "rdSubbie";
            this.rdSubbie.Size = new System.Drawing.Size(168, 26);
            this.rdSubbie.TabIndex = 4;
            this.rdSubbie.TabStop = true;
            this.rdSubbie.Text = "Sub Contractors";
            this.rdSubbie.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.AccessibleName = "Button";
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShow.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(442, 38);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(160, 28);
            this.btnShow.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmCurrentMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 727);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rdSubbie);
            this.Controls.Add(this.rdCreditor);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmCurrentMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Mapping ";
            this.Load += new System.EventHandler(this.frmSubbieCurrentMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridResult;
        private System.Windows.Forms.RadioButton rdCreditor;
        private System.Windows.Forms.RadioButton rdSubbie;
        private Syncfusion.WinForms.Controls.SfButton btnShow;
    }
}