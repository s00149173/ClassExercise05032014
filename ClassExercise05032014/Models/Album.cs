using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassExercise05032014.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }

        public virtual ICollection<Track> tracks { get; set; }
    }
}