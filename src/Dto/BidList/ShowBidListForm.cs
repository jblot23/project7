using System.ComponentModel.DataAnnotations;

namespace WebApi.Dto.BidList
{
    public class ShowBidListForm
    {
        [Required]
        public int Id { get; set; }
    }
}
