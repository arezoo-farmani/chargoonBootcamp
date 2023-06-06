using System.Windows.Forms;

namespace RestaurantApp.UILayer.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ResturantsListBox = new GroupBox();
            RestaurantsDataGrid = new DataGridView();
            RestaurantName = new DataGridViewTextBoxColumn();
            Guid = new DataGridViewTextBoxColumn();
            MessageLabel = new Label();
            lblInfo = new Label();
            ResturantsListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RestaurantsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ResturantsListBox
            // 
            ResturantsListBox.Controls.Add(RestaurantsDataGrid);
            ResturantsListBox.FlatStyle = FlatStyle.Flat;
            ResturantsListBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ResturantsListBox.ForeColor = Color.Teal;
            ResturantsListBox.Location = new Point(9, 81);
            ResturantsListBox.Margin = new Padding(5, 6, 5, 6);
            ResturantsListBox.Name = "ResturantsListBox";
            ResturantsListBox.Padding = new Padding(5, 6, 5, 6);
            ResturantsListBox.RightToLeft = RightToLeft.Yes;
            ResturantsListBox.Size = new Size(667, 353);
            ResturantsListBox.TabIndex = 4;
            ResturantsListBox.TabStop = false;
            ResturantsListBox.Text = "رستوران ها";
            // 
            // RestaurantsDataGrid
            // 
            RestaurantsDataGrid.BackgroundColor = Color.FromArgb(224, 224, 224);
            RestaurantsDataGrid.BorderStyle = BorderStyle.None;
            RestaurantsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            RestaurantsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            RestaurantsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RestaurantsDataGrid.ColumnHeadersVisible = false;
            RestaurantsDataGrid.Columns.AddRange(new DataGridViewColumn[] { RestaurantName, Guid });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            RestaurantsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            RestaurantsDataGrid.Location = new Point(23, 35);
            RestaurantsDataGrid.Margin = new Padding(5, 6, 5, 6);
            RestaurantsDataGrid.Name = "RestaurantsDataGrid";
            RestaurantsDataGrid.RightToLeft = RightToLeft.Yes;
            RestaurantsDataGrid.RowHeadersWidth = 62;
            RestaurantsDataGrid.Size = new Size(622, 376);
            RestaurantsDataGrid.TabIndex = 15;
            RestaurantsDataGrid.CellContentDoubleClick += RestaurantsDataGrid_CellContentDoubleClick;
            // 
            // RestaurantName
            // 
            RestaurantName.DataPropertyName = "RestaurantName";
            RestaurantName.HeaderText = "RestaurantName";
            RestaurantName.MinimumWidth = 8;
            RestaurantName.Name = "RestaurantName";
            RestaurantName.ReadOnly = true;
            RestaurantName.Width = 150;
            // 
            // Guid
            // 
            Guid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Guid.DataPropertyName = "Guid";
            Guid.HeaderText = "Guid";
            Guid.MinimumWidth = 8;
            Guid.Name = "Guid";
            Guid.ReadOnly = true;
            Guid.Visible = false;
            // 
            // MessageLabel
            // 
            MessageLabel.BackColor = Color.FromArgb(224, 224, 224);
            MessageLabel.FlatStyle = FlatStyle.Flat;
            MessageLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MessageLabel.ForeColor = Color.Red;
            MessageLabel.Location = new Point(32, 440);
            MessageLabel.Margin = new Padding(5, 0, 5, 0);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.RightToLeft = RightToLeft.Yes;
            MessageLabel.Size = new Size(622, 38);
            MessageLabel.TabIndex = 5;
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(307, 50);
            lblInfo.Name = "lblInfo";
            lblInfo.RightToLeft = RightToLeft.Yes;
            lblInfo.Size = new Size(42, 25);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "Test";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResturantsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 497);
            Controls.Add(lblInfo);
            Controls.Add(MessageLabel);
            Controls.Add(ResturantsListBox);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ResturantsForm";
            Text = "AllResturantsForm";
            ResturantsListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RestaurantsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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