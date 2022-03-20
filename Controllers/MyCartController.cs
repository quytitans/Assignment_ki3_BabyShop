using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssignmentWCD_BabyFashionShop.Data;
using AssignmentWCD_BabyFashionShop.Models;

namespace AssignmentWCD_BabyFashionShop.Controllers
{
    public class MyCartController : Controller
    {
        private ProductDBcontext db = new ProductDBcontext();
        // GET: MyCart
        public ActionResult Index()
        {
            List<CartItem> currentCartItems = Session["ShoppingCartNow"] as List<CartItem>;
            return View("Index",currentCartItems);
        }

        public ActionResult Add(int ProductIDInput)
        {
            if (Session["ShoppingCartNow"] == null)
            {
                Session["ShoppingCartNow"] = new List<CartItem>();
            }
            List<CartItem> shoppingCartNow = Session["ShoppingCartNow"] as List<CartItem>;

            if (shoppingCartNow.FirstOrDefault(m => m.ProductId == ProductIDInput) == null)
            {
                Clothes product = db.Clothes.Find(ProductIDInput);

                CartItem newItem = new CartItem()
                {
                    ProductId = ProductIDInput,
                    ProductName = product.Name,
                    Quantity = 1,
                    UnitPrice = product.Price,
                };

                shoppingCartNow.Add(newItem);
                Debug.WriteLine(shoppingCartNow.Count());
            }
            else
            {
                CartItem cardItem = shoppingCartNow.FirstOrDefault(m => m.ProductId == ProductIDInput);
                cardItem.Quantity++;
            }

            return RedirectToAction("Index", "MyCart");
        }

        //Delete
        public ActionResult Delete(int ProductIDInput)
        {
            List<CartItem> shoppingCartNow = Session["ShoppingCartNow"] as List<CartItem>;
            CartItem itemXoa = shoppingCartNow.FirstOrDefault(m => m.ProductId == ProductIDInput);
            if (itemXoa != null)
            {
                shoppingCartNow.Remove(itemXoa);
            }
            return RedirectToAction("Index", "MyCart");
        }
        //update
        public ActionResult Edit(int ProductIDInput, int newQuantity)
        {
            List<CartItem> shoppingCartNow = Session["ShoppingCartNow"] as List<CartItem>;
            CartItem itemSua = shoppingCartNow.FirstOrDefault(m => m.ProductId == ProductIDInput);
            if (itemSua != null)
            {
                itemSua.Quantity = newQuantity;
            }
            return RedirectToAction("Index", "MyCart");
        }

        public ActionResult ClearShoppingCart()
        {
            List<CartItem> shoppingCartNow = Session["ShoppingCartNow"] as List<CartItem>;
            shoppingCartNow.Clear();
            return RedirectToAction("Index", "MyCart");
        }
    }
}