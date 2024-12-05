using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace systemMovies.Migrations
{
    /// <inheritdoc />
    public partial class _66 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_actorMovies",
                table: "actorMovies");

            migrationBuilder.RenameTable(
                name: "actorMovies",
                newName: "ActorMovies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActorMovies",
                table: "ActorMovies",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ActorMovies",
                table: "ActorMovies");

            migrationBuilder.RenameTable(
                name: "ActorMovies",
                newName: "actorMovies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actorMovies",
                table: "actorMovies",
                column: "Id");
        }
    }
}
