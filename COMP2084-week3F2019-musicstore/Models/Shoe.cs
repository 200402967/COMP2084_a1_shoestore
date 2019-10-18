using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_a1_shoestore.Models
{
    public class Shoe
    {
        [Key]
        public int ShoeId { get; set; }

        [ForeignKey("ShoeType")]
        public int ShoeTypeId { get; set; }

        public string ShoeName { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }

        public int Size { get; set; }

    
}
}
