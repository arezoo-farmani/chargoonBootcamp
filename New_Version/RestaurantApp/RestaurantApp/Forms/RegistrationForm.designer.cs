using System.Windows.Forms;

namespace RestaurantApp.UILayer.Forms
{
    partial class RegistrationForm
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
            RegistrationBox = new GroupBox();
            ResturantRegBtn = new Button();
            UserRegBtn = new Button();
            RegistrationBox.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrationBox
            // 
            RegistrationBox.Controls.Add(ResturantRegBtn);
            RegistrationBox.Controls.Add(UserRegBtn);
            RegistrationBox.FlatStyle = FlatStyle.Flat;
            RegistrationBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationBox.ForeColor = Color.Teal;
            RegistrationBox.Location = new Point(12, 17);
            RegistrationBox.Margin = new Padding(0);
            RegistrationBox.Name = "RegistrationBox";
            RegistrationBox.Padding = new Padding(5, 6, 5, 6);
            RegistrationBox.RightToLeft = RightToLeft.Yes;
            RegistrationBox.Size = new Size(667, 276);
            RegistrationBox.TabIndex = 1;
            RegistrationBox.TabStop = false;
            RegistrationBox.Text = "ثبت نام";
            // 
            // ResturantRegBtn
            // 
            ResturantRegBtn.BackColor = Color.Teal;
            ResturantRegBtn.FlatStyle = FlatStyle.Flat;
            ResturantRegBtn.ForeColor = Color.White;
            ResturantRegBtn.Location = new Point(373, 110);
            ResturantRegBtn.Margin = new Padding(5, 6, 5, 6);
            ResturantRegBtn.Name = "ResturantRegBtn";
            ResturantRegBtn.Size = new Size(200, 58);
            ResturantRegBtn.TabIndex = 1;
            ResturantRegBtn.Text = "ثبت نام رستوران";
            ResturantRegBtn.UseVisualStyleBackColor = false;
            ResturantRegBtn.Click += ResturantRegBtn_Click;
            // 
            // UserRegBtn
            // 
            UserRegBtn.BackColor = Color.Teal;
            UserRegBtn.FlatStyle = FlatStyle.Flat;
            UserRegBtn.ForeColor = Color.White;
            UserRegBtn.Location = new Point(130, 110);
            UserRegBtn.Margin = new Padding(5, 6, 5, 6);
            UserRegBtn.Name = "UserRegBtn";
            UserRegBtn.Size = new Size(200, 58);
            UserRegBtn.TabIndex = 0;
            UserRegBtn.Text = "ثبت نام کاربر";
            UserRegBtn.UseVisualStyleBackColor = false;
            UserRegBtn.Click += UserRegBtn_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 318);
            Controls.Add(RegistrationBox);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            RegistrationBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RegistrationBox;
        private Button ResturantRegBtn;
        private Button UserRegBtn;
    }
}