using System.Windows.Forms;

namespace UI
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
            this.MainBox = new System.Windows.Forms.GroupBox();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.ShowInvoicesBtn = new System.Windows.Forms.Button();
            this.MainBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.MenuBtn);
            this.MainBox.Controls.Add(this.ShowInvoicesBtn);
            this.MainBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainBox.ForeColor = System.Drawing.Color.Teal;
            this.MainBox.Location = new System.Drawing.Point(92, 55);
            this.MainBox.Margin = new System.Windows.Forms.Padding(0);
            this.MainBox.Name = "MainBox";
            this.MainBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainBox.Size = new System.Drawing.Size(400, 150);
            this.MainBox.TabIndex = 2;
            this.MainBox.TabStop = false;
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.Teal;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.ForeColor = System.Drawing.Color.White;
            this.MenuBtn.Location = new System.Drawing.Point(224, 57);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(120, 30);
            this.MenuBtn.TabIndex = 1;
            this.MenuBtn.Text = "منو غذا";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // ShowInvoicesBtn
            // 
            this.ShowInvoicesBtn.BackColor = System.Drawing.Color.Teal;
            this.ShowInvoicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowInvoicesBtn.ForeColor = System.Drawing.Color.White;
            this.ShowInvoicesBtn.Location = new System.Drawing.Point(78, 57);
            this.ShowInvoicesBtn.Name = "ShowInvoicesBtn";
            this.ShowInvoicesBtn.Size = new System.Drawing.Size(120, 30);
            this.ShowInvoicesBtn.TabIndex = 0;
            this.ShowInvoicesBtn.Text = "نمایش فاکتورها";
            this.ShowInvoicesBtn.UseVisualStyleBackColor = false;
            this.ShowInvoicesBtn.Click += new System.EventHandler(this.ShowInvoicesBtn_Click);
            // 
            // ResturantOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.MainBox);
            this.Name = "ResturantOwnerForm";
            this.Text = "ResturantOwnerForm";
            this.MainBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox MainBox;
        private Button MenuBtn;
        private Button ShowInvoicesBtn;
    }
}