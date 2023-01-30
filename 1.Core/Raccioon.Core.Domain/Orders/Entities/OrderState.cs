using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raccioon.Core.Domain.Orders.Entities
{
    public class OrderState 
    {
        public enum OrderStatus : sbyte
        {
            Processing = 0,
            Delivered = 1,
            Returned = 2,
            Cancelled = 3,
        }
    }
}
