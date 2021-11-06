using System.Linq;
using AutoMapper;
using moviesApi.Core.DTOs;
using moviesApi.Core.Models;
using moviesApi.Persistence;

namespace moviesApi.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Generic query result. Used for get all method
            CreateMap(typeof(QueryResult<>), typeof(QueryResult<>));

            CreateMap<Movie, MovieHeader>();
            CreateMap<Movie, MovieDetail>()
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.MovieActors.Select(ma => ma.Actor.Name)));
        }
    }
}