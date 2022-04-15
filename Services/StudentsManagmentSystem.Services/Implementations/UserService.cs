namespace StudentsManagmentSystem.Services.Implementations
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Security.Cryptography;

    using Data;
    using Data.Models;
    using StudentsManagmentSystem.Services.Models;

    public class UserService : IUserService
    {
        private readonly StudentsManagmentSystemDbContext data;

        public UserService(StudentsManagmentSystemDbContext data)
        {
            this.data = data;
        }

        public void Create(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new InvalidOperationException("Please, fill all fields");
            }
            if (this.data.Users.Any(u => u.Username == username))
            {
                throw new InvalidOperationException($"This username is already in use");
            }
            if (username.Length > DataValidations.NameMaxLength
                || password.Length > DataValidations.PasswordMaxLength
                || password.Length < DataValidations.PasswordMinLength)
            {
                throw new InvalidOperationException($"Password must be between {DataValidations.PasswordMinLength} and {DataValidations.PasswordMaxLength} characters long");
            }

            User user = new User
            {
                Username = username,
                Password = HashPassword(password)
            };
            this.data.Users.Add(user);

            this.data.SaveChanges();
        }

        public void UpdatePassword(UserListingServiceModel user, string oldPassword, string newPassword, string confirmPassword)
        {
            if (oldPassword == "" || newPassword == "" || confirmPassword == "")
            {
                throw new InvalidOperationException("Please, fill all fields");
            }
            if (user.Password != HashPassword(oldPassword))
            {
                throw new InvalidOperationException("Invalid old password");
            }
            if (newPassword != confirmPassword)
            {
                throw new InvalidOperationException("Passwords must match");
            }
            if (newPassword.Length > DataValidations.PasswordMaxLength
                || newPassword.Length < DataValidations.PasswordMinLength)
            {
                throw new InvalidOperationException($"Passwords must be between {DataValidations.PasswordMinLength} and {DataValidations.PasswordMaxLength} characters long");
            }
            if (oldPassword == newPassword)
            {
                throw new InvalidOperationException("New password cannot be the same as old password");
            }

            var currUser = data.Users.Where(b => b.Username == user.Username).FirstOrDefault();

            currUser.Password = HashPassword(newPassword);

            this.data.SaveChanges();
        }

        public string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var asBytes = Encoding.Default.GetBytes(password);
            var passwordHash = sha.ComputeHash(asBytes);
            return Convert.ToBase64String(passwordHash);
        }

        public UserListingServiceModel SearchByUsername(string username)
        {
            if (this.data.Users.Any(u => u.Username == username))
            {
                return this.data.Users
                    .Where(u => u.Username == username)
                    .Select(u => new UserListingServiceModel
                    {
                        Id = u.Id,
                        Username = u.Username,
                        Password = u.Password
                    })
                    .FirstOrDefault();
            }
            return null;
        }
    }
}
