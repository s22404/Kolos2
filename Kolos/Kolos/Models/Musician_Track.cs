using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models
{
    public class Musician_Track
    {
        [Key]
        public int IdTrack  { get; set; }
        [Key]
        public int IdMusician { get; set; }


        
    }
}
