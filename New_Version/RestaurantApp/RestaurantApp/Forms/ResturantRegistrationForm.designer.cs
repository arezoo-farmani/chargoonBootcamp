using System.Windows.Forms;

namespace RestaurantApp.UILayer.Forms
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
            ResturantRegBox = new GroupBox();
            PhoneNumberTxt = new TextBox();
            PhoneNumberLabel = new Label();
            HourToTxt = new NumericUpDown();
            HourFromTxt = new NumericUpDown();
            AddressTxt = new TextBox();
            ResturantOwnerTxt = new TextBox();
            ToLabel = new Label();
            FromLabel = new Label();
            AddressLabel = new Label();
            WorkHoursLabel = new Label();
            ResturantOwnerLabel = new Label();
            ResturantNameTxt = new TextBox();
            ResturantNameLabel = new Label();
            ResturantSubmitBtn = new Button();
            ResturantRegBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HourToTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HourFromTxt).BeginInit();
            SuspendLayout();
            // 
            // ResturantRegBox
            // 
            ResturantRegBox.Controls.Add(PhoneNumberTxt);
            ResturantRegBox.Controls.Add(PhoneNumberLabel);
            ResturantRegBox.Controls.Add(HourToTxt);
            ResturantRegBox.Controls.Add(HourFromTxt);
            ResturantRegBox.Controls.Add(AddressTxt);
            ResturantRegBox.Controls.Add(ResturantOwnerTxt);
            ResturantRegBox.Controls.Add(ToLabel);
            ResturantRegBox.Controls.Add(FromLabel);
            ResturantRegBox.Controls.Add(AddressLabel);
            ResturantRegBox.Controls.Add(WorkHoursLabel);
            ResturantRegBox.Controls.Add(ResturantOwnerLabel);
            ResturantRegBox.Controls.Add(ResturantNameTxt);
            ResturantRegBox.Controls.Add(ResturantNameLabel);
            ResturantRegBox.FlatStyle = FlatStyle.Flat;
            ResturantRegBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ResturantRegBox.ForeColor = Color.Teal;
            ResturantRegBox.Location = new Point(139, 36);
            ResturantRegBox.Margin = new Padding(4, 6, 4, 6);
            ResturantRegBox.Name = "ResturantRegBox";
            ResturantRegBox.Padding = new Padding(4, 6, 4, 6);
            ResturantRegBox.RightToLeft = RightToLeft.Yes;
            ResturantRegBox.Size = new Size(667, 578);
            ResturantRegBox.TabIndex = 2;
            ResturantRegBox.TabStop = false;
            ResturantRegBox.Text = "ثبت نام رستوران";
            ResturantRegBox.Enter += ResturantRegBox_Enter;
            // 
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.BackColor = Color.FromArgb(224, 224, 224);
            PhoneNumberTxt.BorderStyle = BorderStyle.None;
            PhoneNumberTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberTxt.Location = new Point(112, 186);
            PhoneNumberTxt.Margin = new Padding(4, 6, 4, 6);
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.ReadOnly = true;
            PhoneNumberTxt.Size = new Size(267, 19);
            PhoneNumberTxt.TabIndex = 15;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLabel.ForeColor = Color.Teal;
            PhoneNumberLabel.Location = new Point(449, 182);
            PhoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(98, 25);
            PhoneNumberLabel.TabIndex = 14;
            PhoneNumberLabel.Text = "شماره موبایل";
            // 
            // HourToTxt
            // 
            HourToTxt.BackColor = Color.FromArgb(224, 224, 224);
            HourToTxt.ForeColor = Color.Teal;
            HourToTxt.Location = new Point(80, 239);
            HourToTxt.Margin = new Padding(4, 6, 4, 6);
            HourToTxt.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            HourToTxt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            HourToTxt.Name = "HourToTxt";
            HourToTxt.Size = new Size(100, 30);
            HourToTxt.TabIndex = 12;
            HourToTxt.TextAlign = HorizontalAlignment.Center;
            HourToTxt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // HourFromTxt
            // 
            HourFromTxt.BackColor = Color.FromArgb(224, 224, 224);
            HourFromTxt.ForeColor = Color.Teal;
            HourFromTxt.Location = new Point(233, 239);
            HourFromTxt.Margin = new Padding(4, 6, 4, 6);
            HourFromTxt.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            HourFromTxt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            HourFromTxt.Name = "HourFromTxt";
            HourFromTxt.Size = new Size(100, 30);
            HourFromTxt.TabIndex = 11;
            HourFromTxt.TextAlign = HorizontalAlignment.Center;
            HourFromTxt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddressTxt
            // 
            AddressTxt.BackColor = Color.FromArgb(224, 224, 224);
            AddressTxt.BorderStyle = BorderStyle.None;
            AddressTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTxt.Location = new Point(38, 304);
            AddressTxt.Margin = new Padding(4, 6, 4, 6);
            AddressTxt.Multiline = true;
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(369, 88);
            AddressTxt.TabIndex = 9;
            // 
            // ResturantOwnerTxt
            // 
            ResturantOwnerTxt.BackColor = Color.FromArgb(224, 224, 224);
            ResturantOwnerTxt.BorderStyle = BorderStyle.None;
            ResturantOwnerTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ResturantOwnerTxt.Location = new Point(112, 127);
            ResturantOwnerTxt.Margin = new Padding(4, 6, 4, 6);
            ResturantOwnerTxt.Name = "ResturantOwnerTxt";
            ResturantOwnerTxt.Size = new Size(267, 19);
            ResturantOwnerTxt.TabIndex = 8;
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ToLabel.ForeColor = Color.Teal;
            ToLabel.Location = new Point(197, 242);
            ToLabel.Margin = new Padding(4, 0, 4, 0);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(22, 25);
            ToLabel.TabIndex = 7;
            ToLabel.Text = "تا";
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FromLabel.ForeColor = Color.Teal;
            FromLabel.Location = new Point(353, 242);
            FromLabel.Margin = new Padding(4, 0, 4, 0);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(26, 25);
            FromLabel.TabIndex = 6;
            FromLabel.Text = "از";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.ForeColor = Color.Teal;
            AddressLabel.Location = new Point(449, 300);
            AddressLabel.Margin = new Padding(4, 0, 4, 0);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(50, 25);
            AddressLabel.TabIndex = 5;
            AddressLabel.Text = "آدرس";
            // 
            // WorkHoursLabel
            // 
            WorkHoursLabel.AutoSize = true;
            WorkHoursLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            WorkHoursLabel.ForeColor = Color.Teal;
            WorkHoursLabel.Location = new Point(449, 242);
            WorkHoursLabel.Margin = new Padding(4, 0, 4, 0);
            WorkHoursLabel.Name = "WorkHoursLabel";
            WorkHoursLabel.Size = new Size(106, 25);
            WorkHoursLabel.TabIndex = 4;
            WorkHoursLabel.Text = "ساعت کارکرد";
            WorkHoursLabel.Click += WorkHoursLabel_Click;
            // 
            // ResturantOwnerLabel
            // 
            ResturantOwnerLabel.AutoSize = true;
            ResturantOwnerLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ResturantOwnerLabel.ForeColor = Color.Teal;
            ResturantOwnerLabel.Location = new Point(449, 121);
            ResturantOwnerLabel.Margin = new Padding(4, 0, 4, 0);
            ResturantOwnerLabel.Name = "ResturantOwnerLabel";
            ResturantOwnerLabel.Size = new Size(123, 25);
            ResturantOwnerLabel.TabIndex = 3;
            ResturantOwnerLabel.Text = "صاحب رستوران";
            // 
            // ResturantNameTxt
            // 
            ResturantNameTxt.BackColor = Color.FromArgb(224, 224, 224);
            ResturantNameTxt.BorderStyle = BorderStyle.None;
            ResturantNameTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ResturantNameTxt.Location = new Point(112, 64);
            ResturantNameTxt.Margin = new Padding(4, 6, 4, 6);
            ResturantNameTxt.Name = "ResturantNameTxt";
            ResturantNameTxt.Size = new Size(267, 19);
            ResturantNameTxt.TabIndex = 1;
            // 
            // ResturantNameLabel
            // 
            ResturantNameLabel.AutoSize = true;
            ResturantNameLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ResturantNameLabel.ForeColor = Color.Teal;
            ResturantNameLabel.Location = new Point(449, 60);
            ResturantNameLabel.Margin = new Padding(4, 0, 4, 0);
            ResturantNameLabel.Name = "ResturantNameLabel";
            ResturantNameLabel.Size = new Size(93, 25);
            ResturantNameLabel.TabIndex = 0;
            ResturantNameLabel.Text = "نام رستوران";
            // 
            // ResturantSubmitBtn
            // 
            ResturantSubmitBtn.BackColor = Color.Teal;
            ResturantSubmitBtn.FlatStyle = FlatStyle.Flat;
            ResturantSubmitBtn.ForeColor = Color.White;
            ResturantSubmitBtn.Location = new Point(167, 742);
            ResturantSubmitBtn.Margin = new Padding(4, 6, 4, 6);
            ResturantSubmitBtn.Name = "ResturantSubmitBtn";
            ResturantSubmitBtn.Size = new Size(100, 58);
            ResturantSubmitBtn.TabIndex = 13;
            ResturantSubmitBtn.Text = "ثبت ";
            ResturantSubmitBtn.UseVisualStyleBackColor = false;
            ResturantSubmitBtn.Click += ResturantSubmitBtn_Click;
            // 
            // ResturantRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 886);
            Controls.Add(ResturantRegBox);
            Controls.Add(ResturantSubmitBtn);
            Margin = new Padding(4, 6, 4, 6);
            Name = "ResturantRegistrationForm";
            Text = "ResturantRegistrationForm";
            ResturantRegBox.ResumeLayout(false);
            ResturantRegBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HourToTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)HourFromTxt).EndInit();
            ResumeLayout(false);
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