using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepoManagment.Server.Migrations
{
    /// <inheritdoc />
    public partial class Secooidhhdsds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BoxBarcode",
                table: "enveloopExtracts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoxBarcode",
                table: "enveloopExtracts");
        }
    }
}
