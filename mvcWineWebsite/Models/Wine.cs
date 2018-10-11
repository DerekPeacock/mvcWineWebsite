using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcWineWebsite.Models
{
    public class Wine
    {
        public int WineID { get; set; }

        [StringLength(50), Required]
        public string Name { get; set; }

        [StringLength(50), Required]
        public string Vineyard { get; set; }

        [StringLength(1024), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [StringLength(128), DataType(DataType.Url)]
        public string ImageURL { get; set; }

        [Required, Range(5, 100)]
        public decimal BottlePrice { get; set; }

        public decimal CasePrice { get; set; }

        [StringLength(20)]
        public string Grape { get; set; }
    }
}