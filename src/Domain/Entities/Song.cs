using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public Album Album { get; set; }
        public TimeSpan Duration { get; set; }
        public string Genre { get; set; }
    }

}
