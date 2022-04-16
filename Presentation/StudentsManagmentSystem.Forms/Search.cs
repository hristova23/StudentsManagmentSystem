namespace StudentsManagmentSystem.Forms
{
    using Data;
    using Services.Models;
    using StudentsManagmentSystem.Services.Implementations;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            using var data = new StudentsManagmentSystemDbContext();
            foreach (var student in data.Students)
            {
                var listItem = new StudentListItem(
                    new StudentListingServiceModel()
                    {
                        FirstName = student.FirstName,
                        MiddleName = student.MiddleName,
                        LastName = student.LastName,
                        EGN = student.EGN,
                        Grade = student.Grade,
                        NumberInClass = student.NumberInClass,
                        EnrollmentDate = student.EnrollmentDate,
                        Year = student.Year,
                        StudentStatus = student.StudentStatus,
                        LastChangeDate = student.LastChangeDate
                    });
                flowListingPanel.Controls.Add(listItem);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            flowListingPanel.Controls.Clear();

            using var data = new StudentsManagmentSystemDbContext();
            StudentService studentService = new StudentService(data);

            string str = searchTxtBox.Text.ToLower();

            List<StudentListingServiceModel> matchedStudents = studentService.SearchByName(str);
            if (matchedStudents != null)
            {
                foreach (var student in matchedStudents)
                {
                    var listItem = new StudentListItem(student);
                    flowListingPanel.Controls.Add(listItem);
                }
            }
            else
            {
                flowListingPanel.Controls.Clear();
            }
        }
    }
}
