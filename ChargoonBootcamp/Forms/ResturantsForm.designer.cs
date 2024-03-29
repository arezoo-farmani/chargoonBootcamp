﻿using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ResturantsListBox = new System.Windows.Forms.GroupBox();
            this.RestaurantsDataGrid = new System.Windows.Forms.DataGridView();
            this.RestaurantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ResturantsListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ResturantsListBox
            // 
            this.ResturantsListBox.Controls.Add(this.RestaurantsDataGrid);
            this.ResturantsListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResturantsListBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResturantsListBox.ForeColor = System.Drawing.Color.Teal;
            this.ResturantsListBox.Location = new System.Drawing.Point(92, 59);
            this.ResturantsListBox.Name = "ResturantsListBox";
            this.ResturantsListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResturantsListBox.Size = new System.Drawing.Size(400, 320);
            this.ResturantsListBox.TabIndex = 4;
            this.ResturantsListBox.TabStop = false;
            this.ResturantsListBox.Text = "رستوران ها";
            // 
            // RestaurantsDataGrid
            // 
            this.RestaurantsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RestaurantsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RestaurantsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RestaurantsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RestaurantsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestaurantsDataGrid.ColumnHeadersVisible = false;
            this.RestaurantsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestaurantName,
            this.Guid});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RestaurantsDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.RestaurantsDataGrid.Location = new System.Drawing.Point(9, 40);
            this.RestaurantsDataGrid.Name = "RestaurantsDataGrid";
            this.RestaurantsDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RestaurantsDataGrid.RowHeadersWidth = 62;
            this.RestaurantsDataGrid.Size = new System.Drawing.Size(373, 255);
            this.RestaurantsDataGrid.TabIndex = 15;
            this.RestaurantsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RestaurantsDataGrid_CellDoubleClick);
            // 
            // RestaurantName
            // 
            this.RestaurantName.DataPropertyName = "RestaurantName";
            this.RestaurantName.HeaderText = "RestaurantName";
            this.RestaurantName.MinimumWidth = 8;
            this.RestaurantName.Name = "RestaurantName";
            this.RestaurantName.ReadOnly = true;
            this.RestaurantName.Width = 150;
            // 
            // Guid
            // 
            this.Guid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Guid.DataPropertyName = "Guid";
            this.Guid.HeaderText = "Guid";
            this.Guid.MinimumWidth = 8;
            this.Guid.Name = "Guid";
            this.Guid.ReadOnly = true;
            this.Guid.Visible = false;
            // 
            // MessageLabel
            // 
            this.MessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageLabel.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MessageLabel.ForeColor = System.Drawing.Color.Red;
            this.MessageLabel.Location = new System.Drawing.Point(92, 380);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MessageLabel.Size = new System.Drawing.Size(400, 20);
            this.MessageLabel.TabIndex = 5;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(198, 16);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(116, 33);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "متن ورود کاربر";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResturantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 439);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ResturantsListBox);
            this.Name = "ResturantsForm";
            this.Text = "فرم لیست رستوران";
            this.ResturantsListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox ResturantsListBox;
        private Label MessageLabel;
        private DataGridView RestaurantsDataGrid;
        private DataGridViewTextBoxColumn RestaurantName;
        private DataGridViewTextBoxColumn Guid;
        private Label lblInfo;
    }
}