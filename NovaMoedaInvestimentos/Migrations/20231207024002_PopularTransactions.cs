using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaMoedaInvestimentos.Migrations
{
    public partial class PopularTransactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO " +
                "UserAccounts (UserName, Balance) " +
                "VALUES ('joao@gmail.com', 4500.00)");

            migrationBuilder.Sql("INSERT INTO " +
                "UserAccounts (UserName, Balance) " +
                "VALUES ('maria@gmail.com', 1000.00)");

            migrationBuilder.Sql("INSERT INTO " +
                "UserAccounts (UserName, Balance) " +
                "VALUES ('pedro@gmail.com', 500.00)");

            migrationBuilder.Sql("INSERT INTO " +
                "UserAccounts (UserName, Balance) " +
                "VALUES ('ana@gmail.com', 800.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM UserAccounts");
        }
    }
}
