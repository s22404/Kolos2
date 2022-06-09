using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models
{
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        [MaxLength(30)]
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public ICollection<MusicLabel> IdMusicLabel { get; set; }
        public int IdTrack { get; set; }
        [ForeignKey("IdTrack")]
        public Track tracl { get; set; }


    }
}
