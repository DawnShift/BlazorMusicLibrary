using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStoreDataStore.Interfaces;
using MusicStoreDataStore.Models;
using ShearedModel;
using System.Collections.Generic;
using System.Linq;

namespace MusicStoreBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRepository<Artist> repository;

        public ArtistController(IMapper _mapper, IRepository<Artist> _repository)
        {
            mapper = _mapper;
            repository = _repository;
        }
        // GET: api/Artist
        [HttpGet]
        public IEnumerable<ArtistDto> Get() => mapper.Map<IEnumerable<ArtistDto>>
                                                     (repository.GetAll());

        // GET: api/Artist/5
        [HttpGet("{id}")]
        public ArtistDto Get(int id)
        {
            var result = repository.FilteredGetAll().Include(x => x.Albums)
                            .Where(x => x.Id == id).SingleOrDefault();
            var data = mapper.Map<ArtistDto>(result);
            return data;
        }

        // POST: api/Artist
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Artist/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
