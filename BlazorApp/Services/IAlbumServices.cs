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
    }
    public class AlbumService : IAlbumService
    {
        private readonly HttpClient httpClient;
        public AlbumService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<AlbumDto>> GetAll()
        {
            return await httpClient.GetJsonAsync<AlbumDto[]>("api/musicstore");
        }
    }

}
