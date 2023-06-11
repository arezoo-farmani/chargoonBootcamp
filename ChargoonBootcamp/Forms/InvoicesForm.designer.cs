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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InvoicesBox = new System.Windows.Forms.GroupBox();
            this.InvoicesDataGrid = new System.Windows.Forms.DataGridView();
            this.InvoiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.InvoicesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoicesBox
            // 
            this.InvoicesBox.Controls.Add(this.InvoicesDataGrid);
            this.InvoicesBox.Controls.Add(this.SumLabel);
            this.InvoicesBox.Controls.Add(this.TotalLabel);
            this.InvoicesBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoicesBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InvoicesBox.ForeColor = System.Drawing.Color.Teal;
            this.InvoicesBox.Location = new System.Drawing.Point(96, 37);
            this.InvoicesBox.Name = "InvoicesBox";
            this.InvoicesBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InvoicesBox.Size = new System.Drawing.Size(400, 300);
            this.InvoicesBox.TabIndex = 4;
            this.InvoicesBox.TabStop = false;
            this.InvoicesBox.Text = "فاکتورها";
            // 
            // InvoicesDataGrid
            // 
            this.InvoicesDataGrid.AllowUserToAddRows = false;
            this.InvoicesDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InvoicesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InvoicesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InvoicesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvoicesDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoicesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InvoicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoicesDataGrid.ColumnHeadersVisible = false;
            this.InvoicesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceName,
            this.Amount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoicesDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.InvoicesDataGrid.Location = new System.Drawing.Point(18, 35);
            this.InvoicesDataGrid.Name = "InvoicesDataGrid";
            this.InvoicesDataGrid.ReadOnly = true;
            this.InvoicesDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InvoicesDataGrid.Size = new System.Drawing.Size(376, 221);
            this.InvoicesDataGrid.TabIndex = 16;
            // 
            // InvoiceName
            // 
            this.InvoiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceName.DataPropertyName = "InvoiceName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            this.InvoiceName.DefaultCellStyle = dataGridViewCellStyle3;
            this.InvoiceName.HeaderText = "InvoiceName";
            this.InvoiceName.Name = "InvoiceName";
            this.InvoiceName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SumLabel.Location = new System.Drawing.Point(131, 263);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(16, 18);
            this.SumLabel.TabIndex = 1;
            this.SumLabel.Text = "0";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalLabel.Location = new System.Drawing.Point(227, 260);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(69, 24);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "جمع مبلغ:";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Teal;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(415, 343);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 30);
            this.BackBtn.TabIndex = 34;
            this.BackBtn.Text = "بازگشت";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 393);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.InvoicesBox);
            this.Name = "InvoicesForm";
            this.Text = "فرم لیست فاکتور";
            this.InvoicesBox.ResumeLayout(false);
            this.InvoicesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox InvoicesBox;
        private Label TotalLabel;
        private Label SumLabel;
        private DataGridView InvoicesDataGrid;
        private DataGridViewTextBoxColumn InvoiceName;
        private DataGridViewTextBoxColumn Amount;
        private Button BackBtn;
    }
}