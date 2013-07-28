using ActionService;
using ActionService.ViewModel;
using Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerceDemoz.Controllers
{
    public class ProductsController : Controller
    {
        private IServiceAccess _service = new ServiceAccess();
        //
        // GET: /Products/

        public ActionResult Index()
        {
            ProductResponse _Products = _service.DisplayProducts();
            return View(_Products);
        }
        //
        // GET: /Products/Details/5

        public ActionResult CartDetail()
        {
            ShoppingCart cart = _service.DisplayCart();
            return View(cart.Items);
        }

        //
        // GET: /Products/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Products/Create

        public ActionResult Create()
        {
            ProductResponse _Products = _service.DisplayProducts();
            return View(_Products);
        }

        //
        // POST: /Products/Create

        [HttpPost]
        public ActionResult Create(ProductResponse prodres, FormCollection frm)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Products/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Products/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Products/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Products/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
