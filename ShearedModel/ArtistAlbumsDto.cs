using System;

namespace ShearedModel
{
    public  class ArtistAlbumsDto: DtoBase
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int ArtistId { get; set; }
        public string AlbumArt { get; set; }
        public DateTime Date { get; set; }
    }
}
