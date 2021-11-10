using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testCrud.Migrations
{
    public partial class outrasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutoresId",
                table: "Livro",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Editora",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CPNJ = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editora", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<int>(nullable: false),
                    Celular = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    EditoraId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Autores_Editora_EditoraId",
                        column: x => x.EditoraId,
                        principalTable: "Editora",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_AutoresId",
                table: "Livro",
                column: "AutoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Autores_EditoraId",
                table: "Autores",
                column: "EditoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Autores_AutoresId",
                table: "Livro",
                column: "AutoresId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Autores_AutoresId",
                table: "Livro");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Editora");

            migrationBuilder.DropIndex(
                name: "IX_Livro_AutoresId",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "AutoresId",
                table: "Livro");
        }
    }
}
