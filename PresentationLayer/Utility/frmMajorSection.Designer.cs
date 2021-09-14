namespace CashFlow
{
    partial class frmMajorSection
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridSections = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtMajorSection = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.lblOrder = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtPosition = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMajorSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(381, 20);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(178, 29);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Major Section";
            // 
            // gridSections
            // 
            this.gridSections.AccessibleName = "Table";
            gridTextColumn4.HeaderText = "Order #";
            gridTextColumn4.MappingName = "Position";
            gridTextColumn4.Width = 100D;
            gridTextColumn5.HeaderText = "Major Section";
            gridTextColumn5.MappingName = "MajorSection";
            gridTextColumn5.Width = 500D;
            gridTextColumn6.HeaderText = "MajorSectionID";
            gridTextColumn6.MappingName = "MajorSectionID";
            gridTextColumn6.Visible = false;
            gridTextColumn6.Width = 0D;
            this.gridSections.Columns.Add(gridTextColumn4);
            this.gridSections.Columns.Add(gridTextColumn5);
            this.gridSections.Columns.Add(gridTextColumn6);
            this.gridSections.Location = new System.Drawing.Point(56, 163);
            this.gridSections.Name = "gridSections";
            this.gridSections.PreviewRowHeight = 35;
            this.gridSections.Size = new System.Drawing.Size(797, 284);
            this.gridSections.TabIndex = 1;
            this.gridSections.Text = "sfDataGrid1";
            this.gridSections.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.gridSections_DrawCell);
            this.gridSections.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridSections_QueryRowStyle);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(749, 453);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 38);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Red;
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(56, 78);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(111, 21);
            this.autoLabel2.TabIndex = 3;
            this.autoLabel2.Text = "Major Section";
            // 
            // txtMajorSection
            // 
            this.txtMajorSection.BeforeTouchSize = new System.Drawing.Size(100, 28);
            this.txtMajorSection.Location = new System.Drawing.Point(173, 71);
            this.txtMajorSection.Name = "txtMajorSection";
            this.txtMajorSection.Size = new System.Drawing.Size(397, 28);
            this.txtMajorSection.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "Button";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(576, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 28);
            this.btnAdd.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Location = new System.Drawing.Point(56, 116);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(231, 21);
            this.lblOrder.TabIndex = 6;
            this.lblOrder.Text = "Order (Keep Difference of 10)";
            // 
            // txtPosition
            // 
            this.txtPosition.BeforeTouchSize = new System.Drawing.Size(100, 28);
            this.txtPosition.IntegerValue = ((long)(10));
            this.txtPosition.Location = new System.Drawing.Point(309, 116);
            this.txtPosition.MaxValue = ((long)(5000));
            this.txtPosition.MinValue = ((long)(10));
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 28);
            this.txtPosition.TabIndex = 7;
            this.txtPosition.Text = "10";
            // 
            // frmMajorSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 519);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMajorSection);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridSections);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMajorSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Major Section";
            this.Load += new System.EventHandler(this.frmMajorSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMajorSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridSections;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMajorSection;
        private Syncfusion.WinForms.Controls.SfButton btnAdd;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblOrder;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtPosition;
    }
}