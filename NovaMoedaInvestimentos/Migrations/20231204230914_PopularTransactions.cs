using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaMoedaInvestimentos.Migrations
{
    public partial class PopularTransactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO" +
                "Transactions(UserAccountId, StockId, ETransactionType, Amount, Timestamp" +
                "VALUES(1, NULL, 3, 500.00, '2023-10-02T10:30:40')");

            migrationBuilder.Sql("INSERT INTO" +
                "Transactions(UserAccountId, StockId, ETransactionType, Amount, Timestamp" +
                "VALUES(2, 1, 1, 100.00, '2023-11-18T18:51:02')");

            migrationBuilder.Sql("INSERT INTO" +
                "Transactions(UserAccountId, StockId, ETransactionType, Amount, Timestamp" +
                "VALUES(3, 2, 2, 30.00, '2023-12-01T12:32:05')");

            migrationBuilder.Sql("INSERT INTO" +
                "Transactions(UserAccountId, StockId, ETransactionType, Amount, Timestamp" +
                "VALUES(4, 3, 4, 150.00, '2023-12-02T15:01:10')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Transactions");
        }
    }
}
