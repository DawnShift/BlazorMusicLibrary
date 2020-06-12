using BlazorApp.Services;
using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using ShearedModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.Pages.Album
{
    public class AddAlbumBase : ComponentBase
    {
        [Inject]
        protected IAlbumService Service { get; set; }
        [Inject]
        public NavigationManager Nav { get; set; }
        [Inject]
        public IArtistServices ArtistServices { get; set; }
        [Inject]
        public IFileService FileService { get; set; }
        public MultipartFormDataContent File { get; set; }
        public bool Spinner { get; set; }
        public AlbumDto Album { get; set; } = new AlbumDto() { Date = DateTime.Now };
        public List<KeyValuePair<int, string>> Artists { get; set; } = new List<KeyValuePair<int, string>> { };
        protected override async Task OnInitializedAsync()
        {
            var data = await ArtistServices.GetAll();
            Artists = data?.Select(x => new KeyValuePair<int, string>(x.Id, $"{x.Name} {x.LastName}")).ToList();
        }
        protected async Task HandleSubmit()
        {
            Spinner = true;
            string albumArt = await FileService.FileUpload(File);
            if (!string.IsNullOrEmpty(albumArt))
            {
                Album.AlbumArt = albumArt;
                var newRecord = await Service.Insert(Album);
                Nav.NavigateTo("/");
            }
        }
        protected async Task HandleFileUpload(IFileListEntry[] files)
        {
            var file = files.FirstOrDefault();
            if (file != null)
            {
                Album.AlbumArt = file.Name;
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                File = new MultipartFormDataContent {
                { new ByteArrayContent(ms.GetBuffer()), "\"upload\"", file.Name }
            };
            }
            else
                Album.AlbumArt = string.Empty;
        }

    }
}
