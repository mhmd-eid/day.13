using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace systemMovies.Migrations
{
    /// <inheritdoc />
    public partial class _88 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActorsId",
                table: "ActorMovies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MoviesId",
                table: "ActorMovies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActorsId",
                table: "ActorMovies");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "ActorMovies");
        }
    }
}
