using System.Windows.Forms;

namespace UI
{
    partial class InvoicesForm
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
            this.InvoicesBox = new System.Windows.Forms.GroupBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.InvoicesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InvoicesBox
            // 
            this.InvoicesBox.Controls.Add(this.SumLabel);
            this.InvoicesBox.Controls.Add(this.TotalLabel);
            this.InvoicesBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoicesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicesBox.ForeColor = System.Drawing.Color.Teal;
            this.InvoicesBox.Location = new System.Drawing.Point(92, 80);
            this.InvoicesBox.Name = "InvoicesBox";
            this.InvoicesBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InvoicesBox.Size = new System.Drawing.Size(400, 300);
            this.InvoicesBox.TabIndex = 4;
            this.InvoicesBox.TabStop = false;
            this.InvoicesBox.Text = "فاکتورها";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.Teal;
            this.TotalLabel.Location = new System.Drawing.Point(209, 259);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(32, 16);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "جمع:";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumLabel.ForeColor = System.Drawing.Color.Teal;
            this.SumLabel.Location = new System.Drawing.Point(162, 259);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(14, 16);
            this.SumLabel.TabIndex = 1;
            this.SumLabel.Text = "0";
            // 
            // AllInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.InvoicesBox);
            this.Name = "AllInvoicesForm";
            this.Text = "AllInvoicesForm";
            this.InvoicesBox.ResumeLayout(false);
            this.InvoicesBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox InvoicesBox;
        private Label TotalLabel;
        private Label SumLabel;
    }
}