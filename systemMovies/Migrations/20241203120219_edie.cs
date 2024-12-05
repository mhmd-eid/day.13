using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace systemMovies.Migrations
{
    /// <inheritdoc />
    public partial class edie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndData",
                table: "movies",
                newName: "EndDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "movies",
                newName: "EndData");
        }
    }
}
