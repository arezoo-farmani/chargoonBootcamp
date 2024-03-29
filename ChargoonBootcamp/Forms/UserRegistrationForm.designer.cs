﻿using System.Windows.Forms;

namespace UI
{
    partial class UserRegistrationForm
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
            this.RegistrationUserBox = new System.Windows.Forms.GroupBox();
            this.Required1 = new System.Windows.Forms.Label();
            this.PhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.NationalCodeTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NationalCodeLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.UserSubmitBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.RegistrationUserBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationUserBox
            // 
            this.RegistrationUserBox.Controls.Add(this.Required1);
            this.RegistrationUserBox.Controls.Add(this.PhoneNumberTxt);
            this.RegistrationUserBox.Controls.Add(this.PhoneNumberLabel);
            this.RegistrationUserBox.Controls.Add(this.NationalCodeTxt);
            this.RegistrationUserBox.Controls.Add(this.AddressTxt);
            this.RegistrationUserBox.Controls.Add(this.LastNameTxt);
            this.RegistrationUserBox.Controls.Add(this.AddressLabel);
            this.RegistrationUserBox.Controls.Add(this.NationalCodeLabel);
            this.RegistrationUserBox.Controls.Add(this.LastNameLabel);
            this.RegistrationUserBox.Controls.Add(this.FirstNameTxt);
            this.RegistrationUserBox.Controls.Add(this.FirstNameLabel);
            this.RegistrationUserBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationUserBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RegistrationUserBox.ForeColor = System.Drawing.Color.Teal;
            this.RegistrationUserBox.Location = new System.Drawing.Point(100, 45);
            this.RegistrationUserBox.Name = "RegistrationUserBox";
            this.RegistrationUserBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RegistrationUserBox.Size = new System.Drawing.Size(400, 300);
            this.RegistrationUserBox.TabIndex = 3;
            this.RegistrationUserBox.TabStop = false;
            this.RegistrationUserBox.Text = "ثبت نام کاربر";
            // 
            // Required1
            // 
            this.Required1.AutoSize = true;
            this.Required1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Required1.ForeColor = System.Drawing.Color.Red;
            this.Required1.Location = new System.Drawing.Point(90, 94);
            this.Required1.Name = "Required1";
            this.Required1.Size = new System.Drawing.Size(14, 16);
            this.Required1.TabIndex = 17;
            this.Required1.Text = "*";
            this.Required1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PhoneNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTxt.Location = new System.Drawing.Point(109, 124);
            this.PhoneNumberTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumberTxt.Multiline = true;
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.ReadOnly = true;
            this.PhoneNumberTxt.Size = new System.Drawing.Size(160, 20);
            this.PhoneNumberTxt.TabIndex = 3;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Teal;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(297, 122);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(88, 24);
            this.PhoneNumberLabel.TabIndex = 15;
            this.PhoneNumberLabel.Text = "شماره موبایل";
            // 
            // NationalCodeTxt
            // 
            this.NationalCodeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NationalCodeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NationalCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalCodeTxt.Location = new System.Drawing.Point(109, 90);
            this.NationalCodeTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NationalCodeTxt.Multiline = true;
            this.NationalCodeTxt.Name = "NationalCodeTxt";
            this.NationalCodeTxt.Size = new System.Drawing.Size(160, 20);
            this.NationalCodeTxt.TabIndex = 2;
            // 
            // AddressTxt
            // 
            this.AddressTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxt.Location = new System.Drawing.Point(25, 158);
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(244, 117);
            this.AddressTxt.TabIndex = 4;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxt.Location = new System.Drawing.Point(109, 59);
            this.LastNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameTxt.Multiline = true;
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(160, 20);
            this.LastNameTxt.TabIndex = 1;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressLabel.ForeColor = System.Drawing.Color.Teal;
            this.AddressLabel.Location = new System.Drawing.Point(297, 156);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 24);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "آدرس";
            // 
            // NationalCodeLabel
            // 
            this.NationalCodeLabel.AutoSize = true;
            this.NationalCodeLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NationalCodeLabel.ForeColor = System.Drawing.Color.Teal;
            this.NationalCodeLabel.Location = new System.Drawing.Point(297, 90);
            this.NationalCodeLabel.Name = "NationalCodeLabel";
            this.NationalCodeLabel.Size = new System.Drawing.Size(52, 24);
            this.NationalCodeLabel.TabIndex = 4;
            this.NationalCodeLabel.Text = "کد ملی";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.LastNameLabel.Location = new System.Drawing.Point(297, 57);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 24);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "نام خانوادگی";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FirstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTxt.Location = new System.Drawing.Point(109, 28);
            this.FirstNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameTxt.Multiline = true;
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(160, 20);
            this.FirstNameTxt.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.FirstNameLabel.Location = new System.Drawing.Point(300, 28);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(28, 24);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "نام";
            // 
            // UserSubmitBtn
            // 
            this.UserSubmitBtn.BackColor = System.Drawing.Color.Teal;
            this.UserSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSubmitBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UserSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.UserSubmitBtn.Location = new System.Drawing.Point(100, 351);
            this.UserSubmitBtn.Name = "UserSubmitBtn";
            this.UserSubmitBtn.Size = new System.Drawing.Size(68, 30);
            this.UserSubmitBtn.TabIndex = 1;
            this.UserSubmitBtn.Text = "ثبت ";
            this.UserSubmitBtn.UseVisualStyleBackColor = false;
            this.UserSubmitBtn.Click += new System.EventHandler(this.UserSubmitBtn_Click_1);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Teal;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(432, 351);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(68, 30);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "بازگشت";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 406);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RegistrationUserBox);
            this.Controls.Add(this.UserSubmitBtn);
            this.Name = "UserRegistrationForm";
            this.Text = "فرم ثبت کاربر";
            this.RegistrationUserBox.ResumeLayout(false);
            this.RegistrationUserBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox RegistrationUserBox;
        private Button UserSubmitBtn;
        private TextBox AddressTxt;
        private TextBox LastNameTxt;
        private Label AddressLabel;
        private Label NationalCodeLabel;
        private Label LastNameLabel;
        private TextBox FirstNameTxt;
        private Label FirstNameLabel;
        private TextBox NationalCodeTxt;
        private Label PhoneNumberLabel;
        private TextBox PhoneNumberTxt;
        private Label Required1;
        private Button BackBtn;
    }
}