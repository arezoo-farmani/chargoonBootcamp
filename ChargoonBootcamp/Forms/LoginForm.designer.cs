using System.Windows.Forms;

namespace ResturantApp
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
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Required1 = new System.Windows.Forms.Label();
            this.PhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.LoginBtn);
            this.LoginBox.Controls.Add(this.Required1);
            this.LoginBox.Controls.Add(this.PhoneNumberTxt);
            this.LoginBox.Controls.Add(this.PhoneNumberLabel);
            this.LoginBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBox.ForeColor = System.Drawing.Color.Teal;
            this.LoginBox.Location = new System.Drawing.Point(120, 108);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginBox.Size = new System.Drawing.Size(600, 231);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "ورود";
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginBtn.BackColor = System.Drawing.Color.Teal;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(24, 162);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(90, 46);
            this.LoginBtn.TabIndex = 14;
            this.LoginBtn.Text = "ورود";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Required1
            // 
            this.Required1.AutoSize = true;
            this.Required1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Required1.ForeColor = System.Drawing.Color.Red;
            this.Required1.Location = new System.Drawing.Point(117, 78);
            this.Required1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Required1.Name = "Required1";
            this.Required1.Size = new System.Drawing.Size(21, 25);
            this.Required1.TabIndex = 2;
            this.Required1.Text = "*";
            this.Required1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PhoneNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PhoneNumberTxt.Location = new System.Drawing.Point(146, 72);
            this.PhoneNumberTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumberTxt.Multiline = true;
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.Size = new System.Drawing.Size(240, 31);
            this.PhoneNumberTxt.TabIndex = 1;
            this.PhoneNumberTxt.TextChanged += new System.EventHandler(this.PhoneNumberTxt_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Teal;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(410, 78);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(98, 25);
            this.PhoneNumberLabel.TabIndex = 0;
            this.PhoneNumberLabel.Text = "شماره موبایل";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::WindowsFormsApp_Restaurant.Properties.Resources.icons8_close_30;
            this.CloseBtn.Location = new System.Drawing.Point(795, 37);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(44, 49);
            this.CloseBtn.TabIndex = 15;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "فرم منوها";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox LoginBox;
        private TextBox PhoneNumberTxt;
        private Label PhoneNumberLabel;
        private Label Required1;
        private Button LoginBtn;
        private PictureBox CloseBtn;
        private Button button1;
    }
}