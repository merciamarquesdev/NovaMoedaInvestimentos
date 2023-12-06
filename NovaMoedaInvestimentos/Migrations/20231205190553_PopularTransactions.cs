using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaMoedaInvestimentos.Migrations
{
    public partial class PopularTransactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO " +
                "Transactions (UserAccountId, StockId, ETransactionType, Amount, Timestamp) " +
                "VALUES (1, 1, 1, 53.21, '2023-11-18T18:51:02')");
            // joao (id=1) comprou (1) uma stock da Apple (id=1) nessa data e hora

            migrationBuilder.Sql("INSERT INTO " +
                "Transactions (UserAccountId, StockId, ETransactionType, Amount, Timestamp) " +
                "VALUES (2, 2, 1, 22.34, '2023-09-01T15:55:05')");
            // maria (id=2) comprou (1) uma stock da Microsoft (id=2) nessa data e hora

            migrationBuilder.Sql("INSERT INTO " +
                "Transactions (UserAccountId, StockId, ETransactionType, Amount, Timestamp) " +
                "VALUES (3, NULL, 3, 500.00, '2023-10-02T10:30:40')");
            // pedro (id=3) depositou (3) 500.00 reais em sua conta nessa data e hora

            migrationBuilder.Sql("INSERT INTO " +
                "Transactions (UserAccountId, StockId, ETransactionType, Amount, Timestamp) " +
                "VALUES (4, NULL, 4, 150.00, '2023-12-02T15:01:10')");
            // ana (id=4) sacou (4) 150.00 reais de sua conta nessa data e hora

            migrationBuilder.Sql("INSERT INTO " +
                "Transactions (UserAccountId, StockId, ETransactionType, Amount, Timestamp) " +
                "VALUES (2, 2, 2, 31.57, '2023-12-10T10:01:10')");
            // maria (id=2) vendeu (2) uma stock da Microsoft (id=2) nessa data e hora
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Transactions");
        }
    }
}
