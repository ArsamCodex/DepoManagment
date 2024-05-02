using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepoManagment.Server.Migrations
{
    /// <inheritdoc />
    public partial class Secooidhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Staff",
                table: "enveloopExtracts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "enveloopExtracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Staff",
                table: "enveloopExtracts");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "enveloopExtracts");
        }
    }
}
