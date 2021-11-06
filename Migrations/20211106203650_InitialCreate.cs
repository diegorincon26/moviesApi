using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace moviesApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieActors",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => new { x.MovieId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_MovieActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7f001061-d564-4fb4-a35e-be90d13a1ede"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley Cooper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4aacfd51-558f-4d42-9dbb-01b924c1a0a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Bentley", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5c20092-69df-4184-8759-9a961050fd3d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole Kidman", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d03d5579-3e71-42d5-8a95-e9356eba63ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haley Joel Osment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a15425a6-4ca7-4735-a9e5-40a26e834dc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruce Willis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad647603-d4af-411c-82fe-9c0ab187794e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan Gosling", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bb8eee4-0d2d-476a-b15c-ce4ed05e406c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arnold Stang", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db9b5474-099d-4d60-9631-648cccfccc6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deborah Lomis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cdf4c376-c884-4219-90b3-8c9c4e51bc3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Karen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e52c2dcd-69bf-4daa-b870-1145c388010a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda Hamilton", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("364c0b4b-59fe-401a-ae17-624a97c5375f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arnold Schwarzenegger", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0772e391-fc3b-4f61-b571-8ed0486bd24a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rachel McAdams", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f668ae4-4260-4023-ab1e-b056457d22f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isla Fisher", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae3d77fb-70a4-48d5-bb15-c49d169467ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owen Wilson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76ef6f41-289e-49ef-8915-5af3046ef9c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ed Helms", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26a070b8-43ef-47af-9af2-9ad8dc2941ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keon Jeong", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae55c403-c142-4279-8945-7b23977a277d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earl Boen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "Description", "Genre", "Poster", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4071087b-2ea2-4424-b238-8924a0cf4ed6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A woman living in her dark old family home with her two photosensitive children becomes convinced that the house is haunted.", "Thriller", "https://m.media-amazon.com/images/M/MV5BMTAxMDE4Mzc3ODNeQTJeQWpwZ15BbWU4MDY2Mjg4MDcx._V1_SX300.jpg", "The Others", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("224aef23-db14-4a91-a3a6-a93f92a9af09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hangover is a 2009 American comedy film directed by Todd Phillips, co-produced with Daniel Goldberg, and written by Jon Lucas and Scott Moore. It is the first installment in The Hangover trilogy. The film stars Bradley Cooper, Ed Helms, Zach Galifianakis, Heather Graham, Justin Bartha, Ken Jeong, and Jeffrey Tambor. It tells the story of Phil Wenneck, Stu Price, Alan Garner, and Doug Billings, who travel to Las Vegas for a bachelor party to celebrate Doug's impending marriage. However, Phil, Stu, and Alan wake up with Doug missing and no memory of the previous night's events, and must find the groom before the wedding can take place", "Comedy", "https://m.media-amazon.com/images/M/MV5BNGQwZjg5YmYtY2VkNC00NzliLTljYTctNzI5NmU3MjE2ODQzXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg", "The Hangover", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a637db3f-d76a-45b7-a257-5e3ccf77d578"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Beckwith and Jeremy Grey, a pair of committed womanizers who sneak into weddings to take advantage of the romantic tinge in the air, find themselves at odds with one another when John meets and falls for Claire Cleary.", "Comedy", "https://m.media-amazon.com/images/M/MV5BZmJkNzViYjYtZWZlNy00OGE4LWI2MzUtYTcwNjY3Y2MyODIwXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SX300.jpg", "Wedding Crashers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f86ce4ec-e8c1-4a43-b826-d3adc868d01a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seemingly indestructible robot is sent to 1984 to assassinate a waitress, whose unborn child will lead humanity in a war against intelligent machines, while a human soldier from the same war is sent to protect her at all costs.", "Action", "https://m.media-amazon.com/images/M/MV5BYTViNzMxZjEtZGEwNy00MDNiLWIzNGQtZDY2MjQ1OWViZjFmXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg", "Terminator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e509ede4-6ab8-4f52-a4a4-b9248001f5f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A poor but passionate young man falls in love with a wealthy young woman who gives him a sense of freedom, but they soon part due to their social differences.", "Romance", "https://m.media-amazon.com/images/M/MV5BMTk3OTM5Njg5M15BMl5BanBnXkFtZTYwMzA0ODI3._V1_SX300.jpg", "The Notebook", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("670c4b7e-b888-4890-88f6-3eac1bdb95f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A child who communicates with spirits seeks the help of a child psychologist without feelings.", "Thriller", "https://m.media-amazon.com/images/M/MV5BMWM4NTFhYjctNzUyNi00NGMwLTk3NTYtMDIyNTZmMzRlYmQyXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_SX300.jpg", "The Sixth Sense", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26eeef20-c765-4381-8bd1-e914a3f55003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hercules is sent to Earth where he finds true love and starts a promising career in the bodybuilder business.", "Fantasy/Adventure", "https://m.media-amazon.com/images/M/MV5BMDE2MDRmMjQtNGM0NC00N2U4LWI2ZGYtM2I2MzIyNzY5NjlmXkEyXkFqcGdeQXVyNDIwODAwNzg@._V1_SX300.jpg", "Hercules in New York", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("7f001061-d564-4fb4-a35e-be90d13a1ede"), new Guid("224aef23-db14-4a91-a3a6-a93f92a9af09") },
                    { new Guid("364c0b4b-59fe-401a-ae17-624a97c5375f"), new Guid("26eeef20-c765-4381-8bd1-e914a3f55003") },
                    { new Guid("db9b5474-099d-4d60-9631-648cccfccc6c"), new Guid("26eeef20-c765-4381-8bd1-e914a3f55003") },
                    { new Guid("4aacfd51-558f-4d42-9dbb-01b924c1a0a1"), new Guid("4071087b-2ea2-4424-b238-8924a0cf4ed6") },
                    { new Guid("f5c20092-69df-4184-8759-9a961050fd3d"), new Guid("4071087b-2ea2-4424-b238-8924a0cf4ed6") },
                    { new Guid("d03d5579-3e71-42d5-8a95-e9356eba63ba"), new Guid("670c4b7e-b888-4890-88f6-3eac1bdb95f7") },
                    { new Guid("a15425a6-4ca7-4735-a9e5-40a26e834dc8"), new Guid("670c4b7e-b888-4890-88f6-3eac1bdb95f7") },
                    { new Guid("0772e391-fc3b-4f61-b571-8ed0486bd24a"), new Guid("e509ede4-6ab8-4f52-a4a4-b9248001f5f3") },
                    { new Guid("7bb8eee4-0d2d-476a-b15c-ce4ed05e406c"), new Guid("26eeef20-c765-4381-8bd1-e914a3f55003") },
                    { new Guid("ad647603-d4af-411c-82fe-9c0ab187794e"), new Guid("e509ede4-6ab8-4f52-a4a4-b9248001f5f3") },
                    { new Guid("e52c2dcd-69bf-4daa-b870-1145c388010a"), new Guid("f86ce4ec-e8c1-4a43-b826-d3adc868d01a") },
                    { new Guid("364c0b4b-59fe-401a-ae17-624a97c5375f"), new Guid("f86ce4ec-e8c1-4a43-b826-d3adc868d01a") },
                    { new Guid("0772e391-fc3b-4f61-b571-8ed0486bd24a"), new Guid("a637db3f-d76a-45b7-a257-5e3ccf77d578") },
                    { new Guid("5f668ae4-4260-4023-ab1e-b056457d22f9"), new Guid("a637db3f-d76a-45b7-a257-5e3ccf77d578") },
                    { new Guid("ae3d77fb-70a4-48d5-bb15-c49d169467ac"), new Guid("a637db3f-d76a-45b7-a257-5e3ccf77d578") },
                    { new Guid("76ef6f41-289e-49ef-8915-5af3046ef9c9"), new Guid("224aef23-db14-4a91-a3a6-a93f92a9af09") },
                    { new Guid("26a070b8-43ef-47af-9af2-9ad8dc2941ad"), new Guid("224aef23-db14-4a91-a3a6-a93f92a9af09") },
                    { new Guid("ae55c403-c142-4279-8945-7b23977a277d"), new Guid("f86ce4ec-e8c1-4a43-b826-d3adc868d01a") },
                    { new Guid("cdf4c376-c884-4219-90b3-8c9c4e51bc3b"), new Guid("26eeef20-c765-4381-8bd1-e914a3f55003") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorId",
                table: "MovieActors",
                column: "ActorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieActors");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
