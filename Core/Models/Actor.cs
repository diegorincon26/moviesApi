using System;
using System.Collections.Generic;
using moviesApi.Core.Kernel;

namespace moviesApi.Core.Models
{
    public class Actor : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}