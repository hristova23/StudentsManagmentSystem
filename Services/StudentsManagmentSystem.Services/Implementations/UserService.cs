﻿namespace StudentsManagmentSystem.Services.Implementations
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
