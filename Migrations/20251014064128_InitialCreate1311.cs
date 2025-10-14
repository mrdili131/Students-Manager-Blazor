using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bogcha.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1311 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExist",
                table: "Attendances",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExist",
                table: "Attendances");
        }
    }
}
