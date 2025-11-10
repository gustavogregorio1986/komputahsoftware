using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace komputahsoftware.Data.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tb_Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Senha",
                value: "$2a$11$NS9xnwhtbTi7taI7y0hxXugHBpfooZt6FyIBkVijfyx6GnDdWbilS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tb_Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Senha",
                value: "$2a$11$zyQI6F.RRBGQhJHSJ1bIE.ILrVObp1WT9GhGCKnTJ0ZTAVfwK7ZEe");
        }
    }
}
