using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnoSewa.Migrations
{
    /// <inheritdoc />
    public partial class tblproblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_problem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PipeLeakage = table.Column<string>(name: "Pipe_Leakage", type: "nvarchar(max)", nullable: false),
                    TapReplacement = table.Column<string>(name: "Tap_Replacement", type: "nvarchar(max)", nullable: false),
                    BasinReplacement = table.Column<string>(name: "Basin_Replacement", type: "nvarchar(max)", nullable: false),
                    CommodeReplacement = table.Column<string>(name: "Commode_Replacement", type: "nvarchar(max)", nullable: false),
                    OtherProblems = table.Column<string>(name: "Other_Problems", type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_problem", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_problem_tbl_register_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_register",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_problem_UserId",
                table: "tbl_problem",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_problem");
        }
    }
}
