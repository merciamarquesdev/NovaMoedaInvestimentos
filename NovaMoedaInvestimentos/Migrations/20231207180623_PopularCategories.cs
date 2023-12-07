using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaMoedaInvestimentos.Migrations
{
    public partial class PopularCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(Name) " +
                "VALUES('Financeiro')");

            migrationBuilder.Sql("INSERT INTO Categories(Name) " +
                "VALUES('Petróleo e Gás')");

            migrationBuilder.Sql("INSERT INTO Categories(Name) " +
                "VALUES('Saúde')");

            migrationBuilder.Sql("INSERT INTO Categories(Name) " +
                "VALUES('Serviços')");

            migrationBuilder.Sql("INSERT INTO Categories(Name) " +
                "VALUES('Tecnologia da Informação')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
