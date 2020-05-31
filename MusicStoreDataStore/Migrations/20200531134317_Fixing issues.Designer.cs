﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicStoreDataStore.Context;

namespace MusicStoreDataStore.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    [Migration("20200531134317_Fixing issues")]
    partial class Fixingissues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicStoreDataStore.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumArt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("MSAlbum");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumArt = "images/albumArt.jpg",
                            ArtistId = 1,
                            CreatedDate = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(7794),
                            Date = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8196),
                            Name = "Castle Of Glass"
                        },
                        new
                        {
                            Id = 2,
                            AlbumArt = "images/albumArt.jpg",
                            ArtistId = 1,
                            CreatedDate = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8667),
                            Date = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8681),
                            Name = "Evolution"
                        },
                        new
                        {
                            Id = 3,
                            AlbumArt = "images/albumArt.jpg",
                            ArtistId = 2,
                            CreatedDate = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8693),
                            Date = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8695),
                            Name = "Thunder"
                        },
                        new
                        {
                            Id = 4,
                            AlbumArt = "images/albumArt.jpg",
                            ArtistId = 2,
                            CreatedDate = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8696),
                            Date = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8697),
                            Name = "Deamons"
                        },
                        new
                        {
                            Id = 5,
                            AlbumArt = "images/albumArt.jpg",
                            ArtistId = 3,
                            CreatedDate = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8698),
                            Date = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8699),
                            Name = "The A-Team"
                        },
                        new
                        {
                            Id = 6,
                            AlbumArt = "images/albumArt.jpg",
                            ArtistId = 3,
                            CreatedDate = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8701),
                            Date = new DateTime(2020, 5, 31, 19, 13, 16, 888, DateTimeKind.Local).AddTicks(8703),
                            Name = "Divide"
                        });
                });

            modelBuilder.Entity("MusicStoreDataStore.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MSArtist");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2020, 5, 31, 19, 13, 16, 886, DateTimeKind.Local).AddTicks(1297),
                            Date = new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(4535),
                            LastName = "Park",
                            Name = "Linkin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(5017),
                            Date = new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(5051),
                            LastName = "Dragons",
                            Name = "Imagine"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(5059),
                            Date = new DateTime(2020, 5, 31, 19, 13, 16, 887, DateTimeKind.Local).AddTicks(5060),
                            LastName = "Sheren",
                            Name = "Ed"
                        });
                });

            modelBuilder.Entity("MusicStoreDataStore.Models.Album", b =>
                {
                    b.HasOne("MusicStoreDataStore.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}