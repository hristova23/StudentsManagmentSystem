namespace StudentsManagmentSystem.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Data.Models;
    using Data;
    using Services.Implementations;

    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
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
                studentService.Create(idCardNumber,
                    firstName,
                    middleName,
                    lastName,
                    (int)clas,
                    (int)numberInClass,
                    $"{DateTime.UtcNow.Year}/{DateTime.UtcNow.Year+1}",
                    enrollmentDate,
                    status.ToString(),
                    DateTime.UtcNow);

                ClearForm(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            ClearForm(sender, e);
            dateTimePicker.Value = DateTime.UtcNow;
            foreach (var item in Enum.GetValues(typeof(StudentStatus)))
            {
                if (!statusComboBox.Items.Contains(item))
                {
                    statusComboBox.Items.Add(item);
                }
            }
            statusComboBox.SelectedIndex = 0;
        }

        public void ClearForm(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in this.Controls.OfType<TextBox>())
            {
                txtBox.Clear();
            }
        }
    }
}
