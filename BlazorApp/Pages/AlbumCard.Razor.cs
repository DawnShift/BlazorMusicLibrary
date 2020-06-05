using Microsoft.AspNetCore.Components; 
using ShearedModel;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class AlbumCardBase : ComponentBase
    { 
        [Parameter]
        public AlbumDto Album { get; set; }
        [Parameter]
        public bool ShowControls { get; set; }
        [Parameter]
        public EventCallback<bool> OnAlbumSelection { get; set; }
        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
           await OnAlbumSelection.InvokeAsync((bool)e.Value);
        }
    }
}
