
namespace StudentsManagmentSystem.Forms
{
    partial class Edit
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
            this.LastChangeDateLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.numNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.classNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.middleNameTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LastChangeDateLbl
            // 
            this.LastChangeDateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastChangeDateLbl.AutoSize = true;
            this.LastChangeDateLbl.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastChangeDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.LastChangeDateLbl.Location = new System.Drawing.Point(96, 294);
            this.LastChangeDateLbl.Name = "LastChangeDateLbl";
            this.LastChangeDateLbl.Size = new System.Drawing.Size(0, 17);
            this.LastChangeDateLbl.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.label9.Location = new System.Drawing.Point(12, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Last change: ";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(239, 318);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(213, 37);
            this.CancelBtn.TabIndex = 42;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(12, 318);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(213, 37);
            this.SaveBtn.TabIndex = 31;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // numNumUpDown
            // 
            this.numNumUpDown.Location = new System.Drawing.Point(53, 250);
            this.numNumUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumUpDown.Name = "numNumUpDown";
            this.numNumUpDown.Size = new System.Drawing.Size(38, 23);
            this.numNumUpDown.TabIndex = 98;
            this.numNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // classNumUpDown
            // 
            this.classNumUpDown.Location = new System.Drawing.Point(187, 250);
            this.classNumUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.classNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.classNumUpDown.Name = "classNumUpDown";
            this.classNumUpDown.Size = new System.Drawing.Size(38, 23);
            this.classNumUpDown.TabIndex = 97;
            this.classNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker.Location = new System.Drawing.Point(241, 206);
            this.dateTimePicker.MaxDate = new System.DateTime(9888, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1888, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(213, 23);
            this.dateTimePicker.TabIndex = 96;
            this.dateTimePicker.Value = new System.DateTime(2022, 4, 16, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(241, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 28);
            this.label5.TabIndex = 95;
            this.label5.Text = "Enrollment Date";
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.IdTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTxtBox.Location = new System.Drawing.Point(241, 71);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.ReadOnly = true;
            this.IdTxtBox.Size = new System.Drawing.Size(213, 22);
            this.IdTxtBox.TabIndex = 94;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(241, 136);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(213, 23);
            this.statusComboBox.TabIndex = 93;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lastNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTxtBox.Location = new System.Drawing.Point(11, 210);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(213, 22);
            this.lastNameTxtBox.TabIndex = 92;
            // 
            // middleNameTxtBox
            // 
            this.middleNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.middleNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.middleNameTxtBox.Location = new System.Drawing.Point(11, 138);
            this.middleNameTxtBox.Name = "middleNameTxtBox";
            this.middleNameTxtBox.Size = new System.Drawing.Size(213, 22);
            this.middleNameTxtBox.TabIndex = 91;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.firstNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTxtBox.Location = new System.Drawing.Point(12, 71);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(213, 22);
            this.firstNameTxtBox.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.label10.Location = new System.Drawing.Point(241, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 30);
            this.label10.TabIndex = 89;
            this.label10.Text = "ID Card Number";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.label8.Location = new System.Drawing.Point(241, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 88;
            this.label8.Text = "Status";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 28);
            this.label6.TabIndex = 87;
            this.label6.Text = "№";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(124, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 28);
            this.label4.TabIndex = 86;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(9, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 85;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 84;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "First Name";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 371);
            this.Controls.Add(this.numNumUpDown);
            this.Controls.Add(this.classNumUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdTxtBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.middleNameTxtBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.LastChangeDateLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastChangeDateLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.NumericUpDown numNumUpDown;
        private System.Windows.Forms.NumericUpDown classNumUpDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.TextBox middleNameTxtBox;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}