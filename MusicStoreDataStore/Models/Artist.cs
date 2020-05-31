using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStoreDataStore.Models
{
    [Table(name: "MSArtist")]
    public class Artist : BaseEntity
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
        }

        public string Name {   get; set; }
        public string LastName {   get; set; }
        public DateTime Date {   get; set; }
        public virtual IEnumerable<Album> Albums {   get; set; }
    }
}
