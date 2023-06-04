namespace WindowsFormsApp_Restaurant.Forms
{
    partial class MainMenuForm
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
            this.FoodMenuBtn = new System.Windows.Forms.Button();
            this.InvoicesListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoodMenuBtn
            // 
            this.FoodMenuBtn.BackColor = System.Drawing.Color.Teal;
            this.FoodMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodMenuBtn.ForeColor = System.Drawing.Color.White;
            this.FoodMenuBtn.Location = new System.Drawing.Point(78, 67);
            this.FoodMenuBtn.Name = "FoodMenuBtn";
            this.FoodMenuBtn.Size = new System.Drawing.Size(120, 30);
            this.FoodMenuBtn.TabIndex = 9;
            this.FoodMenuBtn.Text = "منوی غذا";
            this.FoodMenuBtn.UseVisualStyleBackColor = false;
            this.FoodMenuBtn.Click += new System.EventHandler(this.FoodMenuBtn_Click);
            // 
            // InvoicesListBtn
            // 
            this.InvoicesListBtn.BackColor = System.Drawing.Color.Teal;
            this.InvoicesListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoicesListBtn.ForeColor = System.Drawing.Color.White;
            this.InvoicesListBtn.Location = new System.Drawing.Point(78, 149);
            this.InvoicesListBtn.Name = "InvoicesListBtn";
            this.InvoicesListBtn.Size = new System.Drawing.Size(120, 30);
            this.InvoicesListBtn.TabIndex = 8;
            this.InvoicesListBtn.Text = "لیست فاکتورها";
            this.InvoicesListBtn.UseVisualStyleBackColor = false;
            this.InvoicesListBtn.Click += new System.EventHandler(this.FactorListBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 282);
            this.Controls.Add(this.FoodMenuBtn);
            this.Controls.Add(this.InvoicesListBtn);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FoodMenuBtn;
        private System.Windows.Forms.Button InvoicesListBtn;
    }
}