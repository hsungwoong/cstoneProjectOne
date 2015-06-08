using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AboutMe.Common.Helper;
using AboutMe.Domain.Service.Product;
using AboutMe.Domain.Entity.AdminProduct;

namespace AboutMe.Web.Admin.Controllers
{
    public class AdminProductController : Controller
    {
        // GET: AdminProduct

        private IAdminProductService _AdminProductService;

        
         public AdminProductController(IAdminProductService _adminProductService)
        {
            this._AdminProductService = _adminProductService;
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insert()
        {

            return View();

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(string CATE_GBN, string CATE_CODE, int RE_SORT, string DEPTH1_CODE, string DEPTH1_NAME, string DEPTH1_IMG, string DEPTH2_CODE, string DEPTH2_NAME, string DEPTH_FLAG, string DISPLAY_YN)
        {

            _AdminProductService.InsertAdminProduct(CATE_GBN, CATE_CODE, RE_SORT, DEPTH1_CODE, DEPTH1_NAME, DEPTH1_IMG, DEPTH2_CODE, DEPTH2_NAME, DEPTH_FLAG, DISPLAY_YN);

            return RedirectToAction("Index");
            //Redirect("/AdminMember/Index");
            //return View(Index("" ,"", "","", 1, 10));
        }

        

    }
}