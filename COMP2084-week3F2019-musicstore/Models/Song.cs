using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_week3F2019_musicstore.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        [ForeignKey("Album")]
        public int AlbumId { get; set; }

        public string SongName { get; set; }

        public string ArtistName { get; set; }

        public string Featuring { get; set; }

    public int RunTimeSeconds { get; set; }

    
}
}
