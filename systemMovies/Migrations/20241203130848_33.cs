using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace systemMovies.Migrations
{
    /// <inheritdoc />
    public partial class _33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_actorsMovie",
                table: "actorsMovie");

            migrationBuilder.RenameTable(
                name: "actorsMovie",
                newName: "actorsMovies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actorsMovies",
                table: "actorsMovies",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_actorsMovies",
                table: "actorsMovies");

            migrationBuilder.RenameTable(
                name: "actorsMovies",
                newName: "actorsMovie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actorsMovie",
                table: "actorsMovie",
                column: "Id");
        }
    }
}
