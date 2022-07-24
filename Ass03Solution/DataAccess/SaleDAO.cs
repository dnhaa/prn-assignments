using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class SaleDAO
    {
        private static SaleDAO instance = null;
        private static readonly object instanceLock = new object();
        public static SaleDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SaleDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Sale> GetSale()
        {
            try
            {
                var sale = new List<Sale>();
                FStoreContext context = new FStoreContext();
                /*using var context = new FStoreContext();
                orders = context.Orders.ToList();*/
                sale = (from order in context.Orders
                        join orderDetail in context.OrderDetails
                        on order.OrderId equals orderDetail.OrderId
                        join product in context.Products
                        on orderDetail.ProductId equals product.ProductId
                        group new { orderDetail.Quantity, orderDetail.Discount, orderDetail.ProductId, product.ProductName, orderDetail.UnitPrice } by new { orderDetail.ProductId, product.ProductName, orderDetail.UnitPrice }
                           into g
                        orderby g.Key.ProductId
                        select new Sale
                        {
                            ProductId = g.Key.ProductId,
                            ProductName = g.Key.ProductName,
                            UnitPrice = g.Key.UnitPrice,
                            Quantity = g.Sum(x => x.Quantity),
                            SubTotal = g.Sum(x => x.UnitPrice * x.Quantity),
                            Total = g.Sum(x => Convert.ToInt32(x.UnitPrice) * (1 - x.Discount) * x.Quantity)
                        }).ToList();
                return sale;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public IEnumerable<Sale> GetSaleDate(DateTime startDate, DateTime endDate)
        {
            try
            {
                var sale = new List<Sale>();
                FStoreContext context = new FStoreContext();
                /*using var context = new FStoreContext();
                orders = context.Orders.ToList();*/
                sale = (from order in context.Orders
                        join orderDetail in context.OrderDetails
                        on order.OrderId equals orderDetail.OrderId
                        join product in context.Products
                        on orderDetail.ProductId equals product.ProductId
                        where order.OrderDate >= startDate && order.OrderDate <= endDate
                        group new { orderDetail.Quantity, orderDetail.Discount, orderDetail.ProductId, product.ProductName, orderDetail.UnitPrice } by new { orderDetail.ProductId, product.ProductName, orderDetail.UnitPrice }
                           into g
                        orderby g.Key.ProductId
                        select new Sale
                        {
                            ProductId = g.Key.ProductId,
                            ProductName = g.Key.ProductName,
                            UnitPrice = g.Key.UnitPrice,
                            Quantity = g.Sum(x => x.Quantity),
                            SubTotal = g.Sum(x => x.UnitPrice * x.Quantity),
                            Total = g.Sum(x => Convert.ToInt32(x.UnitPrice) * (1 - x.Discount) * x.Quantity),
                            StartDate = startDate,
                            EndDate = endDate
                        }).ToList();
                return sale;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
