using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using ShearedModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class AlbumBase : ComponentBase
    {
        [Inject]
        public IAlbumService AlbumSrvice { get; set; }

        public IEnumerable<ShearedModel.AlbumDto> Albums { get; set; }
        protected override async Task OnInitializedAsync() => await LoadAlbums(); 
        private async Task LoadAlbums() => Albums = await AlbumSrvice.GetAll();

    }
}
