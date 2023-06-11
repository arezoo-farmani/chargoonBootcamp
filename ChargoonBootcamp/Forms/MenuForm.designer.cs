using System.Windows.Forms;

namespace UI
{
    partial class MenuForm
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
            this.MenuBox = new System.Windows.Forms.GroupBox();
            this.MenuDataGrid = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Minus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuSubmitBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.MenuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBox
            // 
            this.MenuBox.Controls.Add(this.MenuDataGrid);
            this.MenuBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MenuBox.ForeColor = System.Drawing.Color.Teal;
            this.MenuBox.Location = new System.Drawing.Point(42, 29);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuBox.Size = new System.Drawing.Size(500, 314);
            this.MenuBox.TabIndex = 3;
            this.MenuBox.TabStop = false;
            this.MenuBox.Text = "منو";
            // 
            // MenuDataGrid
            // 
            this.MenuDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add,
            this.Minus,
            this.Count,
            this.FoodName,
            this.FoodPrice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MenuDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.MenuDataGrid.Location = new System.Drawing.Point(19, 35);
            this.MenuDataGrid.Name = "MenuDataGrid";
            this.MenuDataGrid.ReadOnly = true;
            this.MenuDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuDataGrid.Size = new System.Drawing.Size(452, 258);
            this.MenuDataGrid.TabIndex = 14;
            this.MenuDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuDataGrid_CellContentClick);
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Add.FillWeight = 60F;
            this.Add.HeaderText = "افزودن";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Add.Text = "+";
            this.Add.UseColumnTextForButtonValue = true;
            // 
            // Minus
            // 
            this.Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Minus.FillWeight = 60F;
            this.Minus.HeaderText = "کاستن";
            this.Minus.Name = "Minus";
            this.Minus.ReadOnly = true;
            this.Minus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Minus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Minus.Text = "-";
            this.Minus.UseColumnTextForButtonValue = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.DataPropertyName = "Count";
            dataGridViewCellStyle5.NullValue = "0";
            this.Count.DefaultCellStyle = dataGridViewCellStyle5;
            this.Count.HeaderText = "تعداد";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "نام غذا";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // FoodPrice
            // 
            this.FoodPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodPrice.DataPropertyName = "FoodPrice";
            this.FoodPrice.HeaderText = "قیمت";
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.ReadOnly = true;
            // 
            // MenuSubmitBtn
            // 
            this.MenuSubmitBtn.BackColor = System.Drawing.Color.Teal;
            this.MenuSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSubmitBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MenuSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.MenuSubmitBtn.Location = new System.Drawing.Point(48, 349);
            this.MenuSubmitBtn.Name = "MenuSubmitBtn";
            this.MenuSubmitBtn.Size = new System.Drawing.Size(96, 30);
            this.MenuSubmitBtn.TabIndex = 13;
            this.MenuSubmitBtn.Text = "تکمیل خرید";
            this.MenuSubmitBtn.UseVisualStyleBackColor = false;
            this.MenuSubmitBtn.Click += new System.EventHandler(this.MenuSubmitBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Teal;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(443, 349);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(96, 30);
            this.BackBtn.TabIndex = 14;
            this.BackBtn.Text = "بازگشت";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 410);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.MenuSubmitBtn);
            this.Controls.Add(this.MenuBox);
            this.Name = "MenuForm";
            this.Text = "فرم ثبت خرید";
            this.MenuBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox MenuBox;
        private Button MenuSubmitBtn;
        private DataGridView MenuDataGrid;
        private DataGridViewButtonColumn Add;
        private DataGridViewButtonColumn Minus;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn FoodPrice;
        private Button BackBtn;
    }
}