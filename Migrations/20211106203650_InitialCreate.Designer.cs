﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using moviesApi.Persistence;

namespace moviesApi.Migrations
{
    [DbContext(typeof(MoviesDBContext))]
    [Migration("20211106203650_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("moviesApi.Core.Models.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f001061-d564-4fb4-a35e-be90d13a1ede"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bradley Cooper",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("26a070b8-43ef-47af-9af2-9ad8dc2941ad"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Keon Jeong",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("76ef6f41-289e-49ef-8915-5af3046ef9c9"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ed Helms",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ae3d77fb-70a4-48d5-bb15-c49d169467ac"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Owen Wilson",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("5f668ae4-4260-4023-ab1e-b056457d22f9"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Isla Fisher",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("0772e391-fc3b-4f61-b571-8ed0486bd24a"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rachel McAdams",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("364c0b4b-59fe-401a-ae17-624a97c5375f"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Arnold Schwarzenegger",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e52c2dcd-69bf-4daa-b870-1145c388010a"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Linda Hamilton",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ae55c403-c142-4279-8945-7b23977a277d"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Earl Boen",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("db9b5474-099d-4d60-9631-648cccfccc6c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Deborah Lomis",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("7bb8eee4-0d2d-476a-b15c-ce4ed05e406c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Arnold Stang",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("cdf4c376-c884-4219-90b3-8c9c4e51bc3b"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "James Karen",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ad647603-d4af-411c-82fe-9c0ab187794e"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ryan Gosling",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a15425a6-4ca7-4735-a9e5-40a26e834dc8"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bruce Willis",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d03d5579-3e71-42d5-8a95-e9356eba63ba"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Haley Joel Osment",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f5c20092-69df-4184-8759-9a961050fd3d"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nicole Kidman",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4aacfd51-558f-4d42-9dbb-01b924c1a0a1"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "James Bentley",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("moviesApi.Core.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("224aef23-db14-4a91-a3a6-a93f92a9af09"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Hangover is a 2009 American comedy film directed by Todd Phillips, co-produced with Daniel Goldberg, and written by Jon Lucas and Scott Moore. It is the first installment in The Hangover trilogy. The film stars Bradley Cooper, Ed Helms, Zach Galifianakis, Heather Graham, Justin Bartha, Ken Jeong, and Jeffrey Tambor. It tells the story of Phil Wenneck, Stu Price, Alan Garner, and Doug Billings, who travel to Las Vegas for a bachelor party to celebrate Doug's impending marriage. However, Phil, Stu, and Alan wake up with Doug missing and no memory of the previous night's events, and must find the groom before the wedding can take place",
                            Genre = "Comedy",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNGQwZjg5YmYtY2VkNC00NzliLTljYTctNzI5NmU3MjE2ODQzXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Title = "The Hangover",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a637db3f-d76a-45b7-a257-5e3ccf77d578"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "John Beckwith and Jeremy Grey, a pair of committed womanizers who sneak into weddings to take advantage of the romantic tinge in the air, find themselves at odds with one another when John meets and falls for Claire Cleary.",
                            Genre = "Comedy",
                            Poster = "https://m.media-amazon.com/images/M/MV5BZmJkNzViYjYtZWZlNy00OGE4LWI2MzUtYTcwNjY3Y2MyODIwXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg",
                            Title = "Wedding Crashers",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f86ce4ec-e8c1-4a43-b826-d3adc868d01a"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A seemingly indestructible robot is sent to 1984 to assassinate a waitress, whose unborn child will lead humanity in a war against intelligent machines, while a human soldier from the same war is sent to protect her at all costs.",
                            Genre = "Action",
                            Poster = "https://m.media-amazon.com/images/M/MV5BYTViNzMxZjEtZGEwNy00MDNiLWIzNGQtZDY2MjQ1OWViZjFmXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Title = "Terminator",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e509ede4-6ab8-4f52-a4a4-b9248001f5f3"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A poor but passionate young man falls in love with a wealthy young woman who gives him a sense of freedom, but they soon part due to their social differences.",
                            Genre = "Romance",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMTk3OTM5Njg5M15BMl5BanBnXkFtZTYwMzA0ODI3._V1_SX300.jpg",
                            Title = "The Notebook",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("670c4b7e-b888-4890-88f6-3eac1bdb95f7"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A child who communicates with spirits seeks the help of a child psychologist without feelings.",
                            Genre = "Thriller",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMWM4NTFhYjctNzUyNi00NGMwLTk3NTYtMDIyNTZmMzRlYmQyXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_SX300.jpg",
                            Title = "The Sixth Sense",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4071087b-2ea2-4424-b238-8924a0cf4ed6"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A woman living in her dark old family home with her two photosensitive children becomes convinced that the house is haunted.",
                            Genre = "Thriller",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMTAxMDE4Mzc3ODNeQTJeQWpwZ15BbWU4MDY2Mjg4MDcx._V1_SX300.jpg",
                            Title = "The Others",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("26eeef20-c765-4381-8bd1-e914a3f55003"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hercules is sent to Earth where he finds true love and starts a promising career in the bodybuilder business.",
                            Genre = "Fantasy/Adventure",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMDE2MDRmMjQtNGM0NC00N2U4LWI2ZGYtM2I2MzIyNzY5NjlmXkEyXkFqcGdeQXVyNDIwODAwNzg@._V1_SX300.jpg",
                            Title = "Hercules in New York",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("moviesApi.Core.Models.MovieActor", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            MovieId = new Guid("224aef23-db14-4a91-a3a6-a93f92a9af09"),
                            ActorId = new Guid("7f001061-d564-4fb4-a35e-be90d13a1ede")
                        },
                        new
                        {
                            MovieId = new Guid("224aef23-db14-4a91-a3a6-a93f92a9af09"),
                            ActorId = new Guid("26a070b8-43ef-47af-9af2-9ad8dc2941ad")
                        },
                        new
                        {
                            MovieId = new Guid("224aef23-db14-4a91-a3a6-a93f92a9af09"),
                            ActorId = new Guid("76ef6f41-289e-49ef-8915-5af3046ef9c9")
                        },
                        new
                        {
                            MovieId = new Guid("a637db3f-d76a-45b7-a257-5e3ccf77d578"),
                            ActorId = new Guid("ae3d77fb-70a4-48d5-bb15-c49d169467ac")
                        },
                        new
                        {
                            MovieId = new Guid("a637db3f-d76a-45b7-a257-5e3ccf77d578"),
                            ActorId = new Guid("5f668ae4-4260-4023-ab1e-b056457d22f9")
                        },
                        new
                        {
                            MovieId = new Guid("a637db3f-d76a-45b7-a257-5e3ccf77d578"),
                            ActorId = new Guid("0772e391-fc3b-4f61-b571-8ed0486bd24a")
                        },
                        new
                        {
                            MovieId = new Guid("f86ce4ec-e8c1-4a43-b826-d3adc868d01a"),
                            ActorId = new Guid("364c0b4b-59fe-401a-ae17-624a97c5375f")
                        },
                        new
                        {
                            MovieId = new Guid("f86ce4ec-e8c1-4a43-b826-d3adc868d01a"),
                            ActorId = new Guid("e52c2dcd-69bf-4daa-b870-1145c388010a")
                        },
                        new
                        {
                            MovieId = new Guid("f86ce4ec-e8c1-4a43-b826-d3adc868d01a"),
                            ActorId = new Guid("ae55c403-c142-4279-8945-7b23977a277d")
                        },
                        new
                        {
                            MovieId = new Guid("26eeef20-c765-4381-8bd1-e914a3f55003"),
                            ActorId = new Guid("db9b5474-099d-4d60-9631-648cccfccc6c")
                        },
                        new
                        {
                            MovieId = new Guid("26eeef20-c765-4381-8bd1-e914a3f55003"),
                            ActorId = new Guid("364c0b4b-59fe-401a-ae17-624a97c5375f")
                        },
                        new
                        {
                            MovieId = new Guid("26eeef20-c765-4381-8bd1-e914a3f55003"),
                            ActorId = new Guid("7bb8eee4-0d2d-476a-b15c-ce4ed05e406c")
                        },
                        new
                        {
                            MovieId = new Guid("26eeef20-c765-4381-8bd1-e914a3f55003"),
                            ActorId = new Guid("cdf4c376-c884-4219-90b3-8c9c4e51bc3b")
                        },
                        new
                        {
                            MovieId = new Guid("e509ede4-6ab8-4f52-a4a4-b9248001f5f3"),
                            ActorId = new Guid("ad647603-d4af-411c-82fe-9c0ab187794e")
                        },
                        new
                        {
                            MovieId = new Guid("e509ede4-6ab8-4f52-a4a4-b9248001f5f3"),
                            ActorId = new Guid("0772e391-fc3b-4f61-b571-8ed0486bd24a")
                        },
                        new
                        {
                            MovieId = new Guid("670c4b7e-b888-4890-88f6-3eac1bdb95f7"),
                            ActorId = new Guid("a15425a6-4ca7-4735-a9e5-40a26e834dc8")
                        },
                        new
                        {
                            MovieId = new Guid("670c4b7e-b888-4890-88f6-3eac1bdb95f7"),
                            ActorId = new Guid("d03d5579-3e71-42d5-8a95-e9356eba63ba")
                        },
                        new
                        {
                            MovieId = new Guid("4071087b-2ea2-4424-b238-8924a0cf4ed6"),
                            ActorId = new Guid("f5c20092-69df-4184-8759-9a961050fd3d")
                        },
                        new
                        {
                            MovieId = new Guid("4071087b-2ea2-4424-b238-8924a0cf4ed6"),
                            ActorId = new Guid("4aacfd51-558f-4d42-9dbb-01b924c1a0a1")
                        });
                });

            modelBuilder.Entity("moviesApi.Core.Models.MovieActor", b =>
                {
                    b.HasOne("moviesApi.Core.Models.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("moviesApi.Core.Models.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("moviesApi.Core.Models.Actor", b =>
                {
                    b.Navigation("MovieActors");
                });

            modelBuilder.Entity("moviesApi.Core.Models.Movie", b =>
                {
                    b.Navigation("MovieActors");
                });
#pragma warning restore 612, 618
        }
    }
}
