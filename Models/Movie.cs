using System.ComponentModel.DataAnnotations;

namespace Mission06_Summerill.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; } = string.Empty;

        [Required]
        public string Rating { get; set; } = string.Empty;

        // optional
        public bool? Edited { get; set; }

        // optional
        public string? LentTo { get; set; }

        // optional, max 25 characters
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
