using System;
using System.Collections.Generic;
using System.Text;

namespace ShearedModel
{
   public class AlbumArtistDto : DtoBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; } 
        //public string Picture { get; set; }
    }
}
