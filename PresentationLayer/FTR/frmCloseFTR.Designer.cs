namespace CashFlow 
{
    partial class frmCloseFTR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFTRNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.txtFTRNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fund Transfer Request - Close";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Enter FTR Number to Close ?";
            // 
            // txtFTRNumber
            // 
            this.txtFTRNumber.BeforeTouchSize = new System.Drawing.Size(169, 28);
            this.txtFTRNumber.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFTRNumber.Location = new System.Drawing.Point(323, 91);
            this.txtFTRNumber.Name = "txtFTRNumber";
            this.txtFTRNumber.Size = new System.Drawing.Size(329, 28);
            this.txtFTRNumber.TabIndex = 26;
            this.txtFTRNumber.Text = "textBoxExt1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleName = "Button";
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.Location = new System.Drawing.Point(688, 91);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 28);
            this.btnSubmit.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblConfirm.Location = new System.Drawing.Point(38, 242);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(359, 22);
            this.lblConfirm.TabIndex = 28;
            this.lblConfirm.Text = "Confirm Your Actioon (Enter Confirm )";
            // 
            // txtConfirm
            // 
            this.txtConfirm.BeforeTouchSize = new System.Drawing.Size(169, 28);
            this.txtConfirm.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(414, 242);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(169, 28);
            this.txtConfirm.TabIndex = 29;
            this.txtConfirm.Text = "Not Sure";
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // frmCloseFTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 473);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFTRNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCloseFTR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close FTR";
            this.Load += new System.EventHandler(this.frmCloseFTR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFTRNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFTRNumber;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
        private System.Windows.Forms.Label lblConfirm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtConfirm;
    }
}