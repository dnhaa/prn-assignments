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
        public Product GetProductById(int productID) => ProductDAO.Instance.GetProductById(productID);
        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProducts();
        public void AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);
        public void RemoveProduct(int productID) => ProductDAO.Instance.RemoveProduct(productID);
        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);

        public IEnumerable<Product> GetProductByName(string name) => ProductDAO.Instance.GetProductByName(name);
    }
}
