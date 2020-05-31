using ShearedModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicStoreBE.Store
{
    public interface IArtistStore
    {
        List<ArtistDto> AddArtist(ArtistDto item);
        int GetArtistIdByName(string name);
        List<ArtistDto> GetAll();
    }
    public class ArtistStore : IArtistStore
    {
        private static List<ArtistDto> Artists { get; set; }
        public ArtistStore()
        {
            Artists = new List<ArtistDto>
            {
                 new ArtistDto{Id=1, Name="Linken", LastName="Park", DateOfBirth=DateTime.Now },
                 new ArtistDto{Id=2, Name="Imagne", LastName="Dragons", DateOfBirth=DateTime.Now },
                 new ArtistDto{Id=3, Name="Ed", LastName="Sheren", DateOfBirth=DateTime.Now }
            };

        }

        public List<ArtistDto> GetAll()
        {
            return Artists;
        }

        public List<ArtistDto> AddArtist(ArtistDto item)
        {
            Artists.Add(item);
            return Artists;
        }

        public int GetArtistIdByName(string name)
        {
            return (int)Artists?.Where(x => x.Name == name).FirstOrDefault().Id;
        }
    }
}
