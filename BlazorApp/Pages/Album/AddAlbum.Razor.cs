using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using ShearedModel;
using System.Collections.Generic;
using System.Linq;
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

        public  bool Spinner { get; set; }
        public AlbumDto Album { get; set; } = new AlbumDto { AlbumArt = "images/albumArt.jpg" };
        public List<KeyValuePair<int, string>> Artists { get; set; } = new List<KeyValuePair<int, string>> { };
        protected override async Task OnInitializedAsync()
        {
            var data = await ArtistServices.GetAll();
            Artists = data?.Select(x => new KeyValuePair<int, string>(x.Id, $"{x.Name} {x.LastName}")).ToList();
        } 
        protected async Task HandleSubmit()
        {
            Spinner = true;
            var newRecord =await Service.Insert(Album);
            Nav.NavigateTo("/");
        }

    }
}
