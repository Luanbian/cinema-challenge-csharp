using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaChallenge.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMoviesColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Movies",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Movies",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Movies",
                type: "tinyint(1)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Movies");
        }
    }
}
