using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using ShearedModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class EditAlbumBase : ComponentBase
    {
        [Inject]
        public IAlbumService AlbumsService { get; set; }
        [Inject]
        public IArtistServices ArtistServices { get; set; }

        [Inject]
        public NavigationManager nav { get; set; }

        public AlbumDto Album { get; set; }
        [Parameter]
        public string Id { get; set; }
        public IEnumerable<ArtistDto> Artists = new List<ArtistDto> { };
        protected async override Task OnInitializedAsync()
        {
            Album = await AlbumsService.Get(int.Parse(Id));
            Artists = await ArtistServices.GetAll();
        }

        protected async Task HandleSubmit()
        {
            var result = await AlbumsService.Update(Album);
            if (result != null)
            {
                nav.NavigateTo("/");
            }
        }
    }
}
