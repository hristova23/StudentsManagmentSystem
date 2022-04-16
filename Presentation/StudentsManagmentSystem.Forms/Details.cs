namespace StudentsManagmentSystem.Forms
{
    using Data.Models;
    using Services.Models;
    using StudentsManagmentSystem.Data;
    using StudentsManagmentSystem.Services.Implementations;
    using System;
    using System.Windows.Forms;

    public partial class Details : Form
    {
        private StudentListingServiceModel student;

        public Details(StudentListingServiceModel student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void Details_Load(object sender, System.EventArgs e)
        {
            firstNameTxtBox.Text = this.student.FirstName;
            middleNameTxtBox.Text = this.student.MiddleName;
            lastNameTxtBox.Text = this.student.LastName;
            IdTxtBox.Text = this.student.EGN;
            classNumTxtBox.Text = this.student.NumberInClass.ToString();
            classTxtBox.Text = this.student.Grade.ToString();
            dateTxtBox.Text = this.student.EnrollmentDate.ToString("d");
            statusTxtBox.Text = this.student.StudentStatus.ToString();
            LastChangeDateLbl.Text = this.student.LastChangeDate.ToString();
        }

        private void EditBtn_Click(object sender, System.EventArgs e)
        {
            var childForm = new Edit(this.student);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ParentForm.Controls.Add(childForm);
            this.ParentForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void RemoveBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using var data = new StudentsManagmentSystemDbContext();
                    StudentService studentService = new StudentService(data);

                    studentService.Delete(this.student.Id);

                    var childForm = new Search();
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    this.ParentForm.Controls.Add(childForm);
                    this.ParentForm.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                    MessageBox.Show("Successfully Deleted!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
