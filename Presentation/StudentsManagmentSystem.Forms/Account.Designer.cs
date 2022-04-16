
namespace StudentsManagmentSystem.Forms
{
    partial class Account
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
            this.changePassGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.confirmPassTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newPassTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.oldPassTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.changePassGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // changePassGroupBox
            // 
            this.changePassGroupBox.Controls.Add(this.CancelBtn);
            this.changePassGroupBox.Controls.Add(this.SaveChangesBtn);
            this.changePassGroupBox.Controls.Add(this.confirmPassTxtBox);
            this.changePassGroupBox.Controls.Add(this.label7);
            this.changePassGroupBox.Controls.Add(this.newPassTxtBox);
            this.changePassGroupBox.Controls.Add(this.label6);
            this.changePassGroupBox.Controls.Add(this.oldPassTxtBox);
            this.changePassGroupBox.Controls.Add(this.label5);
            this.changePassGroupBox.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changePassGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.changePassGroupBox.Location = new System.Drawing.Point(10, 74);
            this.changePassGroupBox.Name = "changePassGroupBox";
            this.changePassGroupBox.Size = new System.Drawing.Size(442, 285);
            this.changePassGroupBox.TabIndex = 39;
            this.changePassGroupBox.TabStop = false;
            this.changePassGroupBox.Text = "Change Password";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(227, 225);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(192, 39);
            this.CancelBtn.TabIndex = 22;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.SaveChangesBtn.FlatAppearance.BorderSize = 0;
            this.SaveChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveChangesBtn.ForeColor = System.Drawing.Color.White;
            this.SaveChangesBtn.Location = new System.Drawing.Point(20, 225);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(192, 39);
            this.SaveChangesBtn.TabIndex = 21;
            this.SaveChangesBtn.Text = "Save Changes";
            this.SaveChangesBtn.UseVisualStyleBackColor = false;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // confirmPassTxtBox
            // 
            this.confirmPassTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.confirmPassTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPassTxtBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPassTxtBox.Location = new System.Drawing.Point(6, 181);
            this.confirmPassTxtBox.Name = "confirmPassTxtBox";
            this.confirmPassTxtBox.Size = new System.Drawing.Size(430, 20);
            this.confirmPassTxtBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(6, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cofirm Password";
            // 
            // newPassTxtBox
            // 
            this.newPassTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.newPassTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassTxtBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassTxtBox.Location = new System.Drawing.Point(6, 124);
            this.newPassTxtBox.Name = "newPassTxtBox";
            this.newPassTxtBox.Size = new System.Drawing.Size(430, 20);
            this.newPassTxtBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "New Password";
            // 
            // oldPassTxtBox
            // 
            this.oldPassTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.oldPassTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPassTxtBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldPassTxtBox.Location = new System.Drawing.Point(6, 68);
            this.oldPassTxtBox.Name = "oldPassTxtBox";
            this.oldPassTxtBox.Size = new System.Drawing.Size(430, 20);
            this.oldPassTxtBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Old Password";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.UsernameLbl.Location = new System.Drawing.Point(10, 18);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(0, 37);
            this.UsernameLbl.TabIndex = 40;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 371);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.changePassGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.changePassGroupBox.ResumeLayout(false);
            this.changePassGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox changePassGroupBox;
        private System.Windows.Forms.TextBox confirmPassTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newPassTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oldPassTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveChangesBtn;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Button CancelBtn;
    }
}