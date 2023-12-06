using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaMoedaInvestimentos.Migrations
{
    public partial class PopularStocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('Apple', 'AAPL', ROUND(RAND() * 100, 2), 'https://logodownload.org/wp-content/uploads/2013/12/apple-logo-0.png', 1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('Microsoft', 'MSFT', ROUND(RAND() * 100, 2), 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Microsoft_logo.svg/2048px-Microsoft_logo.svg.png',1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('Amazon', 'AMZO', ROUND(RAND() * 100, 2), 'https://logopng.com.br/logos/amazon-2.png',0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('Nike', 'NIKE', ROUND(RAND() * 100, 2), 'https://static.vecteezy.com/ti/vetor-gratis/t2/20336375-nike-logotipo-nike-icone-livre-gratis-vetor.jpg',1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('McDonalds', 'MCDC', ROUND(RAND() * 100, 2), 'https://logodownload.org/wp-content/uploads/2014/04/mcdonalds-logo-8.png',0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('Ford Motor Company', 'FDMO', ROUND(RAND() * 100, 2), 'https://t.ctcdn.com.br/hpZcAbxW4kLuTY6_IHO7o0mI6rI=/i632356.png',0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('Arezzo', 'ARZZ', ROUND(RAND() * 100, 2), 'https://logodownload.org/wp-content/uploads/2019/09/arezzo-logo-0.png',0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('Magazine Luiza', 'MGLU', ROUND(RAND() * 100, 2), 'https://logodownload.org/wp-content/uploads/2014/06/magalu-logo-0.png',0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('Avon', 'AVON', ROUND(RAND() * 100, 2), 'https://gkpb.com.br/wp-content/uploads/2021/01/novo-logo-avon-png.png',0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES ('Vivara', 'VIVA', ROUND(RAND() * 100, 2), 'https://logodownload.org/wp-content/uploads/2019/10/vivara-logo-0.png',1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Stocks");
        }
    }
}
