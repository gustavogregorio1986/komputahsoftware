using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace komputahsoftware.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tb_Usuarios",
                columns: new[] { "Id", "NomeUsuario", "Role", "Senha" },
                values: new object[] { 1, "gustavo", "User", "$2a$11$zyQI6F.RRBGQhJHSJ1bIE.ILrVObp1WT9GhGCKnTJ0ZTAVfwK7ZEe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Usuarios");
        }
    }
}
