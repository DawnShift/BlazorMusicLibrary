using Microsoft.AspNetCore.Components;
using ShearedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.Services
{


    public interface IArtistServices
    {
        Task<IEnumerable<ArtistDto>> GetAll();
        Task<ArtistDto> Get(int id);
    }
    public class ArtistServices : IArtistServices
    {
        private readonly HttpClient httpClient;

        public ArtistServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ArtistDto> Get(int id) => await httpClient.GetJsonAsync<ArtistDto>($"api/artist/{id}");

       

        public async Task<IEnumerable<ArtistDto>> GetAll() => await httpClient.GetJsonAsync<ArtistDto[]>("api/artist");


    }

}
