namespace StudentsManagmentSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataValidation;

    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(UsernameMaxLength)]
        public string Username { get; set; }

        [Required]
        //MaxLength?
        public string Password { get; set; }
    }
}
