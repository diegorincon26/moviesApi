using System;

namespace moviesApi.Core.Kernel
{
    public class Entity : IEntity
    {
        public Entity()
        {

        }

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}