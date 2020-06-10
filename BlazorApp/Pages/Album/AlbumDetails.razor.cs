using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using ShearedModel;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class AlbumDetailsBase : ComponentBase
    {
     
        [Inject]
        public IAlbumService AlbumService { get; set; }
        [Parameter]
        public string Id { get; set; } 
        public AlbumDto Album { get; set; } = new AlbumDto();
        protected async override Task OnInitializedAsync()
        {
            Album = await AlbumService.Get(int.Parse(Id));
            
        }

        

    }
}
