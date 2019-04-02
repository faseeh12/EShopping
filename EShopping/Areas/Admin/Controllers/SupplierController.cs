using EShopping.Areas.Admin.Models;
using EShopping.Service.SupplierServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShopping.Areas.Admin.Controllers
{
    public class SupplierController : Controller
    {
        private ISupplierServcice _SuppService;
        public SupplierController(ISupplierServcice SuppService)
        {
            _SuppService = SuppService;
        }

        public ActionResult Index()
        {
            var model = _SuppService.AllSuppliers().Select(c => new SupplierViewModel { Supplier_Id = c.Supplier_Id, CompanyName = c.CompanyName, ContactFName = c.ContactFName });
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        //public ActionResult Details(int Id)
        //{
        //    var domainModel = _CatService.GetCategoryById(Id);
        //    var viewModel = new CategoryViewModel { Id = domainModel.Category_Id, Name = domainModel.Name, Description = domainModel.Description };
        //    return View(viewModel);
        //}
    }
}