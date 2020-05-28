using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteTec.Infra.Data.Migrations
{
    public partial class InitialBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dimensao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDimensao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Morty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ricks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDimensao = table.Column<int>(nullable: false),
                    IdMorty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ricks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ricks_Dimensao_IdDimensao",
                        column: x => x.IdDimensao,
                        principalTable: "Dimensao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ricks_Morty_IdMorty",
                        column: x => x.IdMorty,
                        principalTable: "Morty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_IdDimensao",
                table: "Ricks",
                column: "IdDimensao");

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_IdMorty",
                table: "Ricks",
                column: "IdMorty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ricks");

            migrationBuilder.DropTable(
                name: "Dimensao");

            migrationBuilder.DropTable(
                name: "Morty");
        }
    }
}
