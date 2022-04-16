namespace StudentsManagmentSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataValidations;

    public class Student
    {
        public int Id { get; set; }// id 

        [Required]
        [MaxLength(EGNLength)]
        public string EGN { get; set; }// ЕГН

        [Required]
        [MaxLength(NameMaxLength)]
        public string FirstName { get; set; }// име

        [Required]
        [MaxLength(NameMaxLength)]
        public string MiddleName { get; set; }// презиме

        [Required]
        [MaxLength(NameMaxLength)]
        public string LastName { get; set; }// фамилия

        [Required]
        public int Grade { get; set; }// клас

        [Required]
        [Range(1, LastNumberInClass)]
        public int NumberInClass { get; set; }// номер в клас //new

        [Required]
        [MaxLength(YearLength)]
        public string Year { get; set; }// учебна година //new

        [Required]
        public DateTime EnrollmentDate { get; set; }// дата и година на записване в училище

        [Required]
        public StudentStatus StudentStatus { get; set; }// учащ/завършил/преместен/изгонен //new

        [Required]
        public DateTime LastChangeDate { get; set; }// последна промяна
    }
}
