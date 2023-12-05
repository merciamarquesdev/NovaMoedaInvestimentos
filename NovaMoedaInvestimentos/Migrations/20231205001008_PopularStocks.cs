using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaMoedaInvestimentos.Migrations
{
    public partial class PopularStocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('Apple', 'AAPL', 45.62, 'https://logodownload.org/wp-content/uploads/2013/12/apple-logo-0.png')");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('Microsoft', 'MSFT', 74.87, 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Microsoft_logo.svg/2048px-Microsoft_logo.svg.png')");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('Amazon', 'AMZO', 35.48, 'https://logopng.com.br/logos/amazon-2.png')");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('Nike', 'NIKE', 51.63, 'https://static.vecteezy.com/ti/vetor-gratis/t2/20336375-nike-logotipo-nike-icone-livre-gratis-vetor.jpg')");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('McDonalds', 'MCDC', 65.84, 'https://logodownload.org/wp-content/uploads/2014/04/mcdonalds-logo-8.png')");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('Ford Motor Company', 'FDMO', 50.59, 'https://t.ctcdn.com.br/hpZcAbxW4kLuTY6_IHO7o0mI6rI=/i632356.png')");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('Arezzo', 'ARZZ', 58.14, 'https://logodownload.org/wp-content/uploads/2019/09/arezzo-logo-0.png')");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('Magazine Luiza', 'MGLU', 1.76, 'https://logodownload.org/wp-content/uploads/2014/06/magalu-logo-0.png')");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('Avon', 'AVON', 9.40, 'https://gkpb.com.br/wp-content/uploads/2021/01/novo-logo-avon-png.png')");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (Name, Symbol, CurrentPrice, Image) " +
                "VALUES ('Vivara', 'VIVA', 28.39, 'https://logodownload.org/wp-content/uploads/2019/10/vivara-logo-0.png')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Stocks");
        }
    }
}
