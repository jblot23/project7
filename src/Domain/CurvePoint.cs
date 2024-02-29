using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dot.Net.WebApi.Domain
{
    public class CurvePoint
    {
        public int Id { get; set; }
        [Required]
        public int CurveId { get; set; }
        [Required]
        public DateTime AsOfDate { get; set; }
        [Required]
        public double Term { get; set; }
        [Required]
        public double Value { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }

    }
}