using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca2._0.Data.Migrations
{
    public partial class CadLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Genero = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    Valor = table.Column<int>(nullable: false),
                    LinkImg = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
