using System.Windows.Forms;

namespace RestaurantApp.UILayer.Forms
{
    partial class ResturantOwnerForm
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
            MainBox = new GroupBox();
            MenuBtn = new Button();
            ShowInvoicesBtn = new Button();
            lblInfo = new Label();
            MainBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainBox
            // 
            MainBox.Controls.Add(MenuBtn);
            MainBox.Controls.Add(ShowInvoicesBtn);
            MainBox.FlatStyle = FlatStyle.Flat;
            MainBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MainBox.ForeColor = Color.Teal;
            MainBox.Location = new Point(153, 106);
            MainBox.Margin = new Padding(0);
            MainBox.Name = "MainBox";
            MainBox.Padding = new Padding(5, 6, 5, 6);
            MainBox.RightToLeft = RightToLeft.Yes;
            MainBox.Size = new Size(667, 288);
            MainBox.TabIndex = 2;
            MainBox.TabStop = false;
            // 
            // MenuBtn
            // 
            MenuBtn.BackColor = Color.Teal;
            MenuBtn.FlatStyle = FlatStyle.Flat;
            MenuBtn.ForeColor = Color.White;
            MenuBtn.Location = new Point(373, 110);
            MenuBtn.Margin = new Padding(5, 6, 5, 6);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(200, 58);
            MenuBtn.TabIndex = 1;
            MenuBtn.Text = "ثبت منو جدید";
            MenuBtn.UseVisualStyleBackColor = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // ShowInvoicesBtn
            // 
            ShowInvoicesBtn.BackColor = Color.Teal;
            ShowInvoicesBtn.FlatStyle = FlatStyle.Flat;
            ShowInvoicesBtn.ForeColor = Color.White;
            ShowInvoicesBtn.Location = new Point(130, 110);
            ShowInvoicesBtn.Margin = new Padding(5, 6, 5, 6);
            ShowInvoicesBtn.Name = "ShowInvoicesBtn";
            ShowInvoicesBtn.Size = new Size(200, 58);
            ShowInvoicesBtn.TabIndex = 0;
            ShowInvoicesBtn.Text = "نمایش فاکتورها";
            ShowInvoicesBtn.UseVisualStyleBackColor = false;
            ShowInvoicesBtn.Click += ShowInvoicesBtn_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(466, 70);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(42, 25);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Text";
            // 
            // ResturantOwnerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 502);
            Controls.Add(lblInfo);
            Controls.Add(MainBox);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ResturantOwnerForm";
            Text = "ResturantOwnerForm";
            MainBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox MainBox;
        private Button MenuBtn;
        private Button ShowInvoicesBtn;
        private Label lblInfo;
    }
}