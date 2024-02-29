using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dot.Net.WebApi.Domain
{
    public class Trade
    {
        public int TradeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Account { get; set; }

        [Required]
        public double BuyQuantity { get; set; }

        [Required]
        public double SellQuantity   { get; set; }

        [Required]
        public double BuyPrice   { get; set; }

        [Required]
        public double SellPrice { get; set; }

        [Required]
        [MaxLength(50)]
        public string Benchmark  { get; set;}

        [Required]
        public DateTime TradeDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Security { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status  { get; set; }

        [MaxLength(20)]
        [Required]
        public string Trader { get; set; }

        [Required]
        [MaxLength(50)]
        public string Book  { get; set; }

        [Required]
        [MaxLength(50)]
        public string CreationName { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string RevisionName { get; set; }
        [Required]
        public DateTime RevisionDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string DealName { get; set; }
        [Required]
        [MaxLength(50)]
        public string DealType { get; set; }
        [Required]  
        public string SourceListId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Side { get; set; }


    }
}