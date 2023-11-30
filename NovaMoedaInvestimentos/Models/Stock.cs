namespace NovaMoedaInvestimentos.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double CurrentPrice { get; set; }
        public string Image { get; set; }

    }
}
