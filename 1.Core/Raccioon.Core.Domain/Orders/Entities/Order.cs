using Raccioon.Core.Domain.Orders.ValueObjects;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using static Raccioon.Core.Domain.Orders.Entities.OrderState;

namespace Raccioon.Core.Domain.Orders.Entities
{
    public class Order:AggregateRoot
    {

        #region Properties
        public Title Title { get; private set; }
        public Description Description { get; private set; }
        public DateTime OrderDate { get; private set; }
        public OrderStatus OrderStatus { get; private set; }

        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public bool isRemoved { get; private set; }

        public long  PersonId { get; private set; }

        #endregion

        #region Constructors
        public Order(Title title, Description description)
        {
            Title = title;
            Description = description;
            OrderStatus = OrderStatus.Processing;
        }

        public Order(Title title, Description description, List<OrderItem> orderItems)
        {
            //Delegate OrderValidationCollection;

            long priceMinLimit = 5000;
            Title = title;
            Description = description;
            _orderItems = orderItems;
            long totalPrice = TotalPrice();
            if (totalPrice < priceMinLimit)
            {
                throw new InvalidEntityStateException("ValidationErrorTotalPrice", priceMinLimit.ToString());
            }
            OrderStatus = OrderStatus.Processing;
        }
        private Order()
        {

        }
        #endregion

        #region Behaviours 

        public void AssignPerson(long personId)
        {
            this.Id = personId;
        }

        public long TotalPrice() => _orderItems.Sum(p => p.Price.Value * p.Units);

        public void AddOrderItem(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
        }

        public void AddOrderItem(Title productTitle , Price price ,int unit ,int catalogItemId)
        {
            _orderItems.Add(new OrderItem(catalogItemId,unit ,price,productTitle));
        }

        public void OrderDelivered()
        {
            if (OrderStatus != OrderStatus.Processing)
                throw new InvalidEntityStateException("ValidationStatusError", OrderStatus.Processing.ToString());
            else
            OrderStatus = OrderStatus.Delivered;
        }

        public void OrderReturned()
        {
            if (OrderStatus != OrderStatus.Delivered)
                throw new InvalidEntityStateException("ValidationStatusError", OrderStatus.Delivered.ToString());
            else
            OrderStatus =OrderStatus.Returned;
        }

        public void OrderCancelled()
        {
            if (OrderStatus != OrderStatus.Processing)
                throw new InvalidEntityStateException("ValidationStatusError", OrderStatus.Processing.ToString());
            else
            OrderStatus =OrderStatus.Cancelled;
        }

        public void DeleteAllItems()
        {
            _orderItems.Clear();

        }

        #endregion

    }
}
