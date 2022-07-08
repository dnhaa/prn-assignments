using System.Collections;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<Tuple<int, string, decimal, int, decimal>> GetOrderDetailList();
    }
}
