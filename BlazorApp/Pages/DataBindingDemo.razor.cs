using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class DataBindingDemoBase : ComponentBase
    {
        public string Description { get; set; } = string.Empty;
        public string CssClass => (Description.Length < 10) ? "green" : (Description.Length < 20) ? "orange" : "red";


    }
}
