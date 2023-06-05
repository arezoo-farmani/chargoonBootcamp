using System.Windows.Forms;

namespace UI
{
    partial class ResturantsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ResturantsListBox = new System.Windows.Forms.GroupBox();
            this.RestaurantsDataGrid = new System.Windows.Forms.DataGridView();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.RestaurantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResturantsListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ResturantsListBox
            // 
            this.ResturantsListBox.Controls.Add(this.RestaurantsDataGrid);
            this.ResturantsListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResturantsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResturantsListBox.ForeColor = System.Drawing.Color.Teal;
            this.ResturantsListBox.Location = new System.Drawing.Point(92, 80);
            this.ResturantsListBox.Name = "ResturantsListBox";
            this.ResturantsListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResturantsListBox.Size = new System.Drawing.Size(400, 300);
            this.ResturantsListBox.TabIndex = 4;
            this.ResturantsListBox.TabStop = false;
            this.ResturantsListBox.Text = "رستوران ها";
            // 
            // RestaurantsDataGrid
            // 
            this.RestaurantsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RestaurantsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RestaurantsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RestaurantsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RestaurantsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestaurantsDataGrid.ColumnHeadersVisible = false;
            this.RestaurantsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestaurantName,
            this.Guid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RestaurantsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.RestaurantsDataGrid.Location = new System.Drawing.Point(6, 21);
            this.RestaurantsDataGrid.Name = "RestaurantsDataGrid";
            this.RestaurantsDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RestaurantsDataGrid.Size = new System.Drawing.Size(373, 255);
            this.RestaurantsDataGrid.TabIndex = 15;
            this.RestaurantsDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RestaurantsDataGrid_CellContentDoubleClick);
            // 
            // MessageLabel
            // 
            this.MessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.Red;
            this.MessageLabel.Location = new System.Drawing.Point(92, 380);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MessageLabel.Size = new System.Drawing.Size(400, 20);
            this.MessageLabel.TabIndex = 5;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestaurantName
            // 
            this.RestaurantName.DataPropertyName = "RestaurantName";
            this.RestaurantName.HeaderText = "RestaurantName";
            this.RestaurantName.Name = "RestaurantName";
            this.RestaurantName.ReadOnly = true;
            // 
            // Guid
            // 
            this.Guid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guid.DataPropertyName = "Guid";
            this.Guid.HeaderText = "Guid";
            this.Guid.Name = "Guid";
            this.Guid.ReadOnly = true;
            this.Guid.Visible = false;
            // 
            // ResturantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ResturantsListBox);
            this.Name = "ResturantsForm";
            this.Text = "AllResturantsForm";
            this.ResturantsListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ResturantsListBox;
        private Label MessageLabel;
        private DataGridView RestaurantsDataGrid;
        private DataGridViewTextBoxColumn RestaurantName;
        private DataGridViewTextBoxColumn Guid;
    }
}