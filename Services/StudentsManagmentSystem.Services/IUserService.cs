namespace StudentsManagmentSystem.Services
{
    using Models;

    public interface IUserService
    {
        void Create(string username, string password);
        void UpdatePassword(UserListingServiceModel user, string oldPassword, string newPassword, string confirmPassword);
        string HashPassword(string password);
        UserListingServiceModel SearchByUsername(string username);
    }
}
