
namespace StudentsManagmentSystem.Forms
{
    partial class Search
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
            this.flowListingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowListingPanel
            // 
            this.flowListingPanel.BackColor = System.Drawing.Color.White;
            this.flowListingPanel.Location = new System.Drawing.Point(21, 53);
            this.flowListingPanel.Name = "flowListingPanel";
            this.flowListingPanel.Size = new System.Drawing.Size(421, 306);
            this.flowListingPanel.TabIndex = 0;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(21, 12);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.PlaceholderText = "Search for Student";
            this.searchTxtBox.Size = new System.Drawing.Size(320, 23);
            this.searchTxtBox.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.Location = new System.Drawing.Point(348, 13);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(464, 371);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.flowListingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowListingPanel;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button SearchBtn;
    }
}