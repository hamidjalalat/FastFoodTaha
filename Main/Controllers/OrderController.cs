﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.Orders;

namespace HJ_Template_MVC.Controllers
{
    public class OrderController : Infrastructure.BaseController
    {
    
    
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetProduct(ViewModels.Orders.ProductsViewModel  product,int pageIndex ,int pageSize )
        {
            var listProduct =
                db.Products
                .OrderBy(current => current.Name)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToList()
                ;

            //var listProduct =
            //        db.Products
            //        .AsQueryable()
            //        ;
            //if (product.Name !=null )
            //{
            //    listProduct =
            //        listProduct
            //        .Where(current => current.Name.Contains(product.Name))
            //        ;
            //}
            //if (product.Price != null)
            //{
            //    listProduct =
            //        listProduct
            //        .Where(current => current.Price == product.Price.Value);
            //        ;
            //}

            var result = new {data=listProduct };

            return Json(result, JsonRequestBehavior.AllowGet);
        }
        private int GetCountryCount()
        {
            int intCount =
                db.Products
                .Count();

            return (intCount);
        }
        [HttpPost]
        public JsonResult GetListProduct()
        {
           
           var     listProduct = db.Products
                    .OrderBy(C => C.Name)
                    .Skip(0).Take(10)
                    .ToList();
            var result = new { data = listProduct, count = GetCountryCount() };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            MyUnitOfWork.ProductRepository.Insert(product);
            MyUnitOfWork.Save();
            return View();
        }
    }
}