using Microsoft.AspNetCore.Components;
using ShearedModel;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.Services
{

    public interface IAlbumService
    {
        Task<IEnumerable<AlbumDto>> GetAll();
        Task<AlbumDto>Get(int Id);
    }
    public class AlbumService : IAlbumService
    {
        private readonly HttpClient httpClient;
        public AlbumService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<AlbumDto> Get(int id)
        {
            var data = await httpClient.GetJsonAsync<AlbumDto>($"api/musicstore/{id}");
            return data;
        }

        public async Task<IEnumerable<AlbumDto>> GetAll()
        {
            var data = await httpClient.GetJsonAsync<AlbumDto[]>("api/musicstore");
            return data;
        }
    }

}
