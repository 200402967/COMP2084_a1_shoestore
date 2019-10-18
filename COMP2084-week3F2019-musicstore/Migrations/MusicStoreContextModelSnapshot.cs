﻿// <auto-generated />
using System;
using COMP2084_week3F2019_musicstore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP2084week3F2019musicstore.Migrations
{
    [DbContext(typeof(MusicStoreContext))]
    partial class MusicStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMP2084_week3F2019_musicstore.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist");

                    b.Property<int>("GenreId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("AlbumId");

                    b.HasIndex("GenreId");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("COMP2084_week3F2019_musicstore.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("COMP2084_week3F2019_musicstore.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("ArtistName");

                    b.Property<string>("Featuring");

                    b.Property<int>("RunTimeSeconds");

                    b.Property<string>("SongName");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("COMP2084_week3F2019_musicstore.Models.Album", b =>
                {
                    b.HasOne("COMP2084_week3F2019_musicstore.Models.Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("COMP2084_week3F2019_musicstore.Models.Song", b =>
                {
                    b.HasOne("COMP2084_week3F2019_musicstore.Models.Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}