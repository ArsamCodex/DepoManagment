using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepoManagment.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDepo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BadgeNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StaffName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BadgeNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StaffName",
                table: "AspNetUsers");
        }
    }
}
