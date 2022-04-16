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

        //void Update(string username, string password);
        void Delete(int Id);
        List<StudentListingServiceModel> SearchByName(string name);
    }
}
