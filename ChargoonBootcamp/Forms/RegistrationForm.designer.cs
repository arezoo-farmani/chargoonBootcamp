using System.Windows.Forms;

namespace UI
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
            this.RegistrationBox = new System.Windows.Forms.GroupBox();
            this.ResturantRegBtn = new System.Windows.Forms.Button();
            this.UserRegBtn = new System.Windows.Forms.Button();
            this.RegistrationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationBox
            // 
            this.RegistrationBox.Controls.Add(this.ResturantRegBtn);
            this.RegistrationBox.Controls.Add(this.UserRegBtn);
            this.RegistrationBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationBox.ForeColor = System.Drawing.Color.Teal;
            this.RegistrationBox.Location = new System.Drawing.Point(80, 70);
            this.RegistrationBox.Margin = new System.Windows.Forms.Padding(0);
            this.RegistrationBox.Name = "RegistrationBox";
            this.RegistrationBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RegistrationBox.Size = new System.Drawing.Size(400, 150);
            this.RegistrationBox.TabIndex = 1;
            this.RegistrationBox.TabStop = false;
            this.RegistrationBox.Text = "ثبت نام";
            // 
            // ResturantRegBtn
            // 
            this.ResturantRegBtn.BackColor = System.Drawing.Color.Teal;
            this.ResturantRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResturantRegBtn.ForeColor = System.Drawing.Color.White;
            this.ResturantRegBtn.Location = new System.Drawing.Point(224, 57);
            this.ResturantRegBtn.Name = "ResturantRegBtn";
            this.ResturantRegBtn.Size = new System.Drawing.Size(120, 30);
            this.ResturantRegBtn.TabIndex = 1;
            this.ResturantRegBtn.Text = "ثبت نام رستوران";
            this.ResturantRegBtn.UseVisualStyleBackColor = false;
            this.ResturantRegBtn.Click += new System.EventHandler(this.ResturantRegBtn_Click);
            // 
            // UserRegBtn
            // 
            this.UserRegBtn.BackColor = System.Drawing.Color.Teal;
            this.UserRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserRegBtn.ForeColor = System.Drawing.Color.White;
            this.UserRegBtn.Location = new System.Drawing.Point(78, 57);
            this.UserRegBtn.Name = "UserRegBtn";
            this.UserRegBtn.Size = new System.Drawing.Size(120, 30);
            this.UserRegBtn.TabIndex = 0;
            this.UserRegBtn.Text = "ثبت نام کاربر";
            this.UserRegBtn.UseVisualStyleBackColor = false;
            this.UserRegBtn.Click += new System.EventHandler(this.UserRegBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.RegistrationBox);
            this.Name = "RegistrationForm";
            this.Text = "فرم ثبت نام";
            this.RegistrationBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox RegistrationBox;
        private Button ResturantRegBtn;
        private Button UserRegBtn;
    }
}