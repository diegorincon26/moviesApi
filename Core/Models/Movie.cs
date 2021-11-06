using System;
using System.Collections.Generic;
using moviesApi.Core.Kernel;

namespace moviesApi.Core.Models
{
    public class Movie : Entity
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Poster { get; set; }
        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}