using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models
{
    public class Track
    {
        [Key]
        public int IdTrack { get; set; }
        [MaxLength(20)]
        public String TrackName { get; set; }
        public float Duration { get; set; }
        [Required]
        public ICollection<Album> IdMusicAlbum { get; set; }
        public ICollection<Musician_Track> Musician_Track { get; set; }
    }
}
