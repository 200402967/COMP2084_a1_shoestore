using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_week3F2019_musicstore.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }


        [ForeignKey("Genre")]
        public int GenreId { get; set; }

        public string Name { get; set; }
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }

        public ICollection<Song>Songs {get; set;}



}
}
