namespace StudentsManagmentSystem.Forms
{
    using System;
    using System.Windows.Forms;
    using Services.Models;
    using StudentsManagmentSystem.Data;
    using StudentsManagmentSystem.Data.Models;
    using StudentsManagmentSystem.Services.Implementations;

    public partial class Edit : Form
    {
        private StudentListingServiceModel student;

        public Edit(StudentListingServiceModel student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            Edit_Load(sender,e);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var firstName = firstNameTxtBox.Text;
            var middleName = middleNameTxtBox.Text;
            var lastName = lastNameTxtBox.Text;
            var idCardNumber = IdTxtBox.Text;
            var clas = classNumUpDown.Value;
            var numberInClass = numNumUpDown.Value;
            var enrollmentDate = dateTimePicker.Value;
            var status = statusComboBox.SelectedItem;

            try
            {
                using var data = new StudentsManagmentSystemDbContext();
                var studentService = new StudentService(data);

                studentService.Update(this.student.Id,
                    firstName,
                    middleName,
                    lastName,
                    (int)clas,
                    (int)numberInClass,
                    enrollmentDate,
                    status.ToString());

                MessageBox.Show("You have successfully updated this student's information!");
                Edit_Load(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(StudentStatus)))
            {
                if (!statusComboBox.Items.Contains(item))
                {
                    statusComboBox.Items.Add(item);
                }
            }
            firstNameTxtBox.Text = this.student.FirstName;
            middleNameTxtBox.Text = this.student.MiddleName;
            lastNameTxtBox.Text = this.student.LastName;
            IdTxtBox.Text = this.student.EGN;
            numNumUpDown.Value = this.student.NumberInClass;
            classNumUpDown.Value = this.student.Grade;
            dateTimePicker.Value = this.student.EnrollmentDate;
            statusComboBox.SelectedItem = this.student.StudentStatus;
            LastChangeDateLbl.Text = this.student.LastChangeDate.ToString();
        }
    }
}
