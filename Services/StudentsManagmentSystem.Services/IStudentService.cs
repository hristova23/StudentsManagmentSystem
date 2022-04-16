namespace StudentsManagmentSystem.Services
{
    using System;
    using System.Collections.Generic;

    using Models;
    using Data.Models;

    public interface IStudentService
    {
        void Create(string EGN, 
            string firstName,
            string middleName,
            string lastName, 
            int grade, 
            int numberInClass,
            string Year, 
            DateTime enrollmentDate,
            string studentStatus,
            DateTime LastChangeDate);

        void Update(string EGN,
            string firstName,
            string middleName,
            string lastName,
            int grade,
            int numberInClass,
            DateTime enrollmentDate,
            string studentStatus);

        void Delete(string egn);
        List<StudentListingServiceModel> SearchByName(string name);
    }
}
