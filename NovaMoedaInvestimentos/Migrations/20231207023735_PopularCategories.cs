using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaMoedaInvestimentos.Migrations
{
    public partial class PopularCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) " +
                "VALUES('Financeiro','Bancos e serviços financeiros diversos.')");

            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) " +
                "VALUES('Petróleo e Gás','Exploração, refino e distribuição de Petróleo e Gás.')");

            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) " +
                "VALUES('Saúde','Serviços médicos e hospitalares, Análises, Diagnósticos, Medicamentos e Outros Produtos.')");

            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) " +
                "VALUES('Serviços','Serviços diversos.')");

            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) " +
                "VALUES('Tecnologia da Informação','Programas e Serviços.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
