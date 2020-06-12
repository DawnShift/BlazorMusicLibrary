using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MusicStoreBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        public FilesController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }
        // GET: api/Files
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Files/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Files
        [HttpPost]
        public async Task<string> Post()
        {
            try
            {
                string result = string.Empty;
                if (HttpContext.Request.Form.Files.Any())
                { 
                    foreach (var file in HttpContext.Request.Form.Files)
                    {
                        result = $"images/AlbumArt/{Guid.NewGuid():N}_{file.FileName}";
                        var path = Path.Combine(environment.WebRootPath, result);
                        using var stream = new FileStream(path, FileMode.Create);
                        await file.CopyToAsync(stream);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/Files/5
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
