using AutoMapper;
using MusicStoreDataStore.Models;
using ShearedModel;

namespace MusicStoreBE.AutoMapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// not a best practice Always provide different mapper profile for dfferent entities for ease of editing
        /// </summary>
        public AutoMapperProfile()
        {
            CreateMap<Album, AlbumDto>().ReverseMap();
            CreateMap<Artist, ArtistDto>().ReverseMap();
            CreateMap<Artist, AlbumArtistDto>().ReverseMap();
            CreateMap<Album, ArtistAlbumsDto>().ReverseMap();
        }
    }
}
