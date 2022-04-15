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
            Grade grade, 
            int numberInClass,
            string Year, 
            DateTime enrollmentDate,
            StudentStatus studentStatus,
            DateTime LastChangeDate);

        //void Update(string username, string password);
        void Delete(int Id);
        IList<StudentListingServiceModel> SearchByName(string name);
    }
}
