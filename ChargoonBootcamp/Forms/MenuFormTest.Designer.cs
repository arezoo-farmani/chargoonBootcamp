namespace WindowsFormsApp_Restaurant.Forms
{
    partial class MenuFormTest
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
            this.FactorListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoodMenuBtn
            // 
            this.FoodMenuBtn.BackColor = System.Drawing.Color.Teal;
            this.FoodMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodMenuBtn.ForeColor = System.Drawing.Color.White;
            this.FoodMenuBtn.Location = new System.Drawing.Point(73, 67);
            this.FoodMenuBtn.Name = "FoodMenuBtn";
            this.FoodMenuBtn.Size = new System.Drawing.Size(120, 30);
            this.FoodMenuBtn.TabIndex = 7;
            this.FoodMenuBtn.Text = "منوی غذا";
            this.FoodMenuBtn.UseVisualStyleBackColor = false;
            this.FoodMenuBtn.Click += new System.EventHandler(this.FoodMenuBtn_Click);
            // 
            // FactorListBtn
            // 
            this.FactorListBtn.BackColor = System.Drawing.Color.Teal;
            this.FactorListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FactorListBtn.ForeColor = System.Drawing.Color.White;
            this.FactorListBtn.Location = new System.Drawing.Point(73, 149);
            this.FactorListBtn.Name = "FactorListBtn";
            this.FactorListBtn.Size = new System.Drawing.Size(120, 30);
            this.FactorListBtn.TabIndex = 6;
            this.FactorListBtn.Text = "لیست فاکتورها";
            this.FactorListBtn.UseVisualStyleBackColor = false;
            this.FactorListBtn.Click += new System.EventHandler(this.FactorListBtn_Click);
            // 
            // MenuFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 312);
            this.Controls.Add(this.FoodMenuBtn);
            this.Controls.Add(this.FactorListBtn);
            this.Name = "MenuFormTest";
            this.Text = "MenuFormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FoodMenuBtn;
        private System.Windows.Forms.Button FactorListBtn;
    }
}