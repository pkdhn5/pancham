using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public int producerId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string plot { get; set; }
        public DateTime yearofRealse { get; set; }
        public string poster { get; set; }
        
        public Producer producer { get; set; }
        public ICollection<Actor> Actors { get; set; }
    }
}
