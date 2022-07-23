using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int id) => OrderDAO.Instance.Remove(id);

        public Order GetOrderByID(int id) => OrderDAO.Instance.GetOrderByID(id);

        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList();

        public void InsertOrder(Order order) => OrderDAO.Instance.AddNew(order);

        public void UpdateOrder(Order order) => OrderDAO.Instance.Update(order);
    }
}
