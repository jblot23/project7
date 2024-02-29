using System.ComponentModel.DataAnnotations;

namespace WebApi.Dto.CurvePoint
{
    public class DeleteCurvePoint
    {
        [Required]
        public int Id { get; set; }
    }
}
