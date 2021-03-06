﻿using System;
using System.Collections.Generic;

namespace ShearedModel
{
    public class ArtistDto: DtoBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public virtual IEnumerable<ArtistAlbumsDto> Albums { get; set; }
        //public string Picture { get; set; }
    }
}
