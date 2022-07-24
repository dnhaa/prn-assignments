using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface ISaleRepository
    {
        IEnumerable<Sale> GetSales();
        IEnumerable<Sale> GetSaleDate(DateTime startDate, DateTime endDate);

    }
}
