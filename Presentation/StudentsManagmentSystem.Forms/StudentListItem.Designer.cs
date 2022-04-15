
namespace StudentsManagmentSystem.Forms
{
    partial class StudentListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DetailsBtn = new System.Windows.Forms.Button();
            this.ClassNoLbl = new System.Windows.Forms.Label();
            this.ClassLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.MiddleNameLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(117)))));
            this.DetailsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DetailsBtn.FlatAppearance.BorderSize = 0;
            this.DetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DetailsBtn.ForeColor = System.Drawing.Color.White;
            this.DetailsBtn.Location = new System.Drawing.Point(340, 3);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(75, 21);
            this.DetailsBtn.TabIndex = 12;
            this.DetailsBtn.Text = "Details";
            this.DetailsBtn.UseVisualStyleBackColor = false;
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
            // 
            // ClassNoLbl
            // 
            this.ClassNoLbl.AutoSize = true;
            this.ClassNoLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassNoLbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassNoLbl.Location = new System.Drawing.Point(292, 3);
            this.ClassNoLbl.Margin = new System.Windows.Forms.Padding(3);
            this.ClassNoLbl.Name = "ClassNoLbl";
            this.ClassNoLbl.Size = new System.Drawing.Size(42, 21);
            this.ClassNoLbl.TabIndex = 11;
            this.ClassNoLbl.Text = "№ 5";
            // 
            // ClassLbl
            // 
            this.ClassLbl.AutoSize = true;
            this.ClassLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassLbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassLbl.Location = new System.Drawing.Point(248, 3);
            this.ClassLbl.Margin = new System.Windows.Forms.Padding(3);
            this.ClassLbl.Name = "ClassLbl";
            this.ClassLbl.Size = new System.Drawing.Size(38, 21);
            this.ClassLbl.TabIndex = 10;
            this.ClassLbl.Text = "11b";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNameLbl.Location = new System.Drawing.Point(168, 3);
            this.LastNameLbl.Margin = new System.Windows.Forms.Padding(3);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(74, 21);
            this.LastNameLbl.TabIndex = 9;
            this.LastNameLbl.Text = "Hristova";
            // 
            // MiddleNameLbl
            // 
            this.MiddleNameLbl.AutoSize = true;
            this.MiddleNameLbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MiddleNameLbl.Location = new System.Drawing.Point(88, 3);
            this.MiddleNameLbl.Margin = new System.Windows.Forms.Padding(3);
            this.MiddleNameLbl.Name = "MiddleNameLbl";
            this.MiddleNameLbl.Size = new System.Drawing.Size(74, 21);
            this.MiddleNameLbl.TabIndex = 8;
            this.MiddleNameLbl.Text = "Hristova";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLbl.Location = new System.Drawing.Point(3, 3);
            this.FirstNameLbl.Margin = new System.Windows.Forms.Padding(3);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(79, 21);
            this.FirstNameLbl.TabIndex = 7;
            this.FirstNameLbl.Text = "Victoriya";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FirstNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.MiddleNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.LastNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.ClassLbl);
            this.flowLayoutPanel1.Controls.Add(this.ClassNoLbl);
            this.flowLayoutPanel1.Controls.Add(this.DetailsBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(419, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // StudentListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StudentListItem";
            this.Size = new System.Drawing.Size(419, 31);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DetailsBtn;
        private System.Windows.Forms.Label ClassNoLbl;
        private System.Windows.Forms.Label ClassLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label MiddleNameLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
