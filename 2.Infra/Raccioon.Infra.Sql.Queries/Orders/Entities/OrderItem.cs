namespace Raccioon.Infra.Sql.Queries.Orders.Entities
{
    public class OrderItem
    {
        public string ProductTitle { get; set; }
        public long Price { get; set; }
        public int Units { get; set; }
        public int CatalogItemId { get; set; }
    }
}
