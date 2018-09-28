using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtigoSQLite.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Partido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 1, "ALVARO DIAS", 19, "PODE" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 2, "CABO DACIOLO", 51, "PATRI" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 3, "CIROS GOMES", 12, "PDT" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 4, "EYMAEL", 27, "DC" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 5, "FERNANDO HADDAD", 13, "PT" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 6, "GERALDO ALCKIMIN", 45, "PSDB" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 7, "GUILHERME BOULOS", 50, "PSOL" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 8, "HENRIQUE MEIRELLES", 15, "MDB" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 9, "JAIR BOLSONARO", 17, "PSL" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 10, "JOÃO AMOÊDO", 30, "NOVO" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 11, "JOÃO GOULART FILHO", 54, "PPL" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 12, "MARINA SILVA", 18, "REDE" });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "Nome", "Numero", "Partido" },
                values: new object[] { 13, "VERA", 17, "PSTU" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidato");
        }
    }
}
