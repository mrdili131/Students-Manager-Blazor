using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bogcha.Migrations
{
    /// <inheritdoc />
    public partial class newest23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Groups",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Groups");
        }
    }
}
