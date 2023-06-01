namespace UI
{
    partial class OrderBasketForm
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
            this.OrderBasketBox = new System.Windows.Forms.GroupBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.OrderBasketBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderBasketBox
            // 
            this.OrderBasketBox.Controls.Add(this.SumLabel);
            this.OrderBasketBox.Controls.Add(this.TotalLabel);
            this.OrderBasketBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBasketBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBasketBox.ForeColor = System.Drawing.Color.Teal;
            this.OrderBasketBox.Location = new System.Drawing.Point(92, 80);
            this.OrderBasketBox.Name = "OrderBasketBox";
            this.OrderBasketBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderBasketBox.Size = new System.Drawing.Size(400, 300);
            this.OrderBasketBox.TabIndex = 5;
            this.OrderBasketBox.TabStop = false;
            this.OrderBasketBox.Text = "سبد خرید";
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
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.Teal;
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.ForeColor = System.Drawing.Color.White;
            this.PayBtn.Location = new System.Drawing.Point(92, 386);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(80, 30);
            this.PayBtn.TabIndex = 14;
            this.PayBtn.Text = "پرداخت";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // OrderBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.OrderBasketBox);
            this.Name = "OrderBasket";
            this.Text = "OrderBasket";
            this.OrderBasketBox.ResumeLayout(false);
            this.OrderBasketBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OrderBasketBox;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button PayBtn;
    }
}