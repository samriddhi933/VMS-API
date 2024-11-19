using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMS_Project_API.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "tbl_NVR",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "tbl_NVR",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "tbl_NVR",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NVRType",
                table: "tbl_NVR",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tbl_NVR",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Port",
                table: "tbl_NVR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Zone",
                table: "tbl_NVR",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "tbl_NVR");

            migrationBuilder.DropColumn(
                name: "Make",
                table: "tbl_NVR");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "tbl_NVR");

            migrationBuilder.DropColumn(
                name: "NVRType",
                table: "tbl_NVR");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "tbl_NVR");

            migrationBuilder.DropColumn(
                name: "Port",
                table: "tbl_NVR");

            migrationBuilder.DropColumn(
                name: "Zone",
                table: "tbl_NVR");
        }
    }
}
