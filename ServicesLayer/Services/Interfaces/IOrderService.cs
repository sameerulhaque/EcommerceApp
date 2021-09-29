using Commons.Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.Services.Interfaces
{
    public interface IOrderService
    {
        public Order GetAllOrders(Order Order);
        public Order AddOrder(Order order);
    }
}
