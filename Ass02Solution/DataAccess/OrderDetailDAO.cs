using System.Data;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;

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

        public IEnumerable<Tuple<int, string, decimal, int, decimal>> GetOrderDetailList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT [OrderDetail].ProductId, ProductName, [OrderDetail].UnitPrice, sum(Quantity) as Quantity, SUM([OrderDetail].UnitPrice * (1 - Discount) * Quantity) as Total FROM [OrderDetail], [Product] WHERE [OrderDetail].ProductId = [Product].ProductId GROUP BY [OrderDetail].ProductID, ProductName, [OrderDetail].UnitPrice";
            var orderDetails = new List<Tuple<int, string, decimal, int, decimal> >();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orderDetails.Add(Tuple.Create<int, string, decimal, int, decimal>
                        (
                            //ProductId
                            dataReader.GetInt32(0),
                            //ProductName
                            dataReader.GetString(1),
                            //UnitPrice
                            dataReader.GetDecimal(2),
                            //Quantity
                            dataReader.GetInt32(3),
                            //Total = UnitPrice * (1 - Discount) * Quantity)
                            Convert.ToDecimal(dataReader.GetDouble(4))
                        )
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
        //-----------------------------
        
    }
}
