using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP2084_week3F2019_musicstore.Models;

namespace COMP2084_week3F2019_musicstore.Models
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext (DbContextOptions<MusicStoreContext> options)
            : base(options)
        {
        }

        public DbSet<COMP2084_week3F2019_musicstore.Models.Genre> Genre { get; set; }

        public DbSet<COMP2084_week3F2019_musicstore.Models.Album> Album { get; set; }

        public DbSet<COMP2084_week3F2019_musicstore.Models.Song> Song { get; set; }
    }
}
