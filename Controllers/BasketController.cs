using Ass2_Shopping_Basket.Models;
using Ass2_Shopping_Basket.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ass2_Shopping_Basket.Controllers
{
    public class BasketController : Controller
    {
        // GET: Basket
        public ActionResult Index()
        {
            Basket basket = Basket.GetBasket();
            BasketViewModel viewModel = new BasketViewModel
            {
                BasketLines = basket.GetBasketLines(),
                TotalCost = basket.GetTotalCost()
            };
            return View(viewModel);
            //return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddToBasket(int id, int quantity)
        {
            Basket basket = Basket.GetBasket();
            basket.AddToBasket(id, quantity);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateBasket(BasketViewModel viewModel)
        {
            Basket basket = Basket.GetBasket();
            basket.UpdateBasket(viewModel.BasketLines);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult RemoveLine(int id)
        {
            Basket basket = Basket.GetBasket();
            basket.RemoveLine(id);
            return RedirectToAction("Index");
        }
        public PartialViewResult Summary()
        {
            Basket basket = Basket.GetBasket();
            BasketSummaryViewModel viewModel = new BasketSummaryViewModel
            {
                NumberOfItems = basket.GetNumberOfItems(),
                TotalCost = basket.GetTotalCost()
            };
            return PartialView(viewModel);
        }
    }
}