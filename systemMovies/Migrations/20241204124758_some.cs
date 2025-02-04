﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace systemMovies.Migrations
{
    /// <inheritdoc />
    public partial class some : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActorsId",
                table: "ActorMovies");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "ActorMovies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActorsId",
                table: "ActorMovies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MoviesId",
                table: "ActorMovies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
