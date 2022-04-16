namespace StudentsManagmentSystem.Forms
{
    using System;
    using System.Windows.Forms;
    using Services.Models;

    public partial class StudentListItem : UserControl
    {
        private StudentListingServiceModel student;
        public StudentListItem(StudentListingServiceModel student)
        {
            this.student = student;
            InitializeComponent();

            FirstNameLbl.Text = this.student.FirstName;
            MiddleNameLbl.Text = this.student.MiddleName;
            LastNameLbl.Text = this.student.LastName;
            ClassLbl.Text = this.student.Grade.ToString();
            ClassNoLbl.Text = this.student.NumberInClass.ToString();
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            var childForm = new Details(this.student);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ParentForm.Controls.Add(childForm);
            this.ParentForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
