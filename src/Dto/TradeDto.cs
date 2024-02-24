using System.ComponentModel.DataAnnotations;

namespace WebApi.Dto
{
    public class TradeDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
