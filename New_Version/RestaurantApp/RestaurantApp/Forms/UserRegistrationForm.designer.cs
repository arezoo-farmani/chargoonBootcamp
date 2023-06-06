using System.Windows.Forms;

namespace RestaurantApp.UILayer.Forms
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
            RegistrationUserBox = new GroupBox();
            Required1 = new Label();
            PhoneNumberTxt = new TextBox();
            PhoneNumberLabel = new Label();
            NationalCodeTxt = new TextBox();
            AddressTxt = new TextBox();
            LastNameTxt = new TextBox();
            AddressLabel = new Label();
            NationalCodeLabel = new Label();
            LastNameLabel = new Label();
            FirstNameTxt = new TextBox();
            FirstNameLabel = new Label();
            UserSubmitBtn = new Button();
            RegistrationUserBox.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrationUserBox
            // 
            RegistrationUserBox.Controls.Add(Required1);
            RegistrationUserBox.Controls.Add(PhoneNumberTxt);
            RegistrationUserBox.Controls.Add(PhoneNumberLabel);
            RegistrationUserBox.Controls.Add(NationalCodeTxt);
            RegistrationUserBox.Controls.Add(AddressTxt);
            RegistrationUserBox.Controls.Add(LastNameTxt);
            RegistrationUserBox.Controls.Add(AddressLabel);
            RegistrationUserBox.Controls.Add(NationalCodeLabel);
            RegistrationUserBox.Controls.Add(LastNameLabel);
            RegistrationUserBox.Controls.Add(FirstNameTxt);
            RegistrationUserBox.Controls.Add(FirstNameLabel);
            RegistrationUserBox.FlatStyle = FlatStyle.Flat;
            RegistrationUserBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationUserBox.ForeColor = Color.Teal;
            RegistrationUserBox.Location = new Point(14, 13);
            RegistrationUserBox.Margin = new Padding(4, 6, 4, 6);
            RegistrationUserBox.Name = "RegistrationUserBox";
            RegistrationUserBox.Padding = new Padding(4, 6, 4, 6);
            RegistrationUserBox.RightToLeft = RightToLeft.Yes;
            RegistrationUserBox.Size = new Size(667, 412);
            RegistrationUserBox.TabIndex = 3;
            RegistrationUserBox.TabStop = false;
            RegistrationUserBox.Text = "ثبت نام کاربر";
            RegistrationUserBox.Enter += RegistrationUserBox_Enter;
            // 
            // Required1
            // 
            Required1.AutoSize = true;
            Required1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Required1.ForeColor = Color.Red;
            Required1.Location = new Point(150, 181);
            Required1.Margin = new Padding(4, 0, 4, 0);
            Required1.Name = "Required1";
            Required1.Size = new Size(21, 25);
            Required1.TabIndex = 17;
            Required1.Text = "*";
            Required1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.BackColor = Color.FromArgb(224, 224, 224);
            PhoneNumberTxt.BorderStyle = BorderStyle.None;
            PhoneNumberTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberTxt.Location = new Point(182, 239);
            PhoneNumberTxt.Margin = new Padding(4, 6, 4, 6);
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.ReadOnly = true;
            PhoneNumberTxt.Size = new Size(267, 19);
            PhoneNumberTxt.TabIndex = 16;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLabel.ForeColor = Color.Teal;
            PhoneNumberLabel.Location = new Point(496, 235);
            PhoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(98, 25);
            PhoneNumberLabel.TabIndex = 15;
            PhoneNumberLabel.Text = "شماره موبایل";
            // 
            // NationalCodeTxt
            // 
            NationalCodeTxt.BackColor = Color.FromArgb(224, 224, 224);
            NationalCodeTxt.BorderStyle = BorderStyle.None;
            NationalCodeTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            NationalCodeTxt.Location = new Point(182, 172);
            NationalCodeTxt.Margin = new Padding(4, 6, 4, 6);
            NationalCodeTxt.Name = "NationalCodeTxt";
            NationalCodeTxt.Size = new Size(267, 19);
            NationalCodeTxt.TabIndex = 14;
            // 
            // AddressTxt
            // 
            AddressTxt.BackColor = Color.FromArgb(224, 224, 224);
            AddressTxt.BorderStyle = BorderStyle.None;
            AddressTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTxt.Location = new Point(80, 304);
            AddressTxt.Margin = new Padding(4, 6, 4, 6);
            AddressTxt.Multiline = true;
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(369, 79);
            AddressTxt.TabIndex = 9;
            // 
            // LastNameTxt
            // 
            LastNameTxt.BackColor = Color.FromArgb(224, 224, 224);
            LastNameTxt.BorderStyle = BorderStyle.None;
            LastNameTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxt.Location = new Point(182, 101);
            LastNameTxt.Margin = new Padding(4, 6, 4, 6);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(267, 19);
            LastNameTxt.TabIndex = 8;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.ForeColor = Color.Teal;
            AddressLabel.Location = new Point(496, 300);
            AddressLabel.Margin = new Padding(4, 0, 4, 0);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(50, 25);
            AddressLabel.TabIndex = 5;
            AddressLabel.Text = "آدرس";
            // 
            // NationalCodeLabel
            // 
            NationalCodeLabel.AutoSize = true;
            NationalCodeLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NationalCodeLabel.ForeColor = Color.Teal;
            NationalCodeLabel.Location = new Point(496, 172);
            NationalCodeLabel.Margin = new Padding(4, 0, 4, 0);
            NationalCodeLabel.Name = "NationalCodeLabel";
            NationalCodeLabel.Size = new Size(56, 25);
            NationalCodeLabel.TabIndex = 4;
            NationalCodeLabel.Text = "کد ملی";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.ForeColor = Color.Teal;
            LastNameLabel.Location = new Point(496, 95);
            LastNameLabel.Margin = new Padding(4, 0, 4, 0);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(94, 25);
            LastNameLabel.TabIndex = 3;
            LastNameLabel.Text = "نام خانوادگی";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.BackColor = Color.FromArgb(224, 224, 224);
            FirstNameTxt.BorderStyle = BorderStyle.None;
            FirstNameTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTxt.Location = new Point(182, 54);
            FirstNameTxt.Margin = new Padding(4, 6, 4, 6);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(267, 19);
            FirstNameTxt.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = Color.Teal;
            FirstNameLabel.Location = new Point(496, 54);
            FirstNameLabel.Margin = new Padding(4, 0, 4, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(29, 25);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "نام";
            // 
            // UserSubmitBtn
            // 
            UserSubmitBtn.BackColor = Color.Teal;
            UserSubmitBtn.FlatStyle = FlatStyle.Flat;
            UserSubmitBtn.ForeColor = Color.White;
            UserSubmitBtn.Location = new Point(14, 437);
            UserSubmitBtn.Margin = new Padding(4, 6, 4, 6);
            UserSubmitBtn.Name = "UserSubmitBtn";
            UserSubmitBtn.Size = new Size(100, 49);
            UserSubmitBtn.TabIndex = 13;
            UserSubmitBtn.Text = "ثبت ";
            UserSubmitBtn.UseVisualStyleBackColor = false;
            UserSubmitBtn.Click += UserSubmitBtn_Click_1;
            // 
            // UserRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 505);
            Controls.Add(RegistrationUserBox);
            Controls.Add(UserSubmitBtn);
            Margin = new Padding(4, 6, 4, 6);
            Name = "UserRegistrationForm";
            Text = "UserRegistrationForm";
            Load += UserRegistrationForm_Load;
            RegistrationUserBox.ResumeLayout(false);
            RegistrationUserBox.PerformLayout();
            ResumeLayout(false);
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
    }
}