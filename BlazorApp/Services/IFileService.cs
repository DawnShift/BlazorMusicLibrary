using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public interface IFileService
    {
        Task<string> FileUpload(MultipartFormDataContent file);
    }
    public class FileService : IFileService
    {
        private readonly HttpClient httpClient; 
        public FileService(HttpClient httpClient)=> this.httpClient = httpClient; 
        public async Task<string> FileUpload(MultipartFormDataContent file)
        {
            var data = await httpClient.PostAsync("api/Files", file);
            //if (data.StatusCode == HttpStatusCode.OK)
              string a=   await data.Content.ReadAsStringAsync();
            return a;
        }
    }
}
