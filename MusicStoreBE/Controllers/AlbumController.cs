using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using MusicStoreDataStore.Interfaces;
using MusicStoreDataStore.Models;
using ShearedModel;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicStoreBE.Controllers
{
    [Route("api/[controller]")]
    public class AlbumController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRepository<Album> albumRepo;

        public AlbumController(IMapper _mapper, IRepository<Album> _albumRepo)
        {
            mapper = _mapper;
            albumRepo = _albumRepo;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<AlbumDto> Get() => mapper.Map<IEnumerable<AlbumDto>>
                                              (albumRepo.GetAll());

        //[HttpGet("Search/{Search}")]
        //public IEnumerable<AlbumDto> SearchAlbum(string search)
        //{
        //    throw new NotImplementedException();
        //}

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public AlbumDto Get(int id)
        {
            var result = albumRepo.FilteredGetAll().Include(x => x.Artist)
                               .Where(x => x.Id == id).SingleOrDefault();
            var data = mapper.Map<AlbumDto>(result);
            return data;
        }

        [Route("UpdateAlbum")]
        [HttpPut]
        public AlbumDto Update([FromBody] AlbumDto model)
        {
            var album = mapper.Map<Album>(model);
            albumRepo.Update(album);
            return mapper.Map<AlbumDto>(album);
        }
        // POST api/<controller>
        [HttpPost]
        public AlbumDto Post([FromBody] AlbumDto model)
        {
            var data = mapper.Map<Album>(model);
            albumRepo.Insert(data);
            return mapper.Map<AlbumDto>(data);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
