using Microsoft.EntityFrameworkCore.Migrations;

namespace ECinema.Web.Data.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsInMovies_Actor_ActorId",
                table: "ActorsInMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorsInMovies_Movie_MovieId",
                table: "ActorsInMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Movie_movieId",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActorsInMovies",
                table: "ActorsInMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "ActorsInMovies",
                newName: "actorsInMovies");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actors");

            migrationBuilder.RenameIndex(
                name: "IX_ActorsInMovies_MovieId",
                table: "actorsInMovies",
                newName: "IX_actorsInMovies_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_movieId",
                table: "Tickets",
                newName: "IX_Tickets_movieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actorsInMovies",
                table: "actorsInMovies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_actorsInMovies_Actors_ActorId",
                table: "actorsInMovies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_actorsInMovies_Movies_MovieId",
                table: "actorsInMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Movies_movieId",
                table: "Tickets",
                column: "movieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actorsInMovies_Actors_ActorId",
                table: "actorsInMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_actorsInMovies_Movies_MovieId",
                table: "actorsInMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Movies_movieId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actorsInMovies",
                table: "actorsInMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "actorsInMovies",
                newName: "ActorsInMovies");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Actor");

            migrationBuilder.RenameIndex(
                name: "IX_actorsInMovies_MovieId",
                table: "ActorsInMovies",
                newName: "IX_ActorsInMovies_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_movieId",
                table: "Ticket",
                newName: "IX_Ticket_movieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActorsInMovies",
                table: "ActorsInMovies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsInMovies_Actor_ActorId",
                table: "ActorsInMovies",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsInMovies_Movie_MovieId",
                table: "ActorsInMovies",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Movie_movieId",
                table: "Ticket",
                column: "movieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
