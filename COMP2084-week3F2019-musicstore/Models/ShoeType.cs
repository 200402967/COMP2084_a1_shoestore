using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_a1_shoestore.Models
{
    public class ShoeType
    {
        [Key]
        public int ShoeTypeId { get; set; }


        [ForeignKey("Footwear")]
        public int FootwearId { get; set; }

        public string Name { get; set; }
        public string Brand { get; set; }
        public DateTime ReleaseDate { get; set; }

        public ICollection<Shoe>Shoes {get; set;}

        internal static void Add(ShoeType shoeType)
        {
            throw new NotImplementedException();
        }
    }
}
