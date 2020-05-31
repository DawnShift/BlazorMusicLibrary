
using ShearedModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicStoreBE.Store
{

    public interface IAlbumStore
    {
        List<AlbumDto> AddAlbum(AlbumDto item);
        List<AlbumDto> SearchAlbumsByName(string name);
        List<AlbumDto> SearchAlbumByArtistId(int id);
        List<AlbumDto> GetAll();
    }
    public class AlbumStore: IAlbumStore
    {
        private static List<AlbumDto> Albums { get; set; }
        public AlbumStore()
        {
            Albums = new List<Album> {
             new Album{ Id=1,  ArtistId=1, Name="Evolution", Date = DateTime.Now,AlbumArt="images/albumArt.jpg"},
             new Album{ Id=2,  ArtistId=1, Name="PaperCut", Date = DateTime.Now,AlbumArt="images/albumArt.jpg"},
             new Album{ Id=3,  ArtistId=1, Name="Castle Of Glass", Date = DateTime.Now,AlbumArt="images/albumArt.jpg"},
             new Album{ Id=4,  ArtistId=2,Name="RadioActive", Date = DateTime.Now ,AlbumArt="images/albumArt.jpg"},
             new Album{ Id=5,  ArtistId=3, Name="Divide", Date = DateTime.Now ,AlbumArt="images/albumArt.jpg"},
            };
        }

        public List<Album> GetAll()
        {
            return Albums;
        }
        public List<Album> AddAlbum(Album item)
        {
            Albums.Add(item);
            return Albums;
        }
        public List<Album> SearchAlbumsByName(string name)
        {
            return Albums?.Where(x => x.Name.Contains(name)).ToList();
        }
        public List<Album> SearchAlbumByArtistId(int id)
        {
            return Albums?.Where(x => x.Id == id).ToList();
        }
    }
}
