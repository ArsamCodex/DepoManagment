using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepoManagment.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initialy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBoxFinishedToGoOut",
                table: "receivBox",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBoxFinishedToGoOut",
                table: "receivBox");
        }
    }
}
