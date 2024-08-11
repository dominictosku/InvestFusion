using InvestFusion.Core.Entities.Enums;

namespace InvestFusion.Core.Entities
{
    public class Transactions
    {
        public int Id { get; set; }
        public Stock Stock { get; set; } = new Stock();
        public decimal Price { get; set; }
        public int Count { get; set; }
        public OrderType OrderType { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
