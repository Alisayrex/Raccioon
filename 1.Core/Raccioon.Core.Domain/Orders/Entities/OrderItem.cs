using Raccioon.Core.Domain.Orders.ValueObjects;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace Raccioon.Core.Domain.Orders.Entities
{
    public class OrderItem : Entity
    {
        #region Properties

        public Title ProductTitle { get; private set; }
        public Price Price { get; private set; }
        public int Units { get; private set; }
        public int CatalogItemId { get; private set; }

        #endregion Properties

        #region Constructors

        public OrderItem(int CatalogItemId, int Units, Price Price, Title productTitle)
        {
            this.CatalogItemId = CatalogItemId;
            this.Units = Units;
            this.Price = Price;
            this.ProductTitle = productTitle;

        }

        private OrderItem()
        {

        }

        #endregion

        #region Behaviours

        #endregion



    }
}
