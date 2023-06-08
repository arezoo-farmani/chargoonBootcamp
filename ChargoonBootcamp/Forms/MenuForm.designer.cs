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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuBox = new System.Windows.Forms.GroupBox();
            this.MenuDataGrid = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Minus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuSubmitBtn = new System.Windows.Forms.Button();
            this.MenuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBox
            // 
            this.MenuBox.Controls.Add(this.MenuDataGrid);
            this.MenuBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBox.ForeColor = System.Drawing.Color.Teal;
            this.MenuBox.Location = new System.Drawing.Point(42, 80);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuBox.Size = new System.Drawing.Size(500, 300);
            this.MenuBox.TabIndex = 3;
            this.MenuBox.TabStop = false;
            this.MenuBox.Text = "منو";
            // 
            // MenuDataGrid
            // 
            this.MenuDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add,
            this.Minus,
            this.Count,
            this.FoodName,
            this.FoodPrice,
            this.Guid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MenuDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.MenuDataGrid.Location = new System.Drawing.Point(23, 21);
            this.MenuDataGrid.Name = "MenuDataGrid";
            this.MenuDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuDataGrid.Size = new System.Drawing.Size(442, 258);
            this.MenuDataGrid.TabIndex = 14;
            this.MenuDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuDataGrid_CellContentClick);
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Add.FillWeight = 60F;
            this.Add.HeaderText = "افزودن";
            this.Add.Name = "Add";
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
            this.Minus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Minus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Minus.Text = "-";
            this.Minus.UseColumnTextForButtonValue = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.DataPropertyName = "Count";
            dataGridViewCellStyle2.NullValue = "0";
            this.Count.DefaultCellStyle = dataGridViewCellStyle2;
            this.Count.HeaderText = "تعداد";
            this.Count.Name = "Count";
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "نام غذا";
            this.FoodName.Name = "FoodName";
            // 
            // FoodPrice
            // 
            this.FoodPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodPrice.DataPropertyName = "Price";
            this.FoodPrice.HeaderText = "قیمت";
            this.FoodPrice.Name = "FoodPrice";
            // 
            // Guid
            // 
            this.Guid.DataPropertyName = "Guid";
            this.Guid.HeaderText = "Guid";
            this.Guid.Name = "Guid";
            this.Guid.ReadOnly = true;
            this.Guid.Visible = false;
            // 
            // MenuSubmitBtn
            // 
            this.MenuSubmitBtn.BackColor = System.Drawing.Color.Teal;
            this.MenuSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.MenuSubmitBtn.Location = new System.Drawing.Point(42, 386);
            this.MenuSubmitBtn.Name = "MenuSubmitBtn";
            this.MenuSubmitBtn.Size = new System.Drawing.Size(80, 30);
            this.MenuSubmitBtn.TabIndex = 13;
            this.MenuSubmitBtn.Text = "ثبت منو جدید";
            this.MenuSubmitBtn.UseVisualStyleBackColor = false;
            this.MenuSubmitBtn.Click += new System.EventHandler(this.MenuSubmitBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.MenuSubmitBtn);
            this.Controls.Add(this.MenuBox);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
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
        private DataGridViewTextBoxColumn Guid;
    }
}