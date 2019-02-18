using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string sex { get; set; }
        public DateTime Dob { get; set; }
        public string Bio { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
