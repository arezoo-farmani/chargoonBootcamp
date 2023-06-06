using System.Windows.Forms;

namespace RestaurantApp.UILayer.Forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginBox = new GroupBox();
            LoginBtn = new Button();
            Required1 = new Label();
            PhoneNumberTxt = new TextBox();
            PhoneNumberLabel = new Label();
            button1 = new Button();
            LoginBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoginBox
            // 
            LoginBox.Controls.Add(LoginBtn);
            LoginBox.Controls.Add(Required1);
            LoginBox.Controls.Add(PhoneNumberTxt);
            LoginBox.Controls.Add(PhoneNumberLabel);
            LoginBox.FlatStyle = FlatStyle.Flat;
            LoginBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBox.ForeColor = Color.Teal;
            LoginBox.Location = new Point(133, 135);
            LoginBox.Margin = new Padding(4, 6, 4, 6);
            LoginBox.Name = "LoginBox";
            LoginBox.Padding = new Padding(4, 6, 4, 6);
            LoginBox.RightToLeft = RightToLeft.Yes;
            LoginBox.Size = new Size(667, 289);
            LoginBox.TabIndex = 0;
            LoginBox.TabStop = false;
            LoginBox.Text = "ورود";
            LoginBox.Enter += LoginBox_Enter;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LoginBtn.BackColor = Color.Teal;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(27, 202);
            LoginBtn.Margin = new Padding(4, 6, 4, 6);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(100, 58);
            LoginBtn.TabIndex = 14;
            LoginBtn.Text = "ورود";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Required1
            // 
            Required1.AutoSize = true;
            Required1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Required1.ForeColor = Color.Red;
            Required1.Location = new Point(130, 98);
            Required1.Margin = new Padding(4, 0, 4, 0);
            Required1.Name = "Required1";
            Required1.Size = new Size(21, 25);
            Required1.TabIndex = 2;
            Required1.Text = "*";
            Required1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.BackColor = Color.FromArgb(224, 224, 224);
            PhoneNumberTxt.BorderStyle = BorderStyle.None;
            PhoneNumberTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberTxt.Location = new Point(168, 104);
            PhoneNumberTxt.Margin = new Padding(4, 6, 4, 6);
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.Size = new Size(267, 19);
            PhoneNumberTxt.TabIndex = 1;
            PhoneNumberTxt.TextChanged += PhoneNumberTxt_TextChanged;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLabel.ForeColor = Color.Teal;
            PhoneNumberLabel.Location = new Point(456, 98);
            PhoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(98, 25);
            PhoneNumberLabel.TabIndex = 0;
            PhoneNumberLabel.Text = "شماره موبایل";
            // 
            // button1
            // 
            button1.Location = new Point(644, 464);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.Name = "button1";
            button1.Size = new Size(124, 44);
            button1.TabIndex = 16;
            button1.Text = "فرم منوها";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 614);
            Controls.Add(button1);
            Controls.Add(LoginBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "LoginForm";
            Text = "LoginForm";
            LoginBox.ResumeLayout(false);
            LoginBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LoginBox;
        private TextBox PhoneNumberTxt;
        private Label PhoneNumberLabel;
        private Label Required1;
        private Button LoginBtn;
        //  private PictureBox CloseBtn;
        private Button button1;
    }
}