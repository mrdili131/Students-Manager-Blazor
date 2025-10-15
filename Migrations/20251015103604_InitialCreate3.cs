using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bogcha.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Clients_ClientId",
                table: "Attendances");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Clients_ClientId",
                table: "Attendances",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Clients_ClientId",
                table: "Attendances");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Clients_ClientId",
                table: "Attendances",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }
    }
}
