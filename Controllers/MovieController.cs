using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using moviesApi.Core;
using moviesApi.Core.DTOs;
using moviesApi.Core.Models;
using moviesApi.Persistence;

namespace moviesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IRepository<Movie> _repositoryMovie;
        private readonly IMapper _mapper;

        public MovieController(IRepository<Movie> repositoryMovie, IMapper mapper)
        {
            _repositoryMovie = repositoryMovie;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var movie = await _repositoryMovie.GetByIdAsync(id);
                var result = _mapper.Map<Movie, MovieDetail>(movie);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.Message);
            }
        }

        [HttpGet("page/{page}/pageSize/{pageSize}")]
        public async Task<IActionResult> GetByPaging(byte page, byte pageSize)
        {
            try
            {
                var queryParameters = new QueryParameters()
                {
                    Page = page,
                    PageSize = pageSize
                };

                var movies = await _repositoryMovie.GetByPagingAsync(queryParameters);
                var result = _mapper.Map<QueryResult<Movie>, QueryResult<MovieHeader>>(movies);

                return Ok(result);

            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.Message);
            }
        }

        [HttpGet("page/{page}/pageSize/{pageSize}/keyword/{keyword}")]
        public async Task<IActionResult> GetByKeywordWithPaging(int page, byte pageSize, string keyword)
        {
            try
            {
                keyword = keyword.ToLower();

                var queryParameters = new QueryParameters()
                {
                    Page = page,
                    PageSize = pageSize
                };

                var movies = await _repositoryMovie.SearchForAsync(m => m.Title.ToLower().Contains(keyword) ||
                                                                         m.Genre.ToLower().Contains(keyword) ||
                                                                         m.MovieActors.Any(ma => ma.Actor.Name.ToLower().Contains(keyword)),
                                                                    queryParameters);

                var results = _mapper.Map<QueryResult<Movie>, QueryResult<MovieHeader>>(movies);

                return Ok(results);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.Message);
            }
        }
    }
}