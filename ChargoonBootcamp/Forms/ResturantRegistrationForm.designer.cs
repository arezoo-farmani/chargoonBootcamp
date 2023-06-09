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
            this.ResturantRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResturantRegBox.ForeColor = System.Drawing.Color.Teal;
            this.ResturantRegBox.Location = new System.Drawing.Point(150, 123);
            this.ResturantRegBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResturantRegBox.Name = "ResturantRegBox";
            this.ResturantRegBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResturantRegBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResturantRegBox.Size = new System.Drawing.Size(600, 462);
            this.ResturantRegBox.TabIndex = 2;
            this.ResturantRegBox.TabStop = false;
            this.ResturantRegBox.Text = "ثبت نام رستوران";
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PhoneNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PhoneNumberTxt.Location = new System.Drawing.Point(98, 140);
            this.PhoneNumberTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.ReadOnly = true;
            this.PhoneNumberTxt.Size = new System.Drawing.Size(240, 19);
            this.PhoneNumberTxt.TabIndex = 15;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Teal;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(404, 146);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(98, 25);
            this.PhoneNumberLabel.TabIndex = 14;
            this.PhoneNumberLabel.Text = "شماره موبایل";
            // 
            // HourToTxt
            // 
            this.HourToTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HourToTxt.ForeColor = System.Drawing.Color.Teal;
            this.HourToTxt.Location = new System.Drawing.Point(72, 191);
            this.HourToTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.HourToTxt.Size = new System.Drawing.Size(90, 30);
            this.HourToTxt.TabIndex = 12;
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
            this.HourFromTxt.Location = new System.Drawing.Point(210, 191);
            this.HourFromTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.HourFromTxt.Size = new System.Drawing.Size(90, 30);
            this.HourFromTxt.TabIndex = 11;
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
            this.AddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AddressTxt.Location = new System.Drawing.Point(34, 243);
            this.AddressTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(332, 75);
            this.AddressTxt.TabIndex = 9;
            // 
            // ResturantOwnerTxt
            // 
            this.ResturantOwnerTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResturantOwnerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResturantOwnerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ResturantOwnerTxt.Location = new System.Drawing.Point(98, 91);
            this.ResturantOwnerTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResturantOwnerTxt.Name = "ResturantOwnerTxt";
            this.ResturantOwnerTxt.Size = new System.Drawing.Size(240, 19);
            this.ResturantOwnerTxt.TabIndex = 8;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.ForeColor = System.Drawing.Color.Teal;
            this.ToLabel.Location = new System.Drawing.Point(177, 194);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(22, 25);
            this.ToLabel.TabIndex = 7;
            this.ToLabel.Text = "تا";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.ForeColor = System.Drawing.Color.Teal;
            this.FromLabel.Location = new System.Drawing.Point(318, 194);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(26, 25);
            this.FromLabel.TabIndex = 6;
            this.FromLabel.Text = "از";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.Teal;
            this.AddressLabel.Location = new System.Drawing.Point(404, 240);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(50, 25);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "آدرس";
            // 
            // WorkHoursLabel
            // 
            this.WorkHoursLabel.AutoSize = true;
            this.WorkHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkHoursLabel.ForeColor = System.Drawing.Color.Teal;
            this.WorkHoursLabel.Location = new System.Drawing.Point(404, 194);
            this.WorkHoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkHoursLabel.Name = "WorkHoursLabel";
            this.WorkHoursLabel.Size = new System.Drawing.Size(106, 25);
            this.WorkHoursLabel.TabIndex = 4;
            this.WorkHoursLabel.Text = "ساعت کارکرد";
            // 
            // ResturantOwnerLabel
            // 
            this.ResturantOwnerLabel.AutoSize = true;
            this.ResturantOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResturantOwnerLabel.ForeColor = System.Drawing.Color.Teal;
            this.ResturantOwnerLabel.Location = new System.Drawing.Point(404, 97);
            this.ResturantOwnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResturantOwnerLabel.Name = "ResturantOwnerLabel";
            this.ResturantOwnerLabel.Size = new System.Drawing.Size(123, 25);
            this.ResturantOwnerLabel.TabIndex = 3;
            this.ResturantOwnerLabel.Text = "صاحب رستوران";
            // 
            // ResturantNameTxt
            // 
            this.ResturantNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResturantNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResturantNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ResturantNameTxt.Location = new System.Drawing.Point(98, 42);
            this.ResturantNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResturantNameTxt.Name = "ResturantNameTxt";
            this.ResturantNameTxt.Size = new System.Drawing.Size(240, 19);
            this.ResturantNameTxt.TabIndex = 1;
            // 
            // ResturantNameLabel
            // 
            this.ResturantNameLabel.AutoSize = true;
            this.ResturantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResturantNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.ResturantNameLabel.Location = new System.Drawing.Point(404, 48);
            this.ResturantNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResturantNameLabel.Name = "ResturantNameLabel";
            this.ResturantNameLabel.Size = new System.Drawing.Size(93, 25);
            this.ResturantNameLabel.TabIndex = 0;
            this.ResturantNameLabel.Text = "نام رستوران";
            // 
            // ResturantSubmitBtn
            // 
            this.ResturantSubmitBtn.BackColor = System.Drawing.Color.Teal;
            this.ResturantSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResturantSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.ResturantSubmitBtn.Location = new System.Drawing.Point(150, 594);
            this.ResturantSubmitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResturantSubmitBtn.Name = "ResturantSubmitBtn";
            this.ResturantSubmitBtn.Size = new System.Drawing.Size(90, 46);
            this.ResturantSubmitBtn.TabIndex = 13;
            this.ResturantSubmitBtn.Text = "ثبت ";
            this.ResturantSubmitBtn.UseVisualStyleBackColor = false;
            this.ResturantSubmitBtn.Click += new System.EventHandler(this.ResturantSubmitBtn_Click);
            // 
            // ResturantRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 709);
            this.Controls.Add(this.ResturantRegBox);
            this.Controls.Add(this.ResturantSubmitBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResturantRegistrationForm";
            this.Text = "ResturantRegistrationForm";
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
    }
}