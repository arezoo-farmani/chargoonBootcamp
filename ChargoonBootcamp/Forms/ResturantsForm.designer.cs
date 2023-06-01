using System.Windows.Forms;

namespace UI
{
    partial class ResturantsForm
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
            this.ResturantsListBox = new System.Windows.Forms.GroupBox();
            this.ResturantsList = new System.Windows.Forms.ListView();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ResturantsListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResturantsListBox
            // 
            this.ResturantsListBox.Controls.Add(this.ResturantsList);
            this.ResturantsListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResturantsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResturantsListBox.ForeColor = System.Drawing.Color.Teal;
            this.ResturantsListBox.Location = new System.Drawing.Point(92, 80);
            this.ResturantsListBox.Name = "ResturantsListBox";
            this.ResturantsListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResturantsListBox.Size = new System.Drawing.Size(400, 300);
            this.ResturantsListBox.TabIndex = 4;
            this.ResturantsListBox.TabStop = false;
            this.ResturantsListBox.Text = "رستوران ها";
            // 
            // ResturantsList
            // 
            this.ResturantsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResturantsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResturantsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResturantsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResturantsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ResturantsList.HideSelection = false;
            this.ResturantsList.LabelWrap = false;
            this.ResturantsList.Location = new System.Drawing.Point(3, 18);
            this.ResturantsList.MultiSelect = false;
            this.ResturantsList.Name = "ResturantsList";
            this.ResturantsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResturantsList.RightToLeftLayout = true;
            this.ResturantsList.ShowItemToolTips = true;
            this.ResturantsList.Size = new System.Drawing.Size(394, 279);
            this.ResturantsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ResturantsList.TabIndex = 0;
            this.ResturantsList.UseCompatibleStateImageBehavior = false;
            this.ResturantsList.View = System.Windows.Forms.View.List;
            this.ResturantsList.DoubleClick += new System.EventHandler(this.ResturantsList_DoubleClick);
            // 
            // MessageLabel
            // 
            this.MessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.Red;
            this.MessageLabel.Location = new System.Drawing.Point(92, 380);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MessageLabel.Size = new System.Drawing.Size(400, 20);
            this.MessageLabel.TabIndex = 5;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResturantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ResturantsListBox);
            this.Name = "ResturantsForm";
            this.Text = "AllResturantsForm";
            this.ResturantsListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ResturantsListBox;
        private ListView ResturantsList;
        private Label MessageLabel;
    }
}