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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderBasketBox = new System.Windows.Forms.GroupBox();
            this.OrderBasketDataGrid = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
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
            this.OrderBasketBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrderBasketBox.ForeColor = System.Drawing.Color.Teal;
            this.OrderBasketBox.Location = new System.Drawing.Point(61, 29);
            this.OrderBasketBox.Name = "OrderBasketBox";
            this.OrderBasketBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderBasketBox.Size = new System.Drawing.Size(468, 316);
            this.OrderBasketBox.TabIndex = 5;
            this.OrderBasketBox.TabStop = false;
            this.OrderBasketBox.Text = "سبد خرید";
            // 
            // OrderBasketDataGrid
            // 
            this.OrderBasketDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OrderBasketDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderBasketDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderBasketDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.OrderBasketDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderBasketDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Count,
            this.FoodPrice});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderBasketDataGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.OrderBasketDataGrid.Location = new System.Drawing.Point(18, 35);
            this.OrderBasketDataGrid.Name = "OrderBasketDataGrid";
            this.OrderBasketDataGrid.ReadOnly = true;
            this.OrderBasketDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderBasketDataGrid.Size = new System.Drawing.Size(442, 221);
            this.OrderBasketDataGrid.TabIndex = 15;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "نام غذا";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.DataPropertyName = "Count";
            dataGridViewCellStyle14.NullValue = "0";
            this.Count.DefaultCellStyle = dataGridViewCellStyle14;
            this.Count.HeaderText = "تعداد";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FoodPrice
            // 
            this.FoodPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodPrice.DataPropertyName = "FoodPrice";
            this.FoodPrice.HeaderText = "قیمت";
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.ReadOnly = true;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SumLabel.Location = new System.Drawing.Point(232, 276);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(19, 24);
            this.SumLabel.TabIndex = 1;
            this.SumLabel.Text = "0";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalLabel.Location = new System.Drawing.Point(322, 277);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(123, 24);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "جمع مبلغ پرداختی:";
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.Teal;
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PayBtn.ForeColor = System.Drawing.Color.White;
            this.PayBtn.Location = new System.Drawing.Point(67, 351);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(80, 30);
            this.PayBtn.TabIndex = 14;
            this.PayBtn.Text = "پرداخت";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // OrderBasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 405);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.OrderBasketBox);
            this.Name = "OrderBasketForm";
            this.Text = "فرم پرداخت";
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