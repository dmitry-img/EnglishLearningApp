using System.ComponentModel.DataAnnotations;

namespace EnglishLearning.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        public string CourseShareCode { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<WordsPair> WordsPairs { get; set; }
    }
}
