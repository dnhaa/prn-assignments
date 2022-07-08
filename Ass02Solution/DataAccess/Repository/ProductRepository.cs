using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int productId) => ProductDAO.Instance.RemoveProduct(productId);

        public Product GetProductById(int productId) => ProductDAO.Instance.GetProductById(productId);

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();

        public void InsertProduct(Product product) => ProductDAO.Instance.AddNewProduct(product);

        public IEnumerable<Product> SearchProductBy(string option, string input) => ProductDAO.Instance.SearchProductBy(option, input);

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);   
    }
}
