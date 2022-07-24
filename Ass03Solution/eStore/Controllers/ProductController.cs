using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessObject;
using DataAccess.Repository;
using System;

namespace eStore.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository productRepository = null;
        public ProductController() => productRepository = new ProductRepository();
        // GET: ProductController
        public ActionResult Index(string name)
        {
            var productList = productRepository.GetProducts();
            if (!string.IsNullOrEmpty(name))
            {
                productList = productRepository.GetProductByName(name);
            }
            return View(productList);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProductById(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    productRepository.AddProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(product);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProductById(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                if (id != product.ProductId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    productRepository.UpdateProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProductById(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                productRepository.RemoveProduct(id);
                return RedirectToAction(nameof(Index));
            } 
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
