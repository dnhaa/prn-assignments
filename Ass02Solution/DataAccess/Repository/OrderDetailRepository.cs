using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<object> FilterDate(DateTime startDate, DateTime endDate) => OrderDetailDAO.Instance.FilterDate(startDate, endDate);

        public IEnumerable<Object> GetOrderDetailList() => OrderDetailDAO.Instance.GetOrderDetailList();

        public IEnumerable<Object> SortSalesDescending() => OrderDetailDAO.Instance.SortSalesDescending();
    }
}
