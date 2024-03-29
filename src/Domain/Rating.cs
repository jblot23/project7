using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dot.Net.WebApi.Controllers.Domain
{
    public class Rating
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string MoodysRating { get; set; }

        [Required]
        [MaxLength(50)]
        public string SandPRating { get; set; }

        [Required]
        [MaxLength(50)]
        public string FitchRating { get; set; }

        [Required]
        public int OrderNumber { get; set; }

    }
}