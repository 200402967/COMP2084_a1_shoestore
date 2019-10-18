using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP2084_a1_shoestore.Models;

namespace COMP2084_a1_shoestore.Models
{
    public class ShoeStoreContext : DbContext
    {
        public ShoeStoreContext (DbContextOptions<ShoeStoreContext> options)
            : base(options)
        {
        }

        public DbSet<COMP2084_a1_shoestore.Models.Footwear> Footwear { get; set; }

        public DbSet<COMP2084_a1_shoestore.Models.ShoeType> ShoeType { get; set; }

        public DbSet<COMP2084_a1_shoestore.Models.Shoe> Shoe { get; set; }
    }
}
