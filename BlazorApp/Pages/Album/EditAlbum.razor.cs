using BlazorApp.Services;
using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using ShearedModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class EditAlbumBase : ComponentBase
    {
        [Inject]
        public IAlbumService Service { get; set; }
        [Inject]
        public IArtistServices ArtistServices { get; set; }
        [Inject]
        public IFileService FileService { get; set; }
        public MultipartFormDataContent File { get; set; }
        [Inject]
        public NavigationManager Nav { get; set; }

        protected bool IsFileUploaded { get; set; } = false;
        public AlbumDto Album { get; set; }
        [Parameter]
        public string Id { get; set; }
        public IEnumerable<ArtistDto> Artists = new List<ArtistDto> { };
        protected async override Task OnInitializedAsync()
        {
            Album = await Service.Get(int.Parse(Id));
            Artists = await ArtistServices.GetAll();
        }

        protected async Task HandleSubmit()
        {
            Album.AlbumArt = IsFileUploaded ? await FileService.FileUpload(File) : Album.AlbumArt;
            var result = await Service.Update(Album);
            if (result != null)
            {
                Nav.NavigateTo("/");
            }
        }

        protected async Task HandleFileUpload(IFileListEntry[] files)
        {
            var file = files.FirstOrDefault();
            if (file != null)
            {
                IsFileUploaded = true;
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                File = new MultipartFormDataContent {
                { new ByteArrayContent(ms.GetBuffer()), "\"upload\"", file.Name }
            };
            }
        }
    }
}
