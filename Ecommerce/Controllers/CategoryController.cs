using Ecommerce.Models;
using Ecommerce.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public CategoryController(AppDbContext context)
        {
            _appDbContext = context;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _appDbContext.Categories.ToList(); //call db
            return View(objCategoryList);
        }
        public IActionResult Detail(int categoryId)
        {
            //return categoryId == 1? RedirectToAction("FastFoodDetail"): categoryId == 2? RedirectToAction("JunkFoodDetail"):"";
            if (categoryId == 1)
            {
                return RedirectToAction("FastFoodDetail");
            }
            else if (categoryId == 2)
            {
                return RedirectToAction("JunkFoodDetail");
            }
            else if (categoryId == 3)
            {
                return RedirectToAction("CleaningDetail");
            }
            else if (categoryId == 4)
            {
                return RedirectToAction("ToysDetail");
            }
            else 
            { 
                return RedirectToAction("Index");
            }  
        }
        public IActionResult FastFoodDetail()
        {
            List<FastFoodDetail> objFastFoodDetail = _appDbContext.FastFoodDetail.ToList();
            return View(objFastFoodDetail);
        }
        public IActionResult JunkFoodDetail()
        {
            List<JunkFoodDetail> objJunkFoodDetail = _appDbContext.JunkFoodDetail.ToList();
            return View(objJunkFoodDetail);
        }
        public IActionResult CleaningDetail()
        {
            List<CleaningDetail> objCleaningDetail = _appDbContext.CleaningDetail.ToList();
            return View(objCleaningDetail);
        }
        public IActionResult ToysDetail()
        {
            List<ToysDetail> objToysDetail = _appDbContext.ToysDetail.ToList();
            return View(objToysDetail);
        }
    }
}
