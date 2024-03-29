﻿namespace UI
{
    partial class FoodMenu
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.ListMenuBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.FoodPriceText = new System.Windows.Forms.TextBox();
            this.FoodPriceLabel = new System.Windows.Forms.Label();
            this.FoodNameText = new System.Windows.Forms.TextBox();
            this.FoodNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Teal;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(17, 182);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 30);
            this.BackBtn.TabIndex = 33;
            this.BackBtn.Text = "بازگشت";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ListMenuBtn
            // 
            this.ListMenuBtn.BackColor = System.Drawing.Color.Teal;
            this.ListMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListMenuBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ListMenuBtn.ForeColor = System.Drawing.Color.White;
            this.ListMenuBtn.Location = new System.Drawing.Point(193, 180);
            this.ListMenuBtn.Name = "ListMenuBtn";
            this.ListMenuBtn.Size = new System.Drawing.Size(75, 30);
            this.ListMenuBtn.TabIndex = 32;
            this.ListMenuBtn.Text = "لیست";
            this.ListMenuBtn.UseVisualStyleBackColor = false;
            this.ListMenuBtn.Click += new System.EventHandler(this.ListMenuBtn_Click_1);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Teal;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(286, 180);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 30);
            this.SubmitBtn.TabIndex = 30;
            this.SubmitBtn.Text = "ثبت ";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // FoodPriceText
            // 
            this.FoodPriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FoodPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FoodPriceText.Location = new System.Drawing.Point(90, 112);
            this.FoodPriceText.Multiline = true;
            this.FoodPriceText.Name = "FoodPriceText";
            this.FoodPriceText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodPriceText.Size = new System.Drawing.Size(160, 20);
            this.FoodPriceText.TabIndex = 29;
            // 
            // FoodPriceLabel
            // 
            this.FoodPriceLabel.AutoSize = true;
            this.FoodPriceLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FoodPriceLabel.ForeColor = System.Drawing.Color.Teal;
            this.FoodPriceLabel.Location = new System.Drawing.Point(256, 112);
            this.FoodPriceLabel.Name = "FoodPriceLabel";
            this.FoodPriceLabel.Size = new System.Drawing.Size(47, 24);
            this.FoodPriceLabel.TabIndex = 28;
            this.FoodPriceLabel.Text = "قیمت ";
            // 
            // FoodNameText
            // 
            this.FoodNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FoodNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FoodNameText.Location = new System.Drawing.Point(90, 56);
            this.FoodNameText.Multiline = true;
            this.FoodNameText.Name = "FoodNameText";
            this.FoodNameText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodNameText.Size = new System.Drawing.Size(160, 20);
            this.FoodNameText.TabIndex = 27;
            // 
            // FoodNameLabel
            // 
            this.FoodNameLabel.AutoSize = true;
            this.FoodNameLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FoodNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.FoodNameLabel.Location = new System.Drawing.Point(266, 56);
            this.FoodNameLabel.Name = "FoodNameLabel";
            this.FoodNameLabel.Size = new System.Drawing.Size(32, 24);
            this.FoodNameLabel.TabIndex = 26;
            this.FoodNameLabel.Text = "نام ";
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 247);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ListMenuBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.FoodPriceText);
            this.Controls.Add(this.FoodPriceLabel);
            this.Controls.Add(this.FoodNameText);
            this.Controls.Add(this.FoodNameLabel);
            this.Name = "FoodMenu";
            this.Text = "فرم ثبت منو";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ListMenuBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label FoodPriceLabel;
        private System.Windows.Forms.Label FoodNameLabel;
        private System.Windows.Forms.TextBox FoodPriceText;
        private System.Windows.Forms.TextBox FoodNameText;
    }
}