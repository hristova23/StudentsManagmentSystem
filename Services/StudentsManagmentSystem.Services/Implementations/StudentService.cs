namespace StudentsManagmentSystem.Services.Implementations
{
    using System;
    using System.Linq;

    using Data;
    using Data.Models;
    using StudentsManagmentSystem.Services.Models;
    using System.Collections.Generic;

    public class StudentService : IStudentService
    {
        private readonly StudentsManagmentSystemDbContext data;

        public StudentService(StudentsManagmentSystemDbContext data)
        {
            this.data = data;
        }

        public void Create(string EGN,
            string firstName,
            string middleName,
            string lastName,
            Grade grade, 
            int numberInClass,
            string Year,
            DateTime enrollmentDate,
            StudentStatus studentStatus,
            DateTime LastChangeDate)
        {
            if (EGN == "" 
                || firstName== ""
                || middleName== ""
                || lastName== ""
                || grade == ""
                || numberInClass == null
                || Year == ""
                || enrollmentDate == null
                || studentStatus == ""
                || LastChangeDate == null)
            {
                throw new InvalidOperationException("Please, fill all fields");
            }
            if (this.data.Students.Any(u => u.EGN == EGN))
            {
                throw new InvalidOperationException($"This ID is already in use");
            }
            if (username.Length > DataValidations.NameMaxLength
                || password.Length > DataValidations.PasswordMaxLength
                || password.Length < DataValidations.PasswordMinLength)
            {
                throw new InvalidOperationException($"Password must be between {DataValidations.PasswordMinLength} and {DataValidations.PasswordMaxLength} characters long");
            }

            Student student = new Student
            {
                EGN = EGN,
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Grade = grade,
                NumberInClass = numberInClass,
                Year = Year,
                EnrollmentDate = enrollmentDate,
                StudentStatus = studentStatus,
                LastChangeDate = LastChangeDate
            };
            this.data.Students.Add(student);

            this.data.SaveChanges();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<StudentListingServiceModel> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
