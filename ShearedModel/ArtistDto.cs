using System;
using System.Collections.Generic;
using System.Text;

namespace ShearedModel
{
    public class ArtistDto: DtoBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual IEnumerable<AlbumDto> Albums { get; set; }
        public string Picture { get; set; }
    }
}
