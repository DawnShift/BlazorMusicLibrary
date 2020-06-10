using System;
using System.ComponentModel.DataAnnotations;

namespace ShearedModel
{
    public class AlbumDto: DtoBase
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter a Name")]
        [MinLength(2)]
        public string Name { get; set; }
        public AlbumArtistDto Artist { get; set; }
       [Required]
        public int ArtistId { get; set; }
        public string AlbumArt { get; set; } 
        [Required]
        public DateTime Date { get; set; }
    }
}
