using System.ComponentModel.DataAnnotations;

namespace EnglishLearning.Models
{
    public class WordsPair
    {
        [Key]
        public int WordsPairId { get; set; }
        [Required]
        public string OriginalWord { get; set; }
        [Required]
        public string Definition { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
