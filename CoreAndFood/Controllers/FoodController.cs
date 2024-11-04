using CoreAndFood.Data.Models;
using CoreAndFood.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CoreAndFood.Controllers
{
	public class FoodController : Controller
	{
		Context c=new Context();
        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index()
		{
			
			return View(foodRepository.TList("Category"));
		}
		[HttpGet]
		public IActionResult FoodAdd()
		{
			List<SelectListItem> values = (from x in c.Categories.ToList()
										   select new SelectListItem
										   {
                                               Text = x.CategoryName,
                                               Value =x.CategoryID.ToString()
											   
										   }).ToList();
			ViewBag.v1 = values;
			return View();
		}
		[HttpPost]
        public IActionResult FoodAdd(Food food )
        {
			foodRepository.TAdd(food);
			return RedirectToAction("Index");
        }
        public IActionResult FoodDelete(int id)
        {
            foodRepository.TDelete(new Food { FoodID = id });
            return RedirectToAction("Index");
        }
		public IActionResult FoodGet(int id)
		{
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryID.ToString()

                                           }).ToList();
            ViewBag.v1 = values;
            var x=foodRepository.TGet(id);
			Food f = new Food()
			{
			CategoryID = x.CategoryID,
			 FoodID = x.FoodID,
			 Name = x.Name,
			 Stock = x.Stock,
			 Price = x.Price,
			 Description = x.Description,
			 ImageUrl = x.ImageUrl
			};
			return View(f);
		}
		public IActionResult FoodUpdate(Food food) 
		{
			var x = foodRepository.TGet(food.FoodID);
			x.Name = food.Name;
			x.Stock = food.Stock;
			x.Price = food.Price;
			x.Description = food.Description;
			x.ImageUrl = food.ImageUrl;
			x.CategoryID = food.CategoryID;
            foodRepository.TUpdate(x);
            return RedirectToAction("Index");
		}


    }
}
