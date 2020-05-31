using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStoreDataStore.Models
{
    [Table(name: "MSAlbum")]
    public class Album:BaseEntity
    { 
        public string Name {   get; set; }
        public int ArtistId {   get; set; }
        [ForeignKey("ArtistId")]
        public virtual Artist Artist {   get; set; }
        public string AlbumArt {   get; set; }
        public DateTime Date {   get; set; }
    }
}
