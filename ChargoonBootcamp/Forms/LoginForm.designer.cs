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
            this.LoginBox.Location = new System.Drawing.Point(80, 70);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginBox.Size = new System.Drawing.Size(400, 150);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "ورود";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginBtn.BackColor = System.Drawing.Color.Teal;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(16, 105);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(60, 30);
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
            this.Required1.Location = new System.Drawing.Point(78, 51);
            this.Required1.Name = "Required1";
            this.Required1.Size = new System.Drawing.Size(14, 16);
            this.Required1.TabIndex = 2;
            this.Required1.Text = "*";
            this.Required1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PhoneNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PhoneNumberTxt.Location = new System.Drawing.Point(97, 47);
            this.PhoneNumberTxt.Multiline = true;
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.Size = new System.Drawing.Size(160, 20);
            this.PhoneNumberTxt.TabIndex = 1;
            this.PhoneNumberTxt.TextChanged += new System.EventHandler(this.PhoneNumberTxt_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.Teal;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(273, 51);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(75, 16);
            this.PhoneNumberLabel.TabIndex = 0;
            this.PhoneNumberLabel.Text = "شماره موبایل";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::WindowsFormsApp_Restaurant.Properties.Resources.icons8_close_30;
            this.CloseBtn.Location = new System.Drawing.Point(530, 24);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(29, 32);
            this.CloseBtn.TabIndex = 15;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "فرم منوها";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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