using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using BusinessObject;
using DataAccess.Repository;

namespace eStore.Controllers
{
    public class SaleController : Controller
    {
        ISaleRepository saleRepository = null;
        public SaleController()
        {
            saleRepository = new SaleRepository();
        }
        // GET: SaleController
        public ActionResult Index(string startDate, string endDate)
        {
            var saleList = saleRepository.GetSales();
            if (!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate)){
                saleList = saleRepository.GetSaleDate(DateTime.Parse(startDate), DateTime.Parse(endDate));
            }
            return View(saleList);
            
        }

        // GET: SaleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SaleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SaleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
