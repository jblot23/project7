using System.ComponentModel.DataAnnotations;

namespace WebApi.Dto.Rating
{
    public class RatingDto
    {
        [Required]
        public string MoodysRating { get; set; }
        [Required]
        public string SandPRating { get; set; }
        [Required]
        public string FitchRating { get; set; }
        [Required]
        public int OrderNumber { get; set; }
    }
}
