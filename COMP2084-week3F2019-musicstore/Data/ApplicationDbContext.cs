using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using COMP2084_week3F2019_musicstore.Models;

namespace COMP2084_week3F2019_musicstore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<COMP2084_week3F2019_musicstore.Models.Song> Song { get; set; }
    }
}
