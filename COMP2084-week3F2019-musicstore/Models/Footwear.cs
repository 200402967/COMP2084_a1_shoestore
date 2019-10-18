using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_a1_shoestore.Models
{
    public class Footwear
    {
        [Key]

        
        public int FootwearId { get; set; }

        public string Name { get; set; }

        public ICollection<ShoeType> ShoeType { get; set; }
    }
}
