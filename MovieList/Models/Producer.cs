using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList.Models
{
    public class Producer
    {
        public int MovieId { get; set; }
        public int producerId { get; set; }
        public string Name { get; set; }
        public string sex { get; set; }
        public DateTime Dob { get; set; }
        public string Bio { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
