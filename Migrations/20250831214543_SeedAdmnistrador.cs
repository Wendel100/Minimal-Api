using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Minimal_Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdmnistrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "administradores",
                columns: new[] { "Id", "Email", "Perfil", "Senha" },
                values: new object[] { 1, "admin@teste.com", "Adm", "1234" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "administradores",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
