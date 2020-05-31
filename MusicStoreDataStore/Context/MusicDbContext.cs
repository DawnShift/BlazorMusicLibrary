using Microsoft.EntityFrameworkCore;
using MusicStoreDataStore.Models;
using System;
using System.Collections.Generic;

namespace MusicStoreDataStore.Context
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {

        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Artist>().HasData(
                new Artist
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    Name = "Linkin",
                    LastName = "Park",
                    ModifiedDate = null,
                    Date = DateTime.Now,

                },
                 new Artist
                 {
                     Id = 2,
                     CreatedDate = DateTime.Now,
                     Name = "Imagine",
                     LastName = "Dragons",
                     ModifiedDate = null,
                     Date = DateTime.Now,
                 },
                  new Artist
                  {
                      Id = 3,
                      CreatedDate = DateTime.Now,
                      Name = "Ed",
                      LastName = "Sheren",
                      ModifiedDate = null,
                      Date = DateTime.Now,
                  });


            builder.Entity<Album>().HasData(
                        new Album
                        {
                            Id = 1,
                            ArtistId = 1,
                            AlbumArt = "images/albumArt.jpg",
                            CreatedDate = DateTime.Now,
                            Name = "Castle Of Glass",
                            ModifiedDate = null,
                            Date = DateTime.Now
                        },
                    new Album
                    {
                        Id = 2,
                        ArtistId = 1,
                        AlbumArt = "images/albumArt.jpg",
                        CreatedDate = DateTime.Now,
                        Name = "Evolution",
                        ModifiedDate = null,
                        Date = DateTime.Now
                    },
                      new Album
                      {
                          Id = 3,
                          ArtistId = 2,
                          AlbumArt = "images/albumArt.jpg",
                          CreatedDate = DateTime.Now,
                          Name = "Thunder",
                          ModifiedDate = null,
                          Date = DateTime.Now
                      },
                    new Album
                    {
                        Id = 4,
                        ArtistId = 2,
                        AlbumArt = "images/albumArt.jpg",
                        CreatedDate = DateTime.Now,
                        Name = "Deamons",
                        ModifiedDate = null,
                        Date = DateTime.Now
                    }, new Album
                    {
                        Id = 5,
                        ArtistId = 3,
                        AlbumArt = "images/albumArt.jpg",
                        CreatedDate = DateTime.Now,
                        Name = "The A-Team",
                        ModifiedDate = null,
                        Date = DateTime.Now
                    },
                    new Album
                    {
                        Id = 6,
                        ArtistId = 3,
                        AlbumArt = "images/albumArt.jpg",
                        CreatedDate = DateTime.Now,
                        Name = "Divide",
                        ModifiedDate = null,
                        Date = DateTime.Now
                    }
                );
        }
    }
}
