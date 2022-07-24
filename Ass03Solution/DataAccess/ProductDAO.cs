using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
            try
            {
                using var context = new FStoreContext();
                products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public Product GetProductById(int productId)
        {
            Product product = null;
            try
            {
                using var context = new FStoreContext();
                product = context.Products.SingleOrDefault(x => x.ProductId == productId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }
        public IEnumerable<Product> GetProductByName(string name)
        {
            var products = new List<Product>();
            try
            {
                using var context = new FStoreContext();
                products = context.Products.Where(x => x.ProductName.Contains(name)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public void AddProduct(Product product)
        {
            try
            {
                Product _product = GetProductById(product.ProductId);
                if (_product == null)
                {
                    using var context = new FStoreContext();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                Product _product = GetProductById(product.ProductId);
                if (_product != null)
                {
                    using var context = new FStoreContext();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveProduct(int productId)
        {
            try
            {
                Product product = GetProductById(productId);
                if (product != null)
                {
                    using var context = new FStoreContext();
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
