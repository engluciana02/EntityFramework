using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", new string[] {"Nome","AnoLancamento"}, new object[] {"Eu te devoro", "1997"});
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Oceano", "1989" });
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Flor de Lis", "1900" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musicas");
        }
    }
}
