using System;

namespace moviesApi.Core.DTOs
{
    public class MovieHeader
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Poster { get; set; }
    }
}