using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnoSewa.Migrations
{
    /// <inheritdoc />
    public partial class PhoneNUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone_Number",
                table: "tbl_register",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone_Number",
                table: "tbl_register");
        }
    }
}
