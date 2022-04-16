namespace StudentsManagmentSystem.Services.Models
{
    using System;
    using Data.Models;

    public class StudentListingServiceModel
    {
        public int Id { get; set; }
        public string EGN { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int NumberInClass { get; set; }
        public string Year { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public StudentStatus StudentStatus { get; set; }
        public DateTime LastChangeDate { get; set; }
    }
}
