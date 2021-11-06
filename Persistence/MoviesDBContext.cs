using System;
using Microsoft.EntityFrameworkCore;
using moviesApi.Core.Models;

namespace moviesApi.Persistence
{
    public class MoviesDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public MoviesDBContext(DbContextOptions<MoviesDBContext> options) : base(options)
        {
        }

        // TODO: Change the hardcode name database for a variable
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseLazyLoadingProxies()
                          .UseSqlServer("Name=MoviesConnection");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>().HasKey(ma => new { ma.MovieId, ma.ActorId });
            modelBuilder.Entity<MovieActor>().HasOne(ma => ma.Movie)
                                             .WithMany(m => m.MovieActors)
                                             .HasForeignKey(ma => ma.MovieId);
            modelBuilder.Entity<MovieActor>().HasOne(ma => ma.Actor)
                                             .WithMany(a => a.MovieActors)
                                             .HasForeignKey(ma => ma.ActorId);


            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    Id = Guid.Parse("224aef23-db14-4a91-a3a6-a93f92a9af09"),
                    Title = "The Hangover",
                    Genre = "Comedy",
                    Description = "The Hangover is a 2009 American comedy film directed by Todd Phillips, co-produced with Daniel Goldberg, and written by Jon Lucas and Scott Moore. It is the first installment in The Hangover trilogy. The film stars Bradley Cooper, Ed Helms, Zach Galifianakis, Heather Graham, Justin Bartha, Ken Jeong, and Jeffrey Tambor. It tells the story of Phil Wenneck, Stu Price, Alan Garner, and Doug Billings, who travel to Las Vegas for a bachelor party to celebrate Doug's impending marriage. However, Phil, Stu, and Alan wake up with Doug missing and no memory of the previous night's events, and must find the groom before the wedding can take place",
                    Poster = "https://m.media-amazon.com/images/M/MV5BNGQwZjg5YmYtY2VkNC00NzliLTljYTctNzI5NmU3MjE2ODQzXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg"
                },
                new Movie()
                {
                    Id = Guid.Parse("a637db3f-d76a-45b7-a257-5e3ccf77d578"),
                    Title = "Wedding Crashers",
                    Genre = "Comedy",
                    Description = "John Beckwith and Jeremy Grey, a pair of committed womanizers who sneak into weddings to take advantage of the romantic tinge in the air, find themselves at odds with one another when John meets and falls for Claire Cleary.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BZmJkNzViYjYtZWZlNy00OGE4LWI2MzUtYTcwNjY3Y2MyODIwXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg",
                },
                new Movie()
                {
                    Id = Guid.Parse("f86ce4ec-e8c1-4a43-b826-d3adc868d01a"),
                    Title = "Terminator",
                    Genre = "Action",
                    Description = "A seemingly indestructible robot is sent to 1984 to assassinate a waitress, whose unborn child will lead humanity in a war against intelligent machines, while a human soldier from the same war is sent to protect her at all costs.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BYTViNzMxZjEtZGEwNy00MDNiLWIzNGQtZDY2MjQ1OWViZjFmXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg"
                },
                new Movie()
                {
                    Id = Guid.Parse("e509ede4-6ab8-4f52-a4a4-b9248001f5f3"),
                    Title = "The Notebook",
                    Genre = "Romance",
                    Description = "A poor but passionate young man falls in love with a wealthy young woman who gives him a sense of freedom, but they soon part due to their social differences.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMTk3OTM5Njg5M15BMl5BanBnXkFtZTYwMzA0ODI3._V1_SX300.jpg"
                },
                new Movie()
                {
                    Id = Guid.Parse("670c4b7e-b888-4890-88f6-3eac1bdb95f7"),
                    Title = "The Sixth Sense",
                    Genre = "Thriller",
                    Description = "A child who communicates with spirits seeks the help of a child psychologist without feelings.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMWM4NTFhYjctNzUyNi00NGMwLTk3NTYtMDIyNTZmMzRlYmQyXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_SX300.jpg"
                },
                new Movie()
                {
                    Id = Guid.Parse("4071087b-2ea2-4424-b238-8924a0cf4ed6"),
                    Title = "The Others",
                    Genre = "Thriller",
                    Description = "A woman living in her dark old family home with her two photosensitive children becomes convinced that the house is haunted.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMTAxMDE4Mzc3ODNeQTJeQWpwZ15BbWU4MDY2Mjg4MDcx._V1_SX300.jpg"
                },
                new Movie()
                {
                    Id = Guid.Parse("26eeef20-c765-4381-8bd1-e914a3f55003"),
                    Title = "Hercules in New York",
                    Genre = "Fantasy/Adventure",
                    Description = "Hercules is sent to Earth where he finds true love and starts a promising career in the bodybuilder business.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDE2MDRmMjQtNGM0NC00N2U4LWI2ZGYtM2I2MzIyNzY5NjlmXkEyXkFqcGdeQXVyNDIwODAwNzg@._V1_SX300.jpg"
                });

            modelBuilder.Entity<Actor>().HasData(
                new Actor() { Id = Guid.Parse("7f001061-d564-4fb4-a35e-be90d13a1ede"), Name = "Bradley Cooper" },
                new Actor() { Id = Guid.Parse("26a070b8-43ef-47af-9af2-9ad8dc2941ad"), Name = "Keon Jeong" },
                new Actor() { Id = Guid.Parse("76ef6f41-289e-49ef-8915-5af3046ef9c9"), Name = "Ed Helms" },
                new Actor() { Id = Guid.Parse("ae3d77fb-70a4-48d5-bb15-c49d169467ac"), Name = "Owen Wilson" },
                new Actor() { Id = Guid.Parse("5f668ae4-4260-4023-ab1e-b056457d22f9"), Name = "Isla Fisher" },
                new Actor() { Id = Guid.Parse("0772e391-fc3b-4f61-b571-8ed0486bd24a"), Name = "Rachel McAdams" },
                new Actor() { Id = Guid.Parse("364c0b4b-59fe-401a-ae17-624a97c5375f"), Name = "Arnold Schwarzenegger" },
                new Actor() { Id = Guid.Parse("e52c2dcd-69bf-4daa-b870-1145c388010a"), Name = "Linda Hamilton" },
                new Actor() { Id = Guid.Parse("ae55c403-c142-4279-8945-7b23977a277d"), Name = "Earl Boen" },
                new Actor() { Id = Guid.Parse("db9b5474-099d-4d60-9631-648cccfccc6c"), Name = "Deborah Lomis" },
                new Actor() { Id = Guid.Parse("7bb8eee4-0d2d-476a-b15c-ce4ed05e406c"), Name = "Arnold Stang" },
                new Actor() { Id = Guid.Parse("cdf4c376-c884-4219-90b3-8c9c4e51bc3b"), Name = "James Karen" },
                new Actor() { Id = Guid.Parse("ad647603-d4af-411c-82fe-9c0ab187794e"), Name = "Ryan Gosling" },
                new Actor() { Id = Guid.Parse("a15425a6-4ca7-4735-a9e5-40a26e834dc8"), Name = "Bruce Willis" },
                new Actor() { Id = Guid.Parse("d03d5579-3e71-42d5-8a95-e9356eba63ba"), Name = "Haley Joel Osment" },
                new Actor() { Id = Guid.Parse("f5c20092-69df-4184-8759-9a961050fd3d"), Name = "Nicole Kidman" },
                new Actor() { Id = Guid.Parse("4aacfd51-558f-4d42-9dbb-01b924c1a0a1"), Name = "James Bentley" }
            );

            modelBuilder.Entity<MovieActor>()
                        .HasData(
                new MovieActor() { MovieId = Guid.Parse("224aef23-db14-4a91-a3a6-a93f92a9af09"), ActorId = Guid.Parse("7f001061-d564-4fb4-a35e-be90d13a1ede") },
                new MovieActor() { MovieId = Guid.Parse("224aef23-db14-4a91-a3a6-a93f92a9af09"), ActorId = Guid.Parse("26a070b8-43ef-47af-9af2-9ad8dc2941ad") },
                new MovieActor() { MovieId = Guid.Parse("224aef23-db14-4a91-a3a6-a93f92a9af09"), ActorId = Guid.Parse("76ef6f41-289e-49ef-8915-5af3046ef9c9") },
                new MovieActor() { MovieId = Guid.Parse("a637db3f-d76a-45b7-a257-5e3ccf77d578"), ActorId = Guid.Parse("ae3d77fb-70a4-48d5-bb15-c49d169467ac") },
                new MovieActor() { MovieId = Guid.Parse("a637db3f-d76a-45b7-a257-5e3ccf77d578"), ActorId = Guid.Parse("5f668ae4-4260-4023-ab1e-b056457d22f9") },
                new MovieActor() { MovieId = Guid.Parse("a637db3f-d76a-45b7-a257-5e3ccf77d578"), ActorId = Guid.Parse("0772e391-fc3b-4f61-b571-8ed0486bd24a") },
                new MovieActor() { MovieId = Guid.Parse("f86ce4ec-e8c1-4a43-b826-d3adc868d01a"), ActorId = Guid.Parse("364c0b4b-59fe-401a-ae17-624a97c5375f") },
                new MovieActor() { MovieId = Guid.Parse("f86ce4ec-e8c1-4a43-b826-d3adc868d01a"), ActorId = Guid.Parse("e52c2dcd-69bf-4daa-b870-1145c388010a") },
                new MovieActor() { MovieId = Guid.Parse("f86ce4ec-e8c1-4a43-b826-d3adc868d01a"), ActorId = Guid.Parse("ae55c403-c142-4279-8945-7b23977a277d") },
                new MovieActor() { MovieId = Guid.Parse("26eeef20-c765-4381-8bd1-e914a3f55003"), ActorId = Guid.Parse("db9b5474-099d-4d60-9631-648cccfccc6c") },
                new MovieActor() { MovieId = Guid.Parse("26eeef20-c765-4381-8bd1-e914a3f55003"), ActorId = Guid.Parse("364c0b4b-59fe-401a-ae17-624a97c5375f") },
                new MovieActor() { MovieId = Guid.Parse("26eeef20-c765-4381-8bd1-e914a3f55003"), ActorId = Guid.Parse("7bb8eee4-0d2d-476a-b15c-ce4ed05e406c") },
                new MovieActor() { MovieId = Guid.Parse("26eeef20-c765-4381-8bd1-e914a3f55003"), ActorId = Guid.Parse("cdf4c376-c884-4219-90b3-8c9c4e51bc3b") },
                new MovieActor() { MovieId = Guid.Parse("e509ede4-6ab8-4f52-a4a4-b9248001f5f3"), ActorId = Guid.Parse("ad647603-d4af-411c-82fe-9c0ab187794e") },
                new MovieActor() { MovieId = Guid.Parse("e509ede4-6ab8-4f52-a4a4-b9248001f5f3"), ActorId = Guid.Parse("0772e391-fc3b-4f61-b571-8ed0486bd24a") },
                new MovieActor() { MovieId = Guid.Parse("670c4b7e-b888-4890-88f6-3eac1bdb95f7"), ActorId = Guid.Parse("a15425a6-4ca7-4735-a9e5-40a26e834dc8") },
                new MovieActor() { MovieId = Guid.Parse("670c4b7e-b888-4890-88f6-3eac1bdb95f7"), ActorId = Guid.Parse("d03d5579-3e71-42d5-8a95-e9356eba63ba") },
                new MovieActor() { MovieId = Guid.Parse("4071087b-2ea2-4424-b238-8924a0cf4ed6"), ActorId = Guid.Parse("f5c20092-69df-4184-8759-9a961050fd3d") },
                new MovieActor() { MovieId = Guid.Parse("4071087b-2ea2-4424-b238-8924a0cf4ed6"), ActorId = Guid.Parse("4aacfd51-558f-4d42-9dbb-01b924c1a0a1") }
            );
        }
    }
}