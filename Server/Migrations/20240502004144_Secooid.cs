using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepoManagment.Server.Migrations
{
    /// <inheritdoc />
    public partial class Secooid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnveloopNumber",
                table: "enveloopExtracts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnveloopNumber",
                table: "enveloopExtracts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
