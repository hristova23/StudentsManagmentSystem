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
            int grade,
            int numberInClass,
            string Year,
            DateTime enrollmentDate,
            string studentStatus,
            DateTime LastChangeDate)
        {
            if (EGN == ""
                || firstName == ""
                || middleName == ""
                || lastName == ""
                || grade == 0
                || numberInClass == 0
                || Year == ""
                || enrollmentDate == null
                || studentStatus == ""
                || LastChangeDate == null)
            {
                throw new InvalidOperationException("Please, fill all fields");
            }
            if (firstName.Length > DataValidations.NameMaxLength
                || middleName.Length > DataValidations.NameMaxLength
                || lastName.Length > DataValidations.NameMaxLength)
            {
                throw new InvalidOperationException($"Name cannot be more than {DataValidations.NameMaxLength} characters long");
            }
            if (EGN.Length != DataValidations.EGNLength)
            {
                throw new InvalidOperationException($"ID Card Number must be exactly {DataValidations.EGNLength} characters long");
            }
            if (this.data.Students.Any(u => u.EGN == EGN))
            {
                throw new InvalidOperationException($"This ID is already in use");
            }

            StudentStatus status = StudentStatus.Studying;
            switch (studentStatus)
            {
                case "Studying":
                    status = StudentStatus.Studying;
                    break;
                case "Transferred":
                    status = StudentStatus.Transferred;
                    break;
                case "Graduated":
                    status = StudentStatus.Graduated;
                    break;
                case "Expelled":
                    status = StudentStatus.Expelled;
                    break;
                default:
                    status = StudentStatus.Studying;
                    break;
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
                StudentStatus = status,
                LastChangeDate = LastChangeDate
            };
            this.data.Students.Add(student);

            this.data.SaveChanges();
        }

        public void Update(string EGN,
            string firstName,
            string middleName,
            string lastName,
            int grade,
            int numberInClass,
            DateTime enrollmentDate,
            string studentStatus)
        {
            if (firstName == ""
                || middleName == ""
                || lastName == ""
                || grade == 0
                || numberInClass == 0
                || enrollmentDate == null
                || studentStatus == "")
            {
                throw new InvalidOperationException("Please, fill all fields");
            }
            if (firstName.Length > DataValidations.NameMaxLength
                || middleName.Length > DataValidations.NameMaxLength
                || lastName.Length > DataValidations.NameMaxLength)
            {
                throw new InvalidOperationException($"Name cannot be more than {DataValidations.NameMaxLength} characters long");
            }

            StudentStatus status = StudentStatus.Studying;
            switch (studentStatus)
            {
                case "Studying":
                    status = StudentStatus.Studying;
                    break;
                case "Transferred":
                    status = StudentStatus.Transferred;
                    break;
                case "Graduated":
                    status = StudentStatus.Graduated;
                    break;
                case "Expelled":
                    status = StudentStatus.Expelled;
                    break;
                default:
                    status = StudentStatus.Studying;
                    break;
            }

            var currStudent = data.Students.Where(s => s.EGN == EGN).FirstOrDefault();
            if (currStudent == null)
            {
                throw new InvalidProgramException("Cannot alocate this user");
            }

            currStudent.FirstName = firstName;
            currStudent.MiddleName= middleName;
            currStudent.LastName = lastName;
            currStudent.Grade = grade;
            currStudent.NumberInClass = numberInClass;
            currStudent.EnrollmentDate = enrollmentDate;
            currStudent.StudentStatus = status;
            currStudent.LastChangeDate = DateTime.UtcNow;

            this.data.SaveChanges();
        }

        public void Delete(string egn)
        {
            this.data.Students
                .Remove(this.data.Students
                .Where(s => s.EGN == egn)
                .FirstOrDefault());

            data.SaveChanges();
        }

        public List<StudentListingServiceModel> SearchByName(string name)
        {
            if (this.data.Students.Any(s => s.FirstName.ToLower().Contains(name.ToLower())) 
                || this.data.Students.Any(s => s.MiddleName.ToLower().Contains(name.ToLower()))
                || this.data.Students.Any(s => s.LastName.ToLower().Contains(name.ToLower())))
            {
                return this.data.Students
                    .Where(s => s.FirstName.ToLower().Contains(name.ToLower())
                    || s.MiddleName.ToLower().Contains(name.ToLower())
                    || s.LastName.ToLower().Contains(name.ToLower()))
                    .Select(u => new StudentListingServiceModel()
                    {
                        FirstName = u.FirstName,
                        MiddleName = u.MiddleName,
                        LastName = u.LastName,
                        EGN = u.EGN,
                        Grade = u.Grade,
                        NumberInClass = u.NumberInClass,
                        EnrollmentDate = u.EnrollmentDate,
                        Year = u.Year,
                        StudentStatus = u.StudentStatus,
                        LastChangeDate = u.LastChangeDate
                    })
                    .ToList();
            }
            return null;
        }
    }
}
