using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECinema.Web.Data.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "MovieImage",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "MovieName",
                table: "Ticket");

            migrationBuilder.AddColumn<float>(
                name: "TicketPrice",
                table: "Ticket",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<Guid>(
                name: "movieId",
                table: "Ticket",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MovieName = table.Column<string>(nullable: true),
                    MovieImage = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Genre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorsInMovies",
                columns: table => new
                {
                    ActorId = table.Column<Guid>(nullable: false),
                    MovieId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsInMovies", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_ActorsInMovies_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsInMovies_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_movieId",
                table: "Ticket",
                column: "movieId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorsInMovies_MovieId",
                table: "ActorsInMovies",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Movie_movieId",
                table: "Ticket",
                column: "movieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Movie_movieId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "ActorsInMovies");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_movieId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "movieId",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieImage",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieName",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
