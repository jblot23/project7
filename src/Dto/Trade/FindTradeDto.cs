using System.ComponentModel.DataAnnotations;

namespace WebApi.Dto.Trade
{
    public class FindTradeDto
    {
        [Required]
        public int Id { get; set; }
    }
}
