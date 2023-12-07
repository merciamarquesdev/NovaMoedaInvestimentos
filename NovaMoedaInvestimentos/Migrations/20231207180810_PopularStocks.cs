using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaMoedaInvestimentos.Migrations
{
    public partial class PopularStocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (1, 'XP Inc', 'XPBR', 99.10, 'https://logodownload.org/wp-content/uploads/2019/07/xp-investimentos-logo-8.png', 1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (1, 'Stone', 'STOC', ROUND(RAND() * 100, 2), 'https://logodownload.org/wp-content/uploads/2022/10/stone-logo-0.png', 0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (1, 'Banco do Brasil', 'BBAS', ROUND(RAND() * 100, 2), 'https://cdn.freebiesupply.com/logos/large/2x/banco-do-brasil-2-logo-png-transparent.png', 1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (1, 'Banco BTG Pactual', 'BPAC', ROUND(RAND() * 100, 2), 'https://e3ba6e8732e83984.cdn.gocache.net/uploads/image/file/96916/regular_logobtg.png', 1)");


            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (2, 'Petrobrás', 'PETR', ROUND(RAND() * 100, 2), 'https://seeklogo.com/images/P/Petrobras-logo-03DABEE0AC-seeklogo.com.png', 1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (2, 'Petrorio', 'PRIO', ROUND(RAND() * 100, 2), 'https://analise.orama.com.br/wp-content/uploads/2023/02/prio.png',0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (2, 'Raízen', 'RAIZ', ROUND(RAND() * 100, 2), 'https://www.raizen.com.br/img/frontend/header/logo.svg',0)");


            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (3, 'Raia Drogasil', 'RADL', ROUND(RAND() * 100, 2), 'https://assets.hgbrasil.com/finance/companies/big/raiadrogasil.png', 0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (3, 'Rede Dor São Luiz', 'RDOR', ROUND(RAND() * 100, 2), 'https://financenews.com.br/wp-content/uploads/2021/02/Dor-300x238.png',1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (3, 'Oncoclínicas do Brasil', 'ONCO', ROUND(RAND() * 100, 2), 'https://oncoclinicas-assets-wordpress-prd.s3.amazonaws.com/wp-content/uploads/2022/02/logo-oncoclinicas.png',0)");


            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (4, 'Azul', 'AZUL', ROUND(RAND() * 100, 2), 'https://attachments.gupy.io/production/companies/727/career/938/images/2020-08-14_13-12_logo.jpg', 0)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (4, 'Gol', 'GOLL', ROUND(RAND() * 100, 2), 'https://gkpb.com.br/wp-content/uploads/2018/10/novo-logo-gol-2018.jpg',1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (4, 'Sequoia', 'SEQL', ROUND(RAND() * 100, 2), 'https://1.bp.blogspot.com/-mjTLvMw1uyY/XsxPYOMPM_I/AAAAAAAAANI/2eC4c0TIzKA8syWmBKbJyUxolLZl5QNSQCLcBGAsYHQ/s1600/Sequoia.png',0)");


            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (5, 'Apple', 'AAPL', ROUND(RAND() * 100, 2), 'https://logodownload.org/wp-content/uploads/2013/12/apple-logo-0.png', 1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (5, 'Microsoft', 'MSFT', ROUND(RAND() * 100, 2), 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Microsoft_logo.svg/2048px-Microsoft_logo.svg.png',1)");

            migrationBuilder.Sql("INSERT INTO " +
                "Stocks (CategoryId, Name, Symbol, CurrentPrice, Image, IsFavoriteStock) " +
                "VALUES (5, 'Amazon', 'AMZO', ROUND(RAND() * 100, 2), 'https://logopng.com.br/logos/amazon-2.png',0)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Stocks");
        }
    }
}
