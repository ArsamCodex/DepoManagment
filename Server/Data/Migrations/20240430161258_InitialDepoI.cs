using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepoManagment.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDepoI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "extractBoxDepartments",
                columns: table => new
                {
                    ExtractBoxDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoxBarcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtractDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Staff = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_extractBoxDepartments", x => x.ExtractBoxDepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "receiveBoxPoints",
                columns: table => new
                {
                    ReceiveBoxPointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BoxBarcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarPlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarPlateNumberCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Staff = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receiveBoxPoints", x => x.ReceiveBoxPointId);
                });

            migrationBuilder.CreateTable(
                name: "parts",
                columns: table => new
                {
                    PartsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartBarcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateComeIn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateGoesOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlaceInDepoToGo = table.Column<int>(type: "int", nullable: false),
                    ExtractBoxDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parts", x => x.PartsId);
                    table.ForeignKey(
                        name: "FK_parts_extractBoxDepartments_ExtractBoxDepartmentId",
                        column: x => x.ExtractBoxDepartmentId,
                        principalTable: "extractBoxDepartments",
                        principalColumn: "ExtractBoxDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_parts_ExtractBoxDepartmentId",
                table: "parts",
                column: "ExtractBoxDepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "parts");

            migrationBuilder.DropTable(
                name: "receiveBoxPoints");

            migrationBuilder.DropTable(
                name: "extractBoxDepartments");
        }
    }
}
