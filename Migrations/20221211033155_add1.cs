using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnoSewa.Migrations
{
    /// <inheritdoc />
    public partial class add1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_problem_registerModel_UserId",
                table: "tbl_problem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_registerModel",
                table: "registerModel");

            migrationBuilder.RenameTable(
                name: "registerModel",
                newName: "tbl_register");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_register",
                table: "tbl_register",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "tbl_book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookvalue = table.Column<int>(name: "book_value", type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_book_tbl_register_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_register",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_book_UserId",
                table: "tbl_book",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_problem_tbl_register_UserId",
                table: "tbl_problem",
                column: "UserId",
                principalTable: "tbl_register",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_problem_tbl_register_UserId",
                table: "tbl_problem");

            migrationBuilder.DropTable(
                name: "tbl_book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_register",
                table: "tbl_register");

            migrationBuilder.RenameTable(
                name: "tbl_register",
                newName: "registerModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_registerModel",
                table: "registerModel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_problem_registerModel_UserId",
                table: "tbl_problem",
                column: "UserId",
                principalTable: "registerModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
