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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderBasketBox = new System.Windows.Forms.GroupBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.OrderBasketDataGrid = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBasketBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBasketDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderBasketBox
            // 
            this.OrderBasketBox.Controls.Add(this.OrderBasketDataGrid);
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
            this.SumLabel.Location = new System.Drawing.Point(132, 259);
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
            this.TotalLabel.Location = new System.Drawing.Point(237, 259);
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
            // OrderBasketDataGrid
            // 
            this.OrderBasketDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OrderBasketDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderBasketDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderBasketDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderBasketDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderBasketDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Count,
            this.FoodPrice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderBasketDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.OrderBasketDataGrid.Location = new System.Drawing.Point(18, 35);
            this.OrderBasketDataGrid.Name = "OrderBasketDataGrid";
            this.OrderBasketDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderBasketDataGrid.Size = new System.Drawing.Size(376, 221);
            this.OrderBasketDataGrid.TabIndex = 15;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "نام غذا";
            this.FoodName.Name = "FoodName";
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.DataPropertyName = "Count";
            dataGridViewCellStyle5.NullValue = "0";
            this.Count.DefaultCellStyle = dataGridViewCellStyle5;
            this.Count.HeaderText = "تعداد";
            this.Count.Name = "Count";
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FoodPrice
            // 
            this.FoodPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodPrice.DataPropertyName = "FoodPrice";
            this.FoodPrice.HeaderText = "قیمت";
            this.FoodPrice.Name = "FoodPrice";
            // 
            // OrderBasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.OrderBasketBox);
            this.Name = "OrderBasketForm";
            this.Text = "OrderBasket";
            this.OrderBasketBox.ResumeLayout(false);
            this.OrderBasketBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBasketDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OrderBasketBox;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.DataGridView OrderBasketDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPrice;
    }
}