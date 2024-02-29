using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dot.Net.WebApi.Domain
{
    public class BidList
    {
        public int Id { get; set; }

        [Required]
        public int BidListId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Account { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        [Required]
        public double BidQuantity { get; set; }

        [Required]
        public double AskQuantity { get; set; }

        [Required]
        public double Bid { get; set; }

        [Required]
        public double Ask { get; set; }

        [Required]
        [MaxLength(50)]
        public string Benchmark { get; set; }

        [Required]
        [MaxLength(50)]
        public DateTime BidListDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Commentary { get; set; }

        [Required]
        [MaxLength(50)]
        public string Security { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string Trader { get; set; }

        [Required]
        [MaxLength(50)]
        public string Book { get; set; }

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
        [MaxLength(50)]
        public string SourceListId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Side { get; set; }
    }
}