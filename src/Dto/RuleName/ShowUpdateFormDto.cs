using System.ComponentModel.DataAnnotations;

namespace WebApi.Dto.RuleName
{
    public class ShowUpdateFormDto
    {
        [Required]
        public int Id { get; set; }
    }
}
