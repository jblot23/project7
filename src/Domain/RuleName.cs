using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain
{
    public class RuleName
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Json { get; set; }

        [Required]
        [MaxLength(50)]
        public string Template { get; set; }

        [Required]
        [MaxLength(50)]
        public string SqlStr { get; set; }

        [Required]
        [MaxLength(50)]
        public string SqlPart { get; set; }

    }
}
