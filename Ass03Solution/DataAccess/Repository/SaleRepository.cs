using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class SaleRepository : ISaleRepository
    {
        public IEnumerable<Sale> GetSaleDate(DateTime startDate, DateTime endDate) => SaleDAO.Instance.GetSaleDate(startDate, endDate);

        public IEnumerable<Sale> GetSales() => SaleDAO.Instance.GetSale();  
    }
}
