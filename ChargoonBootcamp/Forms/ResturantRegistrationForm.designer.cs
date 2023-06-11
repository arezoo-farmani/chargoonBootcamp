using System.Windows.Forms;

namespace UI
{
    partial class ResturantRegistrationForm
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
            this.ResturantRegBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.HourToTxt = new System.Windows.Forms.NumericUpDown();
            this.HourFromTxt = new System.Windows.Forms.NumericUpDown();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.ResturantOwnerTxt = new System.Windows.Forms.TextBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.WorkHoursLabel = new System.Windows.Forms.Label();
            this.ResturantOwnerLabel = new System.Windows.Forms.Label();
            this.ResturantNameTxt = new System.Windows.Forms.TextBox();
            this.ResturantNameLabel = new System.Windows.Forms.Label();
            this.ResturantSubmitBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.RestaurantSubmitBtn = new System.Windows.Forms.Button();
            this.ResturantRegBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourToTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourFromTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // ResturantRegBox
            // 
            this.ResturantRegBox.Controls.Add(this.PhoneNumberTxt);
            this.ResturantRegBox.Controls.Add(this.PhoneNumberLabel);
            this.ResturantRegBox.Controls.Add(this.HourToTxt);
            this.ResturantRegBox.Controls.Add(this.HourFromTxt);
            this.ResturantRegBox.Controls.Add(this.AddressTxt);
            this.ResturantRegBox.Controls.Add(this.ResturantOwnerTxt);
            this.ResturantRegBox.Controls.Add(this.ToLabel);
            this.ResturantRegBox.Controls.Add(this.FromLabel);
            this.ResturantRegBox.Controls.Add(this.AddressLabel);
            this.ResturantRegBox.Controls.Add(this.WorkHoursLabel);
            this.ResturantRegBox.Controls.Add(this.ResturantOwnerLabel);
            this.ResturantRegBox.Controls.Add(this.ResturantNameTxt);
            this.ResturantRegBox.Controls.Add(this.ResturantNameLabel);
            this.ResturantRegBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResturantRegBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResturantRegBox.ForeColor = System.Drawing.Color.Teal;
            this.ResturantRegBox.Location = new System.Drawing.Point(100, 25);
            this.ResturantRegBox.Name = "ResturantRegBox";
            this.ResturantRegBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResturantRegBox.Size = new System.Drawing.Size(400, 310);
            this.ResturantRegBox.TabIndex = 2;
            this.ResturantRegBox.TabStop = false;
            this.ResturantRegBox.Text = "ثبت نام رستوران";
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PhoneNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTxt.Location = new System.Drawing.Point(66, 102);
            this.PhoneNumberTxt.Multiline = true;
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.ReadOnly = true;
            this.PhoneNumberTxt.Size = new System.Drawing.Size(160, 20);
            this.PhoneNumberTxt.TabIndex = 2;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Teal;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(263, 102);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(88, 24);
            this.PhoneNumberLabel.TabIndex = 14;
            this.PhoneNumberLabel.Text = "شماره موبایل";
            // 
            // HourToTxt
            // 
            this.HourToTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HourToTxt.ForeColor = System.Drawing.Color.Teal;
            this.HourToTxt.Location = new System.Drawing.Point(61, 141);
            this.HourToTxt.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HourToTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HourToTxt.Name = "HourToTxt";
            this.HourToTxt.Size = new System.Drawing.Size(60, 32);
            this.HourToTxt.TabIndex = 4;
            this.HourToTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HourToTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HourFromTxt
            // 
            this.HourFromTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HourFromTxt.ForeColor = System.Drawing.Color.Teal;
            this.HourFromTxt.Location = new System.Drawing.Point(153, 141);
            this.HourFromTxt.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HourFromTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HourFromTxt.Name = "HourFromTxt";
            this.HourFromTxt.Size = new System.Drawing.Size(60, 32);
            this.HourFromTxt.TabIndex = 3;
            this.HourFromTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HourFromTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddressTxt
            // 
            this.AddressTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxt.Location = new System.Drawing.Point(38, 191);
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(221, 64);
            this.AddressTxt.TabIndex = 5;
            // 
            // ResturantOwnerTxt
            // 
            this.ResturantOwnerTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResturantOwnerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResturantOwnerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResturantOwnerTxt.Location = new System.Drawing.Point(65, 67);
            this.ResturantOwnerTxt.Multiline = true;
            this.ResturantOwnerTxt.Name = "ResturantOwnerTxt";
            this.ResturantOwnerTxt.Size = new System.Drawing.Size(160, 20);
            this.ResturantOwnerTxt.TabIndex = 1;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToLabel.ForeColor = System.Drawing.Color.Teal;
            this.ToLabel.Location = new System.Drawing.Point(131, 143);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(18, 23);
            this.ToLabel.TabIndex = 7;
            this.ToLabel.Text = "تا";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromLabel.ForeColor = System.Drawing.Color.Teal;
            this.FromLabel.Location = new System.Drawing.Point(225, 143);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(20, 23);
            this.FromLabel.TabIndex = 6;
            this.FromLabel.Text = "از";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressLabel.ForeColor = System.Drawing.Color.Teal;
            this.AddressLabel.Location = new System.Drawing.Point(272, 190);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 24);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "آدرس";
            // 
            // WorkHoursLabel
            // 
            this.WorkHoursLabel.AutoSize = true;
            this.WorkHoursLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.WorkHoursLabel.ForeColor = System.Drawing.Color.Teal;
            this.WorkHoursLabel.Location = new System.Drawing.Point(265, 145);
            this.WorkHoursLabel.Name = "WorkHoursLabel";
            this.WorkHoursLabel.Size = new System.Drawing.Size(89, 24);
            this.WorkHoursLabel.TabIndex = 4;
            this.WorkHoursLabel.Text = "ساعت کارکرد";
            // 
            // ResturantOwnerLabel
            // 
            this.ResturantOwnerLabel.AutoSize = true;
            this.ResturantOwnerLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResturantOwnerLabel.ForeColor = System.Drawing.Color.Teal;
            this.ResturantOwnerLabel.Location = new System.Drawing.Point(260, 67);
            this.ResturantOwnerLabel.Name = "ResturantOwnerLabel";
            this.ResturantOwnerLabel.Size = new System.Drawing.Size(104, 24);
            this.ResturantOwnerLabel.TabIndex = 3;
            this.ResturantOwnerLabel.Text = "صاحب رستوران";
            // 
            // ResturantNameTxt
            // 
            this.ResturantNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResturantNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResturantNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResturantNameTxt.Location = new System.Drawing.Point(65, 35);
            this.ResturantNameTxt.Multiline = true;
            this.ResturantNameTxt.Name = "ResturantNameTxt";
            this.ResturantNameTxt.Size = new System.Drawing.Size(160, 20);
            this.ResturantNameTxt.TabIndex = 0;
            // 
            // ResturantNameLabel
            // 
            this.ResturantNameLabel.AutoSize = true;
            this.ResturantNameLabel.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResturantNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.ResturantNameLabel.Location = new System.Drawing.Point(266, 35);
            this.ResturantNameLabel.Name = "ResturantNameLabel";
            this.ResturantNameLabel.Size = new System.Drawing.Size(85, 24);
            this.ResturantNameLabel.TabIndex = 0;
            this.ResturantNameLabel.Text = "نام رستوران";
            // 
            // ResturantSubmitBtn
            // 
            this.ResturantSubmitBtn.BackColor = System.Drawing.Color.Teal;
            this.ResturantSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResturantSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.ResturantSubmitBtn.Location = new System.Drawing.Point(288, 251);
            this.ResturantSubmitBtn.Name = "ResturantSubmitBtn";
            this.ResturantSubmitBtn.Size = new System.Drawing.Size(60, 30);
            this.ResturantSubmitBtn.TabIndex = 13;
            this.ResturantSubmitBtn.Text = "ثبت ";
            this.ResturantSubmitBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Teal;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(420, 342);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(72, 30);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "بازگشت";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RestaurantSubmitBtn
            // 
            this.RestaurantSubmitBtn.BackColor = System.Drawing.Color.Teal;
            this.RestaurantSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestaurantSubmitBtn.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RestaurantSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.RestaurantSubmitBtn.Location = new System.Drawing.Point(105, 345);
            this.RestaurantSubmitBtn.Name = "RestaurantSubmitBtn";
            this.RestaurantSubmitBtn.Size = new System.Drawing.Size(72, 30);
            this.RestaurantSubmitBtn.TabIndex = 1;
            this.RestaurantSubmitBtn.Text = "ثبت ";
            this.RestaurantSubmitBtn.UseVisualStyleBackColor = false;
            this.RestaurantSubmitBtn.Click += new System.EventHandler(this.RestaurantSubmitBtn_Click);
            // 
            // ResturantRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 392);
            this.Controls.Add(this.RestaurantSubmitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ResturantRegBox);
            this.Controls.Add(this.ResturantSubmitBtn);
            this.Name = "ResturantRegistrationForm";
            this.Text = "فرم ثبت رستوران";
            this.ResturantRegBox.ResumeLayout(false);
            this.ResturantRegBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourToTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourFromTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ResturantRegBox;
        private TextBox ResturantNameTxt;
        private Label ResturantNameLabel;
        private Label ToLabel;
        private Label FromLabel;
        private Label AddressLabel;
        private Label WorkHoursLabel;
        private Label ResturantOwnerLabel;
        private TextBox AddressTxt;
        private TextBox ResturantOwnerTxt;
        private NumericUpDown HourFromTxt;
        private NumericUpDown HourToTxt;
        private Button ResturantSubmitBtn;
        private Label PhoneNumberLabel;
        private TextBox PhoneNumberTxt;
        private Button BackBtn;
        private Button RestaurantSubmitBtn;
    }
}