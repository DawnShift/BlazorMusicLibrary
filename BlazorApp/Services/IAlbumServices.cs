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
        Task<AlbumDto>Get(int id);
        Task<AlbumDto> Update(AlbumDto model);
    }
    public class AlbumService : IAlbumService
    {
        private readonly HttpClient httpClient;
        public AlbumService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<AlbumDto> Get(int id)=> await httpClient.GetJsonAsync<AlbumDto>($"api/album/{id}");

        public async Task<IEnumerable<AlbumDto>> GetAll() => await httpClient.GetJsonAsync<AlbumDto[]>("api/album"); 
        public async Task<AlbumDto> Update(AlbumDto model) => await httpClient.PutJsonAsync<AlbumDto>("api/album/UpdateAlbum",model);
         
    }

}
