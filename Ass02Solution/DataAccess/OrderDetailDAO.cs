using System.Data;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class OrderDetailDAO : BaseDAL
    {
        private static OrderDetailDAO instance;
        private static readonly object instanceLock = new Object();
        private OrderDetailDAO () { }
        public static OrderDetailDAO Instance { 
            get 
            { 
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO ();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Object> GetOrderDetailList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT [OrderDetail].ProductId, ProductName, [OrderDetail].UnitPrice, sum(Quantity) as Quantity,SUM([OrderDetail].UnitPrice * Quantity), SUM([OrderDetail].UnitPrice * (1 - Discount) * Quantity) FROM [OrderDetail], [Product] WHERE [OrderDetail].ProductId = [Product].ProductId GROUP BY [OrderDetail].ProductID, ProductName, [OrderDetail].UnitPrice ORDER BY [OrderDetail].ProductId";
            var orderDetails = new List<Object>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orderDetails.Add(new 
                    {
                        //ProductId
                        ProductId = dataReader.GetInt32(0),
                        //ProductName
                        ProductName = dataReader.GetString(1),
                        //UnitPrice
                        UnitPrice = dataReader.GetDecimal(2),
                        //Quantity
                        QuantitySold = dataReader.GetInt32(3),
                        //Sales before Discount
                        SalesBeforeDiscount = dataReader.GetDecimal(4),
                        //Total = UnitPrice * (1 - Discount) * Quantity)
                        SalesAfterDiscount = Convert.ToDecimal(dataReader.GetDouble(5)).ToString("0.0000")
                    }
                        
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return orderDetails;
        }

        public IEnumerable<Object> SortSalesDescending()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT [OrderDetail].ProductId, ProductName, [OrderDetail].UnitPrice, sum(Quantity) as Quantity,SUM([OrderDetail].UnitPrice * Quantity), SUM([OrderDetail].UnitPrice * (1 - Discount) * Quantity) FROM [OrderDetail], [Product] WHERE [OrderDetail].ProductId = [Product].ProductId GROUP BY [OrderDetail].ProductID, ProductName, [OrderDetail].UnitPrice ORDER BY SUM([OrderDetail].UnitPrice * (1 - Discount) * Quantity) DESC";
            var orderDetails = new List<Object>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orderDetails.Add(new
                    {
                        //ProductId
                        ProductId = dataReader.GetInt32(0),
                        //ProductName
                        ProductName = dataReader.GetString(1),
                        //UnitPrice
                        UnitPrice = dataReader.GetDecimal(2),
                        //Quantity
                        QuantitySold = dataReader.GetInt32(3),
                        //Sales before Discount
                        SalesBeforeDiscount = dataReader.GetDecimal(4),
                        //Total = UnitPrice * (1 - Discount) * Quantity)
                        SalesAfterDiscount = Convert.ToDecimal(dataReader.GetDouble(5)).ToString("0.0000")
                    }

                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return orderDetails;
        }

        public IEnumerable<Object> FilterDate(DateTime startDate, DateTime endDate)
        {
            if (DateTime.Compare(startDate, endDate) > 0)
            {
                throw new Exception("Start date has to be before End date.");
            }
            IDataReader dataReader = null;
            string SQLSelect = "SELECT [OrderDetail].ProductId, ProductName, [OrderDetail].UnitPrice, sum(Quantity) as Quantity,SUM([OrderDetail].UnitPrice * Quantity), SUM([OrderDetail].UnitPrice * (1 - Discount) * Quantity) FROM [OrderDetail], [Product], [Order] WHERE [OrderDetail].ProductId = [Product].ProductId AND [OrderDetail].OrderId = [Order].OrderId　AND [Order].OrderDate BETWEEN @startDate AND @endDate GROUP BY [OrderDetail].ProductID, ProductName, [OrderDetail].UnitPrice ORDER BY [OrderDetail].ProductId";
            var parameters = new List<SqlParameter>();
            parameters.Add(dataProvider.CreateParameter("@startDate", 10, startDate, DbType.DateTime));
            parameters.Add(dataProvider.CreateParameter("@endDate", 10, endDate, DbType.DateTime));

            var orderDetails = new List<Object>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                while (dataReader.Read())
                {
                    orderDetails.Add(new
                    {
                        //ProductId
                        ProductId = dataReader.GetInt32(0),
                        //ProductName
                        ProductName = dataReader.GetString(1),
                        //UnitPrice
                        UnitPrice = dataReader.GetDecimal(2),
                        //Quantity
                        QuantitySold = dataReader.GetInt32(3),
                        //Sales before Discount
                        SalesBeforeDiscount = dataReader.GetDecimal(4),
                        //Total = UnitPrice * (1 - Discount) * Quantity)
                        SalesAfterDiscount = Convert.ToDecimal(dataReader.GetDouble(5)).ToString("0.0000")
                    });
                }
                if (orderDetails.Count < 1)
                {
                    throw new Exception("No sales found in this time range.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return orderDetails;
        }
        //-----------------------------

        /*public IEnumerable<Object> GetOrderDetailList()
        {
            FStoreContext db = new FStoreContext();
            var orderDetails = (from od in db.OrderDetails
                    join p in db.Products on od.ProductId equals p.ProductId
                    group new { od, p } by new { od.ProductId, p.ProductName, od.UnitPrice, od.Quantity, od.Discount}
                    into grp
                    select new
                    {
                        ProductId = grp.Key.ProductId,
                        ProductName = grp.Key.ProductName,
                        UnitPrice = grp.Key.UnitPrice, 
                        QuantitySold = grp.Sum(x => grp.Key.Quantity),
                        TotalPrice = grp.Sum(x => grp.Key.UnitPrice * (decimal)
                        (1 - grp.Key.Discount) * grp.Key.Quantity)
                    }).ToList();
            return (IEnumerable<Object> )orderDetails;
        }*/
    }
}
