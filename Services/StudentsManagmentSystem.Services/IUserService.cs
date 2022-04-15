namespace StudentsManagmentSystem.Services
{
    using Models;

    public interface IUserService
    {
        void Create(string username, string password);
        string HashPassword(string password);
        UserListingServiceModel SearchByUsername(string username);
    }
}
