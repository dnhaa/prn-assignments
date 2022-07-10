using System.Collections;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<Object> GetOrderDetailList();
        IEnumerable<Object> SortSalesDescending();
        IEnumerable<Object> FilterDate(DateTime startDate, DateTime endDate);

    }
}
