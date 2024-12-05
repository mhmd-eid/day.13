using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace systemMovies.Migrations
{
    /// <inheritdoc />
    public partial class _55 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_actorsMovies",
                table: "actorsMovies");

            migrationBuilder.RenameTable(
                name: "actorsMovies",
                newName: "actorMovies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actorMovies",
                table: "actorMovies",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_actorMovies",
                table: "actorMovies");

            migrationBuilder.RenameTable(
                name: "actorMovies",
                newName: "actorsMovies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actorsMovies",
                table: "actorsMovies",
                column: "Id");
        }
    }
}
