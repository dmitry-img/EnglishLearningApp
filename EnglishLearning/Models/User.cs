using System.ComponentModel.DataAnnotations;

namespace EnglishLearning.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
