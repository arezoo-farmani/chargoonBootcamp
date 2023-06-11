namespace UI
{
    partial class FoodEditForm
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
            this.FoodPriceText = new System.Windows.Forms.TextBox();
            this.FoodPriceLabel = new System.Windows.Forms.Label();
            this.FoodNameText = new System.Windows.Forms.TextBox();
            this.FoodNameLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoodPriceText
            // 
            this.FoodPriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FoodPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FoodPriceText.Location = new System.Drawing.Point(96, 115);
            this.FoodPriceText.Multiline = true;
            this.FoodPriceText.Name = "FoodPriceText";
            this.FoodPriceText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodPriceText.Size = new System.Drawing.Size(160, 20);
            this.FoodPriceText.TabIndex = 33;
            // 
            // FoodPriceLabel
            // 
            this.FoodPriceLabel.AutoSize = true;
            this.FoodPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodPriceLabel.ForeColor = System.Drawing.Color.Teal;
            this.FoodPriceLabel.Location = new System.Drawing.Point(262, 118);
            this.FoodPriceLabel.Name = "FoodPriceLabel";
            this.FoodPriceLabel.Size = new System.Drawing.Size(36, 16);
            this.FoodPriceLabel.TabIndex = 32;
            this.FoodPriceLabel.Text = "قیمت ";
            // 
            // FoodNameText
            // 
            this.FoodNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FoodNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FoodNameText.Location = new System.Drawing.Point(96, 59);
            this.FoodNameText.Multiline = true;
            this.FoodNameText.Name = "FoodNameText";
            this.FoodNameText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodNameText.Size = new System.Drawing.Size(160, 20);
            this.FoodNameText.TabIndex = 31;
            // 
            // FoodNameLabel
            // 
            this.FoodNameLabel.AutoSize = true;
            this.FoodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.FoodNameLabel.Location = new System.Drawing.Point(268, 59);
            this.FoodNameLabel.Name = "FoodNameLabel";
            this.FoodNameLabel.Size = new System.Drawing.Size(25, 16);
            this.FoodNameLabel.TabIndex = 30;
            this.FoodNameLabel.Text = "نام ";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Teal;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(60, 191);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(60, 30);
            this.BackBtn.TabIndex = 34;
            this.BackBtn.Text = "بازگشت";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Teal;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(262, 191);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(80, 30);
            this.SubmitBtn.TabIndex = 35;
            this.SubmitBtn.Text = "ثبت تغییرات";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // FoodEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 282);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.FoodPriceText);
            this.Controls.Add(this.FoodPriceLabel);
            this.Controls.Add(this.FoodNameText);
            this.Controls.Add(this.FoodNameLabel);
            this.Name = "FoodEditForm";
            this.Text = "فرم ویرایش غذا";
            this.Load += new System.EventHandler(this.FoodEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FoodPriceText;
        private System.Windows.Forms.Label FoodPriceLabel;
        private System.Windows.Forms.TextBox FoodNameText;
        private System.Windows.Forms.Label FoodNameLabel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SubmitBtn;
    }
}