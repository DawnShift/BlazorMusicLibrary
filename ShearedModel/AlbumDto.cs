using Microsoft.AspNetCore.Http;
using ShearedModel.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShearedModel
{
    public class AlbumDto : DtoBase
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter a Name")]
        [MinLength(2)]
        public string Name { get; set; }
        public AlbumArtistDto Artist { get; set; }
        [Required]
        [MinValueValidator(AllowedMinimumValue = 1, ErrorMessage = "Please select an Artist")]
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "Please Choose a Valid File")]
        public string AlbumArt { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public IFormFile AlbumPic { get; set; }
    }
}
